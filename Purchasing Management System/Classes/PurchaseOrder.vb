Public Class PurchaseOrder
    Inherits DatabaseItem
    Dim report As ReportsGenerator
    Private poNum As String
    Private poDate As Date
    Private vend As String
    Private mgr As String
    Private price As Double

    Public Sub New()
        GetData()
    End Sub

#Region "Data and Search functions"
    Public Sub GetData()
        Dim com As New DatabaseAccess
        With com
            .InitiateADOProcedure("qryPurchaseOrders")
            .Execute(DatabaseAccess.ReturnType.ExecuteReader)
            Data = .ReturnResults
        End With
        Me.BuildIndex(0)
    End Sub

    Public Function SearchPOs(myKey As String) As Boolean
        Dim rw As DataRow = SearchIndex(myKey)
        If rw IsNot Nothing Then
            With Me
                .PONumber = CType(rw.Item(0), String)
                .poDate = CType(rw.Item(1), Date)
                .mgr = CType(rw.Item(2), String)
                .vend = CType(rw.Item(3), String)
                If rw.Item(4).GetType IsNot GetType(DBNull) Then
                    .price = CType(rw.Item(4), Double)
                Else
                    .price = 0.0
                End If
            End With
            Return True
        Else
            Return False
        End If
    End Function
#End Region

#Region "Getters/Setters"

    Public Property PONumber As String
        Get
            Return poNum
        End Get
        Set(value As String)
            poNum = value
        End Set
    End Property

    Public Property LineID As Integer
        Get
            Return lnID
        End Get
        Set(value As Integer)
            lnID = value
        End Set
    End Property

    Public Sub SetPurchaseOrderDetails(PONumber As String, Vendor As String, Manager As String, SubmissionDate As Date)
        Dim ex As New Exception
        If PONumber.Length = 0 Or Vendor.Length = 0 Or Manager.Length = 0 Then
            Throw ex
        Else
            If SearchPOs(PONumber) = False Then
                poNum = PONumber
                vend = Vendor
                mgr = Manager
                poDate = SubmissionDate
            End If
        End If
    End Sub
#End Region

#Region "Database Functions"
    Public Sub GetPOData()
        Dim com As New DatabaseAccess
        With com
            .InitiateADOProcedure("qryPurchaseOrders")
            .Execute(DatabaseAccess.ReturnType.ExecuteReader)
            Data = .ReturnResults()
        End With
    End Sub

    Public Sub SubmitPurchaseOrder()
        Dim com As New DatabaseAccess
        With com
            .InitiateADOProcedure("spInsertPO")
            .AddParameter("varPO", PONumber)
            .AddParameter("varMgr", mgr)
            .AddParameter("varVendor", vend)
            .AddParameter("varDate", poDate)
            .Execute(DatabaseAccess.ReturnType.ExecuteNonQuery)
        End With
    End Sub

    Public Sub ErasePurchaseOrder()
        For i As Integer = 0 To 1
            Dim com As New DatabaseAccess
            With com
                Select Case i
                    Case 0
                        .InitiateADOProcedure("spDeletePurchaseOrder")
                    Case 1
                        .InitiateADOProcedure("spBatchDeletePurchaseOrderItems")
                End Select
                .AddParameter("varPO", PONumber)
                .Execute(DatabaseAccess.ReturnType.ExecuteNonQuery)
            End With
        Next i
    End Sub
#End Region

#Region "Reporting Functions"
    Public Sub GenerateDetailedPurchaseOrderReport(pMonth As Integer, pYear As Integer)
        Dim com As New DatabaseAccess
        report = New ReportsGenerator()
        With com
            .InitiateADOProcedure("qryGetPOByDate")
            .AddParameter("varmonth", CType(pMonth, String))
            .AddParameter("varyear", CType(pYear, String))
            .Execute(DatabaseAccess.ReturnType.ExecuteReader)
            report.source.Data = .ReturnResults()
        End With
        With report
            .GenerateReport(3, "Purchase Orders Details Month: " & pMonth & " Year: " & pYear)
        End With
    End Sub

    Public Sub GenerateSummaryPurchaseOrderReport(pMonth As Integer, pYear As Integer)
        Dim com As New DatabaseAccess
        report = New ReportsGenerator()
        With com
            .InitiateADOProcedure("qryPurchaseOrdersByDate")
            .AddParameter("varmonth", CType(pMonth, String))
            .AddParameter("varyear", CType(pYear, String))
            .Execute(DatabaseAccess.ReturnType.ExecuteReader)
            report.source.Data = .ReturnResults()
        End With
        With report
            .GenerateReport(3, "Purchase Orders Month: " & pMonth & " Year: " & pYear)
        End With
    End Sub

    'Public Sub GeneratePurchaseOrderReport(pMonth As Integer, pYear As Integer)
    '    Try
    '        Dim xlapp As New Excel.Application
    '        Dim xlwb As Excel.Workbook = xlapp.Workbooks.Add
    '        Dim xlws As Excel.Worksheet = CType(xlwb.Worksheets.Add, Excel.Worksheet)
    '        Dim com As New DatabaseAccess
    '        Dim tbl As New DataTable
    '        Dim i As Integer
    '        With com
    '            .InitiateADOProcedure("qryGetPOByDate")
    '            .AddParameter("varmonth", CType(pMonth, String))
    '            .AddParameter("varyear", CType(pYear, String))
    '            .Execute(DatabaseAccess.ReturnType.ExecuteReader)
    '            tbl = .ReturnResults()
    '        End With
    '        i = 3
    '        With xlws
    '            For x = 1 To tbl.Rows.Count - 1
    '                For y = 0 To tbl.Columns.Count - 1
    '                    .Cells(i, y + 1) = tbl.Rows(x).Item(y)
    '                Next
    '                i += 1
    '            Next
    '        End With
    '        xlapp.Visible = True
    '        xlws.Range("A1:G300").EntireColumn.AutoFit()
    '        xlws.Cells(1, 1) = "Purchase Orders Month: " & pMonth & " Year: " & pYear
    '    Catch
    '        MsgBox("Error: " & Err.Number & ", " & Err.Description)
    '    End Try
    'End Sub
#End Region
End Class

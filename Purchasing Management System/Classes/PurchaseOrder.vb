Imports Microsoft.Office.Interop

Public Class PurchaseOrder
    Inherits DatabaseItem
    Private poExist As Boolean
    Private poiExist As Boolean
    Private poNum As String
    Private poDate As Date
    Private vend As String
    Private desc As String
    Private mgr As String
    Private glCode As String
    Private price As Double
    Private lnID As Integer

    Public Sub New()

    End Sub

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
        Return False 'placeholder
    End Function

#Region "Getters/Setters"
    Public Property Exists As Boolean
        Get
            Return poExist
        End Get
        Private Set(value As Boolean)
            poExist = value
        End Set
    End Property

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

    Public Property ItemExists As Boolean
        Get
            Return poiExist
        End Get
        Set(value As Boolean)
            poiExist = value
        End Set
    End Property

    Public Sub SetPurchaseOrderLineDetails(pGLCode As String, pDescription As String, pPrice As Double)
        glCode = pGLCode
        desc = pDescription
        price = pPrice
    End Sub

    Public Sub SetPurchaseOrderDetails(PONumber As String, Vendor As String, Manager As String, SubmissionDate As Date)
        Dim ex As New Exception
        If PONumber.Length = 0 Or Vendor.Length = 0 Or Manager.Length = 0 Then
            Throw ex
        Else
            poNum = PONumber
            vend = Vendor
            mgr = Manager
            poDate = SubmissionDate
            POExists()
        End If
    End Sub
#End Region

#Region "Database Functions"
    Public Function GetPOData() As DataTable
        Dim com As New DatabaseAccess
        Dim table As New DataTable
        With com
            .InitiateADOProcedure("qryPurchaseOrders")
            .Execute(DatabaseAccess.ReturnType.ExecuteReader)
            table = .ReturnResults()
        End With
        Return table
        table.Dispose()
    End Function

    Public Function GetPOLineData() As DataTable
        Dim com As New DatabaseAccess
        Dim table As New DataTable
        With com
            .InitiateADOProcedure("qryGetPOByNumber")
            .AddParameter("varPO", PONumber)
            .Execute(DatabaseAccess.ReturnType.ExecuteReader)
            table = .ReturnResults()
        End With
        Return table
        table.Dispose()
    End Function

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

    Public Sub SubmitPurchaseOrderEntry()
        POIExists()
        If ItemExists = False Then
            Dim com As New DatabaseAccess
            With com
                .InitiateADOProcedure("spInsertPurchaseOrderItem")
                .AddParameter("varPO", poNum)
                .AddParameter("varGLCode", glCode)
                .AddParameter("varDesc", desc)
                .AddParameter("varCost", price)
                .Execute(DatabaseAccess.ReturnType.ExecuteNonQuery)
            End With
        End If
    End Sub

    Public Sub DeletePurchaseOrderEntry()
        If Me.LineID <> -1 Then
            Dim com As New DatabaseAccess
            With com
                .InitiateADOProcedure("spDeletePurchaseOrderItem")
                .AddParameter("spDeletePurchaseOrderItem", LineID)
                .Execute(DatabaseAccess.ReturnType.ExecuteNonQuery)
            End With
        Else
            MsgBox("Please select a line item from the below list then try again.")
        End If
    End Sub

    Public Sub UpdatePurchaseOrderEntry()
        If Me.LineID <> -1 Then
            Dim com As New DatabaseAccess
            With com
                .InitiateADOProcedure("spUpdatePurchaseOrderItem")
                .AddParameter("varGLCode", glCode)
                .AddParameter("varDesc", desc)
                .AddParameter("varCost", price)
                .AddParameter("varLine", LineID)
                .Execute(DatabaseAccess.ReturnType.ExecuteNonQuery)
            End With
        Else
            MsgBox("Please select a line item from the below list then try again.")
        End If
    End Sub

    Public Sub ErasePurchaseOrder()
        For i = 0 To 1
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

    Private Sub POExists()
        Dim com As New DatabaseAccess
        With com
            .InitiateADOCommand("SELECT PONumber FROM tPuchaseOrders WHERE PONumber='" & poNum & "';")
            .Execute(DatabaseAccess.ReturnType.ExecuteReader)
            Exists = .CheckIfExists
        End With
    End Sub

    Private Sub POIExists()
        Dim com As New DatabaseAccess
        With com
            .InitiateADOCommand("SELECT PONumber, DepartmentGLCode, Description, Cost FROM tPurchaseOrdersItems WHERE PONumber ='" & PONumber &
                                    "' AND DepartmentGLCode='" & glCode & "' AND Description='" & desc & "' AND COST=" & price & ";")
            .Execute(DatabaseAccess.ReturnType.ExecuteReader)
            ItemExists = .CheckIfExists
        End With
    End Sub
#End Region

#Region "Reporting Functions"
    Public Sub GeneratePurchaseOrderReport(pMonth As Integer, pYear As Integer)
        Try
            Dim xlapp As New Excel.Application
            Dim xlwb As Excel.Workbook = xlapp.Workbooks.Add
            Dim xlws As Excel.Worksheet = xlwb.Worksheets.Add
            Dim com As New DatabaseAccess
            Dim tbl As New DataTable
            Dim i As Integer
            With com
                .InitiateADOProcedure("qryGetPOByDate")
                .AddParameter("varmonth", CType(pMonth, String))
                .AddParameter("varyear", CType(pYear, String))
                .Execute(DatabaseAccess.ReturnType.ExecuteReader)
                tbl = .ReturnResults()
            End With
            i = 3
            With xlws
                For x = 1 To tbl.Rows.Count - 1
                    For y = 0 To tbl.Columns.Count - 1
                        .Cells(i, y + 1) = tbl.Rows(x).Item(y)
                    Next
                    i += 1
                Next
            End With
            xlapp.Visible = True
            xlws.Range("A1:G300").EntireColumn.AutoFit()
            xlws.Cells(1, 1) = "Purchase Orders Month: " & pMonth & " Year: " & pYear
        Catch
            MsgBox("Error: " & Err.Number & ", " & Err.Description)
        End Try
    End Sub
#End Region
End Class

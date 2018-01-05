Imports Purchasing_Management_System

Public Class PurchaseOrderItem
    Inherits DatabaseItem
    Private po As PurchaseOrder
    Private id As Integer
    Private glc As String
    Private prc As Double
    Private dsc As String

    Public Sub New(po As PurchaseOrder)
        Me.po = po
        GetData()
    End Sub

    Public Sub GetData()
        Dim com As New DatabaseAccess
        With com
            .InitiateADOProcedure("qryGetPOByNumber")
            .AddParameter("varPO", PONumber)
            .Execute(DatabaseAccess.ReturnType.ExecuteReader)
            Data = .ReturnResults
        End With
        BuildIndex(0)
    End Sub

    Public Function SearchPOItems(myKey As String) As Boolean
        Dim rw As DataRow = SearchIndex(myKey)
        If rw IsNot Nothing Then
            Me.LineID = CType(rw.Item(0), Integer)
            Me.GlCode = CType(rw.Item(1), String)
            Me.Description = CType(rw.Item(2), String)
            Me.Price = CType(rw.Item(3), Double)
            Return True
        Else
            Return False
        End If
    End Function

#Region "Database Functions"
    Public Sub SubmitPurchaseOrderItemEntry()
        Dim i As Integer
        Dim match As Boolean = False
        If Data.Rows.Count > 0 Then
            For i = 0 To Data.Rows.Count - 1
                If CType(Data.Rows(i).Item(2), String) = Me.Description Then
                    match = True
                    Exit For
                End If
            Next
        End If
        If match = False Then
            NewPurchaseOrderItemEntry()
        Else
            UpdatePurchaseOrderItemEntry(CType(Data.Rows(i).Item(0), Integer))
        End If
    End Sub

    Public Sub DeletePurchaseOrderItemEntry()
        If Me.LineID <> -1 Then
            Dim com As New DatabaseAccess
            With com
                .InitiateADOProcedure("spdeletepurchaseorderitem")
                .AddParameter("varid", LineID)
                .Execute(DatabaseAccess.ReturnType.ExecuteNonQuery)
            End With
        Else
            MsgBox("please select a line item from the below list then try again.")
        End If
    End Sub

    Private Sub NewPurchaseOrderItemEntry()
        Dim com As New DatabaseAccess
        With com
            .InitiateADOProcedure("spInsertPurchaseOrderItem")
            .AddParameter("varPO", PONumber)
            .AddParameter("varGLCode", GlCode)
            .AddParameter("varDesc", Description)
            .AddParameter("varCost", Price)
            .Execute(DatabaseAccess.ReturnType.ExecuteNonQuery)
        End With
    End Sub

    Private Sub UpdatePurchaseOrderItemEntry(line As Integer)
        Dim com As New DatabaseAccess
        With com
            .InitiateADOProcedure("spupdatepurchaseorderitem")
            .AddParameter("varglcode", GlCode)
            .AddParameter("vardesc", Description)
            .AddParameter("varcost", Price)
            .AddParameter("varline", line)
            .Execute(DatabaseAccess.ReturnType.ExecuteNonQuery)
        End With
    End Sub
#End Region

#Region "Getters/Setters"
    Public Property GlCode As String
        Get
            Return glc
        End Get
        Set(value As String)
            glc = value
        End Set
    End Property

    Public Property Price As Double
        Get
            Return prc
        End Get
        Set(value As Double)
            prc = value
        End Set
    End Property

    Public Property Description As String
        Get
            Return dsc
        End Get
        Set(value As String)
            dsc = value
        End Set
    End Property

    Public Property LineID As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public ReadOnly Property PONumber As String
        Get
            Return po.PONumber
        End Get
    End Property
#End Region

End Class

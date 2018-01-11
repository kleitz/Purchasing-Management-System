Public Class RequisitionItems
    Inherits DatabaseItem
    Private req As Requisitions
    Private bcID As String
    Private qty As Integer

    Public Sub New(ByVal requisition As Requisitions)
        req = requisition
    End Sub

#Region "Database Functions"

    Public Sub SubmitRequisitionItem()
        Dim com As New DatabaseAccess
        With com
            .InitiateADOProcedure("spInsertRequisitionItem")
            .AddParameter("varReqID", req.RequisitionID)
            .AddParameter("varBarcode", BarcodeID)
            .AddParameter("varQuantity", Quantity)
            .Execute(DatabaseAccess.ReturnType.ExecuteNonQuery)
        End With
    End Sub

    Public Sub EditRequisitionItem()

    End Sub

#End Region

#Region "Getters/Setters"
    Public Property BarcodeID As String
        Get
            Return bcID
        End Get
        Set(value As String)
            bcID = value
        End Set
    End Property

    Public Property Quantity As Integer
        Get
            Return qty
        End Get
        Set(value As Integer)
            qty = value
        End Set
    End Property
#End Region
End Class

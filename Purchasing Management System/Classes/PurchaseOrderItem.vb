Public Class PurchaseOrderItem
    Inherits DatabaseItem
    Private po As PurchaseOrder
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
            .AddParameter("varPO", po.PONumber)
            .Execute(DatabaseAccess.ReturnType.ExecuteReader)
            Data = .ReturnResults
        End With
    End Sub

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
#End Region
End Class

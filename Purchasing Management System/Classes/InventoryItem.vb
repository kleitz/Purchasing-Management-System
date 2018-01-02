Imports Purchasing_Management_System

Public Class InventoryItem
    Private vendName As String
    Private vendID As Integer
    Private vendItemNo As String
    Private AgilisysIN As Double
    Private desc As String
    Private pack As String
    Private unit As String
    Private cat As String
    Private cost As String
    Private ext As Boolean
    Private quant As Int32
    Private ref As References

    Public Sub New()
        Reference = New References
        With Reference
            .BuildItemIndex(Me)
            .BuildDepartmentIndex()
        End With
    End Sub

    Enum SearchMethod
        VendorID
        Description
        AllItems
    End Enum

    Public Sub RebuildIndex()
        Reference.BuildItemIndex(Me)
    End Sub

    Public Sub UpdateQuantity()
        Dim com As New DatabaseAccess
        With com
            .InitiateADOCommand("UPDATE tVendorItems SET Quantity=" & Quantity & " WHERE VendorItemNumber=" & AgilisysItemNumber)
        End With
    End Sub

    Public Function ReturnAgilisysItems(Search As SearchMethod) As DataTable
        Dim com As New DatabaseAccess
        Dim tbl As New DataTable
        Select Case Search
            Case SearchMethod.VendorID
                With com
                    .InitiateADOProcedure("qrySearchItemsByVendorID")
                    .AddParameter("varSearch", "%" & VendorItemNumber & "%")
                End With
            Case SearchMethod.Description
                With com
                    .InitiateADOProcedure("qrySearchItemsByDescription")
                    .AddParameter("varSearch", "%" & Description & "%")
                End With
            Case SearchMethod.AllItems
                With com
                    .InitiateADOProcedure("qryInventoryItems")
                End With
        End Select
        com.Execute(DatabaseAccess.ReturnType.ExecuteReader)
        tbl = com.ReturnResults
        Return tbl
    End Function

    Public Sub SubmitAgilisysItem()
        Dim com As New DatabaseAccess
        With com
            .InitiateADOProcedure("spInsertVendorItem")
            .AddParameter("varVendor", VendorName)
            .AddParameter("varVendorItemNumber", VendorItemNumber)
            .AddParameter("varAgilisysItemNo", AgilisysItemNumber)
            .AddParameter("varDesc", Description)
            .AddParameter("varCat", Category)
            .AddParameter("varPackaging", Packaging)
            .AddParameter("varUnitMeasure", UnitMeasure)
            .AddParameter("varPrice", Price)
            .Execute(DatabaseAccess.ReturnType.ExecuteNonQuery)
        End With
    End Sub

    Public Sub UpdateAgilisysItem()
        Dim com As New DatabaseAccess
        With com
            .InitiateADOProcedure("spUpdateVendorItem")
            .AddParameter("varVendorItemNumber", VendorItemNumber)
            .AddParameter("varAgilisysItemNo", AgilisysItemNumber)
            .AddParameter("varDesc", Description)
            .AddParameter("varCat", Category)
            .AddParameter("varPackaging", Packaging)
            .AddParameter("varUnitMeasure", UnitMeasure)
            .AddParameter("varPrice", Price)
            .Execute(DatabaseAccess.ReturnType.ExecuteNonQuery)
        End With
    End Sub

    Public Sub DeleteAgilisysItem()
        Dim com As New DatabaseAccess
        With com
            .InitiateADOProcedure("spDeleteVendorItem")
            .AddParameter("varVendorID", VendorItemNumber)
            .Execute(DatabaseAccess.ReturnType.ExecuteNonQuery)
        End With
    End Sub

    Public Function ItemExists(myKey As String) As Boolean
        Return Reference.SearchItemIndex(myKey, Me)
    End Function

    Public Property VendorItemNumber As String
        Get
            Return vendItemNo
        End Get
        Set(value As String)
            vendItemNo = value
        End Set
    End Property

    Public Property AgilisysItemNumber As Double
        Get
            Return AgilisysIN
        End Get
        Set(value As Double)
            AgilisysIN = value
        End Set
    End Property

    Public Property Description As String
        Get
            Return desc
        End Get
        Set(value As String)
            desc = value
        End Set
    End Property

    Public Property Packaging As String
        Get
            Return pack
        End Get
        Set(value As String)
            pack = value
        End Set
    End Property

    Public Property UnitMeasure As String
        Get
            Return unit
        End Get
        Set(value As String)
            unit = value
        End Set
    End Property

    Public Property Category As String
        Get
            Return cat
        End Get
        Set(value As String)
            cat = value
        End Set
    End Property

    Public Property Price As String
        Get
            Return cost
        End Get
        Set(value As String)
            cost = value
        End Set
    End Property

    Public Property VendorName As String
        Get
            Return vendName
        End Get
        Set(value As String)
            vendName = value
            Dim com As New DatabaseAccess
            With com
                .InitiateADOCommand("SELECT VendorID FROM tVendors WHERE VendorName = '" & value & "';")
                .Execute(DatabaseAccess.ReturnType.ExecuteReader)
                vendID = .ReturnValue
            End With
        End Set
    End Property

    Public Property Exists As Boolean
        Get
            Return ext
        End Get
        Set(value As Boolean)
            ext = value
        End Set
    End Property

    Public Property Reference As References
        Get
            Return ref
        End Get
        Set(value As References)
            ref = value
        End Set
    End Property

    Public Property Quantity As Integer
        Get
            Return quant
        End Get
        Set(value As Integer)
            quant = value
        End Set
    End Property
End Class

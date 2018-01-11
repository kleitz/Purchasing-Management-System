Public Class InventoryItem
    Inherits DatabaseItem
    Public vend As Vendors
    Private vendItemNo As String
    Private barid As String
    Private AgilisysIN As Double
    Private desc As String
    Private pack As String
    Private unit As String
    Private cat As String
    Private cost As String
    Private ext As Boolean
    Private quant As Integer
    Enum SearchMethod
        VendorID
        Description
        AllItems
    End Enum

    Public Sub New()
        vend = New Vendors
        BuildItemsIndex(SearchMethod.AllItems)
    End Sub

#Region "Data and Search Functions"
    Public Sub GetData(SearchMethod As SearchMethod)
        Dim com As New DatabaseAccess
        Select Case SearchMethod
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
        Data = com.ReturnResults
    End Sub

    Public Sub BuildItemsIndex(SearchBy As SearchMethod)
        GetData(SearchBy)
        BuildIndex(4)
    End Sub

    Public Function SearchItems(myKey As String) As Boolean
        Dim rw As DataRow = SearchIndex(myKey)
        If rw IsNot Nothing Then
            With Me
                .VendorItemNumber = CType(rw.Item(3), String)
                .AgilisysItemNumber = CDbl(rw.Item(4))
                .Description = CType(rw.Item(5), String)
                .Price = CType(rw.Item(9), String)
                vend.VendorName = CType(rw.Item(1), String)
                .Packaging = CType(rw.Item(6), String)
                .UnitMeasure = CType(rw.Item(7), String)
                .Quantity = CType(rw.Item(8), Integer)
                If IsDBNull(rw.Item(2)) = False Then
                    .BarcodeID = CType(rw.Item(2), String)
                Else
                    .BarcodeID = ""
                End If
            End With
            Return True
        Else
            Return False
        End If
    End Function
#End Region

#Region "Database Functions"
    Public Sub UpdateQuantity()
        Dim com As New DatabaseAccess
        With com
            .InitiateADOCommand("UPDATE tVendorItems SET Quantity=" & Quantity & " WHERE VendorItemNumber=" & AgilisysItemNumber)
        End With
    End Sub

    Public Sub SubmitAgilisysItem()
        Dim com As New DatabaseAccess
        With com
            .InitiateADOProcedure("spInsertVendorItem")
            .AddParameter("varVendorID", vend.VendorID)
            .AddParameter("varVendorItemNumber", VendorItemNumber)
            .AddParameter("varBarcode", BarcodeID)
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
            .AddParameter("varVendItemNumber", VendorItemNumber)
            .AddParameter("varBarcode", BarcodeID)
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
#End Region

#Region "Getters/Setters"
    Public Property VendorName As String
        Get
            Return vend.VendorName
        End Get
        Set(value As String)
            vend.VendorName = value
            If (vend.SearchVendors(vend.VendorName)) = False Then
                vend.VendorID = -1
            End If
        End Set

    End Property


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


    Public Property Exists As Boolean
        Get
            Return ext
        End Get
        Set(value As Boolean)
            ext = value
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

    Public Property BarcodeID As String
        Get
            Return barid
        End Get
        Set(value As String)
            barid = value
        End Set
    End Property
#End Region
End Class

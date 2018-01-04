Public Class Vendors
    Inherits DatabaseItem
    Private vID As Integer
    Private nm As String
    Private acctNum As String
    Private phon As String
    Private eml As String
    Private saddress As String
    Private cty As String
    Private st As String
    Private zip As String

    Public Sub New()
        GetData()
    End Sub

#Region "Data and Search Functions"
    Public Sub GetData()
        Dim com As New DatabaseAccess
        With com
            .InitiateADOProcedure("qryVendors")
            .Execute(DatabaseAccess.ReturnType.ExecuteReader)
            Me.Data = .ReturnResults
        End With
        Me.BuildIndex(1)
    End Sub

    Public Function SearchVendors(myKey As String) As Boolean
        Dim rw As DataRow = SearchIndex(myKey)
        If rw IsNot Nothing Then
            With Me
                .VendorID = CType(rw.Item(0), Integer)
                .VendorName = CType(rw.Item(1), String)
                .AccountNumber = CType(rw.Item(2), String)
                .PhoneNumber = CType(rw.Item(3), String)
                .Email = CType(rw.Item(4), String)
                .StreetAddress = CType(rw.Item(5), String)
                .City = CType(rw.Item(6), String)
                .State = CType(rw.Item(7), String)
                .ZipCode = CType(rw.Item(8), String)
            End With
            Return True
        Else
            Return False
        End If
    End Function
#End Region

#Region "Database Functions"
    Public Sub InsertVendor()
        Dim com As New DatabaseAccess
        With com
            .InitiateADOProcedure("spInsertVendor")
            .AddParameter("varName", VendorName)
            .AddParameter("varAcctNumber", AccountNumber)
            .AddParameter("varPhone", PhoneNumber)
            .AddParameter("varEmail", Email)
            .AddParameter("varAddress", StreetAddress)
            .AddParameter("varCity", City)
            .AddParameter("varState", State)
            .AddParameter("varZip", ZipCode)
            .Execute(DatabaseAccess.ReturnType.ExecuteNonQuery)
            MsgBox("Vendor: " & Me.VendorName & " has been added to the database.")
        End With
        GetData()
    End Sub

    Public Sub UpdateVendor()
        Dim com As New DatabaseAccess
        With com
            .InitiateADOProcedure("spUpdateVendor")
            .AddParameter("varName", VendorName)
            .AddParameter("varAcctNumber", AccountNumber)
            .AddParameter("varPhone", PhoneNumber)
            .AddParameter("varEmail", Email)
            .AddParameter("varAddress", StreetAddress)
            .AddParameter("varCity", City)
            .AddParameter("varState", State)
            .AddParameter("varZip", ZipCode)
            .Execute(DatabaseAccess.ReturnType.ExecuteNonQuery)
            MsgBox("Vendor: " & Me.VendorName & " has been updated.")
        End With
        GetData()
    End Sub
#End Region

#Region "Getters/Setters"
    Public Property VendorID As Integer
        Get
            Return vID
        End Get
        Set(value As Integer)
            vID = value
        End Set
    End Property

    Public Property VendorName As String
        Get
            Return nm
        End Get
        Set(value As String)
            nm = value
        End Set
    End Property

    Public Property AccountNumber As String
        Get
            Return acctNum
        End Get
        Set(value As String)
            acctNum = value
        End Set
    End Property

    Public Property PhoneNumber As String
        Get
            Return phon
        End Get
        Set(value As String)
            phon = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return eml
        End Get
        Set(value As String)
            eml = value
        End Set
    End Property

    Public Property StreetAddress As String
        Get
            Return saddress
        End Get
        Set(value As String)
            saddress = value
        End Set
    End Property

    Public Property City As String
        Get
            Return cty
        End Get
        Set(value As String)
            cty = value
        End Set
    End Property

    Public Property State As String
        Get
            Return st
        End Get
        Set(value As String)
            st = value
        End Set
    End Property

    Public Property ZipCode As String
        Get
            Return zip
        End Get
        Set(value As String)
            zip = value
        End Set
    End Property
#End Region
End Class

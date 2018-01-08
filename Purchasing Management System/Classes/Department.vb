Public Class Departments
    Inherits DatabaseItem
    Private datID As Integer
    Private deptName As String
    Private divID As Integer
    Private deptID As Integer

    Public Sub New()
        GetData()
    End Sub

    Public Sub GetData()
        Dim com As New DatabaseAccess
        With com
            .InitiateADOProcedure("qryDepartments")
            .Execute(DatabaseAccess.ReturnType.ExecuteReader)
            Data = .ReturnResults
        End With
        Me.BuildIndex(1)
    End Sub

#Region "Database Functions"
    Public Function SearchDepartments(myKey As String) As Boolean
        Dim rw As DataRow = SearchIndex(myKey)
        If rw IsNot Nothing Then
            With Me
                .DatabaseID = CType(rw.Item(0), Integer)
                .DepartmentName = CType(rw.Item(1), String)
                .DivisionID = CType(rw.Item(2), Integer)
                .DepartmentID = CType(rw.Item(3), Integer)
            End With
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub InsertDepartment()
        Dim com As New DatabaseAccess
        With com
            .InitiateADOProcedure("spInsertDepartment")
            .AddParameter("varDatID", DatabaseID)
            .AddParameter("varName", DepartmentName)
            .AddParameter("varDivID", DivisionID)
            .AddParameter("varDeptID", DepartmentID)
            .Execute(DatabaseAccess.ReturnType.ExecuteNonQuery)
        End With
        GetData()
    End Sub

    Public Sub UpdateDepartment()
        Dim com As New DatabaseAccess
        With com
            .InitiateADOProcedure("spUpdateDepartment")
            .AddParameter("varDatID", DatabaseID)
            .AddParameter("varName", DepartmentName)
            .AddParameter("varDivID", DivisionID)
            .AddParameter("varDeptID", DepartmentID)
            .Execute(DatabaseAccess.ReturnType.ExecuteNonQuery)
        End With
        GetData()
    End Sub

    Public Sub DeleteDepartment()
        Dim com As New DatabaseAccess
        With com
            .InitiateADOProcedure("spDeleteDepartment")
            .AddParameter("varDatID", DatabaseID)
            .Execute(DatabaseAccess.ReturnType.ExecuteNonQuery)
        End With
        GetData()
    End Sub
#End Region

#Region "Getters/Setters"
    Public Property DepartmentName As String
        Get
            Return deptName
        End Get
        Set(value As String)
            deptName = value
        End Set
    End Property

    Public Property DivisionID As Integer
        Get
            Return divID
        End Get
        Set(value As Integer)
            divID = value
        End Set
    End Property

    Public Property DepartmentID As Integer
        Get
            Return deptID
        End Get
        Set(value As Integer)
            deptID = value
        End Set
    End Property

    Public Property DatabaseID As Integer
        Get
            Return datID
        End Get
        Set(value As Integer)
            datID = value
        End Set
    End Property
#End Region
End Class

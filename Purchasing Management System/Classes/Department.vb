Public Class Deparmtnets
    Private deptName As String
    Private divID As Integer
    Private deptID As Integer

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
End Class

Imports Purchasing_Management_System

Public Class Requisitions
    Inherits DatabaseItem
    Private dt As Date
    Private reqID As Integer
    Private dept As Departments

    Public Sub New()
        Department = New Departments
    End Sub

#Region "Database Functions"

    Public Sub SubmitRequisition()
        Dim com As New DatabaseAccess
        With com
            .InitiateADOProcedure("spInsertRequisition")
            .AddParameter("varDate", RequisitionDate)
            .AddParameter("varDivID", dept.DivisionID)
            .AddParameter("varDeptID", dept.DepartmentID)
            .Execute(DatabaseAccess.ReturnType.ExecuteNonQuery)
        End With
    End Sub

    Public Sub DeleteRequisition()
        Dim com As New DatabaseAccess
        With com
            .InitiateADOProcedure("spDeleteRequisition")
            .AddParameter("varID", RequisitionID)
            .Execute(DatabaseAccess.ReturnType.ExecuteNonQuery)
        End With

        com = New DatabaseAccess
        With com
            .InitiateADOProcedure("spDeleteRequisitionItems")
            .AddParameter("varID", RequisitionID)
            .Execute(DatabaseAccess.ReturnType.ExecuteNonQuery)
        End With
    End Sub

    Private Sub GetData()
        Dim com As New DatabaseAccess
        With com
            .InitiateADOProcedure("qryRequisitions")
            .Execute(DatabaseAccess.ReturnType.ExecuteReader)
            Data = .ReturnResults
        End With
    End Sub

    Private Sub SearchRequisitions()
        RequisitionID = -1
        For Each row As DataRow In Data.Rows
            If row.Item(1) = RequisitionDate And row.Item(3) = dept.DepartmentID Then
                ReqID1 = row.Item(0)
                Exit For
            End If
        Next
        If RequisitionID = -1 Then
            MsgBox("No requisition matched the search parameters.")
        End If
    End Sub

#End Region

#Region "Getters/Setters"
    Public Property RequisitionDate As Date
        Get
            Return dt
        End Get
        Set(value As Date)
            dt = value
        End Set
    End Property

    Public Property Department As Departments
        Get
            Return dept
        End Get
        Set(value As Departments)
            dept = value
        End Set
    End Property

    Public Property RequisitionID As Integer
        Get
            Return reqID
        End Get
        Set(value As Integer)
            reqID = value
        End Set
    End Property
#End Region
End Class

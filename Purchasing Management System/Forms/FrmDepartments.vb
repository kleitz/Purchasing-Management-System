Public Class FrmDepartments
    Private dept As New Departments

    Private Sub LoadData()
        Try
            With dgvDepartments
                .AutoGenerateColumns = True
                .DataSource = dept.Data
                .Refresh()
                .AutoResizeColumns()
            End With
        Catch ex As Exception
            Dim handleError As New ErrorHandler
            With handleError
                .ErrorNumber = Err.Number
                .ErrorDescription = Err.Description
                .ExceptionMessage = ex.Message
                .LogError()
            End With
        End Try
    End Sub

    Private Sub FrmDepartments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub


    Private Sub DgvDepartments_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDepartments.CellClick
        On Error Resume Next
        Dim xRow As DataGridViewRow = Me.dgvDepartments.CurrentRow
        Me.txtName.Text = CType(xRow.Cells(1).Value, String)
        Me.txtDeptID.Text = CType(xRow.Cells(3).Value, String)
        Me.txtDivID.Text = CType(xRow.Cells(2).Value, String)
        Me.lblDatID.Text = "Database ID: " & CType(xRow.Cells(0).Value, String)
        On Error GoTo 0
    End Sub

    Private Sub CmdInsert_Click(sender As Object, e As EventArgs) Handles cmdInsert.Click
        Try
            With dept
                .DepartmentName = Me.txtName.Text
                .DepartmentID = CInt(txtDeptID.Text)
                .DivisionID = CInt(txtDivID.Text)
                If .DatabaseID > 0 Then
                    .UpdateDepartment()
                Else
                    .InsertDepartment()
                End If
            End With
            LoadData()
        Catch ex As Exception
            Dim handleError As New ErrorHandler
            With handleError
                .ErrorNumber = Err.Number
                .ErrorDescription = Err.Description
                .ExceptionMessage = ex.Message
                .LogError()
            End With
        End Try
    End Sub

    Private Sub TxtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        With dept
            If .SearchDepartments(Me.txtName.Text) Then
                Me.txtName.Text = .DepartmentName
                Me.txtDeptID.Text = CStr(.DepartmentID)
                Me.txtDivID.Text = CStr(.DivisionID)
                Me.lblDatID.Text = "Database ID: " & CStr(.DatabaseID)
                Me.cmdInsert.Text = "Update Department"
            Else
                Me.lblDatID.Text = "Database ID: "
                .DatabaseID = 0
                Me.cmdInsert.Text = "Add New Department"
            End If
        End With
    End Sub

    Private Sub CmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        Me.lblDatID.Text = "Database ID: "
        Me.txtName.Text = ""
        Me.txtDivID.Text = ""
        Me.txtDeptID.Text = ""
        Me.cmdInsert.Text = "Add New Department"
    End Sub

    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
End Class
Public Class FrmDepartments
    Private dept As New Deparmtnets

    Private Sub LoadData()
        With dgvDepartments
            .AutoGenerateColumns = True
            .DataSource = dept.Data
            .Refresh()
            .AutoResizeColumns()
        End With
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
End Class
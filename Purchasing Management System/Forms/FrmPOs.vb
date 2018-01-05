Public Class FrmPOs
    Private Sub FrmPOs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillPOData()
    End Sub

    Private Sub CmdOpen_Click(sender As Object, e As EventArgs) Handles cmdOpen.Click
        If Application.OpenForms.OfType(Of FrmPOEdit).Any <> True Then
            Dim po As New PurchaseOrder
            Try
                po.SetPurchaseOrderDetails(Me.txtPONum.Text, Me.txtVendor.Text, Me.txtMgr.Text, CType(Me.txtDate.Text, Date))
                If po.SearchPOs(Me.txtPONum.Text) = False Then
                    po.SubmitPurchaseOrder()
                End If
                Dim frm As New FrmPOEdit(po) With {.MdiParent = FrmMain}
                frm.Show()
                Me.Close()
            Catch
                MsgBox("One or more entries were incorrect. Please try again.")
            End Try
        End If
    End Sub

    Private Sub CmdDeletePO_Click(sender As Object, e As EventArgs) Handles cmdDeletePO.Click
        Dim po As New PurchaseOrder
        With po
            .SetPurchaseOrderDetails(Me.txtPONum.Text, Me.txtVendor.Text, Me.txtMgr.Text, CType(Me.txtDate.Text, Date))
            .ErasePurchaseOrder()
        End With
        FillPOData()
    End Sub

    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub DgvPOItems_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPO.CellClick
        Dim xRow As DataGridViewRow = Me.dgvPO.CurrentRow
        Me.txtDate.Text = CType(xRow.Cells(1).Value, String)
        Me.txtPONum.Text = CType(xRow.Cells(0).Value, String)
        Me.txtMgr.Text = CType(xRow.Cells(2).Value, String)
        Me.txtVendor.Text = CType(xRow.Cells(3).Value, String)
    End Sub

    Public Sub FillPOData()
        Dim po As New PurchaseOrder
        With po.Data
            For i As Integer = 0 To .Rows.Count - 1
                If .Rows(i).Item(4).GetType() IsNot GetType(DBNull) Then
                    .Rows(i).Item(4) = .Rows(i).Item(4) * (1 + My.Settings.TaxRate)
                End If
            Next i
        End With
        With Me.dgvPO
            .AutoGenerateColumns = True
            .DataSource = po.Data
            .Refresh()
        End With
        po = Nothing
    End Sub
End Class
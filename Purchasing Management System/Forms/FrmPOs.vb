Public Class FrmPOs
    Private Sub FrmPOs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillPOData()
    End Sub

    Private Sub CmdOpen_Click(sender As Object, e As EventArgs) Handles cmdOpen.Click
        If Application.OpenForms.OfType(Of FrmPOEdit).Any <> True Then
            Dim po As New PurchaseOrder
            Try
                With po
                    .SetPurchaseOrderDetails(Me.txtPONum.Text, Me.txtVendor.Text, Me.txtMgr.Text, CType(Me.txtDate.Text, Date))
                    If .Exists = False Then
                        .SubmitPurchaseOrder()
                    End If

                    Dim frm As New FrmPOEdit(po) With {.MdiParent = FrmMain}
                    frm.Show()
                    Me.Close()
                End With
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
    End Sub

    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub DgvPOItems_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPO.CellClick
        Dim xRow As DataGridViewRow = Me.dgvPO.CurrentRow
        Me.txtDate.Text = xRow.Cells(1).Value
        Me.txtPONum.Text = xRow.Cells(0).Value
        Me.txtMgr.Text = xRow.Cells(2).Value
        Me.txtVendor.Text = xRow.Cells(3).Value
    End Sub

    Public Sub FillPOData()
        Dim po As New PurchaseOrder
        Dim table As DataTable
        With po
            table = .GetPOData
        End With

        With table
            For i = 0 To .Rows.Count - 1
                .Rows(i).Item(4) = .Rows(i).Item(4) * (1 + My.Settings.TaxRate)
            Next
        End With
        With Me.dgvPO
            .AutoGenerateColumns = True
            .DataSource = table
            .Refresh()
        End With
        po = Nothing
        table.Dispose()
    End Sub
End Class
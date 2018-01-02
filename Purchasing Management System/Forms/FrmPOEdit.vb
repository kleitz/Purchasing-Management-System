Public Class FrmPOEdit
    Dim Purchase As New PurchaseOrder
    Private Sub FrmPOEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayPODetails()
    End Sub

    Public Sub New(ByVal PO As PurchaseOrder)
        InitializeComponent()
        Purchase = PO
        Show()
    End Sub

    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Dim frm As New FrmPOs With {.MdiParent = FrmMain}
        frm.Show()
        Close()
    End Sub

    Private Sub CmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        ' Try
        With Purchase
                .SetPurchaseOrderLineDetails(Me.txtGLCode.Text, Me.txtItemDesc.Text, Me.txtPrice.Text)
                .SubmitPurchaseOrderEntry()
            End With
        DisplayPODetails()
        Me.txtItemDesc.Text = ""
        Me.txtPrice.Text = ""
        Me.txtItemDesc.Focus()
        'Catch
        'MsgBox("One or more entries was incorrect. Please try again.")
        'End Try
    End Sub

    Private Sub DisplayPODetails()
        Dim table As New DataTable
        Dim total As Double
        Me.Text = "PO: " & Purchase.PONumber
        With Purchase
            table = .GetPOLineData()
        End With
        With dgvPOItems
            .AutoGenerateColumns = True
            .DataSource = table
            .Refresh()
        End With
        table.Dispose()
        For Each row As DataGridViewRow In dgvPOItems.Rows
            total += row.Cells(4).Value
        Next
        Me.lblSubTotal.Text = "Sub Total: " & total
        Me.lblTax.Text = "Tax: " & (total * My.Settings.TaxRate)
        Me.lblTotal.Text = "Total: " & ((total * My.Settings.TaxRate) + total)
    End Sub

    Private Sub DgvPOItems_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPOItems.CellClick
        Dim xRow = Me.dgvPOItems.CurrentRow
        Purchase.LineID = xRow.Cells(0).Value
        Me.lblID.Text = "ID: " & Purchase.LineID
        Me.txtGLCode.Text = xRow.Cells(3).Value
        Me.txtItemDesc.Text = xRow.Cells(2).Value
        Me.txtPrice.Text = xRow.Cells(4).Value
    End Sub

    Private Sub CmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        Try
            With Purchase
                .SetPurchaseOrderLineDetails(Me.txtGLCode.Text, Me.txtItemDesc.Text, Me.txtPrice.Text)
                .UpdatePurchaseOrderEntry()
                Purchase.LineID = -1
                DisplayPODetails()
            End With
        Catch
            MsgBox("One or more entries was incorrect. Please try your entries again.")
        End Try
    End Sub

    Private Sub CmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        With Purchase
            .DeletePurchaseOrderEntry()
            Purchase.LineID = -1
            DisplayPODetails()
        End With
    End Sub
End Class


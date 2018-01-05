Public Class FrmPOEdit
    Dim PurchaseItem As PurchaseOrderItem
    Private Sub FrmPOEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayPODetails()
    End Sub

    Public Sub New(ByVal PO As PurchaseOrder)
        InitializeComponent()
        PurchaseItem = New PurchaseOrderItem(PO)
        Show()
    End Sub

    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Dim frm As New FrmPOs With {.MdiParent = FrmMain}
        frm.Show()
        Close()
    End Sub

    Private Sub CmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        With PurchaseItem
            .GlCode = Me.txtGLCode.Text
            .Description = Me.txtItemDesc.Text
            .Price = CType(Me.txtPrice.Text, Double)
            .SubmitPurchaseOrderItemEntry()
        End With
        DisplayPODetails()
        Me.txtItemDesc.Text = ""
        Me.txtPrice.Text = ""
        Me.txtItemDesc.Focus()
    End Sub

    Private Sub DisplayPODetails()
        Dim total As Double
        PurchaseItem.GetData()
        Me.Text = "PO: " & PurchaseItem.PONumber
        With dgvPOItems
            .AutoGenerateColumns = True
            .DataSource = PurchaseItem.Data
            .Refresh()
        End With

        For Each row As DataGridViewRow In dgvPOItems.Rows
            total += CType(row.Cells(4).Value, Double)
        Next
        Me.lblSubTotal.Text = "Sub Total: " & total
        Me.lblTax.Text = "Tax: " & (total * My.Settings.TaxRate)
        Me.lblTotal.Text = "Total: " & ((total * My.Settings.TaxRate) + total)
    End Sub

    Private Sub DgvPOItems_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPOItems.CellClick
        Dim xRow As DataGridViewRow = Me.dgvPOItems.CurrentRow
        PurchaseItem.LineID = CType(xRow.Cells(0).Value, Integer)
        Me.lblID.Text = "ID: " & PurchaseItem.LineID
        Me.txtGLCode.Text = CType(xRow.Cells(3).Value, String)
        Me.txtItemDesc.Text = CType(xRow.Cells(2).Value, String)
        Me.txtPrice.Text = CType(xRow.Cells(4).Value, String)
    End Sub

    Private Sub CmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        PurchaseItem.DeletePurchaseOrderItemEntry()
        PurchaseItem.GetData()
    End Sub

End Class


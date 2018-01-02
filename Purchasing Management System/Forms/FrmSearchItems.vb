Public Class FrmSearchItems
    Dim item As New InventoryItem
    Private Sub FrmSearchItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me.comboVendor.Items
            .Add("Southeastern Paper Group")
            .Add("Perimeter Office Products")
            .Add("Sewell")
            .Add("Six Degrees North")
        End With

        With Me.comboUM.Items
            .Add("Case")
            .Add("Roll")
            .Add("Each")
            .Add("Box")
        End With

        With Me.comboCat.Items
            .Add("Guest Supplies")
            .Add("Cleaning Supplies")
            .Add("Laundry Supplies")
            .Add("Stationary Supplies")
            .Add("F&B Disposables")
            .Add("Paper Disposables")
            .Add("Candy")
            .Add("Ammenities")
            .Add("Fuel")
        End With
        ReturnItems(InventoryItem.SearchMethod.AllItems)
    End Sub

    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub ReturnItems(pSearchMethod As InventoryItem.SearchMethod)
        Dim tbl As New DataTable
        With item
            tbl = .ReturnAgilisysItems(pSearchMethod)
        End With
        With dgvItems
            .AutoGenerateColumns = True
            .DataSource = tbl
            .Refresh()
            .AutoResizeColumns()
        End With
    End Sub

    Private Sub CmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        With item
            If Me.txtVendIN.Text.Length > 0 Then
                .VendorItemNumber = Me.txtVendIN.Text
                ReturnItems(InventoryItem.SearchMethod.VendorID)
            ElseIf Me.txtDesc.Text.Length > 0 Then
                .Description = Me.txtDesc.Text
                ReturnItems(InventoryItem.SearchMethod.Description)
            Else
                ReturnItems(InventoryItem.SearchMethod.AllItems)
            End If
        End With
    End Sub

    Private Sub CmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        With item
            '  .VendorItemNumber = Me.txtVendIN.Text
            '.AgilisysItemNumber = CDbl(Me.txtSWSIN.Text)
            '.Price = Me.txtPrice.Text
            '.Category = Me.comboCat.Text
            '.Packaging = Me.txtPkg.Text
            .VendorName = Me.comboVendor.Text
            '.UnitMeasure = Me.comboUM.Text
            '.Description = Me.txtDesc.Text
            '.BuildIndex()
            'If .ItemExists(.VendorItemNumber) = True Then
            ' .UpdateAgilisysItem()
            'Else
            '.SubmitAgilisysItem()
            'End If
        End With
    End Sub


    Private Sub DgvItems_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvItems.CellClick
        On Error Resume Next
        Dim xRow = Me.dgvItems.CurrentRow
        Me.txtVendIN.Text = xRow.Cells(2).Value
        Me.txtSWSIN.Text = xRow.Cells(3).Value
        Me.txtPrice.Text = xRow.Cells(7).Value
        Me.txtPkg.Text = xRow.Cells(5).Value
        Me.txtDesc.Text = xRow.Cells(4).Value
        Me.comboVendor.Text = xRow.Cells(1).Value
        Me.comboUM.Text = xRow.Cells(6).Value
        On Error GoTo 0
    End Sub

    Private Sub CmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        Me.txtVendIN.Text = ""
        Me.txtSWSIN.Text = ""
        Me.txtPrice.Text = ""
        Me.txtDesc.Text = ""
        Me.comboCat.Text = ""
        Me.comboUM.Text = ""
        Me.comboVendor.Text = ""
    End Sub
End Class
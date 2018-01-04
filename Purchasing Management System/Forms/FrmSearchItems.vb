Public Class FrmSearchItems
    Dim item As InventoryItem
    Dim vend As Vendors
    Private Sub FrmSearchItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vend = New Vendors
        item = New InventoryItem
        For Each row As DataRow In vend.Data.Rows
            With Me.comboVendor.Items
                .Add(row(1).ToString)
            End With
        Next

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
        item.GetData(pSearchMethod)
        With dgvItems
            .AutoGenerateColumns = True
            .DataSource = item.Data
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
            .VendorItemNumber = Me.txtVendIN.Text
            If .SearchItems(.VendorItemNumber) = True Then
                .BarcodeID = Me.txtBarcode.Text
                .AgilisysItemNumber = CDbl(Me.txtSWSIN.Text)
                .Price = Me.txtPrice.Text
                .Category = Me.comboCat.Text
                .Packaging = Me.txtPkg.Text
                .VendorName = Me.comboVendor.Text
                .UnitMeasure = Me.comboUM.Text
                .Description = Me.txtDesc.Text
                .Quantity = Me.txtQnty.Text
                .UpdateAgilisysItem()
            Else
                .AgilisysItemNumber = CDbl(Me.txtSWSIN.Text)
                .Price = Me.txtPrice.Text
                .Category = Me.comboCat.Text
                .Packaging = Me.txtPkg.Text
                .VendorName = Me.comboVendor.Text
                .UnitMeasure = Me.comboUM.Text
                .Description = Me.txtDesc.Text
                .Quantity = Me.txtQnty.Text
                .SubmitAgilisysItem()
            End If
            Me.ReturnItems(InventoryItem.SearchMethod.VendorID)
        End With
    End Sub


    Private Sub DgvItems_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvItems.CellClick
        On Error Resume Next
        Dim xRow As DataGridViewRow = Me.dgvItems.CurrentRow
        Me.txtVendIN.Text = CType(xRow.Cells(3).Value, String)
        Me.txtSWSIN.Text = CType(xRow.Cells(4).Value, String)
        Me.txtPrice.Text = CType(xRow.Cells(9).Value, String)
        Me.txtPkg.Text = CType(xRow.Cells(6).Value, String)
        Me.txtDesc.Text = CType(xRow.Cells(5).Value, String)
        Me.comboVendor.Text = CType(xRow.Cells(1).Value, String)
        Me.comboUM.Text = CType(xRow.Cells(7).Value, String)
        Me.txtQnty.Text = CType(xRow.Cells(8).Value, String)
        Me.txtBarcode.Text = CType(xRow.Cells(2).Value, String)
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
        Me.txtQnty.Text = ""
        ReturnItems(InventoryItem.SearchMethod.AllItems)
    End Sub
End Class
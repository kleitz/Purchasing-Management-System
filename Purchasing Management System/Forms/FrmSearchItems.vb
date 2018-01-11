Public Class FrmSearchItems
    Dim item As InventoryItem

    Private Sub FrmSearchItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        item = New InventoryItem
        For Each row As DataRow In item.vend.Data.Rows
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
            .Add("Printing/Stationary")
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
        item.vend.SearchVendors(Me.comboVendor.Text)

        Dim exist As Boolean
        exist = item.SearchItems(Me.txtSWSIN.Text)

        With item
            .BarcodeID = Me.txtBarcode.Text
            .VendorItemNumber = Me.txtVendIN.Text
            .AgilisysItemNumber = CDbl(Me.txtSWSIN.Text)
            .Description = Me.txtDesc.Text
            .Packaging = Me.txtPkg.Text
            .Price = Me.txtPrice.Text
            .UnitMeasure = Me.comboUM.Text
            .Category = Me.comboCat.Text
            .Quantity = Me.txtQnty.Text
        End With
        If item.vend.VendorID > 0 Then
            If exist Then
                item.UpdateAgilisysItem()
            Else
                item.SubmitAgilisysItem()
            End If
            Me.ReturnItems(InventoryItem.SearchMethod.Description)
        Else
            MsgBox("Invalid vendor. Please add vendor from the Vendors module under Settings/Database Settings.")
            Exit Sub
        End If
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
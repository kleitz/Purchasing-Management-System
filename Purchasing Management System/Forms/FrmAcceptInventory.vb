Imports Microsoft.Office.Interop

Public Class FrmAcceptInventory
    Dim Inventory As New InventoryItem
    Dim xrow As New DataGridViewRow
    Private Sub TxtScanner_TextChanged(sender As Object, e As EventArgs) Handles txtScanner.TextChanged
        With Inventory
            .SearchItems(Me.txtScanner.Text)
            If .Exists = True Then
                txtScanner.Text = ""
                Dim row As Int32
                If dgvReciever.Rows.Count > 0 Then
                    For i = 0 To dgvReciever.Rows.Count - 1
                        If dgvReciever.Rows(i).Cells(0).Value = .VendorItemNumber Then
                            dgvReciever.Rows(i).Cells(3).Value = dgvReciever.Rows(i).Cells(3).Value + 1
                            dgvReciever.Rows(i).Cells(4).Value = dgvReciever.Rows(i).Cells(3).Value * .Price
                            dgvReciever.AutoSizeColumnsMode() = DataGridViewAutoSizeColumnMode.AllCells
                            Exit Sub
                        End If
                    Next i
                End If
                row = dgvReciever.Rows.Add()
                dgvReciever.Rows(row).Cells(0).Value = .VendorItemNumber
                dgvReciever.Rows(row).Cells(1).Value = .AgilisysItemNumber
                dgvReciever.Rows(row).Cells(2).Value = .Description
                dgvReciever.Rows(row).Cells(3).Value = 1
                dgvReciever.Rows(row).Cells(4).Value = dgvReciever.Rows(row).Cells(3).Value * .Price
                dgvReciever.AutoSizeColumnsMode() = DataGridViewAutoSizeColumnMode.AllCells
            End If
        End With
    End Sub

    Private Sub FrmAcceptInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inventory = New InventoryItem
    End Sub

    Private Sub CmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        Try
            dgvReciever.Rows.Remove(xrow)
        Catch
            MsgBox("Please select a row to delete.")
        End Try
    End Sub

    Private Sub DgvReciever_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvReciever.CellClick
        xrow = New DataGridViewRow
        xrow = dgvReciever.CurrentRow
    End Sub

    Private Sub CmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        For Each row As DataGridViewRow In dgvReciever.Rows
            Inventory.AgilisysItemNumber = row.Cells(1).Value
            Inventory.Quantity = row.Cells(3).Value
            Inventory.UpdateQuantity()
        Next

        Dim xlApp As New Excel.Application
        Dim xlWb As Excel.Workbook = xlApp.Workbooks.Open(Application.StartupPath & "\Resources\Accept Inventory.xlsx")
        Dim xlWs As Excel.Worksheet = xlWb.Worksheets(1)
        Dim i As Integer = 0

        With xlWs
            .Cells(3, 2) = "Date: " & DateTime.Today.ToString("d") & DateTime.Today.DayOfWeek.ToString()

            For Each row As DataGridViewRow In dgvReciever.Rows
                .Cells(i + 6, 1) = row.Cells(0).Value
                .Cells(i + 6, 2) = row.Cells(1).Value
                .Cells(i + 6, 3) = row.Cells(2).Value
                .Cells(i + 6, 4) = row.Cells(3).Value
                .Cells(i + 6, 5) = row.Cells(4).Value
                i += 1
            Next
        End With
        xlApp.Visible = True
    End Sub
End Class
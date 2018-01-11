Imports Microsoft.Office.Interop
Public Class FrmReqInventory
    Private Items As New InventoryItem
    Private req As Requisitions
    Private reqItem As RequisitionItems

    Private Sub FrmReqInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        req = New Requisitions
        Me.cmdDelete.Enabled = False
        Me.cmdSave.Enabled = False
        Me.cmdReloadItems.Visible = False
        Me.cmdReloadItems.Enabled = False
        Me.dgvRequisition.Enabled = False
        Items.GetData(InventoryItem.SearchMethod.AllItems)
        req.Department.GetData()
        For Each row As DataRow In req.Department.Data.Rows
            With Me.comboDept.Items
                .Add(row(1).ToString)
            End With
        Next
    End Sub

    Private Sub TxtScanner_TextChanged(sender As Object, e As EventArgs) Handles txtScanner.TextChanged
        Dim f As Double
        With Items
            If .SearchItems(Me.txtScanner.Text) Then
                txtScanner.Text = ""
                Dim row As Int32
                If dgvRequisition.Rows.Count > 0 Then
                    For i As Integer = 0 To dgvRequisition.Rows.Count - 1
                        If CType(dgvRequisition.Rows(i).Cells(0).Value, String) = .VendorItemNumber Then
                            dgvRequisition.Rows(i).Cells(3).Value = CType(dgvRequisition.Rows(i).Cells(3).Value, Integer) + 1
                            dgvRequisition.Rows(i).Cells(4).Value = .Quantity - CType(dgvRequisition.Rows(i).Cells(3).Value, Integer)
                            dgvRequisition.Rows(i).Cells(5).Value = CType(dgvRequisition.Rows(i).Cells(3).Value, Integer) * CDbl(.Price)
                            dgvRequisition.AutoSizeColumnsMode() = DataGridViewAutoSizeColumnMode.AllCells
                            Exit Sub
                        End If
                    Next i
                End If
                row = dgvRequisition.Rows.Add()
                dgvRequisition.Rows(row).Cells(0).Value = .VendorItemNumber
                dgvRequisition.Rows(row).Cells(1).Value = .AgilisysItemNumber
                dgvRequisition.Rows(row).Cells(2).Value = .Description
                dgvRequisition.Rows(row).Cells(3).Value = 1
                dgvRequisition.Rows(row).Cells(4).Value = .Quantity
                dgvRequisition.Rows(row).Cells(5).Value = CType(dgvRequisition.Rows(row).Cells(3).Value, Integer) * .Price
                dgvRequisition.Rows(row).Cells(6).Value = .BarcodeID
                dgvRequisition.AutoSizeColumnsMode() = DataGridViewAutoSizeColumnMode.AllCells
            End If
        End With
        For Each row As DataGridViewRow In dgvRequisition.Rows
            f = 0
            f = row.Cells(5).Value + f
        Next
        lblSubTotal.Text = "Sub Total: " & CStr(f)
        lblTax.Text = "Tax: " & CStr(f * My.Settings.TaxRate)
        lblTotal.Text = "Grand Total: " & CStr((f * My.Settings.TaxRate) + f)
    End Sub

    Private Sub CmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click

        req.SubmitRequisition()

        Dim xlApp As New Excel.Application
        Dim xlWb As Excel.Workbook = xlApp.Workbooks.Open(Application.StartupPath & "\Resources\Requisition.xlsx")
        Dim xlWs As Excel.Worksheet = xlWb.Worksheets(1)
        Dim i As Integer = 0
        Dim total As Double = 0

        With xlWs
            .Cells(3, 2) = "Date: " & DateTime.Today.ToString("d") & DateTime.Today.DayOfWeek.ToString()
            .Cells(4, 2) = req.Department.DepartmentName
            .Cells(5, 2) = req.Department.DivisionID
            .Cells(6, 2) = req.Department.DepartmentID
            For Each row As DataGridViewRow In dgvRequisition.Rows
                '    reqItem.BarcodeID = row.Cells(6).Value
                '   reqItem.Quantity = row.Cells(3).Value
                '   reqItem.SubmitRequisitionItem()
                .Cells(i + 9, 1) = row.Cells(0).Value
                .Cells(i + 9, 2) = row.Cells(1).Value
                .Cells(i + 9, 3) = row.Cells(2).Value
                .Cells(i + 9, 4) = row.Cells(3).Value
                .Cells(i + 9, 5) = row.Cells(4).Value
                .Cells(i + 9, 6) = row.Cells(5).Value
                total = total + row.Cells(5).Value
                i += 1
            Next
            .Cells(3, 5) = total
            .Cells(4, 5) = total * My.Settings.TaxRate
            .Cells(5, 5) = (total * My.Settings.TaxRate) + total
        End With

        xlApp.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        req.Department.DepartmentName = Me.comboDept.Text
        If req.Department.SearchDepartments(Me.comboDept.Text) Then
            req.RequisitionDate = Now()
            Me.cmdDelete.Enabled = True
            Me.cmdSave.Enabled = True
            Me.dgvRequisition.Enabled = True
            Me.Button1.Enabled = False
            Me.Button1.Visible = False
            Me.comboDept.Enabled = False
            Me.cmdReloadItems.Visible = True
            Me.cmdReloadItems.Enabled = True
            Me.txtScanner.Focus()
        End If
    End Sub

    Private Sub cmdReloadItems_Click(sender As Object, e As EventArgs) Handles cmdReloadItems.Click
        Items.BuildItemsIndex(InventoryItem.SearchMethod.AllItems)
    End Sub
End Class
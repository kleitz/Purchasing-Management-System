Public Class FrmReports
    Private Sub cmdPOReport_Click(sender As Object, e As EventArgs) Handles cmdPOReport.Click
        Dim po As New PurchaseOrder
        po.GeneratePurchaseOrderReport(txtMonth.Text, txtYear.Text)
    End Sub
End Class
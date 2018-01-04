Public Class FrmReports
    Private Sub CmdPOReport_Click(sender As Object, e As EventArgs) Handles cmdPOReport.Click
        Dim po As New PurchaseOrder
        Dim mt As Integer
        Dim yr As Integer
        mt = CType(Me.txtMonth.Text, Integer)
        yr = CType(Me.txtYear.Text, Integer)
        po.GeneratePurchaseOrderReport(mt, yr)
    End Sub

    Private Sub CmdSum_Click(sender As Object, e As EventArgs) Handles cmdSum.Click

    End Sub
End Class
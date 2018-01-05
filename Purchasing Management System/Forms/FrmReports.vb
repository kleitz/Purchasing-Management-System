Public Class FrmPOReports
    Private Sub CmdPOReport_Click(sender As Object, e As EventArgs) Handles cmdPOReport.Click
        Dim po As New PurchaseOrder
        Dim mt As Integer
        Dim yr As Integer
        mt = CType(Me.txtMonth.Text, Integer)
        yr = CType(Me.txtYear.Text, Integer)
        po.GenerateDetailedPurchaseOrderReport(mt, yr)
    End Sub

    Private Sub CmdSum_Click(sender As Object, e As EventArgs) Handles cmdSum.Click
        Dim po As New PurchaseOrder
        Dim mt As Integer
        Dim yr As Integer
        mt = CInt(Me.txtSumMonth.Text)
        yr = CInt(Me.txtSumYear.Text)
        po.GenerateSummaryPurchaseOrderReport(mt, yr)
    End Sub
End Class
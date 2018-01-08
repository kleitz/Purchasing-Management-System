Public Class FrmPackagesReports
    Dim pkg As New Package
    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdGenSumReport_Click(sender As Object, e As EventArgs) Handles cmdGenSumReport.Click

    End Sub

    Private Sub cmdGenerateReport_Click(sender As Object, e As EventArgs) Handles cmdGenerateReport.Click

    End Sub

    Private Sub FrmPackagesReports_Load(sender As Object, e As EventArgs) Handles Me.Load
        pkg.GetPackageData()
    End Sub
End Class
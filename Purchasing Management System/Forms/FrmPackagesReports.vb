Public Class FrmPackagesReports
    Dim pkg As New Package
    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdGenSumReport_Click(sender As Object, e As EventArgs) Handles cmdGenSumReport.Click
        pkg.PackageDate = CDate(Me.dtpPackageDate.Text)
        pkg.GetPackageData()
        Dim report As New ReportsGenerator
        With report
            .source = pkg
            .GenerateReport(3, "All Packages for: " & Me.dtpPackageDate.Text)
        End With
    End Sub

    Private Sub cmdGenerateReport_Click(sender As Object, e As EventArgs) Handles cmdGenerateReport.Click
        Try
            pkg.GenerateMonthlyPackageReport(CInt(Me.txtMonth.Text), CInt(Me.txtYear.Text))
        Catch ex As Exception
            Dim HandleError As New ErrorHandler
            With HandleError
                .ErrorNumber = Err.Number
                .ErrorDescription = Err.Description
                .ExceptionMessage = ex.Message
                .LogError()
            End With
        End Try
    End Sub

    Private Sub FrmPackagesReports_Load(sender As Object, e As EventArgs) Handles Me.Load
        pkg.GetPackageData()
    End Sub
End Class
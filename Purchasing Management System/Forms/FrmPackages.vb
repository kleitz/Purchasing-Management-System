Imports Microsoft.Office.Interop

Public Class FrmPackages
    Private Sub FrmPackages_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtDate.Text = DateTime.Today.ToString("d")
        FillPackageData(CDate(Me.txtDate.Text))
        With Me.comboCourier
            With .Items
                .Add("UPS")
                .Add("FEDEX")
                .Add("USPS")
                .Add("Courier")
            End With
        End With
        With Me.comboGorE
            With .Items
                .Add("Guest")
                .Add("Employee")
            End With
        End With
        With Me.comboType
            With .Items
                .Add("Box")
                .Add("Envelope")
                .Add("Tube")
                .Add("Other")
            End With
        End With
    End Sub


    Private Sub FillPackageData(pDate As Date)
        Dim pkg As New Package
        Dim table As New System.Data.DataTable
        With pkg
            .PackageDate = pDate
            table = .GetPackageData
        End With
        With dgvShippingLog
            .AutoGenerateColumns = True
            .DataSource = table
            .Refresh()
        End With
    End Sub

    Private Sub DgvShippingLog_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvShippingLog.CellClick
        Dim xRow As DataGridViewRow = Me.dgvShippingLog.CurrentRow
        Me.comboCourier.Text = CType(xRow.Cells(0).Value, String)
        Me.comboType.Text = CType(xRow.Cells(4).Value, String)
        Me.comboGorE.Text = CType(xRow.Cells(1).Value, String)
        Me.txtReciever.Text = CType(xRow.Cells(2).Value, String)
        Me.txtSender.Text = CType(xRow.Cells(3).Value, String)
        Me.txtTracking.Text = CType(xRow.Cells(5).Value, String)
    End Sub

    Private Sub CmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim pkg As New Package
        With pkg
            .PackageDate = CType(Me.txtDate.Text, Date)
            .Courier = Me.comboCourier.Text
            .Shipper = Me.txtSender.Text
            .Recipient = Me.txtReciever.Text
            .PackageType = Me.comboType.Text
            .RecipientType = Me.comboGorE.Text
            .TrackingNumber = Me.txtTracking.Text
            .SubmitTrackingEntry()
        End With
        FillPackageData(pkg.PackageDate)
        Me.txtReciever.Text = ""
        Me.txtSender.Text = ""
        Me.txtTracking.Text = ""
        Me.txtReciever.Focus()
    End Sub

    Private Sub CmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        Dim pkg As New Package
        With pkg
            .PackageDate = CType(txtDate.Text, Date)
            .Courier = comboCourier.Text
            .Shipper = txtSender.Text
            .Recipient = txtReciever.Text
            .PackageType = comboType.Text
            .RecipientType = comboGorE.Text
            .TrackingNumber = txtTracking.Text
            .UpateTrackingEntry()
        End With
        FillPackageData(pkg.PackageDate)
    End Sub

    Private Sub CmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        Dim pkg As New Package
        With pkg
            .PackageDate = CType(Me.txtDate.Text, Date)
            .TrackingNumber = Me.txtTracking.Text
            .DeleteTrackingEntry()
        End With
        FillPackageData(pkg.PackageDate)
    End Sub

    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub TxtDate_TextChanged(sender As Object, e As PreviewKeyDownEventArgs) Handles txtDate.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Dim pkg As New Package
                With pkg
                    .PackageDate = CType(Me.txtDate.Text, Date)
                End With
                FillPackageData(pkg.PackageDate)
            Catch
                MsgBox("Please enter a valid date.")
            End Try
        End If
    End Sub

    Private Sub CmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        Dim pkg As New Package
        Dim xlApp As New Excel.Application
        Dim xlWb As Excel.Workbook = xlApp.Workbooks.Open(Application.StartupPath & "\Resources\Employee Shipping Log.xlsx")
        Dim xlWs As Excel.Worksheet = xlWb.Worksheets(1)
        Dim i As Integer = 0
        pkg.RecipientType = "Employee"
        pkg.PackageDate = DateTime.Today.ToString("d")
        pkg.GeneratePackageReport()
        With xlWs
            .Cells(1, 3) = "Date: " & DateTime.Today.ToString("d") & " " & DateTime.Today.DayOfWeek.ToString()
            .Cells(3, 1) = pkg.RecipientType & " Recieving Log"
            For Each row As DataRow In pkg.tbl.Rows
                .Cells(i + 6, 1) = row(0).ToString
                .Cells(i + 6, 2) = row(1).ToString
                .Cells(i + 6, 3) = row(2).ToString
                .Cells(i + 6, 4) = row(3).ToString
                .Cells(i + 6, 5) = row(4).ToString
                i += 1
            Next
        End With
        xlApp.Visible = True
    End Sub

    Private Sub PbUPS_Click(sender As Object, e As EventArgs) Handles pbUPS.Click
        Process.Start("https://www.ups.com/WebTracking/track?loc=en_US")
    End Sub

    Private Sub PbFEDEX_Click(sender As Object, e As EventArgs) Handles pbFEDEX.Click
        Process.Start("https://www.fedex.com/en-us/home.html")
    End Sub

    Private Sub PbUSPS_Click(sender As Object, e As EventArgs) Handles pbUSPS.Click
        Process.Start("https://tools.usps.com/go/TrackConfirmAction!input.action")
    End Sub
End Class
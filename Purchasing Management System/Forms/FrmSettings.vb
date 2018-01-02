Imports System.Configuration
Imports System.Collections.Specialized

Public Class FrmSettings
    Private Sub FrmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblDatabaseLoc.Text = "Database Location: " & My.Settings.DatabaseLocation
    End Sub

    Private Sub CmdDatabaseLocation_Click(sender As Object, e As EventArgs) Handles cmdDatabaseLocation.Click
        Dim fileBrowser As New OpenFileDialog
        With fileBrowser
            .ShowDialog()
            If .FileName.Length = 0 Then
                MsgBox("Nothing Selected. Please try again.")
            Else
                Dim strFilePath As String
                strFilePath = System.IO.Path.GetFullPath(.FileName)
                My.Settings.DatabaseLocation() = strFilePath
                Me.lblDatabaseLoc.Text = "Location: " & strFilePath
            End If
        End With
    End Sub

    Private Sub CmdTaxRate_Click(sender As Object, e As EventArgs) Handles cmdTaxRate.Click
        If Me.TextBox1.Text.Length > 0 Then
            My.Settings.TaxRate = Me.TextBox1.Text
            MsgBox("New tax rate set. Tax rate:" & My.Settings.TaxRate)
        End If
    End Sub
End Class
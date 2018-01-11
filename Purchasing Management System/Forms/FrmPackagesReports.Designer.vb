<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPackagesReports
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMonth = New System.Windows.Forms.TextBox()
        Me.dtpPackageDate = New System.Windows.Forms.DateTimePicker()
        Me.cmdGenerateReport = New System.Windows.Forms.Button()
        Me.cmdGenSumReport = New System.Windows.Forms.Button()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Month:"
        '
        'txtMonth
        '
        Me.txtMonth.Location = New System.Drawing.Point(72, 28)
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Size = New System.Drawing.Size(100, 20)
        Me.txtMonth.TabIndex = 1
        '
        'dtpPackageDate
        '
        Me.dtpPackageDate.Location = New System.Drawing.Point(6, 19)
        Me.dtpPackageDate.Name = "dtpPackageDate"
        Me.dtpPackageDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpPackageDate.TabIndex = 2
        '
        'cmdGenerateReport
        '
        Me.cmdGenerateReport.Location = New System.Drawing.Point(59, 106)
        Me.cmdGenerateReport.Name = "cmdGenerateReport"
        Me.cmdGenerateReport.Size = New System.Drawing.Size(100, 23)
        Me.cmdGenerateReport.TabIndex = 3
        Me.cmdGenerateReport.Text = "Generate Report"
        Me.cmdGenerateReport.UseVisualStyleBackColor = True
        '
        'cmdGenSumReport
        '
        Me.cmdGenSumReport.Location = New System.Drawing.Point(59, 69)
        Me.cmdGenSumReport.Name = "cmdGenSumReport"
        Me.cmdGenSumReport.Size = New System.Drawing.Size(100, 23)
        Me.cmdGenSumReport.TabIndex = 4
        Me.cmdGenSumReport.Text = "Generate Report"
        Me.cmdGenSumReport.UseVisualStyleBackColor = True
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(72, 54)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(100, 20)
        Me.txtYear.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Year:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtYear)
        Me.GroupBox1.Controls.Add(Me.cmdGenerateReport)
        Me.GroupBox1.Controls.Add(Me.txtMonth)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(219, 149)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Packages by Month"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtpPackageDate)
        Me.GroupBox2.Controls.Add(Me.cmdGenSumReport)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 167)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(219, 114)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Packages by Day"
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(71, 287)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(100, 23)
        Me.cmdClose.TabIndex = 5
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'FrmPackagesReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(241, 319)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmPackagesReports"
        Me.Text = "Package Reports"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtMonth As TextBox
    Friend WithEvents dtpPackageDate As DateTimePicker
    Friend WithEvents cmdGenerateReport As Button
    Friend WithEvents cmdGenSumReport As Button
    Friend WithEvents txtYear As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmdClose As Button
End Class

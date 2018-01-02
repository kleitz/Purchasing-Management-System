<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReports
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMonth = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdPOReport = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtYear)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtMonth)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmdPOReport)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(702, 69)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Purchase Orders"
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(234, 29)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(100, 20)
        Me.txtYear.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(189, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Year:"
        '
        'txtMonth
        '
        Me.txtMonth.Location = New System.Drawing.Point(77, 29)
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Size = New System.Drawing.Size(100, 20)
        Me.txtMonth.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Month:"
        '
        'cmdPOReport
        '
        Me.cmdPOReport.Location = New System.Drawing.Point(549, 27)
        Me.cmdPOReport.Name = "cmdPOReport"
        Me.cmdPOReport.Size = New System.Drawing.Size(123, 23)
        Me.cmdPOReport.TabIndex = 0
        Me.cmdPOReport.Text = "Generate Report"
        Me.cmdPOReport.UseVisualStyleBackColor = True
        '
        'FrmReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 354)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmReports"
        Me.Text = "Reports"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtYear As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMonth As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdPOReport As Button
End Class

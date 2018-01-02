<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSettings
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
        Me.cmdDatabaseLocation = New System.Windows.Forms.Button()
        Me.lblDatabaseLoc = New System.Windows.Forms.Label()
        Me.cmdTaxRate = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdDatabaseLocation
        '
        Me.cmdDatabaseLocation.Location = New System.Drawing.Point(9, 99)
        Me.cmdDatabaseLocation.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdDatabaseLocation.Name = "cmdDatabaseLocation"
        Me.cmdDatabaseLocation.Size = New System.Drawing.Size(148, 28)
        Me.cmdDatabaseLocation.TabIndex = 0
        Me.cmdDatabaseLocation.Text = "Database Location"
        Me.cmdDatabaseLocation.UseVisualStyleBackColor = True
        '
        'lblDatabaseLoc
        '
        Me.lblDatabaseLoc.AutoSize = True
        Me.lblDatabaseLoc.Location = New System.Drawing.Point(165, 105)
        Me.lblDatabaseLoc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDatabaseLoc.Name = "lblDatabaseLoc"
        Me.lblDatabaseLoc.Size = New System.Drawing.Size(0, 17)
        Me.lblDatabaseLoc.TabIndex = 1
        '
        'cmdTaxRate
        '
        Me.cmdTaxRate.Location = New System.Drawing.Point(244, 13)
        Me.cmdTaxRate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdTaxRate.Name = "cmdTaxRate"
        Me.cmdTaxRate.Size = New System.Drawing.Size(148, 25)
        Me.cmdTaxRate.TabIndex = 2
        Me.cmdTaxRate.Text = "Set Tax Rate"
        Me.cmdTaxRate.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(86, 13)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(148, 22)
        Me.TextBox1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Tax Rate:"
        '
        'FrmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 140)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.cmdTaxRate)
        Me.Controls.Add(Me.lblDatabaseLoc)
        Me.Controls.Add(Me.cmdDatabaseLocation)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmSettings"
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdDatabaseLocation As Button
    Friend WithEvents lblDatabaseLoc As Label
    Friend WithEvents cmdTaxRate As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
End Class

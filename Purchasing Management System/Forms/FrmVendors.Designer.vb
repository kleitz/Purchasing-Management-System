<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVendors
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
        Me.dgvVendors = New System.Windows.Forms.DataGridView()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdInsert = New System.Windows.Forms.Button()
        Me.lblDatID = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtAcctNum = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.dgvVendors, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvVendors
        '
        Me.dgvVendors.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvVendors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVendors.Location = New System.Drawing.Point(12, 143)
        Me.dgvVendors.Name = "dgvVendors"
        Me.dgvVendors.Size = New System.Drawing.Size(655, 309)
        Me.dgvVendors.TabIndex = 32
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(572, 114)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(95, 23)
        Me.cmdClose.TabIndex = 31
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.Location = New System.Drawing.Point(572, 64)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(95, 23)
        Me.cmdClear.TabIndex = 30
        Me.cmdClear.Text = "Clear Form"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdInsert
        '
        Me.cmdInsert.Location = New System.Drawing.Point(572, 14)
        Me.cmdInsert.Name = "cmdInsert"
        Me.cmdInsert.Size = New System.Drawing.Size(95, 23)
        Me.cmdInsert.TabIndex = 29
        Me.cmdInsert.Text = "Add Vendor"
        Me.cmdInsert.UseVisualStyleBackColor = True
        '
        'lblDatID
        '
        Me.lblDatID.AutoSize = True
        Me.lblDatID.Location = New System.Drawing.Point(47, 14)
        Me.lblDatID.Name = "lblDatID"
        Me.lblDatID.Size = New System.Drawing.Size(61, 13)
        Me.lblDatID.TabIndex = 28
        Me.lblDatID.Text = "Vendor ID: "
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(114, 91)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(170, 20)
        Me.txtPhone.TabIndex = 27
        '
        'txtAcctNum
        '
        Me.txtAcctNum.Location = New System.Drawing.Point(114, 65)
        Me.txtAcctNum.Name = "txtAcctNum"
        Me.txtAcctNum.Size = New System.Drawing.Size(170, 20)
        Me.txtAcctNum.TabIndex = 26
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(114, 39)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(170, 20)
        Me.txtName.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Phone Number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Account Number:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Vendor Name:"
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(348, 91)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(170, 20)
        Me.txtState.TabIndex = 38
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(349, 66)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(170, 20)
        Me.txtCity.TabIndex = 37
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(348, 39)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(170, 20)
        Me.txtAddress.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(307, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "State:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(316, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "City:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(295, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Address:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(114, 116)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(170, 20)
        Me.txtEmail.TabIndex = 40
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(73, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Email:"
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(348, 116)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(170, 20)
        Me.txtZip.TabIndex = 42
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(289, 119)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Zip Code:"
        '
        'FrmVendors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 466)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgvVendors)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmdInsert)
        Me.Controls.Add(Me.lblDatID)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtAcctNum)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmVendors"
        Me.Text = "FrmVendors"
        CType(Me.dgvVendors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvVendors As DataGridView
    Friend WithEvents cmdClose As Button
    Friend WithEvents cmdClear As Button
    Friend WithEvents cmdInsert As Button
    Friend WithEvents lblDatID As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtAcctNum As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtState As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtZip As TextBox
    Friend WithEvents Label8 As Label
End Class

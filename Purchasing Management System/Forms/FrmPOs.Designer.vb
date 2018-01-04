<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPOs
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
        Me.lblDate = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtPONum = New System.Windows.Forms.TextBox()
        Me.lblPONo = New System.Windows.Forms.Label()
        Me.txtMgr = New System.Windows.Forms.TextBox()
        Me.lblManager = New System.Windows.Forms.Label()
        Me.txtVendor = New System.Windows.Forms.TextBox()
        Me.lblVendor = New System.Windows.Forms.Label()
        Me.cmdOpen = New System.Windows.Forms.Button()
        Me.cmdDeletePO = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.dgvPO = New System.Windows.Forms.DataGridView()
        CType(Me.dgvPO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(41, 12)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 0
        Me.lblDate.Text = "Date:"
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(80, 9)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(150, 20)
        Me.txtDate.TabIndex = 1
        '
        'txtPONum
        '
        Me.txtPONum.Location = New System.Drawing.Point(80, 39)
        Me.txtPONum.Name = "txtPONum"
        Me.txtPONum.Size = New System.Drawing.Size(150, 20)
        Me.txtPONum.TabIndex = 3
        '
        'lblPONo
        '
        Me.lblPONo.AutoSize = True
        Me.lblPONo.Location = New System.Drawing.Point(9, 42)
        Me.lblPONo.Name = "lblPONo"
        Me.lblPONo.Size = New System.Drawing.Size(65, 13)
        Me.lblPONo.TabIndex = 2
        Me.lblPONo.Text = "PO Number:"
        '
        'txtMgr
        '
        Me.txtMgr.Location = New System.Drawing.Point(80, 69)
        Me.txtMgr.Name = "txtMgr"
        Me.txtMgr.Size = New System.Drawing.Size(150, 20)
        Me.txtMgr.TabIndex = 5
        '
        'lblManager
        '
        Me.lblManager.AutoSize = True
        Me.lblManager.Location = New System.Drawing.Point(22, 72)
        Me.lblManager.Name = "lblManager"
        Me.lblManager.Size = New System.Drawing.Size(52, 13)
        Me.lblManager.TabIndex = 4
        Me.lblManager.Text = "Manager:"
        '
        'txtVendor
        '
        Me.txtVendor.Location = New System.Drawing.Point(80, 99)
        Me.txtVendor.Name = "txtVendor"
        Me.txtVendor.Size = New System.Drawing.Size(150, 20)
        Me.txtVendor.TabIndex = 7
        '
        'lblVendor
        '
        Me.lblVendor.AutoSize = True
        Me.lblVendor.Location = New System.Drawing.Point(30, 101)
        Me.lblVendor.Name = "lblVendor"
        Me.lblVendor.Size = New System.Drawing.Size(44, 13)
        Me.lblVendor.TabIndex = 6
        Me.lblVendor.Text = "Vendor:"
        '
        'cmdOpen
        '
        Me.cmdOpen.Location = New System.Drawing.Point(636, 9)
        Me.cmdOpen.Name = "cmdOpen"
        Me.cmdOpen.Size = New System.Drawing.Size(75, 52)
        Me.cmdOpen.TabIndex = 8
        Me.cmdOpen.Text = "Open PO"
        Me.cmdOpen.UseVisualStyleBackColor = True
        '
        'cmdDeletePO
        '
        Me.cmdDeletePO.Location = New System.Drawing.Point(636, 67)
        Me.cmdDeletePO.Name = "cmdDeletePO"
        Me.cmdDeletePO.Size = New System.Drawing.Size(75, 23)
        Me.cmdDeletePO.TabIndex = 10
        Me.cmdDeletePO.Text = "Delete PO"
        Me.cmdDeletePO.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(636, 96)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 11
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'dgvPO
        '
        Me.dgvPO.AllowUserToAddRows = False
        Me.dgvPO.AllowUserToDeleteRows = False
        Me.dgvPO.AllowUserToResizeColumns = False
        Me.dgvPO.AllowUserToResizeRows = False
        Me.dgvPO.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvPO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPO.GridColor = System.Drawing.SystemColors.Window
        Me.dgvPO.Location = New System.Drawing.Point(12, 125)
        Me.dgvPO.Name = "dgvPO"
        Me.dgvPO.ShowRowErrors = False
        Me.dgvPO.Size = New System.Drawing.Size(699, 365)
        Me.dgvPO.TabIndex = 12
        '
        'FrmPOs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 502)
        Me.Controls.Add(Me.dgvPO)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdDeletePO)
        Me.Controls.Add(Me.cmdOpen)
        Me.Controls.Add(Me.txtVendor)
        Me.Controls.Add(Me.lblVendor)
        Me.Controls.Add(Me.txtMgr)
        Me.Controls.Add(Me.lblManager)
        Me.Controls.Add(Me.txtPONum)
        Me.Controls.Add(Me.lblPONo)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.lblDate)
        Me.MaximizeBox = False
        Me.Name = "FrmPOs"
        Me.Text = "Purchase Orders"
        CType(Me.dgvPO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents txtDate As TextBox
    Friend WithEvents txtPONum As TextBox
    Friend WithEvents lblPONo As Label
    Friend WithEvents txtMgr As TextBox
    Friend WithEvents lblManager As Label
    Friend WithEvents txtVendor As TextBox
    Friend WithEvents lblVendor As Label
    Friend WithEvents cmdOpen As Button
    Friend WithEvents cmdDeletePO As Button
    Friend WithEvents cmdClose As Button
    Friend WithEvents dgvPO As DataGridView
End Class

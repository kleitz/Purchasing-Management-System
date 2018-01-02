<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPackages
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPackages))
        Me.lblDate = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtReciever = New System.Windows.Forms.TextBox()
        Me.lblRecieve = New System.Windows.Forms.Label()
        Me.txtSender = New System.Windows.Forms.TextBox()
        Me.lblShip = New System.Windows.Forms.Label()
        Me.txtTracking = New System.Windows.Forms.TextBox()
        Me.lblTrack = New System.Windows.Forms.Label()
        Me.lblCourier = New System.Windows.Forms.Label()
        Me.comboCourier = New System.Windows.Forms.ComboBox()
        Me.comboGorE = New System.Windows.Forms.ComboBox()
        Me.lblGorE = New System.Windows.Forms.Label()
        Me.comboType = New System.Windows.Forms.ComboBox()
        Me.lblType = New System.Windows.Forms.Label()
        Me.grpPackage = New System.Windows.Forms.GroupBox()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.grpPackageInfo = New System.Windows.Forms.GroupBox()
        Me.dgvShippingLog = New System.Windows.Forms.DataGridView()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.pbUPS = New System.Windows.Forms.PictureBox()
        Me.pbFEDEX = New System.Windows.Forms.PictureBox()
        Me.pbUSPS = New System.Windows.Forms.PictureBox()
        Me.grpPackage.SuspendLayout()
        Me.grpPackageInfo.SuspendLayout()
        CType(Me.dgvShippingLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbUPS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFEDEX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbUSPS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(14, 16)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 0
        Me.lblDate.Text = "Date:"
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(59, 13)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(231, 20)
        Me.txtDate.TabIndex = 1
        '
        'txtReciever
        '
        Me.txtReciever.Location = New System.Drawing.Point(11, 49)
        Me.txtReciever.Name = "txtReciever"
        Me.txtReciever.Size = New System.Drawing.Size(196, 20)
        Me.txtReciever.TabIndex = 3
        '
        'lblRecieve
        '
        Me.lblRecieve.AutoSize = True
        Me.lblRecieve.Location = New System.Drawing.Point(86, 32)
        Me.lblRecieve.Name = "lblRecieve"
        Me.lblRecieve.Size = New System.Drawing.Size(52, 13)
        Me.lblRecieve.TabIndex = 2
        Me.lblRecieve.Text = "Recipient"
        '
        'txtSender
        '
        Me.txtSender.Location = New System.Drawing.Point(212, 49)
        Me.txtSender.Name = "txtSender"
        Me.txtSender.Size = New System.Drawing.Size(196, 20)
        Me.txtSender.TabIndex = 5
        '
        'lblShip
        '
        Me.lblShip.AutoSize = True
        Me.lblShip.Location = New System.Drawing.Point(284, 32)
        Me.lblShip.Name = "lblShip"
        Me.lblShip.Size = New System.Drawing.Size(43, 13)
        Me.lblShip.TabIndex = 4
        Me.lblShip.Text = "Shipper"
        '
        'txtTracking
        '
        Me.txtTracking.Location = New System.Drawing.Point(413, 49)
        Me.txtTracking.Name = "txtTracking"
        Me.txtTracking.Size = New System.Drawing.Size(196, 20)
        Me.txtTracking.TabIndex = 7
        '
        'lblTrack
        '
        Me.lblTrack.AutoSize = True
        Me.lblTrack.Location = New System.Drawing.Point(461, 32)
        Me.lblTrack.Name = "lblTrack"
        Me.lblTrack.Size = New System.Drawing.Size(89, 13)
        Me.lblTrack.TabIndex = 6
        Me.lblTrack.Text = "Tracking Number"
        '
        'lblCourier
        '
        Me.lblCourier.AutoSize = True
        Me.lblCourier.Location = New System.Drawing.Point(14, 42)
        Me.lblCourier.Name = "lblCourier"
        Me.lblCourier.Size = New System.Drawing.Size(43, 13)
        Me.lblCourier.TabIndex = 8
        Me.lblCourier.Text = "Courier:"
        '
        'comboCourier
        '
        Me.comboCourier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboCourier.FormattingEnabled = True
        Me.comboCourier.Location = New System.Drawing.Point(59, 39)
        Me.comboCourier.Name = "comboCourier"
        Me.comboCourier.Size = New System.Drawing.Size(231, 21)
        Me.comboCourier.TabIndex = 9
        '
        'comboGorE
        '
        Me.comboGorE.FormattingEnabled = True
        Me.comboGorE.Location = New System.Drawing.Point(417, 20)
        Me.comboGorE.Name = "comboGorE"
        Me.comboGorE.Size = New System.Drawing.Size(226, 21)
        Me.comboGorE.TabIndex = 11
        '
        'lblGorE
        '
        Me.lblGorE.AutoSize = True
        Me.lblGorE.Location = New System.Drawing.Point(324, 24)
        Me.lblGorE.Name = "lblGorE"
        Me.lblGorE.Size = New System.Drawing.Size(89, 13)
        Me.lblGorE.TabIndex = 10
        Me.lblGorE.Text = "Guest/Employee:"
        '
        'comboType
        '
        Me.comboType.FormattingEnabled = True
        Me.comboType.Location = New System.Drawing.Point(88, 20)
        Me.comboType.Name = "comboType"
        Me.comboType.Size = New System.Drawing.Size(226, 21)
        Me.comboType.TabIndex = 13
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(6, 24)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(80, 13)
        Me.lblType.TabIndex = 12
        Me.lblType.Text = "Package Type:"
        '
        'grpPackage
        '
        Me.grpPackage.Controls.Add(Me.cmdClear)
        Me.grpPackage.Controls.Add(Me.cmdDelete)
        Me.grpPackage.Controls.Add(Me.cmdUpdate)
        Me.grpPackage.Controls.Add(Me.cmdSave)
        Me.grpPackage.Controls.Add(Me.grpPackageInfo)
        Me.grpPackage.Controls.Add(Me.lblType)
        Me.grpPackage.Controls.Add(Me.comboType)
        Me.grpPackage.Controls.Add(Me.lblGorE)
        Me.grpPackage.Controls.Add(Me.comboGorE)
        Me.grpPackage.Location = New System.Drawing.Point(17, 66)
        Me.grpPackage.Name = "grpPackage"
        Me.grpPackage.Size = New System.Drawing.Size(648, 167)
        Me.grpPackage.TabIndex = 14
        Me.grpPackage.TabStop = False
        Me.grpPackage.Text = "Enter Packages"
        '
        'cmdClear
        '
        Me.cmdClear.Location = New System.Drawing.Point(542, 125)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(100, 36)
        Me.cmdClear.TabIndex = 18
        Me.cmdClear.Text = "Clear Form"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(364, 125)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(100, 36)
        Me.cmdDelete.TabIndex = 17
        Me.cmdDelete.Text = "Delete Tracking Information"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Location = New System.Drawing.Point(186, 125)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(100, 36)
        Me.cmdUpdate.TabIndex = 16
        Me.cmdUpdate.Text = "Update Tracking Information"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(8, 125)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(100, 36)
        Me.cmdSave.TabIndex = 15
        Me.cmdSave.Text = "Save Tracking Information"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'grpPackageInfo
        '
        Me.grpPackageInfo.Controls.Add(Me.txtReciever)
        Me.grpPackageInfo.Controls.Add(Me.lblRecieve)
        Me.grpPackageInfo.Controls.Add(Me.lblShip)
        Me.grpPackageInfo.Controls.Add(Me.lblTrack)
        Me.grpPackageInfo.Controls.Add(Me.txtTracking)
        Me.grpPackageInfo.Controls.Add(Me.txtSender)
        Me.grpPackageInfo.Location = New System.Drawing.Point(8, 46)
        Me.grpPackageInfo.Name = "grpPackageInfo"
        Me.grpPackageInfo.Size = New System.Drawing.Size(634, 73)
        Me.grpPackageInfo.TabIndex = 14
        Me.grpPackageInfo.TabStop = False
        Me.grpPackageInfo.Text = "Package Information"
        '
        'dgvShippingLog
        '
        Me.dgvShippingLog.AllowUserToAddRows = False
        Me.dgvShippingLog.AllowUserToDeleteRows = False
        Me.dgvShippingLog.AllowUserToOrderColumns = True
        Me.dgvShippingLog.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvShippingLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvShippingLog.GridColor = System.Drawing.SystemColors.Window
        Me.dgvShippingLog.Location = New System.Drawing.Point(17, 239)
        Me.dgvShippingLog.Name = "dgvShippingLog"
        Me.dgvShippingLog.ReadOnly = True
        Me.dgvShippingLog.Size = New System.Drawing.Size(648, 338)
        Me.dgvShippingLog.TabIndex = 15
        '
        'cmdPrint
        '
        Me.cmdPrint.Location = New System.Drawing.Point(17, 583)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(105, 23)
        Me.cmdPrint.TabIndex = 16
        Me.cmdPrint.Text = "Print Shipping Log"
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(590, 583)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 17
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'pbUPS
        '
        Me.pbUPS.Image = CType(resources.GetObject("pbUPS.Image"), System.Drawing.Image)
        Me.pbUPS.Location = New System.Drawing.Point(491, 11)
        Me.pbUPS.Name = "pbUPS"
        Me.pbUPS.Size = New System.Drawing.Size(54, 54)
        Me.pbUPS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbUPS.TabIndex = 18
        Me.pbUPS.TabStop = False
        '
        'pbFEDEX
        '
        Me.pbFEDEX.Image = CType(resources.GetObject("pbFEDEX.Image"), System.Drawing.Image)
        Me.pbFEDEX.Location = New System.Drawing.Point(551, 11)
        Me.pbFEDEX.Name = "pbFEDEX"
        Me.pbFEDEX.Size = New System.Drawing.Size(54, 54)
        Me.pbFEDEX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbFEDEX.TabIndex = 19
        Me.pbFEDEX.TabStop = False
        '
        'pbUSPS
        '
        Me.pbUSPS.Image = CType(resources.GetObject("pbUSPS.Image"), System.Drawing.Image)
        Me.pbUSPS.Location = New System.Drawing.Point(611, 11)
        Me.pbUSPS.Name = "pbUSPS"
        Me.pbUSPS.Size = New System.Drawing.Size(54, 54)
        Me.pbUSPS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbUSPS.TabIndex = 20
        Me.pbUSPS.TabStop = False
        '
        'FrmPackages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 615)
        Me.Controls.Add(Me.pbUSPS)
        Me.Controls.Add(Me.pbFEDEX)
        Me.Controls.Add(Me.pbUPS)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.dgvShippingLog)
        Me.Controls.Add(Me.grpPackage)
        Me.Controls.Add(Me.comboCourier)
        Me.Controls.Add(Me.lblCourier)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.lblDate)
        Me.Name = "FrmPackages"
        Me.Text = "Packages"
        Me.grpPackage.ResumeLayout(False)
        Me.grpPackage.PerformLayout()
        Me.grpPackageInfo.ResumeLayout(False)
        Me.grpPackageInfo.PerformLayout()
        CType(Me.dgvShippingLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbUPS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFEDEX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbUSPS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDate As Label
    Friend WithEvents txtDate As TextBox
    Friend WithEvents txtReciever As TextBox
    Friend WithEvents lblRecieve As Label
    Friend WithEvents txtSender As TextBox
    Friend WithEvents lblShip As Label
    Friend WithEvents txtTracking As TextBox
    Friend WithEvents lblTrack As Label
    Friend WithEvents lblCourier As Label
    Friend WithEvents comboCourier As ComboBox
    Friend WithEvents comboGorE As ComboBox
    Friend WithEvents lblGorE As Label
    Friend WithEvents comboType As ComboBox
    Friend WithEvents lblType As Label
    Friend WithEvents grpPackage As GroupBox
    Friend WithEvents cmdClear As Button
    Friend WithEvents cmdDelete As Button
    Friend WithEvents cmdUpdate As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents grpPackageInfo As GroupBox
    Friend WithEvents dgvShippingLog As DataGridView
    Friend WithEvents cmdPrint As Button
    Friend WithEvents cmdClose As Button
    Friend WithEvents pbUPS As PictureBox
    Friend WithEvents pbFEDEX As PictureBox
    Friend WithEvents pbUSPS As PictureBox
End Class

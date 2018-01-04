<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSearchItems
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgvItems = New System.Windows.Forms.DataGridView()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.lblVendorItemNo = New System.Windows.Forms.Label()
        Me.txtVendIN = New System.Windows.Forms.TextBox()
        Me.txtSWSIN = New System.Windows.Forms.TextBox()
        Me.lblAgilisysItemNo = New System.Windows.Forms.Label()
        Me.txtPkg = New System.Windows.Forms.TextBox()
        Me.lblPackaging = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.lblVendor = New System.Windows.Forms.Label()
        Me.comboVendor = New System.Windows.Forms.ComboBox()
        Me.comboCat = New System.Windows.Forms.ComboBox()
        Me.lblCat = New System.Windows.Forms.Label()
        Me.comboUM = New System.Windows.Forms.ComboBox()
        Me.lblum = New System.Windows.Forms.Label()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblQnty = New System.Windows.Forms.Label()
        Me.txtQnty = New System.Windows.Forms.TextBox()
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvItems
        '
        Me.dgvItems.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItems.Location = New System.Drawing.Point(12, 139)
        Me.dgvItems.Name = "dgvItems"
        Me.dgvItems.Size = New System.Drawing.Size(1195, 285)
        Me.dgvItems.TabIndex = 0
        '
        'cmdSearch
        '
        Me.cmdSearch.Location = New System.Drawing.Point(1132, 9)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(75, 23)
        Me.cmdSearch.TabIndex = 1
        Me.cmdSearch.Text = "Search"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.Location = New System.Drawing.Point(1132, 43)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(75, 23)
        Me.cmdClear.TabIndex = 2
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(1132, 75)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 3
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(1132, 110)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 4
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'lblVendorItemNo
        '
        Me.lblVendorItemNo.AutoSize = True
        Me.lblVendorItemNo.Location = New System.Drawing.Point(13, 13)
        Me.lblVendorItemNo.Name = "lblVendorItemNo"
        Me.lblVendorItemNo.Size = New System.Drawing.Size(84, 13)
        Me.lblVendorItemNo.TabIndex = 5
        Me.lblVendorItemNo.Text = "Vendor Item No:"
        '
        'txtVendIN
        '
        Me.txtVendIN.Location = New System.Drawing.Point(103, 9)
        Me.txtVendIN.Name = "txtVendIN"
        Me.txtVendIN.Size = New System.Drawing.Size(246, 20)
        Me.txtVendIN.TabIndex = 6
        '
        'txtSWSIN
        '
        Me.txtSWSIN.Location = New System.Drawing.Point(103, 35)
        Me.txtSWSIN.Name = "txtSWSIN"
        Me.txtSWSIN.Size = New System.Drawing.Size(246, 20)
        Me.txtSWSIN.TabIndex = 8
        '
        'lblAgilisysItemNo
        '
        Me.lblAgilisysItemNo.AutoSize = True
        Me.lblAgilisysItemNo.Location = New System.Drawing.Point(13, 38)
        Me.lblAgilisysItemNo.Name = "lblAgilisysItemNo"
        Me.lblAgilisysItemNo.Size = New System.Drawing.Size(84, 13)
        Me.lblAgilisysItemNo.TabIndex = 7
        Me.lblAgilisysItemNo.Text = "Agilisys Item No:"
        '
        'txtPkg
        '
        Me.txtPkg.Location = New System.Drawing.Point(103, 87)
        Me.txtPkg.Name = "txtPkg"
        Me.txtPkg.Size = New System.Drawing.Size(246, 20)
        Me.txtPkg.TabIndex = 12
        '
        'lblPackaging
        '
        Me.lblPackaging.AutoSize = True
        Me.lblPackaging.Location = New System.Drawing.Point(36, 90)
        Me.lblPackaging.Name = "lblPackaging"
        Me.lblPackaging.Size = New System.Drawing.Size(61, 13)
        Me.lblPackaging.TabIndex = 11
        Me.lblPackaging.Text = "Packaging:"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(103, 61)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(246, 20)
        Me.txtPrice.TabIndex = 10
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(63, 64)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(34, 13)
        Me.lblPrice.TabIndex = 9
        Me.lblPrice.Text = "Price:"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(103, 113)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(568, 20)
        Me.txtDesc.TabIndex = 14
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Location = New System.Drawing.Point(11, 116)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(86, 13)
        Me.lblDesc.TabIndex = 13
        Me.lblDesc.Text = "Item Description:"
        '
        'lblVendor
        '
        Me.lblVendor.AutoSize = True
        Me.lblVendor.Location = New System.Drawing.Point(375, 14)
        Me.lblVendor.Name = "lblVendor"
        Me.lblVendor.Size = New System.Drawing.Size(44, 13)
        Me.lblVendor.TabIndex = 15
        Me.lblVendor.Text = "Vendor:"
        '
        'comboVendor
        '
        Me.comboVendor.FormattingEnabled = True
        Me.comboVendor.Location = New System.Drawing.Point(425, 9)
        Me.comboVendor.Name = "comboVendor"
        Me.comboVendor.Size = New System.Drawing.Size(246, 21)
        Me.comboVendor.TabIndex = 16
        '
        'comboCat
        '
        Me.comboCat.FormattingEnabled = True
        Me.comboCat.Location = New System.Drawing.Point(425, 34)
        Me.comboCat.Name = "comboCat"
        Me.comboCat.Size = New System.Drawing.Size(246, 21)
        Me.comboCat.TabIndex = 18
        '
        'lblCat
        '
        Me.lblCat.AutoSize = True
        Me.lblCat.Location = New System.Drawing.Point(367, 42)
        Me.lblCat.Name = "lblCat"
        Me.lblCat.Size = New System.Drawing.Size(52, 13)
        Me.lblCat.TabIndex = 17
        Me.lblCat.Text = "Category:"
        '
        'comboUM
        '
        Me.comboUM.FormattingEnabled = True
        Me.comboUM.Location = New System.Drawing.Point(425, 61)
        Me.comboUM.Name = "comboUM"
        Me.comboUM.Size = New System.Drawing.Size(246, 21)
        Me.comboUM.TabIndex = 20
        '
        'lblum
        '
        Me.lblum.AutoSize = True
        Me.lblum.Location = New System.Drawing.Point(387, 69)
        Me.lblum.Name = "lblum"
        Me.lblum.Size = New System.Drawing.Size(32, 13)
        Me.lblum.TabIndex = 19
        Me.lblum.Text = "U/M:"
        '
        'txtBarcode
        '
        Me.txtBarcode.Location = New System.Drawing.Point(776, 64)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(246, 20)
        Me.txtBarcode.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(875, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Scan Barcode"
        '
        'lblQnty
        '
        Me.lblQnty.AutoSize = True
        Me.lblQnty.Location = New System.Drawing.Point(367, 90)
        Me.lblQnty.Name = "lblQnty"
        Me.lblQnty.Size = New System.Drawing.Size(52, 13)
        Me.lblQnty.TabIndex = 23
        Me.lblQnty.Text = "Quantity: "
        Me.lblQnty.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtQnty
        '
        Me.txtQnty.Location = New System.Drawing.Point(425, 88)
        Me.txtQnty.Name = "txtQnty"
        Me.txtQnty.Size = New System.Drawing.Size(246, 20)
        Me.txtQnty.TabIndex = 24
        '
        'FrmSearchItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1219, 436)
        Me.Controls.Add(Me.txtQnty)
        Me.Controls.Add(Me.lblQnty)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.comboUM)
        Me.Controls.Add(Me.lblum)
        Me.Controls.Add(Me.comboCat)
        Me.Controls.Add(Me.lblCat)
        Me.Controls.Add(Me.comboVendor)
        Me.Controls.Add(Me.lblVendor)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.txtPkg)
        Me.Controls.Add(Me.lblPackaging)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.txtSWSIN)
        Me.Controls.Add(Me.lblAgilisysItemNo)
        Me.Controls.Add(Me.txtVendIN)
        Me.Controls.Add(Me.lblVendorItemNo)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.dgvItems)
        Me.Name = "FrmSearchItems"
        Me.Text = "Search/Update Items"
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvItems As DataGridView
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents cmdClear As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents lblVendorItemNo As Label
    Friend WithEvents txtVendIN As TextBox
    Friend WithEvents txtSWSIN As TextBox
    Friend WithEvents lblAgilisysItemNo As Label
    Friend WithEvents txtPkg As TextBox
    Friend WithEvents lblPackaging As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents lblDesc As Label
    Friend WithEvents lblVendor As Label
    Friend WithEvents comboVendor As ComboBox
    Friend WithEvents comboCat As ComboBox
    Friend WithEvents lblCat As Label
    Friend WithEvents comboUM As ComboBox
    Friend WithEvents lblum As Label
    Friend WithEvents txtBarcode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblQnty As Label
    Friend WithEvents txtQnty As TextBox
End Class

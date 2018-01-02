<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPOEdit
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
        Me.lblGLCode = New System.Windows.Forms.Label()
        Me.txtGLCode = New System.Windows.Forms.TextBox()
        Me.txtItemDesc = New System.Windows.Forms.TextBox()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.dgvPOItems = New System.Windows.Forms.DataGridView()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvPOItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblGLCode
        '
        Me.lblGLCode.AutoSize = True
        Me.lblGLCode.Location = New System.Drawing.Point(59, 15)
        Me.lblGLCode.Name = "lblGLCode"
        Me.lblGLCode.Size = New System.Drawing.Size(49, 13)
        Me.lblGLCode.TabIndex = 0
        Me.lblGLCode.Text = "GL Code"
        '
        'txtGLCode
        '
        Me.txtGLCode.Location = New System.Drawing.Point(6, 31)
        Me.txtGLCode.Name = "txtGLCode"
        Me.txtGLCode.Size = New System.Drawing.Size(137, 20)
        Me.txtGLCode.TabIndex = 1
        '
        'txtItemDesc
        '
        Me.txtItemDesc.Location = New System.Drawing.Point(241, 31)
        Me.txtItemDesc.Name = "txtItemDesc"
        Me.txtItemDesc.Size = New System.Drawing.Size(241, 20)
        Me.txtItemDesc.TabIndex = 3
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Location = New System.Drawing.Point(314, 16)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(83, 13)
        Me.lblDesc.TabIndex = 2
        Me.lblDesc.Text = "Item Description"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(580, 31)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(137, 20)
        Me.txtPrice.TabIndex = 5
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(644, 15)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(31, 13)
        Me.lblPrice.TabIndex = 4
        Me.lblPrice.Text = "Price"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblID)
        Me.GroupBox1.Controls.Add(Me.cmdDelete)
        Me.GroupBox1.Controls.Add(Me.cmdUpdate)
        Me.GroupBox1.Controls.Add(Me.cmdSave)
        Me.GroupBox1.Controls.Add(Me.txtGLCode)
        Me.GroupBox1.Controls.Add(Me.txtPrice)
        Me.GroupBox1.Controls.Add(Me.lblGLCode)
        Me.GroupBox1.Controls.Add(Me.lblPrice)
        Me.GroupBox1.Controls.Add(Me.lblDesc)
        Me.GroupBox1.Controls.Add(Me.txtItemDesc)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(729, 124)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(6, 89)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(24, 13)
        Me.lblID.TabIndex = 9
        Me.lblID.Text = "ID: "
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(638, 82)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(79, 26)
        Me.cmdDelete.TabIndex = 8
        Me.cmdDelete.Text = "Delete Entry"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Location = New System.Drawing.Point(553, 82)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(79, 26)
        Me.cmdUpdate.TabIndex = 7
        Me.cmdUpdate.Text = "Update Entry"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(468, 82)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(79, 26)
        Me.cmdSave.TabIndex = 6
        Me.cmdSave.Text = "Save Entry"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'dgvPOItems
        '
        Me.dgvPOItems.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvPOItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPOItems.Location = New System.Drawing.Point(12, 143)
        Me.dgvPOItems.MultiSelect = False
        Me.dgvPOItems.Name = "dgvPOItems"
        Me.dgvPOItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPOItems.Size = New System.Drawing.Size(729, 358)
        Me.dgvPOItems.TabIndex = 7
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.Location = New System.Drawing.Point(9, 512)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(56, 13)
        Me.lblSubTotal.TabIndex = 10
        Me.lblSubTotal.Text = "Sub Total:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(287, 512)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(66, 13)
        Me.lblTotal.TabIndex = 11
        Me.lblTotal.Text = "Grand Total:"
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(666, 507)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 10
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(152, 512)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(28, 13)
        Me.lblTax.TabIndex = 12
        Me.lblTax.Text = "Tax:"
        '
        'FrmPOEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 542)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblSubTotal)
        Me.Controls.Add(Me.dgvPOItems)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmPOEdit"
        Me.Text = "Purchase Order:"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvPOItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblGLCode As Label
    Friend WithEvents txtGLCode As TextBox
    Friend WithEvents txtItemDesc As TextBox
    Friend WithEvents lblDesc As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblID As Label
    Friend WithEvents cmdDelete As Button
    Friend WithEvents cmdUpdate As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents dgvPOItems As DataGridView
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents cmdClose As Button
    Friend WithEvents lblTax As Label
End Class

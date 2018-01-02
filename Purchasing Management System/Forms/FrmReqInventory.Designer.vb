<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReqInventory
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
        Me.comboDept = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtScanner = New System.Windows.Forms.TextBox()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.dgvRequisition = New System.Windows.Forms.DataGridView()
        Me.VendIN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.agilIN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qtyRemain = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.dgvRequisition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Department:"
        '
        'comboDept
        '
        Me.comboDept.FormattingEnabled = True
        Me.comboDept.Location = New System.Drawing.Point(80, 12)
        Me.comboDept.Name = "comboDept"
        Me.comboDept.Size = New System.Drawing.Size(191, 21)
        Me.comboDept.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Scan:"
        '
        'txtScanner
        '
        Me.txtScanner.Location = New System.Drawing.Point(80, 39)
        Me.txtScanner.Name = "txtScanner"
        Me.txtScanner.Size = New System.Drawing.Size(191, 20)
        Me.txtScanner.TabIndex = 3
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(12, 65)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(127, 32)
        Me.cmdDelete.TabIndex = 4
        Me.cmdDelete.Text = "Delete Selection"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(146, 65)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(127, 32)
        Me.cmdSave.TabIndex = 5
        Me.cmdSave.Text = "Print Requisition"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'dgvRequisition
        '
        Me.dgvRequisition.AllowUserToAddRows = False
        Me.dgvRequisition.AllowUserToDeleteRows = False
        Me.dgvRequisition.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvRequisition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRequisition.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VendIN, Me.agilIN, Me.Desc, Me.qty, Me.qtyRemain, Me.price})
        Me.dgvRequisition.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.dgvRequisition.Location = New System.Drawing.Point(279, 12)
        Me.dgvRequisition.Name = "dgvRequisition"
        Me.dgvRequisition.Size = New System.Drawing.Size(864, 376)
        Me.dgvRequisition.TabIndex = 6
        '
        'VendIN
        '
        Me.VendIN.HeaderText = "Vendor Item No"
        Me.VendIN.Name = "VendIN"
        '
        'agilIN
        '
        Me.agilIN.HeaderText = "SWS Item No"
        Me.agilIN.Name = "agilIN"
        '
        'Desc
        '
        Me.Desc.HeaderText = "Item Description"
        Me.Desc.Name = "Desc"
        '
        'qty
        '
        Me.qty.HeaderText = "Quantity Requisitioned"
        Me.qty.Name = "qty"
        '
        'qtyRemain
        '
        Me.qtyRemain.HeaderText = "Quantity In Inventory"
        Me.qtyRemain.Name = "qtyRemain"
        '
        'price
        '
        Me.price.HeaderText = "System Price"
        Me.price.Name = "price"
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.Location = New System.Drawing.Point(9, 34)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(56, 13)
        Me.lblSubTotal.TabIndex = 7
        Me.lblSubTotal.Text = "Sub Total:"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(9, 68)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(28, 13)
        Me.lblTax.TabIndex = 8
        Me.lblTax.Text = "Tax:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(9, 102)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(34, 13)
        Me.lblTotal.TabIndex = 9
        Me.lblTotal.Text = "Total:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Controls.Add(Me.lblSubTotal)
        Me.GroupBox1.Controls.Add(Me.lblTax)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 249)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(261, 139)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'FrmReqInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1155, 401)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvRequisition)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.txtScanner)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.comboDept)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmReqInventory"
        Me.Text = "Requisition Inventory"
        CType(Me.dgvRequisition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents comboDept As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtScanner As TextBox
    Friend WithEvents cmdDelete As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents dgvRequisition As DataGridView
    Friend WithEvents VendIN As DataGridViewTextBoxColumn
    Friend WithEvents agilIN As DataGridViewTextBoxColumn
    Friend WithEvents Desc As DataGridViewTextBoxColumn
    Friend WithEvents qty As DataGridViewTextBoxColumn
    Friend WithEvents qtyRemain As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class

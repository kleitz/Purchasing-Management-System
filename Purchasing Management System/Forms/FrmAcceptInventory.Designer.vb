<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAcceptInventory
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
        Me.dgvReciever = New System.Windows.Forms.DataGridView()
        Me.clmVendorID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmAgilisysitemNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmSysPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblScanner = New System.Windows.Forms.Label()
        Me.txtScanner = New System.Windows.Forms.TextBox()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        CType(Me.dgvReciever, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvReciever
        '
        Me.dgvReciever.AllowUserToAddRows = False
        Me.dgvReciever.AllowUserToDeleteRows = False
        Me.dgvReciever.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvReciever.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReciever.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmVendorID, Me.clmAgilisysitemNo, Me.clmDescription, Me.clmQuantity, Me.clmSysPrice})
        Me.dgvReciever.Location = New System.Drawing.Point(12, 103)
        Me.dgvReciever.Name = "dgvReciever"
        Me.dgvReciever.ReadOnly = True
        Me.dgvReciever.Size = New System.Drawing.Size(591, 225)
        Me.dgvReciever.TabIndex = 0
        '
        'clmVendorID
        '
        Me.clmVendorID.HeaderText = "Vendor Item No"
        Me.clmVendorID.Name = "clmVendorID"
        Me.clmVendorID.ReadOnly = True
        '
        'clmAgilisysitemNo
        '
        Me.clmAgilisysitemNo.HeaderText = "SWS Item No"
        Me.clmAgilisysitemNo.Name = "clmAgilisysitemNo"
        Me.clmAgilisysitemNo.ReadOnly = True
        '
        'clmDescription
        '
        Me.clmDescription.HeaderText = "Description"
        Me.clmDescription.Name = "clmDescription"
        Me.clmDescription.ReadOnly = True
        '
        'clmQuantity
        '
        Me.clmQuantity.HeaderText = "Quantity"
        Me.clmQuantity.Name = "clmQuantity"
        Me.clmQuantity.ReadOnly = True
        '
        'clmSysPrice
        '
        Me.clmSysPrice.HeaderText = "System Price"
        Me.clmSysPrice.Name = "clmSysPrice"
        Me.clmSysPrice.ReadOnly = True
        '
        'lblScanner
        '
        Me.lblScanner.AutoSize = True
        Me.lblScanner.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScanner.Location = New System.Drawing.Point(17, 19)
        Me.lblScanner.Name = "lblScanner"
        Me.lblScanner.Size = New System.Drawing.Size(97, 16)
        Me.lblScanner.TabIndex = 1
        Me.lblScanner.Text = "Scan Barcode:"
        '
        'txtScanner
        '
        Me.txtScanner.Location = New System.Drawing.Point(120, 18)
        Me.txtScanner.Name = "txtScanner"
        Me.txtScanner.Size = New System.Drawing.Size(483, 20)
        Me.txtScanner.TabIndex = 2
        '
        'cmdDelete
        '
        Me.cmdDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Location = New System.Drawing.Point(20, 61)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(123, 23)
        Me.cmdDelete.TabIndex = 3
        Me.cmdDelete.Text = "Delete Selection"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Location = New System.Drawing.Point(473, 61)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(130, 23)
        Me.cmdPrint.TabIndex = 4
        Me.cmdPrint.Text = "Print Reciever"
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'FrmAcceptInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 340)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.txtScanner)
        Me.Controls.Add(Me.lblScanner)
        Me.Controls.Add(Me.dgvReciever)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmAcceptInventory"
        Me.Text = "Accept Inventory"
        CType(Me.dgvReciever, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvReciever As DataGridView
    Friend WithEvents lblScanner As Label
    Friend WithEvents txtScanner As TextBox
    Friend WithEvents cmdDelete As Button
    Friend WithEvents cmdPrint As Button
    Friend WithEvents clmVendorID As DataGridViewTextBoxColumn
    Friend WithEvents clmAgilisysitemNo As DataGridViewTextBoxColumn
    Friend WithEvents clmDescription As DataGridViewTextBoxColumn
    Friend WithEvents clmQuantity As DataGridViewTextBoxColumn
    Friend WithEvents clmSysPrice As DataGridViewTextBoxColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDepartments
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtDivID = New System.Windows.Forms.TextBox()
        Me.txtDeptID = New System.Windows.Forms.TextBox()
        Me.lblDatID = New System.Windows.Forms.Label()
        Me.cmdInsert = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.dgvDepartments = New System.Windows.Forms.DataGridView()
        CType(Me.dgvDepartments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Department Name: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Divison ID: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Department ID: "
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(116, 42)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(233, 20)
        Me.txtName.TabIndex = 3
        '
        'txtDivID
        '
        Me.txtDivID.Location = New System.Drawing.Point(116, 68)
        Me.txtDivID.Name = "txtDivID"
        Me.txtDivID.Size = New System.Drawing.Size(233, 20)
        Me.txtDivID.TabIndex = 4
        '
        'txtDeptID
        '
        Me.txtDeptID.Location = New System.Drawing.Point(116, 94)
        Me.txtDeptID.Name = "txtDeptID"
        Me.txtDeptID.Size = New System.Drawing.Size(233, 20)
        Me.txtDeptID.TabIndex = 5
        '
        'lblDatID
        '
        Me.lblDatID.AutoSize = True
        Me.lblDatID.Location = New System.Drawing.Point(37, 20)
        Me.lblDatID.Name = "lblDatID"
        Me.lblDatID.Size = New System.Drawing.Size(73, 13)
        Me.lblDatID.TabIndex = 6
        Me.lblDatID.Text = "Database ID: "
        '
        'cmdInsert
        '
        Me.cmdInsert.Location = New System.Drawing.Point(373, 20)
        Me.cmdInsert.Name = "cmdInsert"
        Me.cmdInsert.Size = New System.Drawing.Size(95, 23)
        Me.cmdInsert.TabIndex = 7
        Me.cmdInsert.Text = "Add Department"
        Me.cmdInsert.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.Location = New System.Drawing.Point(373, 55)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(95, 23)
        Me.cmdClear.TabIndex = 8
        Me.cmdClear.Text = "Clear Form"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(373, 90)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(95, 23)
        Me.cmdClose.TabIndex = 9
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'dgvDepartments
        '
        Me.dgvDepartments.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDepartments.Location = New System.Drawing.Point(14, 126)
        Me.dgvDepartments.Name = "dgvDepartments"
        Me.dgvDepartments.Size = New System.Drawing.Size(454, 329)
        Me.dgvDepartments.TabIndex = 10
        '
        'FrmDepartments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 467)
        Me.Controls.Add(Me.dgvDepartments)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmdInsert)
        Me.Controls.Add(Me.lblDatID)
        Me.Controls.Add(Me.txtDeptID)
        Me.Controls.Add(Me.txtDivID)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmDepartments"
        Me.Text = "Departments"
        CType(Me.dgvDepartments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtDivID As TextBox
    Friend WithEvents txtDeptID As TextBox
    Friend WithEvents lblDatID As Label
    Friend WithEvents cmdInsert As Button
    Friend WithEvents cmdClear As Button
    Friend WithEvents cmdClose As Button
    Friend WithEvents dgvDepartments As DataGridView
End Class

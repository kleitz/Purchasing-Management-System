<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchUpdateItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcceptOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnterRequisitionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchUpdateItemsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseOrdersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PackagesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseOrdersToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PackagesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SearchUpdateItemsToolStripMenuItem, Me.PurchaseOrdersToolStripMenuItem, Me.PackagesToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.SettingsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(960, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'SearchUpdateItemsToolStripMenuItem
        '
        Me.SearchUpdateItemsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcceptOrderToolStripMenuItem, Me.EnterRequisitionToolStripMenuItem, Me.SearchUpdateItemsToolStripMenuItem1})
        Me.SearchUpdateItemsToolStripMenuItem.Name = "SearchUpdateItemsToolStripMenuItem"
        Me.SearchUpdateItemsToolStripMenuItem.Size = New System.Drawing.Size(103, 20)
        Me.SearchUpdateItemsToolStripMenuItem.Text = "Inventory Menu"
        '
        'AcceptOrderToolStripMenuItem
        '
        Me.AcceptOrderToolStripMenuItem.Name = "AcceptOrderToolStripMenuItem"
        Me.AcceptOrderToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.AcceptOrderToolStripMenuItem.Text = "Accept Order"
        '
        'EnterRequisitionToolStripMenuItem
        '
        Me.EnterRequisitionToolStripMenuItem.Name = "EnterRequisitionToolStripMenuItem"
        Me.EnterRequisitionToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.EnterRequisitionToolStripMenuItem.Text = "Enter Requisition"
        '
        'SearchUpdateItemsToolStripMenuItem1
        '
        Me.SearchUpdateItemsToolStripMenuItem1.Name = "SearchUpdateItemsToolStripMenuItem1"
        Me.SearchUpdateItemsToolStripMenuItem1.Size = New System.Drawing.Size(184, 22)
        Me.SearchUpdateItemsToolStripMenuItem1.Text = "Search/Update Items"
        '
        'PurchaseOrdersToolStripMenuItem
        '
        Me.PurchaseOrdersToolStripMenuItem.Name = "PurchaseOrdersToolStripMenuItem"
        Me.PurchaseOrdersToolStripMenuItem.Size = New System.Drawing.Size(105, 20)
        Me.PurchaseOrdersToolStripMenuItem.Text = "Purchase Orders"
        '
        'PackagesToolStripMenuItem
        '
        Me.PackagesToolStripMenuItem.Name = "PackagesToolStripMenuItem"
        Me.PackagesToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.PackagesToolStripMenuItem.Text = "Packages"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PurchaseOrdersToolStripMenuItem1, Me.PackagesToolStripMenuItem1})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'PurchaseOrdersToolStripMenuItem1
        '
        Me.PurchaseOrdersToolStripMenuItem1.Name = "PurchaseOrdersToolStripMenuItem1"
        Me.PurchaseOrdersToolStripMenuItem1.Size = New System.Drawing.Size(160, 22)
        Me.PurchaseOrdersToolStripMenuItem1.Text = "Purchase Orders"
        '
        'PackagesToolStripMenuItem1
        '
        Me.PackagesToolStripMenuItem1.Name = "PackagesToolStripMenuItem1"
        Me.PackagesToolStripMenuItem1.Size = New System.Drawing.Size(160, 22)
        Me.PackagesToolStripMenuItem1.Text = "Packages"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 533)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purchasing Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SearchUpdateItemsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PurchaseOrdersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PackagesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PurchaseOrdersToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PackagesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AcceptOrderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnterRequisitionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchUpdateItemsToolStripMenuItem1 As ToolStripMenuItem
End Class

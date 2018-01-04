Public Class FrmMain

    Private Sub PurchaseOrdersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurchaseOrdersToolStripMenuItem.Click
        If Application.OpenForms().OfType(Of FrmPOs).Any <> True Then
            Dim frmPO As New FrmPOs With {.MdiParent = Me}
            frmPO.Show()
        End If
    End Sub

    Private Sub PackagesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PackagesToolStripMenuItem.Click
        If Application.OpenForms().OfType(Of FrmPackages).Any <> True Then
            Dim frmPkg As New FrmPackages With {.MdiParent = Me}
            frmPkg.Show()
        End If
    End Sub

    Private Sub AcceptOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcceptOrderToolStripMenuItem.Click
        If Application.OpenForms().OfType(Of FrmAcceptInventory).Any <> True Then
            Dim frmAccept As New FrmAcceptInventory With {.MdiParent = Me}
            frmAccept.Show()
        End If
    End Sub

    Private Sub SearchUpdateItemsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SearchUpdateItemsToolStripMenuItem1.Click
        If Application.OpenForms().OfType(Of FrmSearchItems).Any <> True Then
            Dim frmSrch As New FrmSearchItems With {.MdiParent = Me}
            frmSrch.Show()
        End If
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        GC.Collect()
        Me.Close()
    End Sub

    Private Sub PurchaseOrdersToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PurchaseOrdersToolStripMenuItem1.Click
        If Application.OpenForms().OfType(Of FrmReports).Any <> True Then
            Dim frmReport As New FrmReports With {.MdiParent = Me}
            frmReport.Show()
        End If
    End Sub

    Private Sub PackagesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PackagesToolStripMenuItem1.Click
        MsgBox("Coming soon!")
    End Sub

    Private Sub EnterRequisitionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnterRequisitionToolStripMenuItem.Click
        If Application.OpenForms().OfType(Of FrmReqInventory).Any <> True Then
            Dim frmReq As New FrmReqInventory With {.MdiParent = Me}
            frmReq.Show()
        End If
    End Sub

    Private Sub MainSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainSettingsToolStripMenuItem.Click
        If Application.OpenForms().OfType(Of FrmSettings).Any <> True Then
            Dim frmSet As New FrmSettings With {.MdiParent = Me}
            frmSet.Show()
        End If
    End Sub

    Private Sub DepartmentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartmentsToolStripMenuItem.Click
        If Application.OpenForms().OfType(Of FrmDepartments).Any <> True Then
            Dim frmDept As New FrmDepartments With {.MdiParent = Me}
            frmDept.Show()
        End If
    End Sub

    Private Sub VendorsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VendorsToolStripMenuItem.Click
        MsgBox("Coming Soon!")
    End Sub
End Class

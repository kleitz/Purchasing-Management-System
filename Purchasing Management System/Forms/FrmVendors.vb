Public Class FrmVendors
    Dim vend As New Vendors
    Private Sub FrmVendors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillData()
    End Sub

    Private Sub FillData()
        Try
            With dgvVendors
                .AutoGenerateColumns = True
                .DataSource = vend.Data
                .Refresh()
                .AutoResizeColumns()
            End With
        Catch ex As Exception
            Dim handleError As New ErrorHandler
            With handleError
                .ErrorNumber = Err.Number
                .ErrorDescription = Err.Description
                .ExceptionMessage = ex.Message
                .LogError()
            End With
        End Try
    End Sub

    Private Sub DgvVendors_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVendors.CellContentClick
        On Error Resume Next
        Dim xRow As DataGridViewRow = Me.dgvVendors.CurrentRow
        Me.txtName.Text = CType(xRow.Cells(1).Value, String)
        Me.txtAcctNum.Text = CType(xRow.Cells(2).Value, String)
        Me.txtPhone.Text = CType(xRow.Cells(3).Value, String)
        Me.txtEmail.Text = xRow.Cells(4).Value.ToString
        Me.txtAddress.Text = xRow.Cells(5).Value.ToString
        Me.txtCity.Text = xRow.Cells(6).Value.ToString
        Me.txtState.Text = xRow.Cells(7).Value.ToString
        Me.txtZip.Text = xRow.Cells(8).Value.ToString
        On Error GoTo 0
    End Sub

    Private Sub CmdInsert_Click(sender As Object, e As EventArgs) Handles cmdInsert.Click
        Try
            With vend
                .VendorName = Me.txtName.Text
                .AccountNumber = Me.txtAcctNum.Text
                .PhoneNumber = Me.txtPhone.Text
                .Email = Me.txtEmail.Text
                .StreetAddress = Me.txtAddress.Text
                .City = Me.txtCity.Text
                .State = Me.txtState.Text
                .ZipCode = Me.txtZip.Text
                If .VendorID > 0 Then
                    .UpdateVendor()
                Else
                    .InsertVendor()
                End If
            End With
        Catch ex As Exception
            Dim handleError As New ErrorHandler
            With handleError
                .ErrorNumber = Err.Number
                .ErrorDescription = Err.Description
                .ExceptionMessage = ex.Message
                .LogError()
            End With
        End Try
    End Sub

    Private Sub TxtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        With vend
            If .SearchVendors(Me.txtName.Text) Then
                Me.lblDatID.Text = "Vendor ID: " & .VendorID
                Me.txtName.Text = .VendorName
                Me.txtAcctNum.Text = .AccountNumber
                Me.txtPhone.Text = .PhoneNumber
                Me.txtEmail.Text = .Email
                Me.txtAddress.Text = .StreetAddress
                Me.txtCity.Text = .City
                Me.txtState.Text = .State
                Me.txtZip.Text = .ZipCode
                Me.cmdInsert.Text = "Update Vendor"
            Else
                Me.lblDatID.Text = "Database ID: "
                .VendorID = 0
                Me.cmdInsert.Text = "Add New Vendor"
            End If
        End With
    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        Me.lblDatID.Text = "Database ID: "
        Me.txtName.Text = ""
        Me.txtAcctNum.Text = ""
        Me.txtPhone.Text = ""
        Me.txtEmail.Text = ""
        Me.txtAddress.Text = ""
        Me.txtCity.Text = ""
        Me.txtState.Text = ""
        Me.txtZip.Text = ""
        vend.VendorID = 0
    End Sub
End Class
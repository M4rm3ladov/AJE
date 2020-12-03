Public Class frmCustomers
    Dim customer As New clsCustomer
    Dim _id As Integer
    Dim _code, _gname, _mi, _suffix, _surname As String
    Dim _credit_limit, _balance As String

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        frmMain.KeyPreview = True
        If frmMain.lbl_Type.Text = "Manager" Then
            frmMain.btn_Profile.Enabled = False
            frmMain.btn_Logout.Enabled = True
            frmMain.btn_Reports.Enabled = True
            frmMain.btn_Inventory.Enabled = True
            frmMain.btn_Pos.Enabled = True
        End If
        Me.Close()
    End Sub

    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        With frmCustomerEntry
            .btn_Update.Enabled = False
            .btn_Save.Enabled = True
            .tb_Code.ReadOnly = False
            .tb_Gname.ReadOnly = False
            .tb_Mi.ReadOnly = False
            .tb_Surname.ReadOnly = False
            .tb_Suffix.ReadOnly = False
            .ShowDialog()
        End With
    End Sub

    Private Sub frmCustomers_Load(sender As Object, e As EventArgs) Handles Me.Load
        dgCustomers.ColumnHeadersHeight = 50
        cbo_Category.SelectedIndex = 1
        customer.loadRecord()
    End Sub
    Private Sub dgCustomers_SelectionChanged(sender As Object, e As EventArgs) Handles dgCustomers.SelectionChanged
        Dim i As Integer = dgCustomers.CurrentRow.Index
        _id = dgCustomers.Item(0, i).Value
        _code = dgCustomers.Item(2, i).Value
        _gname = dgCustomers.Item(3, i).Value
        _mi = dgCustomers.Item(4, i).Value
        _surname = dgCustomers.Item(5, i).Value
        _suffix = dgCustomers.Item(6, i).Value
        _credit_limit = dgCustomers.Item(7, i).Value
        _balance = dgCustomers.Item(8, i).Value
        lbl_Balance.Text = _balance
    End Sub

    Private Sub dgCustomers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCustomers.CellContentClick
        Dim colName As String = dgCustomers.Columns(e.ColumnIndex).Name
        If colName = "col_Edit" Then
            With frmCustomerEntry
                .lbl_Id.Text = _id
                .tb_Code.Text = _code
                .tb_Gname.Text = _gname
                .tb_Mi.Text = _mi
                .tb_Surname.Text = _surname
                .tb_Suffix.Text = _suffix
                .tb_credit_Limit.Text = _credit_limit
                .tb_Balance.Text = _balance
                .tb_Code.ReadOnly = True
                .tb_Gname.ReadOnly = True
                .tb_Mi.ReadOnly = True
                .tb_Surname.ReadOnly = True
                .tb_Suffix.ReadOnly = True
                .btn_Save.Enabled = False
                .btn_Update.Enabled = True
                .ShowDialog()
            End With

        ElseIf colName = "col_Delete" Then
            Dim result = MsgBox("Are you sure you want to delete this record?", vbYesNo + vbQuestion)
            If result = vbYes Then
                customer.SetId(_id)
                If customer.checkCustomerExists = False Then
                    customer.delete()
                    MsgBox("Record has been successfully deleted.", vbInformation)
                    customer.loadRecord()
                Else
                    MsgBox("Record already in use and therefore can not be deleted.", vbInformation)
                End If
            End If

        End If
    End Sub
    Private Sub tb_Search_TextChanged(sender As Object, e As EventArgs) Handles tb_Search.TextChanged
        If Trim(tb_Search.Text) <> "" Then
            Select Case cbo_Category.Text
                Case "Code"
                    customer.SetcustomerSearch(Trim(tb_Search.Text))
                    customer.searchCustomer("SELECT customer.customer_id, customer_code, customer_gname, customer_mi, customer_surname, customer_suffix, credit_limit, balance FROM customer " &
                                           "INNER JOIN customer_details ON customer_details.customer_id = customer.customer_id WHERE customer_code LIKE @0")
                Case "Name"
                    customer.SetCustomerSearch(Trim(tb_Search.Text))
                    customer.searchCustomer("SELECT customer.customer_id, customer_code, customer_gname, customer_mi, customer_surname, customer_suffix, credit_limit, balance FROM customer " &
                                           "INNER JOIN customer_details ON customer_details.customer_id = customer.customer_id WHERE customer_gname LIKE @0 OR customer_surname LIKE @0")
            End Select
        Else
            customer.loadRecord()
        End If
    End Sub

End Class
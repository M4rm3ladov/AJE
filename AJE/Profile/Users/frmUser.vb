Public Class frmUser
    Dim user As New clsUser
    Dim cashier As New clsCashier
    Dim manager As New clsManager
    Dim _id, _is_active
    Dim _branch, _gName, _mi, _fName, _suffix, _username, _usertype As String
    Private Sub btn_add_Manager_Click(sender As Object, e As EventArgs) Handles btn_add_Manager.Click
        With frmManagerEntry
            .lbl_search_User.Visible = True
            .tb_Username.ReadOnly = False
            .lbl_change_Pass.Visible = False
            .tb_Password.Visible = True
            .cb_show_Password.Visible = True
            .btn_Save.Show()
            .btn_Update.Hide()
            .ShowDialog()
        End With
    End Sub

    Private Sub btn_add_Cashier_Click(sender As Object, e As EventArgs) Handles btn_add_Cashier.Click
        With frmCashierEntry
            .lbl_search_User.Visible = True
            .tb_Username.ReadOnly = False
            .lbl_change_Pass.Visible = False
            .tb_Password.Visible = True
            .cb_show_Password.Visible = True
            .btn_Save.Show()
            .btn_Update.Hide()
            .ShowDialog()
        End With
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        With frmUserEntry
            .tb_Gname.ReadOnly = False
            .tb_Mi.ReadOnly = False
            .tb_Surname.ReadOnly = False
            .tb_Suffix.ReadOnly = False
            .tb_Username.ReadOnly = False
            .lbl_change_Pass.Visible = False
            .tb_Password.Visible = True
            .cb_show_Password.Visible = True
            .cbo_Usertype.Enabled = True
            .cbo_Branch.Items.Clear()
            .btn_Update.Hide()
            .btn_Save.Show()
        End With
        user.loadBranch()
        frmUserEntry.ShowDialog()
    End Sub
    Private Sub frmUser_Load(sender As Object, e As EventArgs) Handles Me.Load
        DataGridView3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        DataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        tc_Users.SelectedTab = tp_user_Profile
        user.loadRecord()
        cashier.loadRecord()
        manager.loadRecord()
        cbo_filter_Cashier.SelectedIndex = 1
        cbo_filter_manager.SelectedIndex = 1
        cbo_Filter.SelectedIndex = 1
    End Sub
    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        Dim i As Integer = DataGridView1.CurrentRow.Index
        _id = DataGridView1.Item(0, i).Value
        _branch = DataGridView1.Item(2, i).Value
        _gName = DataGridView1.Item(3, i).Value
        _mi = DataGridView1.Item(4, i).Value
        _fName = DataGridView1.Item(5, i).Value
        _suffix = DataGridView1.Item(6, i).Value
        _username = DataGridView1.Item(7, i).Value
        _usertype = DataGridView1.Item(8, i).Value
        _is_active = DataGridView1.Item(9, i).Value
        If _is_active = False Then
            _is_active = "No"
        ElseIf _is_active = True Then
            _is_active = "Yes"
        End If
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        frmUserEntry.cbo_Branch.Items.Clear()
        user.loadBranch()
        Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colName = "col_Edit" Then
            With frmUserEntry
                .lbl_Id.Text = _id
                .tb_Gname.Text = _gName
                .tb_Mi.Text = _mi
                .tb_Surname.Text = _fName
                .tb_Suffix.Text = _suffix
                .tb_Username.Text = _username
                .cbo_Branch.Text = _branch
                .cbo_Usertype.Text = _usertype
                .cbo_Active.Text = _is_active
                .tb_Gname.ReadOnly = True
                .tb_Mi.ReadOnly = True
                .tb_Surname.ReadOnly = True
                .tb_Suffix.ReadOnly = True
                .tb_Username.ReadOnly = True
                .lbl_change_Pass.Visible = True
                .tb_Password.Visible = False
                .cb_show_Password.Visible = False
                .cbo_Usertype.Enabled = False
                .btn_Save.Hide()
                .btn_Update.Show()
                .tb_Password.Focus()
                .ShowDialog()
            End With

        ElseIf colName = "col_Delete" Then
            Dim result = MsgBox("are you sure you want to delete this record?", vbYesNo + vbQuestion)
            If result = vbYes Then
                user.Id = _id
                If user.checkUserExists = False Then
                    user.delete()
                    MsgBox("record has been successfully deleted.", vbInformation)
                    user.loadRecord()
                Else
                    MsgBox("record already in use and therefore can not be deleted.", vbInformation)
                End If
            End If

        End If
    End Sub
    Private Sub DataGridView2_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView2.SelectionChanged
        Dim i As Integer = DataGridView2.CurrentRow.Index
        _id = DataGridView2.Item(0, i).Value
        _gName = DataGridView2.Item(2, i).Value
        _mi = DataGridView2.Item(3, i).Value
        _fName = DataGridView2.Item(4, i).Value
        _suffix = DataGridView2.Item(5, i).Value
        _username = DataGridView2.Item(6, i).Value
        _is_active = DataGridView2.Item(7, i).Value
        If _is_active = False Then
            _is_active = "No"
        ElseIf _is_active = True Then
            _is_active = "Yes"
        End If
    End Sub
    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Dim colName As String = DataGridView2.Columns(e.ColumnIndex).Name
        If colName = "col_edit_Cashier" Then
            With frmCashierEntry
                .lbl_Id.Text = _id
                .tb_Name.Text = _gName & " " & _mi & " " & _fName & " " & _suffix
                .tb_Username.Text = _username
                .cbo_Active.Text = _is_active
                .lbl_search_User.Visible = False
                .tb_Username.ReadOnly = True
                .lbl_change_Pass.Visible = True
                .cb_show_Password.Visible = False
                .tb_Password.Visible = False
                .btn_Save.Hide()
                .btn_Update.Show()
                .tb_Password.Focus()
                .ShowDialog()
            End With
        ElseIf colName = "col_delete_Cashier" Then
            Dim result = MsgBox("Are you sure you want to delete this record?", vbYesNo + vbQuestion)
            If result = vbYes Then
                cashier.Id = _id
                If cashier.checkCashierExists = False Then
                    cashier.delete()
                    MsgBox("Record has been successfully deleted.", vbInformation)
                    cashier.loadRecord()
                Else
                    MsgBox("Record already in use and therefore can not be deleted.", vbInformation)
                End If
            End If

        End If
    End Sub
    Private Sub DataGridView3_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView3.SelectionChanged
        Dim i As Integer = DataGridView3.CurrentRow.Index
        _id = DataGridView3.Item(0, i).Value
        _gName = DataGridView3.Item(2, i).Value
        _mi = DataGridView3.Item(3, i).Value
        _fName = DataGridView3.Item(4, i).Value
        _suffix = DataGridView3.Item(5, i).Value
        _username = DataGridView3.Item(6, i).Value
        _is_active = DataGridView3.Item(7, i).Value
        If _is_active = False Then
            _is_active = "No"
        ElseIf _is_active = True Then
            _is_active = "Yes"
        End If
    End Sub
    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
        Dim colName As String = DataGridView3.Columns(e.ColumnIndex).Name
        If colName = "col_edit_Manager" Then
            With frmManagerEntry
                .lbl_Id.Text = _id
                .tb_Name.Text = _gName & " " & _mi & " " & _fName & " " & _suffix
                .tb_Username.Text = _username
                .cbo_Active.Text = _is_active
                .lbl_search_User.Visible = False
                .tb_Username.ReadOnly = True
                .lbl_change_Pass.Visible = True
                .tb_Password.Visible = False
                .cb_show_Password.Visible = False
                .btn_Save.Hide()
                .btn_Update.Show()
                .tb_Password.Focus()
                .ShowDialog()
            End With
        ElseIf colName = "col_Delete_Manager" Then
            Dim result = MsgBox("Are you sure you want to delete this record?", vbYesNo + vbQuestion)
            If result = vbYes Then
                manager.Id = _id
                If manager.checkManagerExists = False Then
                    manager.delete()
                    MsgBox("Record has been successfully deleted.", vbInformation)
                    manager.loadRecord()
                Else
                    MsgBox("Record already in use and therefore can not be deleted.", vbInformation)
                End If
            End If

        End If
    End Sub
    Private Sub tb_Search_TextChanged(sender As Object, e As EventArgs) Handles tb_Search.TextChanged
        If Trim(tb_Search.Text) <> "" Then
            Select Case cbo_Filter.Text
                Case "Username"
                    user.UserSearch = Trim(tb_Search.Text)
                    user.searchUser("SELECT users.user_id, branch.branch_address, user_surname, user_gname, user_mi, user_suffix, CAST(username AS CHAR)AS username, user_type, is_active FROM users " &
                            "INNER JOIN user_details ON users.user_id = user_details.user_id " &
                            "INNER JOIN branch ON branch.branch_id = users.branch_id WHERE users.username LIKE @0")
                Case "Name"
                    user.UserSearch = Trim(tb_Search.Text)
                    user.searchUser("SELECT users.user_id, branch.branch_address, user_surname, user_gname, user_mi, user_suffix, CAST(username AS CHAR)AS username, user_type, is_active FROM users " &
                            "INNER JOIN user_details ON users.user_id = user_details.user_id " &
                            "INNER JOIN branch ON branch.branch_id = users.branch_id WHERE user_details.user_gname LIKE @0 OR user_details.user_surname LIKE @0")
                Case "Branch"
                    user.UserSearch = Trim(tb_Search.Text)
                    user.searchUser("SELECT users.user_id, branch.branch_address, user_surname, user_gname, user_mi, user_suffix, CAST(username AS CHAR)AS username, user_type, is_active FROM users " &
                            "INNER JOIN user_details ON users.user_id = user_details.user_id " &
                            "INNER JOIN branch ON branch.branch_id = users.branch_id WHERE branch_address LIKE @0")

            End Select
        Else
            user.loadRecord()
        End If
    End Sub
    Private Sub tb_search_Cashier_TextChanged(sender As Object, e As EventArgs) Handles tb_search_Cashier.TextChanged
        If Trim(tb_search_Cashier.Text) <> "" Then
            Select Case cbo_filter_Cashier.Text
                Case "Username"
                    cashier.CashierSearch = Trim(tb_search_Cashier.Text)
                    cashier.searchUser("SELECT cashier.user_id, user_surname, user_gname, user_mi, user_suffix, CAST(cashier.username AS CHAR) AS _c_username, cashier.is_active FROM cashier " &
                            "INNER JOIN user_details ON cashier.user_id = user_details.user_id " &
                            "INNER JOIN users ON users.user_id = cashier.user_id WHERE cashier.username LIKE @0")
                Case "Name"
                    cashier.CashierSearch = Trim(tb_search_Cashier.Text)
                    cashier.searchUser("SELECT cashier.user_id, user_surname, user_gname, user_mi, user_suffix, CAST(cashier.username AS CHAR) AS _c_username, cashier.is_active FROM cashier " &
                            "INNER JOIN user_details ON cashier.user_id = user_details.user_id " &
                            "INNER JOIN users ON users.user_id = cashier.user_id WHERE user_details.user_gname LIKE @0 OR user_details.user_surname LIKE @0")
            End Select
        Else
            cashier.loadRecord()
        End If
    End Sub
    Private Sub tb_search_Manager_TextChanged(sender As Object, e As EventArgs) Handles tb_search_Manager.TextChanged
        If Trim(tb_search_Manager.Text) <> "" Then
            Select Case cbo_filter_manager.Text
                Case "Username"
                    manager.ManagerSearch = Trim(tb_search_Manager.Text)
                    manager.searchUser("SELECT manager.user_id, user_surname, user_gname, user_mi, user_suffix, CAST(manager.username AS CHAR) AS _m_username, manager.is_active FROM manager " &
                            "INNER JOIN user_details ON manager.user_id = user_details.user_id " &
                            "INNER JOIN users ON users.user_id = manager.user_id WHERE manager.username LIKE @0")
                Case "Name"
                    manager.ManagerSearch = Trim(tb_search_Manager.Text)
                    manager.searchUser("SELECT manager.user_id, user_surname, user_gname, user_mi, user_suffix, CAST(manager.username AS CHAR) AS _m_username, manager.is_active FROM manager " &
                            "INNER JOIN user_details ON manager.user_id = user_details.user_id " &
                            "INNER JOIN users ON users.user_id = manager.user_id WHERE user_details.user_gname LIKE @0 OR user_details.user_surname LIKE @0")
            End Select
        Else
            manager.loadRecord()
        End If
    End Sub
    Private Sub tb_Search_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_Search.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "',- .abcdefghijklmnopqrstuvwxyz1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub tb_Search_Manager_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_search_Manager.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "',- .abcdefghijklmnopqrstuvwxyz1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
End Class
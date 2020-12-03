Public Class frmUserList
    Dim userList As New clsUserList
    Dim _id, _gname, _mi, _fName, _is_active, _suffix
    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub
    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        Dim i As Integer = DataGridView1.CurrentRow.Index
        _id = DataGridView1.Item(0, i).Value
        _gname = DataGridView1.Item(3, i).Value
        _mi = DataGridView1.Item(4, i).Value
        _fName = DataGridView1.Item(5, i).Value
        _suffix = DataGridView1.Item(6, i).Value
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name
        userList.CashierId = _id
        userList.ManagerId = _id
        If _EntryType = "Cashier" Then
            If userList.checkDuplicateCashier() = True Then
                MsgBox("User already has an existing cashier account.", vbExclamation)
                Exit Sub
            End If
            If colName = "col_Select" Then
                With frmCashierEntry
                    .tb_Name.Text = _gname & " " & _mi & " " & " " & _fName & " " & _suffix
                    .lbl_Id.Text = _id
                End With
                Me.tb_Search.Clear()
                Me.Close()
            End If
        ElseIf _EntryType = "Manager" Then
            If userList.checkUserTypeManager = True Then
                MsgBox("Only users of type 'manager' can be selected.", vbExclamation)
                Exit Sub
            End If
            If userList.checkDuplicateManager() = True Then
                MsgBox("User already has an existing manager account.", vbExclamation)
                Exit Sub
            End If
            If colName = "col_Select" Then
                With frmManagerEntry
                    .tb_Name.Text = _gname & " " & _mi & " " & " " & _fName & " " & _suffix
                    .lbl_Id.Text = _id
                End With
                Me.tb_Search.Clear()
                Me.Close()
            End If
        End If
    End Sub
    Private Sub tb_Search_TextChanged(sender As Object, e As EventArgs) Handles tb_Search.TextChanged
        If Trim(tb_Search.Text) <> "" Then
            Select Case cbo_Filter.Text
                Case "Username"
                    userList.UserSearch = Trim(tb_Search.Text)
                    userList.searchUser("SELECT users.user_id, branch.branch_address, user_surname, user_gname, user_mi, user_suffix, CAST(username AS CHAR) AS username, user_type, is_active FROM users " &
                            "INNER JOIN user_details ON users.user_id = user_details.user_id " &
                            "INNER JOIN branch ON branch.branch_id = users.branch_id WHERE users.username LIKE @0")
                Case "Name"
                    userList.UserSearch = Trim(tb_Search.Text)
                    userList.searchUser("SELECT users.user_id, branch.branch_address, user_surname, user_gname, user_mi, user_suffix, CAST(username AS CHAR) AS username, user_type, is_active FROM users " &
                            "INNER JOIN user_details ON users.user_id = user_details.user_id " &
                            "INNER JOIN branch ON branch.branch_id = users.branch_id WHERE user_details.user_gname LIKE @0 OR user_details.user_surname LIKE @0")
                Case "Branch"
                    userList.UserSearch = Trim(tb_Search.Text)
                    userList.searchUser("SELECT users.user_id, branch.branch_address, user_surname, user_gname, user_mi, user_suffix, CAST(username AS CHAR) AS username, user_type, is_active FROM users " &
                            "INNER JOIN user_details ON users.user_id = user_details.user_id " &
                            "INNER JOIN branch ON branch.branch_id = users.branch_id WHERE branch_address LIKE @0")
            End Select
        Else
            userList.loadRecord()
        End If
    End Sub
    Private Sub frmUserList_Load(sender As Object, e As EventArgs) Handles Me.Load
        cbo_Filter.Text = "Name"
        userList.loadRecord()
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
End Class
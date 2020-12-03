Public Class frmChangePass
    Dim user As New clsUser
    Dim cashier As New clsCashier
    Dim manager As New clsManager
    Dim encryption As New clsEncryption
    Dim password, salt, hashedAndSalt

    Private Sub cb_show_Pass_CheckedChanged(sender As Object, e As EventArgs) Handles cb_show_Pass.CheckedChanged
        If cb_show_Pass.Checked = True Then
            tb_new_Password.PasswordChar = ""
            tb_re_Password.PasswordChar = ""
        ElseIf cb_show_Pass.Checked = False Then
            tb_new_Password.PasswordChar = "*"
            tb_re_Password.PasswordChar = "*"
        End If
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        If tb_new_Password.Text.Length < 8 Then
            MsgBox("Password must be 8 or more characters long.", vbExclamation)
            Exit Sub
        End If
        If frmUserEntry.tb_Username.Text.Contains(tb_new_Password.Text) Then
            MsgBox("Password and Username must not be the same.", vbExclamation)
            Exit Sub
        End If
        If tb_new_Password.Text = vbNullString Or tb_re_Password.Text = vbNullString Then
            MsgBox("Please fill in the field(s) before saving.", vbExclamation)
            Exit Sub
        End If
        If String.Compare(tb_new_Password.Text, tb_re_Password.Text) <> 0 Then
            MsgBox("Please make sure the passwords match.")
            Exit Sub
        End If

        If lbl_type.Text = 1 Then
            password = encryption.hashString(tb_new_Password.Text & frmUserEntry.tb_Username.Text)
            salt = encryption.generateSalt
            hashedAndSalt = encryption.hashString(String.Format("{0},{1}", password, salt))

            user.Username = frmUserEntry.tb_Username.Text
            user.Password = hashedAndSalt
            user.Salt = salt
            If user.changePass = False Then
                Exit Sub
            End If
        ElseIf lbl_type.Text = 2 Then
            password = encryption.hashString(tb_new_Password.Text & frmCashierEntry.tb_Username.Text)
            salt = encryption.generateSalt
            hashedAndSalt = encryption.hashString(String.Format("{0},{1}", password, salt))

            cashier.Username = frmCashierEntry.tb_Username.Text
            cashier.Password = hashedAndSalt
            cashier.Salt = salt
            If cashier.changePass = False Then
                Exit Sub
            End If
        ElseIf lbl_type.Text = 3 Then
            password = encryption.hashString(tb_new_Password.Text & frmManagerEntry.tb_Username.Text)
            salt = encryption.generateSalt
            hashedAndSalt = encryption.hashString(String.Format("{0},{1}", password, salt))

            manager.Username = frmManagerEntry.tb_Username.Text
            manager.Password = hashedAndSalt
            manager.Salt = salt
            If manager.changePass = False Then
                Exit Sub
            End If
        End If
        MsgBox("Password has been successfully updated.", vbInformation)
        tb_re_Password.Clear()
        tb_new_Password.Clear()
        Me.Close()

    End Sub
End Class
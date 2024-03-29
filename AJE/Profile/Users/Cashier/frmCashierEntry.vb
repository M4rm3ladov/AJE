﻿Public Class frmCashierEntry
    Dim cashier As New clsCashier
    Dim encryption As New clsEncryption
    Dim login As New clsLogin
    Dim password, hashedAndSalt, salt
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles _
    Panel1.MouseDown, Label3.MouseDown ' Add more handles here (Example: PictureBox1.MouseDown)

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles _
    Panel1.MouseMove, Label3.MouseDown ' Add more handles here (Example: PictureBox1.MouseMove)

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
    Panel1.MouseUp, Label3.MouseDown ' Add more handles here (Example: PictureBox1.MouseUp)

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub
    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        If countEmpty() > 0 Then
            MsgBox("Please fill in the field(s) before saving.", vbExclamation)
            Exit Sub
        End If
        'username validation
        For Each a As Char In tb_Username.Text.ToLower 'checks if username is letters, no. or underscores
            If checkCharUsername(a) = True Then
                MsgBox("Username can only contain letters (a-z), numbers (0-9), and underscores (_).", vbExclamation)
                Exit Sub
            End If
        Next
        If tb_Username.Text.Length < 6 Then '6 to 30 char
            MsgBox("Username must be 6 and 30 characters long.", vbExclamation)
            Exit Sub
        End If
        'password validation
        If tb_Password.Text.Length < 8 Then
            MsgBox("Password must be 8 or more characters long.", vbExclamation)
            Exit Sub
        End If
        If tb_Username.Text.Contains(tb_Password.Text) Then
            MsgBox("Password and Username must not be the same.", vbExclamation)
            Exit Sub
        End If
        Try
            cashier.Username = tb_Username.Text
            Dim result = MsgBox("Are you sure you want to save this record?", vbYesNo + vbQuestion)
            If cashier.checkCashierDuplicate = True Then
                MsgBox("Username is already existing.", vbInformation)
                Exit Sub
            End If
            If result = vbYes Then
                password = encryption.hashString(tb_Password.Text & tb_Username.Text)
                salt = encryption.generateSalt
                hashedAndSalt = encryption.hashString(String.Format("{0},{1}", password, salt))

                cashier.Id = Me.lbl_Id.Text
                cashier.Username = Me.tb_Username.Text '
                cashier.Password = hashedAndSalt
                cashier.Salt = salt

                If cbo_Active.Text = "Yes" Then
                    cashier.Active = 1
                ElseIf cbo_Active.Text = "No" Then
                    cashier.Active = 0
                End If

                If cashier.save = True Then
                    MsgBox("Record has been successfully saved.", vbInformation)
                    clearControls()
                    frmUser.tb_search_Cashier.Text = vbNullString
                    cashier.loadRecord()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btn_Update_Click(sender As Object, e As EventArgs) Handles btn_Update.Click
        Try
            Dim result = MsgBox("Are you sure you want to update this record?", vbYesNo + vbQuestion)
            If result = vbYes Then
                If cbo_Active.Text = "Yes" Then
                    cashier.Active = 1
                ElseIf cbo_Active.Text = "No" Then
                    cashier.Active = 0
                End If

                If cashier.edit = True Then
                    MsgBox("Record has been successfully updated.", vbInformation)
                    clearControls()
                    frmUser.tb_search_Cashier.Text = vbNullString
                    cashier.loadRecord()
                End If

                MsgBox("In order for changes to be applied, this account needs to log out.", vbOKOnly + vbInformation)
                Me.Close()
                frmUser.Close()

                frmMain.lbl_Name.Text = vbNullString
                frmMain.lbl_Type.Text = vbNullString
                login.SetUsername(frmMain.lbl_Username.Text)
                frmMain.lbl_Username.Text = vbNullString
                frmMain.lbl_branch_Id.Text = vbNullString
                login.setUserLogin(0)
                frmMain.Close()
                frmLogin.ShowDialog()

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Function countEmpty()
        Dim count = 0
        If Trim(tb_Name.Text) = vbNullString Then
            count += 1
        End If
        For Each cntrl As Control In GroupBox2.Controls
            If TypeOf cntrl Is TextBox Then
                If Trim(cntrl.Text) = vbNullString Then
                    count += 1
                End If
            End If
            If TypeOf cntrl Is ComboBox Then
                If Trim(cntrl.Text) = vbNullString Then
                    count += 1
                End If
            End If
        Next
        Return count
    End Function
    Private Sub clearControls()
        With Me
            .tb_Name.Text = vbNullString
            .tb_Username.Text = vbNullString
            .tb_Password.Text = vbNullString
            .cbo_Active.Text = vbNullString
            .cb_show_Password.Checked = False
            .lbl_Id.Text = vbNullString
        End With
    End Sub
    Private Sub cb_show_Password_CheckedChanged(sender As Object, e As EventArgs) Handles cb_show_Password.CheckedChanged
        If cb_show_Password.Checked = True Then
            tb_Password.PasswordChar = ""
        ElseIf cb_show_Password.Checked = False Then
            tb_Password.PasswordChar = "*"
        End If
    End Sub
    Private Function checkCharUsername(ch As Char) As Boolean
        Dim allowedChars As String = "_abcdefghijklmnopqrstuvwxyz1234567890"
        For Each b As Char In allowedChars
            If ch = b Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub lbl_search_User_Click(sender As Object, e As EventArgs) Handles lbl_search_User.Click
        _EntryType = "Cashier"
        frmUserList.ShowDialog()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        clearControls()
        Me.Close()
    End Sub

    Private Sub lbl_search_User_MouseHover(sender As Object, e As EventArgs) Handles lbl_search_User.MouseHover
        lbl_search_User.ForeColor = Color.Blue
    End Sub

    Private Sub lbl_search_User_MouseLeave(sender As Object, e As EventArgs) Handles lbl_search_User.MouseLeave
        lbl_search_User.ForeColor = Color.Black
    End Sub

    Private Sub lbl_change_Pass_Click(sender As Object, e As EventArgs) Handles lbl_change_Pass.Click
        frmChangePass.lbl_type.Text = 2
        frmChangePass.ShowDialog()
    End Sub

    Private Sub lbl_change_Pass_MouseHover(sender As Object, e As EventArgs) Handles lbl_change_Pass.MouseHover
        lbl_change_Pass.ForeColor = Color.Blue
    End Sub

    Private Sub lbl_change_Pass_MouseLeave(sender As Object, e As EventArgs) Handles lbl_change_Pass.MouseLeave
        lbl_change_Pass.ForeColor = Color.Black
    End Sub
End Class
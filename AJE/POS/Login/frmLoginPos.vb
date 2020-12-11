Public Class frmLoginPos
    Dim loginPos As New clsLoginPos
    Dim authkey As Integer
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
    Private Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click
        loginPos.SetUsername(tb_username.Text)
        loginPos.SetPassword(tb_Password.Text)
        authkey = loginPos.authLogin()
        If authkey = 0 Then
            MsgBox("Username or Password incorrect.", vbCritical)
            Exit Sub
        ElseIf authkey = 1 Then
            MsgBox("Cashier is currently inactive.", vbCritical)
            Exit Sub
        ElseIf authkey = 2 Then
            MsgBox("Cashier is currently signed-in.", vbCritical)
            Exit Sub
        ElseIf authkey = 3 Then
            loginPos.setUserLogin(1)
            frmPos.lbl_user_Id.Text = loginPos.setUserId()
            frmPos.lbl_Name.Text = loginPos.setName(CInt(loginPos.setUserCashierId))
            frmPos.lbl_Username.Text = tb_username.Text
            frmPos.lbl_branch_Id.Text = loginPos.setBranchId()
            tb_username.Clear()
            tb_Password.Clear()
            MsgBox("User logged in successfully.", vbInformation)
            frmPos.Show()
            Me.Hide()
            frmMain.Hide()
            frmBalance.ShowDialog()

        End If
    End Sub
    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        frmMain.KeyPreview = True
        tb_Password.Clear()
        tb_username.Clear()
        Me.Close()
    End Sub
    Private Sub tb_username_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_username.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub tb_Password_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_Password.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

End Class
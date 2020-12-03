Public Class frmLogin
    Dim login As New clsLogin
    Dim authKey As Integer

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MinimizeBox = False
        MaximizeBox = False
    End Sub

    Private Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click
        login.SetUsername(tb_username.Text) 'authkey: 1 if inactive, 2 signed-in, 3 if valid
        login.SetPassword(tb_Password.Text)
        authKey = login.authLogin()
        If authKey = 0 Then
            MsgBox("Username or Password incorrect.", vbCritical)
            Exit Sub
        ElseIf authKey = 1 Then
            MsgBox("User is currently inactive.", vbCritical)
            Exit Sub
        ElseIf authKey = 2 Then
            MsgBox("User is currently signed-in.", vbCritical)
            Exit Sub
        ElseIf authKey = 3 Then
            login.setUserLogin(1)
            frmMain.lbl_Name.Text = login.setName(CInt(login.setUserId))
            frmMain.lbl_branch_Id.Text = login.setBranchId()
            frmMain.lbl_branch_Address.Text = login.setBranchAddress
            frmMain.lbl_Username.Text = tb_username.Text
            frmMain.lbl_Type.Text = login.setUserType()
            tb_username.Clear()
            tb_Password.Clear()
            MsgBox("User logged in successfully.", vbInformation)
            tb_username.Focus()
            frmMain.Show()
            Me.Hide()
        End If
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

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Application.Exit()
    End Sub
End Class
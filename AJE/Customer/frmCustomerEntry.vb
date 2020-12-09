Public Class frmCustomerEntry
    Dim strCurrency As String = ""
    Dim acceptableKey As Boolean = False
    Dim customer As New clsCustomer
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles _
    Panel1.MouseDown ' Add more handles here (Example: PictureBox1.MouseDown)

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles _
    Panel1.MouseMove ' Add more handles here (Example: PictureBox1.MouseMove)

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
    Panel1.MouseUp ' Add more handles here (Example: PictureBox1.MouseUp)

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        clearControls()
        Me.Close()
    End Sub
    Private Sub tb_credit_Limit_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_credit_Limit.KeyDown
        If (e.KeyCode >= Keys.D0 And e.KeyCode <= Keys.D9) OrElse (e.KeyCode >= Keys.NumPad0 And e.KeyCode <= Keys.NumPad9) OrElse e.KeyCode = Keys.Back Then
            acceptableKey = True
        Else
            acceptableKey = False
        End If
    End Sub

    Private Sub tb_credit_Limit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_credit_Limit.KeyPress
        If tb_credit_Limit.Text.Length > 7 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = Char.IsNumber(e.KeyChar) Or Not Char.IsNumber(e.KeyChar)
                Exit Sub
            End If
        End If
        ' Check for the flag being set in the KeyDown event.
        If acceptableKey = False Then
            ' Stop the character from being entered into the control since it is non-numerical.
            e.Handled = True
            Return
        Else
            If e.KeyChar = Convert.ToChar(Keys.Back) Then
                If strCurrency.Length > 0 Then
                    strCurrency = strCurrency.Substring(0, strCurrency.Length - 1)
                End If
            Else
                strCurrency = strCurrency & e.KeyChar
            End If

            If strCurrency.Length = 0 Then
                tb_credit_Limit.Text = ""
            ElseIf strCurrency.Length = 1 Then
                tb_credit_Limit.Text = "0.0" & strCurrency
            ElseIf strCurrency.Length = 2 Then
                tb_credit_Limit.Text = "0." & strCurrency
            ElseIf strCurrency.Length > 2 Then
                tb_credit_Limit.Text = strCurrency.Substring(0, strCurrency.Length - 2) & "." & strCurrency.Substring(strCurrency.Length - 2)
            End If
            tb_credit_Limit.Select(tb_credit_Limit.Text.Length, 0)

        End If
        e.Handled = True
    End Sub

    Private Sub tb_credit_Limit_Leave(sender As Object, e As EventArgs) Handles tb_credit_Limit.Leave
        strCurrency = ""
        acceptableKey = False
    End Sub
    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        If countEmpty() = True Then
            MsgBox("Please fill in the field(s) before saving.", vbExclamation)
            Exit Sub
        End If
        Try
            customer.SetCode(Trim(tb_Code.Text))
            customer.SetGName(Trim(tb_Gname.Text))
            customer.SetMi(Trim(tb_Mi.Text))
            customer.SetSurname(Trim(tb_Surname.Text))
            customer.SetSuffix(Trim(tb_Suffix.Text))
            customer.SetCreditLimit(Trim(tb_credit_Limit.Text))

            Dim result = MsgBox("Are you sure you want to save this record?", vbYesNo + vbQuestion)
            If customer.checkCustomerDuplicate = True Then
                MsgBox("Customer code is already existing.", vbInformation)
                Exit Sub
            End If

            If result = vbYes Then
                If customer.save = True Then
                    MsgBox("Record has been successfully saved.", vbInformation)
                    clearControls()
                    frmCustomers.tb_Search.Text = vbNullString
                    customer.loadRecord()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btn_Update_Click(sender As Object, e As EventArgs) Handles btn_Update.Click
        If countEmpty() = True Then
            MsgBox("Please fill in the field(s) before saving.", vbExclamation)
            Exit Sub
        End If
        Try
            customer.SetCreditLimit(Trim(tb_credit_Limit.Text))
            customer.SetId(CInt(lbl_Id.Text))
            Dim result = MsgBox("Are you sure you want to update this record?", vbYesNo + vbQuestion)

            If result = vbYes Then
                If Val(tb_Balance.Text) > Val(tb_credit_Limit.Text) Then
                    MsgBox("Credit limit should be greater than the existing balance", vbExclamation)
                    Exit Sub
                End If
                If customer.edit = True Then
                    MsgBox("Record has been successfully updated.", vbInformation)
                    clearControls()
                    frmCustomers.tb_Search.Text = vbNullString
                    customer.loadRecord()
                End If
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub clearControls()
        For Each cntrl As Control In Me.Controls
            If TypeOf cntrl Is TextBox Then
                cntrl.Text = vbNullString
            End If
        Next
        tb_Balance.Text = "0.00"
        lbl_Id.Text = ""
    End Sub
    Private Function countEmpty()
        If tb_Code.Text = vbNullString Then
            tb_Code.Focus()
            Return True
        ElseIf tb_Gname.Text = vbNullString Then
            tb_Gname.Focus()
            Return True
        ElseIf tb_Surname.Text = vbNullString Then
            tb_Surname.Focus()
            Return True
        ElseIf tb_credit_Limit.Text = vbNullString Then
            tb_credit_Limit.Focus()
            Return True
        End If
        Return False
    End Function

    Private Sub frmCustomerEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MinimizeBox = False
        MaximizeBox = False
    End Sub

End Class
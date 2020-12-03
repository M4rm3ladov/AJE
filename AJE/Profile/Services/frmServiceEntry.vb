Public Class frmServiceEntry
    Dim strCurrency As String = ""
    Dim acceptableKey As Boolean = False
    Dim service As New clsServices
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        clearControls()
        Me.Close()
    End Sub
    Private Sub tb_fee_A_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_fee_A.KeyDown
        If (e.KeyCode >= Keys.D0 And e.KeyCode <= Keys.D9) OrElse (e.KeyCode >= Keys.NumPad0 And e.KeyCode <= Keys.NumPad9) OrElse e.KeyCode = Keys.Back Then
            acceptableKey = True
        Else
            acceptableKey = False
        End If
    End Sub

    Private Sub tb_fee_A_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_fee_A.KeyPress
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
                tb_fee_A.Text = ""
            ElseIf strCurrency.Length = 1 Then
                tb_fee_A.Text = "0.0" & strCurrency
            ElseIf strCurrency.Length = 2 Then
                tb_fee_A.Text = "0." & strCurrency
            ElseIf strCurrency.Length > 2 Then
                tb_fee_A.Text = strCurrency.Substring(0, strCurrency.Length - 2) & "." & strCurrency.Substring(strCurrency.Length - 2)
            End If
            tb_fee_A.Select(tb_fee_A.Text.Length, 0)

        End If
        e.Handled = True
    End Sub
    Private Sub tb_fee_B_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_fee_B.KeyDown

        If (e.KeyCode >= Keys.D0 And e.KeyCode <= Keys.D9) OrElse (e.KeyCode >= Keys.NumPad0 And e.KeyCode <= Keys.NumPad9) OrElse e.KeyCode = Keys.Back Then
            acceptableKey = True
        Else
            acceptableKey = False
        End If
    End Sub
    Private Sub tb_fee_B_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_fee_B.KeyPress
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
                tb_fee_B.Text = ""
            ElseIf strCurrency.Length = 1 Then
                tb_fee_B.Text = "0.0" & strCurrency
            ElseIf strCurrency.Length = 2 Then
                tb_fee_B.Text = "0." & strCurrency
            ElseIf strCurrency.Length > 2 Then
                tb_fee_B.Text = strCurrency.Substring(0, strCurrency.Length - 2) & "." & strCurrency.Substring(strCurrency.Length - 2)
            End If
            tb_fee_B.Select(tb_fee_B.Text.Length, 0)

        End If
        e.Handled = True
    End Sub
    Private Sub tb_fee_A_Leave(sender As Object, e As EventArgs) Handles tb_fee_A.Leave
        strCurrency = ""
        acceptableKey = False
    End Sub

    Private Sub tb_fee_B_Leave(sender As Object, e As EventArgs) Handles tb_fee_B.Leave
        strCurrency = ""
        acceptableKey = False
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        If countEmpty() = True Then
            MsgBox("Please fill in the field(s) before saving.", vbExclamation)
            Exit Sub
        End If
        If Convert.ToDecimal(tb_fee_A.Text) <= Convert.ToDecimal(tb_fee_B.Text) Then
            MsgBox("Fee A should be Greater than fee B.", vbExclamation)
            Exit Sub
        End If
        Try
            service.SetCode(Trim(tb_service_Code.Text))
            service.SetDesc(Trim(tb_Desc.Text))
            service.SetFeeA(Trim(tb_fee_A.Text))
            service.SetFeeB(Trim(tb_fee_B.Text))

            Dim result = MsgBox("Are you sure you want to save this record?", vbYesNo + vbQuestion)
            If service.checkServiceDuplicate = True Then
                MsgBox("Service is already existing.", vbInformation)
                Exit Sub
            End If

            If result = vbYes Then
                If service.save = True Then
                    MsgBox("Record has been successfully saved.", vbInformation)
                    clearControls()
                    frmServices.tb_Search.Text = vbNullString
                    service.loadRecord()
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
        If Convert.ToDecimal(tb_fee_A.Text) <= Convert.ToDecimal(tb_fee_B.Text) Then
            MsgBox("Fee A should be Greater than fee B.", vbExclamation)
            Exit Sub
        End If
        Try
            service.SetCode(tb_service_Code.Text)
            service.SetDesc(Trim(tb_Desc.Text))
            service.SetFeeA(Trim(tb_fee_A.Text))
            service.SetFeeB(Trim(tb_fee_B.Text))

            Dim result = MsgBox("Are you sure you want to update this record?", vbYesNo + vbQuestion)

            If result = vbYes Then
                If service.edit = True Then
                    MsgBox("Record has been successfully updated.", vbInformation)
                    clearControls()
                    frmServices.tb_Search.Text = vbNullString
                    service.loadRecord()
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
        lbl_Id.Text = ""
    End Sub
    Private Function countEmpty()
        If tb_service_Code.Text = vbNullString Then
            tb_service_Code.Focus()
            Return True
        ElseIf tb_Desc.Text = vbNullString Then
            tb_Desc.Focus()
            Return True
        ElseIf tb_fee_A.Text = vbNullString Then
            tb_fee_A.Focus()
            Return True
        ElseIf tb_fee_B.Text = vbNullString Then
            tb_fee_B.Focus()
            Return True
        End If
        Return False
    End Function
End Class
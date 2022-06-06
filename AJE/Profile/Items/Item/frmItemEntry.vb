Public Class frmItemEntry
    Dim strCurrency As String = ""
    Dim acceptableKey As Boolean = False
    Dim item As New clsItem
    Dim category As New clsCategory
    Dim brand As New clsBrand
    Dim unit As New clsUnit
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
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        clearControls()
        Me.Close()
    End Sub
    Private Sub tb_unit_Price_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_unit_Price.KeyDown
        If (e.KeyCode >= Keys.D0 And e.KeyCode <= Keys.D9) OrElse (e.KeyCode >= Keys.NumPad0 And e.KeyCode <= Keys.NumPad9) OrElse e.KeyCode = Keys.Back Then
            acceptableKey = True
        Else
            acceptableKey = False
        End If
    End Sub

    Private Sub tb_unit_Price_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_unit_Price.KeyPress
        If tb_unit_Price.Text.Length > 9 Then
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
                tb_unit_Price.Text = ""
            ElseIf strCurrency.Length = 1 Then
                tb_unit_Price.Text = "0.0" & strCurrency
            ElseIf strCurrency.Length = 2 Then
                tb_unit_Price.Text = "0." & strCurrency
            ElseIf strCurrency.Length > 2 Then
                tb_unit_Price.Text = strCurrency.Substring(0, strCurrency.Length - 2) & "." & strCurrency.Substring(strCurrency.Length - 2)
            End If
            tb_unit_Price.Select(tb_unit_Price.Text.Length, 0)

        End If
        e.Handled = True
    End Sub

    Private Sub tb_price_A_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_price_A.KeyDown
        If (e.KeyCode >= Keys.D0 And e.KeyCode <= Keys.D9) OrElse (e.KeyCode >= Keys.NumPad0 And e.KeyCode <= Keys.NumPad9) OrElse e.KeyCode = Keys.Back Then
            acceptableKey = True
        Else
            acceptableKey = False
        End If
    End Sub

    Private Sub tb_price_A_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_price_A.KeyPress
        If tb_price_A.Text.Length > 9 Then
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
                tb_price_A.Text = ""
            ElseIf strCurrency.Length = 1 Then
                tb_price_A.Text = "0.0" & strCurrency
            ElseIf strCurrency.Length = 2 Then
                tb_price_A.Text = "0." & strCurrency
            ElseIf strCurrency.Length > 2 Then
                tb_price_A.Text = strCurrency.Substring(0, strCurrency.Length - 2) & "." & strCurrency.Substring(strCurrency.Length - 2)
            End If
            tb_price_A.Select(tb_price_A.Text.Length, 0)

        End If
        e.Handled = True
    End Sub
    Private Sub tb_price_B_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_price_B.KeyDown

        If (e.KeyCode >= Keys.D0 And e.KeyCode <= Keys.D9) OrElse (e.KeyCode >= Keys.NumPad0 And e.KeyCode <= Keys.NumPad9) OrElse e.KeyCode = Keys.Back Then
            acceptableKey = True
        Else
            acceptableKey = False
        End If
    End Sub
    Private Sub tb_Quantity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
            Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub tb_price_B_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_price_B.KeyPress
        If tb_price_B.Text.Length > 9 Then
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
                tb_price_B.Text = ""
            ElseIf strCurrency.Length = 1 Then
                tb_price_B.Text = "0.0" & strCurrency
            ElseIf strCurrency.Length = 2 Then
                tb_price_B.Text = "0." & strCurrency
            ElseIf strCurrency.Length > 2 Then
                tb_price_B.Text = strCurrency.Substring(0, strCurrency.Length - 2) & "." & strCurrency.Substring(strCurrency.Length - 2)
            End If
            tb_price_B.Select(tb_price_B.Text.Length, 0)

        End If
        e.Handled = True
    End Sub

    Private Sub tb_unit_Price_Leave(sender As Object, e As EventArgs) Handles tb_unit_Price.Leave
        strCurrency = ""
        acceptableKey = False
    End Sub

    Private Sub tb_price_A_Leave(sender As Object, e As EventArgs) Handles tb_price_A.Leave
        strCurrency = ""
        acceptableKey = False
    End Sub

    Private Sub tb_price_B_Leave(sender As Object, e As EventArgs) Handles tb_price_B.Leave
        strCurrency = ""
        acceptableKey = False
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        If countEmpty() = True Then
            MsgBox("Please fill in the field(s) before saving.", vbExclamation)
            Exit Sub
        End If
        Try
            item.SetCode(Trim(tb_Code.Text))
            item.SetDesc(Trim(tb_Desc.Text))
            item.SetAddDesc(Trim(tb_add_Desc.Text))
            item.SetUnitPrice(Trim(tb_unit_Price.Text))
            item.SetPriceA(Trim(tb_price_A.Text))
            item.SetPriceB(Trim(tb_price_B.Text))

            brand.SetBrandName(Trim(tb_Brand.Text))
            category.SetCategoryName(Trim(tb_Category.Text))
            unit.SetUnitName(Trim(tb_Unit.Text))
            lbl_brand_Id.Text = brand.BrandId()
            If CInt(lbl_brand_Id.Text) = -1 Then
                MsgBox("Please choose an existing Brand, if not create one in the brand module.", vbExclamation)
                Exit Sub
            End If
            lbl_category_Id.Text = category.categoryId()
            If CInt(lbl_category_Id.Text) = -1 Then
                MsgBox("Please choose an existing Category, if not create one in the category module.", vbExclamation)
                Exit Sub
            End If
            lbl_unit_Id.Text = unit.UnitId()
            If CInt(lbl_unit_Id.Text) = -1 Then
                MsgBox("Please choose an existing Unit, if not create one in the unit module.", vbExclamation)
                Exit Sub
            End If
            If Convert.ToDecimal(tb_unit_Price.Text) > Convert.ToDecimal(tb_price_B.Text) Or CDec(tb_unit_Price.Text) > CDec(tb_price_A.Text) Then
                MsgBox("Unit Price should be less than price A and price B.", vbExclamation)
                Exit Sub
            End If
            If Convert.ToDecimal(tb_price_A.Text) < Convert.ToDecimal(tb_price_B.Text) Then
                MsgBox("Price A should be Greater than or equal Price B.", vbExclamation)
                Exit Sub
            End If
            item.SetCategory(CInt(lbl_category_Id.Text))
            item.SetBrand(CInt(lbl_brand_Id.Text))
            item.SetUnit(CInt(lbl_unit_Id.Text))
            Dim result = MsgBox("Are you sure you want to save this record?", vbYesNo + vbQuestion)
            If item.checkItemDuplicate = True Or item.checkServiceDuplicate = True Then
                MsgBox("Item code duplicate.", vbInformation)
                Exit Sub
            End If

            If result = vbYes Then
                If item.save = True Then
                    MsgBox("Record has been successfully saved.", vbInformation)
                    clearControls()
                    frmItem.tb_Search.Text = vbNullString
                    item.loadRecord()
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
            item.SetCode(tb_Code.Text)
            item.SetDesc(Trim(tb_Desc.Text))
            item.SetAddDesc(Trim(tb_add_Desc.Text))
            item.SetUnitPrice(Trim(tb_unit_Price.Text))
            item.SetPriceA(Trim(tb_price_A.Text))
            item.SetPriceB(Trim(tb_price_B.Text))

            brand.SetBrandName(Trim(tb_Brand.Text))
            category.SetCategoryName(Trim(tb_Category.Text))
            unit.SetUnitName(Trim(tb_Unit.Text))
            lbl_category_Id.Text = category.categoryId()
            If CInt(lbl_category_Id.Text) = -1 Then
                MsgBox("Please choose an existing Category, if not create one in the category module.", vbCritical)
                Exit Sub
            End If
            lbl_brand_Id.Text = brand.BrandId()
            If CInt(lbl_brand_Id.Text) = -1 Then
                MsgBox("Please choose an existing Brand, if not create one in the brand module.", vbCritical)
                Exit Sub
            End If
            lbl_unit_Id.Text = unit.UnitId()
            If CInt(lbl_unit_Id.Text) = -1 Then
                MsgBox("Please choose an existing Unit, if not create one in the unit module.", vbExclamation)
                Exit Sub
            End If
            If Convert.ToDecimal(tb_unit_Price.Text) > Convert.ToDecimal(tb_price_B.Text) Or CDec(tb_unit_Price.Text) > CDec(tb_price_A.Text) Then
                MsgBox("Unit Price should be less than price A and price B.", vbExclamation)
                Exit Sub
            End If
            If Convert.ToDecimal(tb_price_A.Text) < Convert.ToDecimal(tb_price_B.Text) Then
                MsgBox("Price A should be Greater than or equal price B.", vbExclamation)
                Exit Sub
            End If
            item.SetCategory(CInt(lbl_category_Id.Text))
            item.SetBrand(CInt(lbl_brand_Id.Text))
            item.SetUnit(CInt(lbl_unit_Id.Text))
            Dim result = MsgBox("Are you sure you want to update this record?", vbYesNo + vbQuestion)

            If result = vbYes Then
                If item.edit = True Then
                    MsgBox("Record has been successfully updated.", vbInformation)
                    clearControls()
                    frmItem.tb_Search.Text = vbNullString
                    item.loadRecord()
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
        lbl_brand_Id.Text = ""
        lbl_category_Id.Text = ""
        lbl_Id.Text = ""
    End Sub
    Private Function countEmpty()
        If tb_Code.Text = vbNullString Then
            tb_Code.Focus()
            Return True
        ElseIf tb_Desc.Text = vbNullString Then
            tb_Desc.Focus()
            Return True
        ElseIf tb_add_Desc.Text = vbNullString Then
            tb_add_Desc.Focus()
            Return True
        ElseIf tb_Brand.Text = vbNullString Then
            tb_Brand.Focus()
            Return True
        ElseIf tb_Category.Text = vbNullString Then
            tb_Category.Focus()
            Return True
        ElseIf tb_Unit.Text = vbNullString Then
            tb_Unit.Focus()
            Return True
        ElseIf tb_unit_Price.Text = vbNullString Then
            tb_unit_Price.Focus()
            Return True
        ElseIf tb_price_A.Text = vbNullString Then
            tb_price_A.Focus()
            Return True
        ElseIf tb_price_B.Text = vbNullString Then
            tb_price_B.Focus()
            Return True
        End If
        Return False
    End Function

End Class
Public Class frmPrice
    Dim strCurrency As String = ""
    Dim acceptableKey As Boolean = False
    Dim _id, _code, _desc, _qty, _unit
    Dim _total, _price, _priceA, _priceB As Double
    Dim order As New clsOrder
    Private Sub tb_Price_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_Price.KeyDown
        If (e.KeyCode >= Keys.D0 And e.KeyCode <= Keys.D9) OrElse (e.KeyCode >= Keys.NumPad0 And e.KeyCode <= Keys.NumPad9) OrElse e.KeyCode = Keys.Back Then
            acceptableKey = True
        Else
            acceptableKey = False
        End If
    End Sub
    Private Sub tb_Price_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_Price.KeyPress
        If tb_Price.Text.Length > 7 Then
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
                tb_Price.Text = ""
            ElseIf strCurrency.Length = 1 Then
                tb_Price.Text = "0.0" & strCurrency
            ElseIf strCurrency.Length = 2 Then
                tb_Price.Text = "0." & strCurrency
            ElseIf strCurrency.Length > 2 Then
                tb_Price.Text = strCurrency.Substring(0, strCurrency.Length - 2) & "." & strCurrency.Substring(strCurrency.Length - 2)
            End If
            tb_Price.Select(tb_Price.Text.Length, 0)

        End If
        e.Handled = True
    End Sub
    Private Sub tb_Price_Leave(sender As Object, e As EventArgs) Handles tb_Price.Leave
        strCurrency = ""
        acceptableKey = False
    End Sub
    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        If Val(tb_Price.Text) = 0 Then
            MsgBox("Please input a valid price", vbExclamation)
            Exit Sub
        End If

        If Val(tb_Qty.Text) = 0 Then                              'prompts message if qty is 0
            MsgBox("Please input a valid quantity", vbExclamation)
            Exit Sub
        End If
        Dim b = frmPos.dg_Search.CurrentRow.Index
        order.SetItemCode(frmPos.dg_Search.Item(1, b).Value)
        If order.checkItemQty < tb_Qty.Text Then
            If MsgBox("The virtual item stocked exceeds the current order. Do you wish to Continue?", vbYesNo + vbQuestion) = vbNo Then
                tb_Qty.Clear()
                tb_Price.Clear()
                Me.Close()
                Exit Sub
            End If
        End If

        If lbl_Type.Text = 1 Then
            Dim i As Integer = frmPos.dg_Search.CurrentRow.Index      'sets price range price A and priceB
            Dim priceA = frmPos.dg_Search.Item(4, i).Value
            Dim priceB = frmPos.dg_Search.Item(5, i).Value

            If Val(tb_Price.Text) > Val(priceA) Or Val(tb_Price.Text) < Val(priceB) Then
                MsgBox("Please input price within the price range.", vbExclamation)
                Exit Sub
            End If

            _id = frmPos.dg_Search.Item(0, i).Value
            _code = frmPos.dg_Search.Item(1, i).Value
            _desc = frmPos.dg_Search.Item(2, i).Value
            _qty = tb_Qty.Text
            _price = Val(tb_Price.Text)
            _unit = frmPos.dg_Search.Item(3, i).Value
            _total = Val(tb_Price.Text) * Val(tb_Qty.Text)
            _priceA = frmPos.dg_Search.Item(4, i).Value
            _priceB = frmPos.dg_Search.Item(5, i).Value

            frmPos.dg_Order.Rows.Add(_id, _code, _desc, Format(_price, "0.00"), _unit, _qty, Format(_total, "0.00"), "EDIT", "REMOVE", _priceA, _priceB)

            MsgBox("Item/Service has been added to cart.", vbInformation)

        ElseIf lbl_Type.Text = 2 Then
            Dim i As Integer = frmPos.dg_Order.CurrentRow.Index
            Dim priceA = frmPos.dg_Order.Item(9, i).Value
            Dim priceB = frmPos.dg_Order.Item(10, i).Value

            If Val(tb_Price.Text) > Val(priceA) Or Val(tb_Price.Text) < Val(priceB) Then
                MsgBox("Please input price within the price range.", vbExclamation)
                Exit Sub
            End If

            frmPos.dg_Order.Item(3, i).Value = Format(Val(tb_Price.Text), "0.00")
            frmPos.dg_Order.Item(5, i).Value = tb_Qty.Text
            frmPos.dg_Order.Item(6, i).Value = Format(Val(tb_Price.Text) * Val(tb_Qty.Text), "0.00")
            MsgBox("Item/Service has been updated.", vbInformation)
        End If
        Dim due_total As Decimal = 0.00
        For i = 0 To frmPos.dg_Order.RowCount - 1
            due_total = due_total + frmPos.dg_Order.Item(6, i).Value
        Next
        frmPos.lbl_due_Total.Text = Format(due_total, "0.00") 'set due total        
        frmPos.tb_Search.Select()
        tb_price_Range.Clear()
        tb_Price.Text = vbNullString
        tb_Qty.Clear()
        Me.Close()
    End Sub

    Private Sub frmPrice_Load(sender As Object, e As EventArgs) Handles Me.Load
        tb_Price.Select()
        cbo_Price.SelectedIndex = 0
        If lbl_Type.Text = 1 Then
            If frmPos.dg_Search.RowCount <> 0 Then
                Dim i As Integer = frmPos.dg_Search.CurrentRow.Index
                tb_price_Range.Text = frmPos.dg_Search.Item(4, i).Value
            End If
        ElseIf lbl_Type.Text = 2 Then
            If frmPos.dg_Order.RowCount <> 0 Then
                Dim i As Integer = frmPos.dg_Order.CurrentRow.Index
                tb_price_Range.Text = frmPos.dg_Order.Item(9, i).Value
            End If
        End If

    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        tb_price_Range.Clear()
        tb_Price.Text = vbNullString
        tb_Qty.Clear()
        Me.Close()
    End Sub

    Private Sub cbo_Price_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Price.SelectedIndexChanged
        If frmPos.dg_Search.RowCount = 0 Then
            Exit Sub
        End If

        If lbl_Type.Text = 1 Then
            Dim i As Integer = frmPos.dg_Search.CurrentRow.Index
            If cbo_Price.SelectedIndex = 0 Then
                tb_price_Range.Text = frmPos.dg_Search.Item(4, i).Value
            ElseIf cbo_Price.SelectedIndex = 1 Then
                tb_price_Range.Text = frmPos.dg_Search.Item(5, i).Value
            End If
        ElseIf lbl_Type.Text = 2 Then
            Dim i As Integer = frmPos.dg_Order.CurrentRow.Index
            If cbo_Price.SelectedIndex = 0 Then
                tb_price_Range.Text = frmPos.dg_Order.Item(9, i).Value
            ElseIf cbo_Price.SelectedIndex = 1 Then
                tb_price_Range.Text = frmPos.dg_Order.Item(10, i).Value
            End If
        End If
    End Sub

    Private Sub tb_Qty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_Qty.KeyPress
        If IsNumeric(e.KeyChar.ToString()) Or e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class
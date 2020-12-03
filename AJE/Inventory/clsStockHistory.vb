Imports MySql.Data.MySqlClient
Public Class clsStockHistory
    Private _DateFrom As Object
    Private _DateTo As Object
    Private _Branch As Object
    Public Sub SetBranch(AutoPropertyValue As Object)
        _Branch = AutoPropertyValue
    End Sub
    Public Sub SetDateFrom(AutoPropertyValue As Object)
        _DateFrom = AutoPropertyValue
    End Sub

    Public Sub SetDateTo(AutoPropertyValue As Object)
        _DateTo = AutoPropertyValue
    End Sub

    Public Sub loadStockHistory()
        Dim refNo As String
        Dim transDate, dateRef As String
        frmStockIn_History.dg_stock_History.Rows.Clear()
        ConnectDatabase()
        Dim query = "SELECT * FROM vw_stock_in_history WHERE trans_date BETWEEN @date_from AND @date_to AND branch_address = @branch_address"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@branch_address", _Branch)
        cm.Parameters.AddWithValue("@date_from", _DateFrom)
        cm.Parameters.AddWithValue("@date_to", _DateTo)
        dr = cm.ExecuteReader()
        If dr.HasRows Then
            While dr.Read()
                Dim zero = ""
                refNo = dr.Item("ref_no").ToString
                For i = 0 To (5 - refNo.Length)
                    zero &= "0"
                    i += 1
                Next
                transDate = Format(dr.Item("trans_date"), "MM/dd/yyyy")
                dateRef = Format(dr.Item("trans_date"), "yyyyMMdd")
                frmStockIn_History.dg_stock_History.Rows.Add(dr.Item("stock_in_id").ToString, "SI" & dateRef & zero & dr.Item("ref_no").ToString, transDate, dr.Item("branch_address").ToString,
                                                   dr.Item("item_code").ToString, dr.Item("brand_name").ToString, dr.Item("item_desc").ToString, dr.Item("item_add_desc").ToString,
                                                   dr.Item("category_name").ToString, dr.Item("unit_name"), dr.Item("qty").ToString, dr.Item("supplier_name"))
            End While
        Else
            MsgBox("No transaction on dates given.", vbInformation)
        End If

        DisconnectDatabase()
    End Sub
    Public Sub loadStockTransHistory()
        Dim refNo As String
        Dim transDate, dateRef As String
        frmStockTrans_History.dg_stock_History.Rows.Clear()
        ConnectDatabase()
        Dim query = "SELECT * FROM vw_stock_trans_history WHERE trans_date BETWEEN @date_from AND @date_to AND b_from = @branch_address"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@branch_address", _Branch)
        cm.Parameters.AddWithValue("@date_from", _DateFrom)
        cm.Parameters.AddWithValue("@date_to", _DateTo)
        dr = cm.ExecuteReader()
        If dr.HasRows Then
            While dr.Read()
                Dim zero = ""
                refNo = dr.Item("ref_no").ToString
                For i = 0 To (5 - refNo.Length)
                    zero &= "0"
                    i += 1
                Next
                transDate = Format(dr.Item("trans_date"), "MM/dd/yyyy")
                dateRef = Format(dr.Item("trans_date"), "yyyyMMdd")
                frmStockTrans_History.dg_stock_History.Rows.Add(dr.Item("stock_trans_id").ToString, "ST" & dateRef & zero & dr.Item("ref_no").ToString, transDate, dr.Item("b_from"),
                                                   dr.Item("b_to"), dr.Item("item_code").ToString, dr.Item("brand_name").ToString, dr.Item("item_desc").ToString,
                                                   dr.Item("item_add_desc").ToString, dr.Item("category_name").ToString, dr.Item("qty").ToString)
            End While
        Else
            MsgBox("No transaction on dates given.", vbInformation)
        End If

        DisconnectDatabase()
    End Sub
    Public Sub loadStockRetHistory()
        Dim refNo As String
        Dim transDate, dateRef As String
        frmStockRet_History.dg_stock_History.Rows.Clear()
        ConnectDatabase()
        Dim query = "SELECT * FROM vw_stock_ret_history WHERE trans_date BETWEEN @date_from AND @date_to AND branch_address = @branch_address"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@branch_address", _Branch)
        cm.Parameters.AddWithValue("@date_from", _DateFrom)
        cm.Parameters.AddWithValue("@date_to", _DateTo)
        dr = cm.ExecuteReader()
        If dr.HasRows Then
            While dr.Read()
                Dim zero = ""
                refNo = dr.Item("ref_no").ToString
                For i = 0 To (5 - refNo.Length)
                    zero &= "0"
                    i += 1
                Next
                transDate = Format(dr.Item("trans_date"), "MM/dd/yyyy")
                dateRef = Format(dr.Item("trans_date"), "yyyyMMdd")
                frmStockRet_History.dg_stock_History.Rows.Add(dr.Item("stock_ret_id").ToString, "SR" & dateRef & zero & dr.Item("ref_no").ToString, transDate, dr.Item("branch_address").ToString,
                                                   dr.Item("item_code").ToString, dr.Item("brand_name").ToString, dr.Item("item_desc").ToString, dr.Item("item_add_desc").ToString,
                                                   dr.Item("category_name").ToString, dr.Item("unit_name").ToString, dr.Item("qty").ToString, dr.Item("supplier_name"))
            End While
        Else
            MsgBox("No transaction on dates given.", vbInformation)
        End If
        DisconnectDatabase()
    End Sub
    Public Sub loadStockOutHistory()
        Dim refNo As String
        Dim transDate, dateRef As String
        frmStockOut_History.dg_stock_History.Rows.Clear()
        ConnectDatabase()
        Dim query = "SELECT * FROM vw_stock_out_history WHERE trans_date BETWEEN @date_from AND @date_to AND branch_address = @branch_address"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@branch_address", _Branch)
        cm.Parameters.AddWithValue("@date_from", _DateFrom)
        cm.Parameters.AddWithValue("@date_to", _DateTo)
        dr = cm.ExecuteReader()
        If dr.HasRows Then
            While dr.Read()
                Dim zero = ""
                refNo = dr.Item("ref_no").ToString
                For i = 0 To (5 - refNo.Length)
                    zero &= "0"
                    i += 1
                Next
                transDate = Format(dr.Item("trans_date"), "MM/dd/yyyy")
                dateRef = Format(dr.Item("trans_date"), "yyyyMMdd")
                frmStockOut_History.dg_stock_History.Rows.Add(dr.Item("stock_out_id").ToString, "SO" & dateRef & zero & dr.Item("ref_no").ToString, transDate, dr.Item("branch_address").ToString,
                                                   dr.Item("item_code").ToString, dr.Item("brand_name").ToString, dr.Item("item_desc").ToString, dr.Item("item_add_desc").ToString,
                                                   dr.Item("category_name").ToString, dr.Item("unit_name").ToString, dr.Item("qty").ToString)
            End While
        Else
            MsgBox("No transaction on dates given.", vbInformation)
        End If

        DisconnectDatabase()
    End Sub

    Public Sub loadStockAdjustHistory()
        Dim refNo As String
        Dim transDate, dateRef As String
        frmStockAdj_History.dg_stock_History.Rows.Clear()
        ConnectDatabase()
        Dim query = "SELECT * FROM vw_stock_adjust_history WHERE count_date BETWEEN @date_from AND @date_to AND branch_address = @branch_address"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@branch_address", _Branch)
        cm.Parameters.AddWithValue("@date_from", _DateFrom)
        cm.Parameters.AddWithValue("@date_to", _DateTo)
        dr = cm.ExecuteReader()
        If dr.HasRows Then
            While dr.Read()
                Dim zero = ""
                refNo = dr.Item("ref_no").ToString
                For i = 0 To (5 - refNo.Length)
                    zero &= "0"
                    i += 1
                Next
                transDate = Format(dr.Item("count_date"), "MM/dd/yyyy")
                dateRef = Format(dr.Item("count_date"), "yyyyMMdd")
                frmStockAdj_History.dg_stock_History.Rows.Add(dr.Item("phys_count_id").ToString, "SA" & dateRef & zero & dr.Item("ref_no").ToString, transDate, dr.Item("branch_address").ToString,
                                                   dr.Item("item_code").ToString, dr.Item("brand_name").ToString, dr.Item("item_desc").ToString, dr.Item("item_add_desc").ToString,
                                                   dr.Item("category_name").ToString, dr.Item("unit_name").ToString, dr.Item("qty").ToString, Format(dr.Item("period_from"), "MM/dd/yyyy"), Format(dr.Item("period_to"), "MM/dd/yyyy"))
            End While
        Else
            MsgBox("No transaction on dates given.", vbInformation)
        End If
        DisconnectDatabase()
    End Sub
End Class

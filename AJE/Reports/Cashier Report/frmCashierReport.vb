Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient
Public Class frmCashierReport
    Private Sub btn_load_log_Report_Click(sender As Object, e As EventArgs) Handles btn_load_log_Report.Click
        Dim rptDs As ReportDataSource
        Me.rv_Log.RefreshReport()
        Try
            With rv_Log.LocalReport
                .ReportPath = Application.StartupPath & "\Report\ReportCashierLog.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            ConnectDatabase()
            da.SelectCommand = New MySqlCommand("SELECT DATE_FORMAT(log_date, '%m/%d/%Y') AS log_date, Cashiers, Managers, TIME_FORMAT(time_from,'%r'), TIME_FORMAT(time_to,'%r'), begin_bal, end_bal FROM vw_cashier_log WHERE branch_id = '" & frmPos.lbl_branch_Id.Text & "' AND log_date BETWEEN '" & dtp_log_From.Value.ToString("yyyy-MM-dd") & "' AND '" & dtp_log_To.Value.ToString("yyyy-MM-dd") & "'", con)
            da.Fill(ds.Tables("dt_cashier_log"))
            DisconnectDatabase()

            rptDs = New ReportDataSource("DataSet1", ds.Tables("dt_cashier_log"))
            rv_Log.LocalReport.DataSources.Add(rptDs)
            rv_Log.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            rv_Log.ZoomMode = ZoomMode.PageWidth
        Catch ex As Exception
            DisconnectDatabase()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub

    Private Sub frmCashierReport_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtp_log_To.Value = DateTime.Now
        dtp_log_From.Value = DateTime.Now
        dtp_cash_in_To.Value = DateTime.Now
        dtp_cash_in_From.Value = DateTime.Now
        dtp_cash_out_From.Value = DateTime.Now
        dtp_cash_out_To.Value = DateTime.Now
    End Sub

    Private Sub btn_load_cash_in_Report_Click(sender As Object, e As EventArgs) Handles btn_load_cash_in_Report.Click
        Dim rptDs As ReportDataSource
        Me.rv_cash_In.RefreshReport()
        Try
            With rv_cash_In.LocalReport
                .ReportPath = Application.StartupPath & "\Report\ReportCashIn.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            ConnectDatabase()
            da.SelectCommand = New MySqlCommand("SELECT DATE_FORMAT(trans_date, '%m/%d/%Y') AS trans_date, Cashiers, Managers, amount, remarks FROM vw_cash_in WHERE branch_id = '" & frmPos.lbl_branch_Id.Text & "' AND trans_date BETWEEN '" & dtp_cash_in_From.Value.ToString("yyyy-MM-dd") & "' AND '" & dtp_cash_in_To.Value.ToString("yyyy-MM-dd") & "'", con)
            da.Fill(ds.Tables("dt_cash_in"))
            DisconnectDatabase()

            rptDs = New ReportDataSource("DataSet1", ds.Tables("dt_cash_in"))
            rv_cash_In.LocalReport.DataSources.Add(rptDs)
            rv_cash_In.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            rv_cash_In.ZoomMode = ZoomMode.PageWidth
        Catch ex As Exception
            DisconnectDatabase()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btn_cash_out_Report_Click(sender As Object, e As EventArgs) Handles btn_cash_out_Report.Click
        Dim rptDs As ReportDataSource
        Me.rv_cash_Out.RefreshReport()
        Try
            With rv_cash_Out.LocalReport
                .ReportPath = Application.StartupPath & "\Report\ReportCashOut.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            ConnectDatabase()
            da.SelectCommand = New MySqlCommand("SELECT DATE_FORMAT(trans_date, '%m/%d/%Y') AS trans_date, Cashiers, Managers, amount, remarks FROM vw_cash_out WHERE branch_id = '" & frmPos.lbl_branch_Id.Text & "' AND trans_date BETWEEN '" & dtp_cash_out_From.Value.ToString("yyyy-MM-dd") & "' AND '" & dtp_cash_out_To.Value.ToString("yyyy-MM-dd") & "'", con)
            da.Fill(ds.Tables("dt_cash_out"))
            DisconnectDatabase()

            rptDs = New ReportDataSource("DataSet1", ds.Tables("dt_cash_out"))
            rv_cash_Out.LocalReport.DataSources.Add(rptDs)
            rv_cash_Out.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            rv_cash_Out.ZoomMode = ZoomMode.PageWidth
        Catch ex As Exception
            DisconnectDatabase()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Class
﻿Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Public Class frmCustomerTransacs
    Private Sub btn_load_transac_Report_Click(sender As Object, e As EventArgs) Handles btn_load_transac_Report.Click
        If tb_transac_Customer.Text = vbNullString Then
            MsgBox("Please select an existing customer.", vbInformation)
            Exit Sub
        End If
        Dim rptDs As ReportDataSource

        Try
            With rv_Transac.LocalReport
                .ReportEmbeddedResource = "AJE.Report3.rdlc" '.ReportPath = Application.StartupPath & "\Report\Report3.rdlc"
                .DataSources.Clear()
            End With
            rv_Transac.RefreshReport()

            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            ConnectDatabase()
            da.SelectCommand = New MySqlCommand("SELECT DATE_FORMAT(trans_date, '%m/%d/%Y') AS trans_date, invoice, Description, Category, Unit, price, qty, line_total, pay_amount, Cashiers FROM vw_customer_transactions WHERE branch_id = '" & frmMain.lbl_branch_Id.Text & "' AND  customer_id = '" & lbl_transac_customer_Id.Text & "' AND trans_date BETWEEN '" & dtp_transac_From.Value.ToString("yyyy-MM-dd") & "' AND '" & dtp_transac_To.Value.ToString("yyyy-MM-dd") & "'", con)
            da.Fill(ds.Tables("dt_customer_cred_Transacs"))
            DisconnectDatabase()

            Dim rptParameter As ReportParameterCollection
            rptParameter = New ReportParameterCollection
            rptParameter.Add(New ReportParameter("BranchAddress", frmMain.lbl_branch_Address.Text))
            rptParameter.Add(New ReportParameter("DateFrom", dtp_transac_From.Value.ToString("MM/dd/yy")))
            rptParameter.Add(New ReportParameter("DateTill", dtp_transac_To.Value.ToString("MM/dd/yy")))
            rv_Transac.LocalReport.SetParameters(rptParameter)

            rptDs = New ReportDataSource("DataSet1", ds.Tables("dt_customer_cred_Transacs"))
            rv_Transac.LocalReport.DataSources.Add(rptDs)
            rv_Transac.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            rv_Transac.ZoomMode = ZoomMode.PageWidth
        Catch ex As Exception
            DisconnectDatabase()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub lbl_transac_Customer_Click(sender As Object, e As EventArgs) Handles lbl_transac_Customer.Click
        frmCustomerSearch.lbl_Type.Text = 4
        frmCustomerSearch.ShowDialog()
    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        rv_History.Reset()
        rv_Transac.Reset()
        rv_Balance.Reset()
        Me.Close()
    End Sub

    Private Sub frmCustomerTransacs_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtp_history_From.Value = DateTime.Now
        dtp_history_To.Value = DateTime.Now
        dtp_transac_From.Value = DateTime.Now
        dtp_transac_To.Value = DateTime.Now
        dtp_bal_From.Value = DateTime.Now
        dtp_bal_To.Value = DateTime.Now
    End Sub

    Private Sub lbl_transac_Customer_MouseHover(sender As Object, e As EventArgs) Handles lbl_transac_Customer.MouseHover
        lbl_transac_Customer.ForeColor = Color.Blue
    End Sub

    Private Sub lbl_transac_Customer_MouseLeave(sender As Object, e As EventArgs) Handles lbl_transac_Customer.MouseLeave
        lbl_transac_Customer.ForeColor = Color.Black
    End Sub

    Private Sub btn_history_load_Report_Click(sender As Object, e As EventArgs) Handles btn_history_load_Report.Click
        Dim rptDs As ReportDataSource

        Try
            With rv_History.LocalReport
                .ReportEmbeddedResource = "AJE.Report4.rdlc" '.ReportPath = Application.StartupPath & "\Report\Report4.rdlc"
                .DataSources.Clear()
            End With
            rv_History.RefreshReport()

            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            ConnectDatabase()
            da.SelectCommand = New MySqlCommand("SELECT DATE_FORMAT(trans_date, '%m/%d/%Y') AS trans_date, receipt, Customers, pay_amount, Cashiers, Managers FROM vw_customer_payments WHERE trans_date BETWEEN '" & dtp_history_From.Value.ToString("yyyy-MM-dd") & "' AND '" & dtp_history_To.Value.ToString("yyyy-MM-dd") & "'", con)
            da.Fill(ds.Tables("dt_customer_payments"))
            DisconnectDatabase()

            Dim rptParameter As ReportParameterCollection
            rptParameter = New ReportParameterCollection
            rptParameter.Add(New ReportParameter("BranchAddress", frmMain.lbl_branch_Address.Text))
            rptParameter.Add(New ReportParameter("DateFrom", dtp_history_From.Value.ToString("MM/dd/yy")))
            rptParameter.Add(New ReportParameter("DateTill", dtp_history_To.Value.ToString("MM/dd/yy")))
            rv_History.LocalReport.SetParameters(rptParameter)

            rptDs = New ReportDataSource("DataSet1", ds.Tables("dt_customer_payments"))
            rv_History.LocalReport.DataSources.Add(rptDs)
            rv_History.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            rv_History.ZoomMode = ZoomMode.PageWidth
        Catch ex As Exception
            DisconnectDatabase()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btn_load_Bal_Click(sender As Object, e As EventArgs) Handles btn_load_Bal.Click
        Dim rptDs As ReportDataSource

        Try
            With rv_Balance.LocalReport
                .ReportEmbeddedResource = "AJE.ReportBalance.rdlc" '.ReportPath = Application.StartupPath & "\Report\ReportBalance.rdlc"
                .DataSources.Clear()
            End With
            rv_Balance.RefreshReport()

            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            ConnectDatabase()
            da.SelectCommand = New MySqlCommand("SELECT Customers, credit_limit, balance FROM vw_customer_balance", con)
            da.Fill(ds.Tables("dt_customer_balance"))
            DisconnectDatabase()

            Dim rptParameter As ReportParameterCollection
            rptParameter = New ReportParameterCollection
            rptParameter.Add(New ReportParameter("BranchAddress", frmMain.lbl_branch_Address.Text))
            rptParameter.Add(New ReportParameter("DateFrom", dtp_bal_From.Value.ToString("MM/dd/yy")))
            rptParameter.Add(New ReportParameter("DateTill", dtp_bal_To.Value.ToString("MM/dd/yy")))
            rv_Balance.LocalReport.SetParameters(rptParameter)

            rptDs = New ReportDataSource("DataSet1", ds.Tables("dt_customer_balance"))
            rv_Balance.LocalReport.DataSources.Add(rptDs)
            rv_Balance.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            rv_Balance.ZoomMode = ZoomMode.PageWidth
        Catch ex As Exception
            DisconnectDatabase()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Class
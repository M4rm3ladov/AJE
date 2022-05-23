Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient
Public Class frmRefundReport
    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub

    Private Sub btn_load_refund_Report_Click(sender As Object, e As EventArgs) Handles btn_load_refund_Report.Click
        Dim rptDs As ReportDataSource

        Try
            With rv_Refund.LocalReport
                .ReportEmbeddedResource = "AJE.ReportRefund.rdlc" '.ReportPath = Application.StartupPath & "\Report\ReportRefund.rdlc"
                .DataSources.Clear()
            End With
            Me.rv_Refund.RefreshReport()

            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            Dim rptParameter As ReportParameterCollection
            rptParameter = New ReportParameterCollection
            rptParameter.Add(New ReportParameter("BranchAddress", frmMain.lbl_branch_Address.Text))
            rptParameter.Add(New ReportParameter("DateFrom", dtp_refund_From.Value.ToString("MM/dd/yy")))
            rptParameter.Add(New ReportParameter("DateTill", dtp_refund_To.Value.ToString("MM/dd/yy")))
            rv_Refund.LocalReport.SetParameters(rptParameter)

            ConnectDatabase()
            da.SelectCommand = New MySqlCommand("SELECT DATE_FORMAT(trans_date, '%m/%d/%Y') AS trans_date, Description, Category, Unit, price, qty, sub_total, Cashiers, Managers, remarks FROM vw_refund WHERE trans_date BETWEEN '" & dtp_refund_From.Value.ToString("yyyy-MM-dd") & "' AND '" & dtp_refund_To.Value.ToString("yyyy-MM-dd") & "' AND branch_id = '" & frmMain.lbl_branch_Id.Text & "'", con)
            da.Fill(ds.Tables("dt_refund"))
            DisconnectDatabase()

            rptDs = New ReportDataSource("DataSet1", ds.Tables("dt_refund"))
            rv_Refund.LocalReport.DataSources.Add(rptDs)
            rv_Refund.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            rv_Refund.ZoomMode = ZoomMode.PageWidth
        Catch ex As Exception
            DisconnectDatabase()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub frmRefundReport_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtp_refund_From.Value = DateTime.Now
        dtp_refund_To.Value = DateTime.Now
    End Sub
End Class
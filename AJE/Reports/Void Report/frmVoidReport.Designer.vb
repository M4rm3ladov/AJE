<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVoidReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVoidReport))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp_credit_To = New System.Windows.Forms.DateTimePicker()
        Me.btn_load_credit_Report = New System.Windows.Forms.Button()
        Me.dtp_credit_From = New System.Windows.Forms.DateTimePicker()
        Me.rv_credit_void = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtp_void_To = New System.Windows.Forms.DateTimePicker()
        Me.btn_load_void_Report = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.dtp_void_From = New System.Windows.Forms.DateTimePicker()
        Me.rv_Void = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.pnl_refund_Right = New System.Windows.Forms.Panel()
        Me.pnl_refund_Left = New System.Windows.Forms.Panel()
        Me.pnl_refund_Bottom = New System.Windows.Forms.Panel()
        Me.pnl_transac_Top = New System.Windows.Forms.Panel()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.Panel5.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.pnl_transac_Top.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(401, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Date To:"
        '
        'dtp_credit_To
        '
        Me.dtp_credit_To.CustomFormat = "MM/dd/yyyy"
        Me.dtp_credit_To.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_credit_To.Location = New System.Drawing.Point(480, 14)
        Me.dtp_credit_To.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dtp_credit_To.Name = "dtp_credit_To"
        Me.dtp_credit_To.Size = New System.Drawing.Size(275, 26)
        Me.dtp_credit_To.TabIndex = 21
        Me.dtp_credit_To.Value = New Date(2020, 3, 21, 0, 0, 0, 0)
        '
        'btn_load_credit_Report
        '
        Me.btn_load_credit_Report.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.btn_load_credit_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_load_credit_Report.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_load_credit_Report.ForeColor = System.Drawing.Color.White
        Me.btn_load_credit_Report.Location = New System.Drawing.Point(771, 5)
        Me.btn_load_credit_Report.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_load_credit_Report.Name = "btn_load_credit_Report"
        Me.btn_load_credit_Report.Size = New System.Drawing.Size(99, 41)
        Me.btn_load_credit_Report.TabIndex = 20
        Me.btn_load_credit_Report.Text = "Load Report"
        Me.btn_load_credit_Report.UseVisualStyleBackColor = False
        '
        'dtp_credit_From
        '
        Me.dtp_credit_From.CustomFormat = "MM/dd/yyyy"
        Me.dtp_credit_From.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_credit_From.Location = New System.Drawing.Point(109, 14)
        Me.dtp_credit_From.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dtp_credit_From.Name = "dtp_credit_From"
        Me.dtp_credit_From.Size = New System.Drawing.Size(275, 26)
        Me.dtp_credit_From.TabIndex = 18
        Me.dtp_credit_From.Value = New Date(2020, 3, 21, 0, 0, 0, 0)
        '
        'rv_credit_void
        '
        Me.rv_credit_void.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rv_credit_void.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Nothing
        Me.rv_credit_void.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rv_credit_void.LocalReport.ReportEmbeddedResource = "AJE.Report1.rdlc"
        Me.rv_credit_void.Location = New System.Drawing.Point(14, 56)
        Me.rv_credit_void.Margin = New System.Windows.Forms.Padding(2)
        Me.rv_credit_void.Name = "rv_credit_void"
        Me.rv_credit_void.Size = New System.Drawing.Size(888, 197)
        Me.rv_credit_void.TabIndex = 44
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(902, 56)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(11, 197)
        Me.Panel1.TabIndex = 43
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(3, 56)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(11, 197)
        Me.Panel2.TabIndex = 42
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(3, 253)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(910, 10)
        Me.Panel4.TabIndex = 41
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.dtp_credit_To)
        Me.Panel5.Controls.Add(Me.btn_load_credit_Report)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.dtp_credit_From)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(3, 3)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(910, 53)
        Me.Panel5.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 16)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 20)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Date From:"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.rv_credit_void)
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Controls.Add(Me.Panel4)
        Me.TabPage2.Controls.Add(Me.Panel5)
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(916, 266)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Voided Credit Sales"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(401, 16)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 20)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Date To:"
        '
        'dtp_void_To
        '
        Me.dtp_void_To.CustomFormat = "MM/dd/yyyy"
        Me.dtp_void_To.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_void_To.Location = New System.Drawing.Point(480, 14)
        Me.dtp_void_To.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dtp_void_To.Name = "dtp_void_To"
        Me.dtp_void_To.Size = New System.Drawing.Size(275, 26)
        Me.dtp_void_To.TabIndex = 21
        Me.dtp_void_To.Value = New Date(2020, 3, 21, 0, 0, 0, 0)
        '
        'btn_load_void_Report
        '
        Me.btn_load_void_Report.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.btn_load_void_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_load_void_Report.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_load_void_Report.ForeColor = System.Drawing.Color.White
        Me.btn_load_void_Report.Location = New System.Drawing.Point(771, 5)
        Me.btn_load_void_Report.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_load_void_Report.Name = "btn_load_void_Report"
        Me.btn_load_void_Report.Size = New System.Drawing.Size(99, 41)
        Me.btn_load_void_Report.TabIndex = 20
        Me.btn_load_void_Report.Text = "Load Report"
        Me.btn_load_void_Report.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(11, 16)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(89, 20)
        Me.Label19.TabIndex = 19
        Me.Label19.Text = "Date From:"
        '
        'dtp_void_From
        '
        Me.dtp_void_From.CustomFormat = "MM/dd/yyyy"
        Me.dtp_void_From.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_void_From.Location = New System.Drawing.Point(109, 14)
        Me.dtp_void_From.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dtp_void_From.Name = "dtp_void_From"
        Me.dtp_void_From.Size = New System.Drawing.Size(275, 26)
        Me.dtp_void_From.TabIndex = 18
        Me.dtp_void_From.Value = New Date(2020, 3, 21, 0, 0, 0, 0)
        '
        'rv_Void
        '
        Me.rv_Void.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rv_Void.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Nothing
        Me.rv_Void.LocalReport.DataSources.Add(ReportDataSource2)
        Me.rv_Void.LocalReport.ReportEmbeddedResource = "AJE.Report1.rdlc"
        Me.rv_Void.Location = New System.Drawing.Point(14, 56)
        Me.rv_Void.Margin = New System.Windows.Forms.Padding(2)
        Me.rv_Void.Name = "rv_Void"
        Me.rv_Void.Size = New System.Drawing.Size(888, 197)
        Me.rv_Void.TabIndex = 39
        '
        'pnl_refund_Right
        '
        Me.pnl_refund_Right.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnl_refund_Right.Location = New System.Drawing.Point(902, 56)
        Me.pnl_refund_Right.Margin = New System.Windows.Forms.Padding(2)
        Me.pnl_refund_Right.Name = "pnl_refund_Right"
        Me.pnl_refund_Right.Size = New System.Drawing.Size(11, 197)
        Me.pnl_refund_Right.TabIndex = 38
        '
        'pnl_refund_Left
        '
        Me.pnl_refund_Left.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl_refund_Left.Location = New System.Drawing.Point(3, 56)
        Me.pnl_refund_Left.Margin = New System.Windows.Forms.Padding(2)
        Me.pnl_refund_Left.Name = "pnl_refund_Left"
        Me.pnl_refund_Left.Size = New System.Drawing.Size(11, 197)
        Me.pnl_refund_Left.TabIndex = 37
        '
        'pnl_refund_Bottom
        '
        Me.pnl_refund_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_refund_Bottom.Location = New System.Drawing.Point(3, 253)
        Me.pnl_refund_Bottom.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnl_refund_Bottom.Name = "pnl_refund_Bottom"
        Me.pnl_refund_Bottom.Size = New System.Drawing.Size(910, 10)
        Me.pnl_refund_Bottom.TabIndex = 36
        '
        'pnl_transac_Top
        '
        Me.pnl_transac_Top.Controls.Add(Me.Label2)
        Me.pnl_transac_Top.Controls.Add(Me.dtp_void_To)
        Me.pnl_transac_Top.Controls.Add(Me.btn_load_void_Report)
        Me.pnl_transac_Top.Controls.Add(Me.Label19)
        Me.pnl_transac_Top.Controls.Add(Me.dtp_void_From)
        Me.pnl_transac_Top.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_transac_Top.Location = New System.Drawing.Point(3, 3)
        Me.pnl_transac_Top.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnl_transac_Top.Name = "pnl_transac_Top"
        Me.pnl_transac_Top.Size = New System.Drawing.Size(910, 53)
        Me.pnl_transac_Top.TabIndex = 35
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.rv_Void)
        Me.TabPage1.Controls.Add(Me.pnl_refund_Right)
        Me.TabPage1.Controls.Add(Me.pnl_refund_Left)
        Me.TabPage1.Controls.Add(Me.pnl_refund_Bottom)
        Me.TabPage1.Controls.Add(Me.pnl_transac_Top)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(916, 266)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Voided Cash Sales"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 36)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(924, 295)
        Me.TabControl1.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(9, 7)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 18)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Void Report"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btn_Close)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(924, 36)
        Me.Panel3.TabIndex = 24
        '
        'btn_Close
        '
        Me.btn_Close.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Close.ForeColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btn_Close.Image = CType(resources.GetObject("btn_Close.Image"), System.Drawing.Image)
        Me.btn_Close.Location = New System.Drawing.Point(885, 0)
        Me.btn_Close.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(39, 36)
        Me.btn_Close.TabIndex = 54
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'frmVoidReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 331)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmVoidReport"
        Me.Text = "frmVoidReport"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.pnl_transac_Top.ResumeLayout(False)
        Me.pnl_transac_Top.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dtp_credit_To As DateTimePicker
    Friend WithEvents btn_load_credit_Report As Button
    Friend WithEvents dtp_credit_From As DateTimePicker
    Friend WithEvents rv_credit_void As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents dtp_void_To As DateTimePicker
    Friend WithEvents btn_load_void_Report As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents dtp_void_From As DateTimePicker
    Friend WithEvents rv_Void As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents pnl_refund_Right As Panel
    Friend WithEvents pnl_refund_Left As Panel
    Friend WithEvents pnl_refund_Bottom As Panel
    Friend WithEvents pnl_transac_Top As Panel
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents btn_Close As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
End Class

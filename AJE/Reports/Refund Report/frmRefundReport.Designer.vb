<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRefundReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRefundReport))
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnl_transac_Top = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtp_refund_To = New System.Windows.Forms.DateTimePicker()
        Me.btn_load_refund_Report = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.dtp_refund_From = New System.Windows.Forms.DateTimePicker()
        Me.rv_Refund = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.pnl_refund_Right = New System.Windows.Forms.Panel()
        Me.pnl_refund_Left = New System.Windows.Forms.Panel()
        Me.pnl_refund_Bottom = New System.Windows.Forms.Panel()
        Me.Panel3.SuspendLayout()
        Me.pnl_transac_Top.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btn_Close)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1522, 55)
        Me.Panel3.TabIndex = 22
        '
        'btn_Close
        '
        Me.btn_Close.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Close.ForeColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btn_Close.Image = CType(resources.GetObject("btn_Close.Image"), System.Drawing.Image)
        Me.btn_Close.Location = New System.Drawing.Point(1464, 0)
        Me.btn_Close.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(58, 55)
        Me.btn_Close.TabIndex = 54
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(14, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 26)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Refund Report"
        '
        'pnl_transac_Top
        '
        Me.pnl_transac_Top.Controls.Add(Me.Label2)
        Me.pnl_transac_Top.Controls.Add(Me.dtp_refund_To)
        Me.pnl_transac_Top.Controls.Add(Me.btn_load_refund_Report)
        Me.pnl_transac_Top.Controls.Add(Me.Label19)
        Me.pnl_transac_Top.Controls.Add(Me.dtp_refund_From)
        Me.pnl_transac_Top.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_transac_Top.Location = New System.Drawing.Point(0, 55)
        Me.pnl_transac_Top.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnl_transac_Top.Name = "pnl_transac_Top"
        Me.pnl_transac_Top.Size = New System.Drawing.Size(1522, 81)
        Me.pnl_transac_Top.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(602, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 29)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Date To:"
        '
        'dtp_refund_To
        '
        Me.dtp_refund_To.CustomFormat = "MM/dd/yyyy"
        Me.dtp_refund_To.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_refund_To.Location = New System.Drawing.Point(720, 22)
        Me.dtp_refund_To.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtp_refund_To.Name = "dtp_refund_To"
        Me.dtp_refund_To.Size = New System.Drawing.Size(410, 35)
        Me.dtp_refund_To.TabIndex = 21
        Me.dtp_refund_To.Value = New Date(2020, 3, 21, 0, 0, 0, 0)
        '
        'btn_load_refund_Report
        '
        Me.btn_load_refund_Report.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.btn_load_refund_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_load_refund_Report.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_load_refund_Report.ForeColor = System.Drawing.Color.White
        Me.btn_load_refund_Report.Location = New System.Drawing.Point(1156, 8)
        Me.btn_load_refund_Report.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_load_refund_Report.Name = "btn_load_refund_Report"
        Me.btn_load_refund_Report.Size = New System.Drawing.Size(148, 63)
        Me.btn_load_refund_Report.TabIndex = 20
        Me.btn_load_refund_Report.Text = "Load Report"
        Me.btn_load_refund_Report.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(17, 24)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(132, 29)
        Me.Label19.TabIndex = 19
        Me.Label19.Text = "Date From:"
        '
        'dtp_refund_From
        '
        Me.dtp_refund_From.CustomFormat = "MM/dd/yyyy"
        Me.dtp_refund_From.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_refund_From.Location = New System.Drawing.Point(163, 22)
        Me.dtp_refund_From.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtp_refund_From.Name = "dtp_refund_From"
        Me.dtp_refund_From.Size = New System.Drawing.Size(411, 35)
        Me.dtp_refund_From.TabIndex = 18
        Me.dtp_refund_From.Value = New Date(2020, 3, 21, 0, 0, 0, 0)
        '
        'rv_Refund
        '
        Me.rv_Refund.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Nothing
        Me.rv_Refund.LocalReport.DataSources.Add(ReportDataSource2)
        Me.rv_Refund.LocalReport.ReportEmbeddedResource = "AJE.Report1.rdlc"
        Me.rv_Refund.Location = New System.Drawing.Point(16, 136)
        Me.rv_Refund.Name = "rv_Refund"
        Me.rv_Refund.Size = New System.Drawing.Size(1490, 358)
        Me.rv_Refund.TabIndex = 34
        '
        'pnl_refund_Right
        '
        Me.pnl_refund_Right.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnl_refund_Right.Location = New System.Drawing.Point(1506, 136)
        Me.pnl_refund_Right.Name = "pnl_refund_Right"
        Me.pnl_refund_Right.Size = New System.Drawing.Size(16, 358)
        Me.pnl_refund_Right.TabIndex = 33
        '
        'pnl_refund_Left
        '
        Me.pnl_refund_Left.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl_refund_Left.Location = New System.Drawing.Point(0, 136)
        Me.pnl_refund_Left.Name = "pnl_refund_Left"
        Me.pnl_refund_Left.Size = New System.Drawing.Size(16, 358)
        Me.pnl_refund_Left.TabIndex = 32
        '
        'pnl_refund_Bottom
        '
        Me.pnl_refund_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_refund_Bottom.Location = New System.Drawing.Point(0, 494)
        Me.pnl_refund_Bottom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnl_refund_Bottom.Name = "pnl_refund_Bottom"
        Me.pnl_refund_Bottom.Size = New System.Drawing.Size(1522, 16)
        Me.pnl_refund_Bottom.TabIndex = 31
        '
        'frmRefundReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1522, 510)
        Me.Controls.Add(Me.rv_Refund)
        Me.Controls.Add(Me.pnl_refund_Right)
        Me.Controls.Add(Me.pnl_refund_Left)
        Me.Controls.Add(Me.pnl_refund_Bottom)
        Me.Controls.Add(Me.pnl_transac_Top)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRefundReport"
        Me.Text = "frmRefundReport"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.pnl_transac_Top.ResumeLayout(False)
        Me.pnl_transac_Top.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_Close As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents pnl_transac_Top As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents dtp_refund_To As DateTimePicker
    Friend WithEvents btn_load_refund_Report As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents dtp_refund_From As DateTimePicker
    Friend WithEvents rv_Refund As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents pnl_refund_Right As Panel
    Friend WithEvents pnl_refund_Left As Panel
    Friend WithEvents pnl_refund_Bottom As Panel
End Class

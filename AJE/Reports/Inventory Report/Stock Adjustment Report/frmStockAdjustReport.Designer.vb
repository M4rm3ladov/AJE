<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockAdjustReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockAdjustReport))
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rv_stock_Adjust = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.pnl_transac_Right = New System.Windows.Forms.Panel()
        Me.pnl_transac_Left = New System.Windows.Forms.Panel()
        Me.pnl_transac_Bottom = New System.Windows.Forms.Panel()
        Me.pnl_transac_Top = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtp_stock_adjust_To = New System.Windows.Forms.DateTimePicker()
        Me.btn_load_stock_adjust_Report = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.dtp_stock_adjust_From = New System.Windows.Forms.DateTimePicker()
        Me.Panel1.SuspendLayout()
        Me.pnl_transac_Top.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_Close)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(924, 36)
        Me.Panel1.TabIndex = 16
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
        Me.btn_Close.TabIndex = 55
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(9, 7)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Stock Adjustment Report"
        '
        'rv_stock_Adjust
        '
        Me.rv_stock_Adjust.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Nothing
        Me.rv_stock_Adjust.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rv_stock_Adjust.LocalReport.ReportEmbeddedResource = "AJE.Report1.rdlc"
        Me.rv_stock_Adjust.Location = New System.Drawing.Point(11, 88)
        Me.rv_stock_Adjust.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rv_stock_Adjust.Name = "rv_stock_Adjust"
        Me.rv_stock_Adjust.Size = New System.Drawing.Size(902, 397)
        Me.rv_stock_Adjust.TabIndex = 43
        '
        'pnl_transac_Right
        '
        Me.pnl_transac_Right.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnl_transac_Right.Location = New System.Drawing.Point(913, 88)
        Me.pnl_transac_Right.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnl_transac_Right.Name = "pnl_transac_Right"
        Me.pnl_transac_Right.Size = New System.Drawing.Size(11, 397)
        Me.pnl_transac_Right.TabIndex = 42
        '
        'pnl_transac_Left
        '
        Me.pnl_transac_Left.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl_transac_Left.Location = New System.Drawing.Point(0, 88)
        Me.pnl_transac_Left.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnl_transac_Left.Name = "pnl_transac_Left"
        Me.pnl_transac_Left.Size = New System.Drawing.Size(11, 397)
        Me.pnl_transac_Left.TabIndex = 41
        '
        'pnl_transac_Bottom
        '
        Me.pnl_transac_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_transac_Bottom.Location = New System.Drawing.Point(0, 485)
        Me.pnl_transac_Bottom.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnl_transac_Bottom.Name = "pnl_transac_Bottom"
        Me.pnl_transac_Bottom.Size = New System.Drawing.Size(924, 10)
        Me.pnl_transac_Bottom.TabIndex = 40
        '
        'pnl_transac_Top
        '
        Me.pnl_transac_Top.Controls.Add(Me.Label2)
        Me.pnl_transac_Top.Controls.Add(Me.dtp_stock_adjust_To)
        Me.pnl_transac_Top.Controls.Add(Me.btn_load_stock_adjust_Report)
        Me.pnl_transac_Top.Controls.Add(Me.Label19)
        Me.pnl_transac_Top.Controls.Add(Me.dtp_stock_adjust_From)
        Me.pnl_transac_Top.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_transac_Top.Location = New System.Drawing.Point(0, 36)
        Me.pnl_transac_Top.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnl_transac_Top.Name = "pnl_transac_Top"
        Me.pnl_transac_Top.Size = New System.Drawing.Size(924, 52)
        Me.pnl_transac_Top.TabIndex = 39
        Me.pnl_transac_Top.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(407, 16)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 20)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Date To:"
        '
        'dtp_stock_adjust_To
        '
        Me.dtp_stock_adjust_To.CustomFormat = "MM/dd/yyyy"
        Me.dtp_stock_adjust_To.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_stock_adjust_To.Location = New System.Drawing.Point(485, 14)
        Me.dtp_stock_adjust_To.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dtp_stock_adjust_To.Name = "dtp_stock_adjust_To"
        Me.dtp_stock_adjust_To.Size = New System.Drawing.Size(275, 26)
        Me.dtp_stock_adjust_To.TabIndex = 21
        Me.dtp_stock_adjust_To.Value = New Date(2020, 3, 21, 0, 0, 0, 0)
        '
        'btn_load_stock_adjust_Report
        '
        Me.btn_load_stock_adjust_Report.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.btn_load_stock_adjust_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_load_stock_adjust_Report.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_load_stock_adjust_Report.ForeColor = System.Drawing.Color.White
        Me.btn_load_stock_adjust_Report.Location = New System.Drawing.Point(780, 5)
        Me.btn_load_stock_adjust_Report.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_load_stock_adjust_Report.Name = "btn_load_stock_adjust_Report"
        Me.btn_load_stock_adjust_Report.Size = New System.Drawing.Size(99, 41)
        Me.btn_load_stock_adjust_Report.TabIndex = 20
        Me.btn_load_stock_adjust_Report.Text = "Load Report"
        Me.btn_load_stock_adjust_Report.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(17, 16)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(89, 20)
        Me.Label19.TabIndex = 19
        Me.Label19.Text = "Date From:"
        '
        'dtp_stock_adjust_From
        '
        Me.dtp_stock_adjust_From.CustomFormat = "MM/dd/yyyy"
        Me.dtp_stock_adjust_From.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_stock_adjust_From.Location = New System.Drawing.Point(114, 14)
        Me.dtp_stock_adjust_From.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dtp_stock_adjust_From.Name = "dtp_stock_adjust_From"
        Me.dtp_stock_adjust_From.Size = New System.Drawing.Size(275, 26)
        Me.dtp_stock_adjust_From.TabIndex = 18
        Me.dtp_stock_adjust_From.Value = New Date(2020, 3, 21, 0, 0, 0, 0)
        '
        'frmStockAdjustReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 495)
        Me.Controls.Add(Me.rv_stock_Adjust)
        Me.Controls.Add(Me.pnl_transac_Right)
        Me.Controls.Add(Me.pnl_transac_Left)
        Me.Controls.Add(Me.pnl_transac_Bottom)
        Me.Controls.Add(Me.pnl_transac_Top)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmStockAdjustReport"
        Me.Text = "frmStockAdjustReport"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnl_transac_Top.ResumeLayout(False)
        Me.pnl_transac_Top.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_Close As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents rv_stock_Adjust As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents pnl_transac_Right As Panel
    Friend WithEvents pnl_transac_Left As Panel
    Friend WithEvents pnl_transac_Bottom As Panel
    Friend WithEvents pnl_transac_Top As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents dtp_stock_adjust_To As DateTimePicker
    Friend WithEvents btn_load_stock_adjust_Report As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents dtp_stock_adjust_From As DateTimePicker
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Per_Harga_Makanan
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btn_tampilkan = New System.Windows.Forms.Button()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.CrystalReport11 = New Sistem_Informasi_Restoran.CrystalReport1()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Report_Per_Harga_Makanan1 = New Sistem_Informasi_Restoran.Report_Per_Harga_Makanan()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(136, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(437, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Report Per Harga Makanan"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(235, 63)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(113, 20)
        Me.TextBox1.TabIndex = 2
        '
        'btn_tampilkan
        '
        Me.btn_tampilkan.Location = New System.Drawing.Point(370, 58)
        Me.btn_tampilkan.Name = "btn_tampilkan"
        Me.btn_tampilkan.Size = New System.Drawing.Size(81, 29)
        Me.btn_tampilkan.TabIndex = 3
        Me.btn_tampilkan.Text = "TAMPILKAN"
        Me.btn_tampilkan.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(12, 93)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.Report_Per_Harga_Makanan1
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(689, 272)
        Me.CrystalReportViewer1.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(457, 58)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 29)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "belum jalan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Per_Harga_Makanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 377)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.btn_tampilkan)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Per_Harga_Makanan"
        Me.Text = "Report Per Harga Makanan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btn_tampilkan As Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Report_Per_Harga_Makanan1 As Report_Per_Harga_Makanan
    Friend WithEvents Button1 As Button
    Friend WithEvents CrystalReport11 As CrystalReport1
End Class

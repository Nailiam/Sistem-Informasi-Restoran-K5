<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main_Menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Menu))
        Me.btnexit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataKaryawanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPelangganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataKasirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetailTransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportDataMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportDataPelanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportPeriodikTransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportBerdasarkanHargaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportCobaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnexit
        '
        Me.btnexit.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(589, 357)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 30)
        Me.btnexit.TabIndex = 11
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(133, 138)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(442, 203)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(122, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(490, 65)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Sistem Informasi "
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 28)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(697, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.LaporanToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.ReportToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(697, 28)
        Me.MenuStrip2.TabIndex = 8
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataKaryawanToolStripMenuItem, Me.DataMenuToolStripMenuItem})
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(107, 24)
        Me.ToolStripMenuItem1.Text = "Input Data "
        '
        'DataKaryawanToolStripMenuItem
        '
        Me.DataKaryawanToolStripMenuItem.Name = "DataKaryawanToolStripMenuItem"
        Me.DataKaryawanToolStripMenuItem.Size = New System.Drawing.Size(198, 24)
        Me.DataKaryawanToolStripMenuItem.Text = "Data Karyawan "
        '
        'DataMenuToolStripMenuItem
        '
        Me.DataMenuToolStripMenuItem.Name = "DataMenuToolStripMenuItem"
        Me.DataMenuToolStripMenuItem.Size = New System.Drawing.Size(198, 24)
        Me.DataMenuToolStripMenuItem.Text = "Data Menu"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataPelangganToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(88, 24)
        Me.LaporanToolStripMenuItem.Text = "Laporan "
        '
        'DataPelangganToolStripMenuItem
        '
        Me.DataPelangganToolStripMenuItem.Name = "DataPelangganToolStripMenuItem"
        Me.DataPelangganToolStripMenuItem.Size = New System.Drawing.Size(202, 24)
        Me.DataPelangganToolStripMenuItem.Text = "Data Pelanggan "
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataKasirToolStripMenuItem, Me.DetailTransaksiToolStripMenuItem, Me.TransaksiToolStripMenuItem1})
        Me.TransaksiToolStripMenuItem.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(99, 24)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi "
        '
        'DataKasirToolStripMenuItem
        '
        Me.DataKasirToolStripMenuItem.Name = "DataKasirToolStripMenuItem"
        Me.DataKasirToolStripMenuItem.Size = New System.Drawing.Size(201, 24)
        Me.DataKasirToolStripMenuItem.Text = "Data Kasir"
        '
        'DetailTransaksiToolStripMenuItem
        '
        Me.DetailTransaksiToolStripMenuItem.Name = "DetailTransaksiToolStripMenuItem"
        Me.DetailTransaksiToolStripMenuItem.Size = New System.Drawing.Size(201, 24)
        Me.DetailTransaksiToolStripMenuItem.Text = "Detail Transaksi"
        '
        'TransaksiToolStripMenuItem1
        '
        Me.TransaksiToolStripMenuItem1.Name = "TransaksiToolStripMenuItem1"
        Me.TransaksiToolStripMenuItem1.Size = New System.Drawing.Size(201, 24)
        Me.TransaksiToolStripMenuItem1.Text = "Transaksi"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportDataMenuToolStripMenuItem, Me.ReportDataPelanToolStripMenuItem, Me.ReportPeriodikTransaksiToolStripMenuItem, Me.ReportBerdasarkanHargaToolStripMenuItem, Me.ReportCobaToolStripMenuItem})
        Me.ReportToolStripMenuItem.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(71, 24)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'ReportDataMenuToolStripMenuItem
        '
        Me.ReportDataMenuToolStripMenuItem.Name = "ReportDataMenuToolStripMenuItem"
        Me.ReportDataMenuToolStripMenuItem.Size = New System.Drawing.Size(279, 24)
        Me.ReportDataMenuToolStripMenuItem.Text = "Report Data Menu"
        '
        'ReportDataPelanToolStripMenuItem
        '
        Me.ReportDataPelanToolStripMenuItem.Name = "ReportDataPelanToolStripMenuItem"
        Me.ReportDataPelanToolStripMenuItem.Size = New System.Drawing.Size(279, 24)
        Me.ReportDataPelanToolStripMenuItem.Text = "Report Data Pelanggan"
        '
        'ReportPeriodikTransaksiToolStripMenuItem
        '
        Me.ReportPeriodikTransaksiToolStripMenuItem.Name = "ReportPeriodikTransaksiToolStripMenuItem"
        Me.ReportPeriodikTransaksiToolStripMenuItem.Size = New System.Drawing.Size(279, 24)
        Me.ReportPeriodikTransaksiToolStripMenuItem.Text = "Report Periodik Transaksi"
        '
        'ReportBerdasarkanHargaToolStripMenuItem
        '
        Me.ReportBerdasarkanHargaToolStripMenuItem.Name = "ReportBerdasarkanHargaToolStripMenuItem"
        Me.ReportBerdasarkanHargaToolStripMenuItem.Size = New System.Drawing.Size(279, 24)
        Me.ReportBerdasarkanHargaToolStripMenuItem.Text = "Report Berdasarkan Harga"
        '
        'ReportCobaToolStripMenuItem
        '
        Me.ReportCobaToolStripMenuItem.Name = "ReportCobaToolStripMenuItem"
        Me.ReportCobaToolStripMenuItem.Size = New System.Drawing.Size(279, 24)
        Me.ReportCobaToolStripMenuItem.Text = "Report Coba"
        '
        'Main_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 399)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Name = "Main_Menu"
        Me.Text = "Main Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnexit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DataKaryawanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataPelangganToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataKasirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportDataMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportDataPelanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportPeriodikTransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportBerdasarkanHargaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportCobaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DetailTransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem1 As ToolStripMenuItem
End Class

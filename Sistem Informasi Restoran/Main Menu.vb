Public Class Main_Menu
    Private Sub DataKaryawanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataKaryawanToolStripMenuItem.Click
        Data_Karyawan.Show()
    End Sub

    Private Sub DataMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataMenuToolStripMenuItem.Click
        Data_Menu.Show()
    End Sub

    Private Sub DataPelangganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataPelangganToolStripMenuItem.Click
        Pelanggan.Show()
    End Sub

    Private Sub DataKasirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataKasirToolStripMenuItem.Click
        Kasir.Show()
    End Sub

    Private Sub DataPembayaranToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataPembayaranToolStripMenuItem.Click
        Transaksi.Show()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub TransaksiToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TransaksiToolStripMenuItem1.Click
        Transaksi.Show()
    End Sub

    Private Sub ReportDataMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportDataMenuToolStripMenuItem.Click
        Form_Report_Data_Menu.Show()
    End Sub

    Private Sub ReportDataPelanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportDataPelanToolStripMenuItem.Click
        Form_Report_Data_Pelanggan.Show()
    End Sub

    Private Sub ReportPeriodikTransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportPeriodikTransaksiToolStripMenuItem.Click
        Interval_Tanggal.Show()
    End Sub

    Private Sub ReportBerdasarkanHargaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportBerdasarkanHargaToolStripMenuItem.Click
        Interval_Harga.Show()
    End Sub

    Private Sub ReportCobaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportCobaToolStripMenuItem.Click
        Form_Report_Coba.Show()
    End Sub
End Class
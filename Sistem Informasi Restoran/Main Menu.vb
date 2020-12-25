﻿Public Class Main_Menu
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

    Private Sub ReportPeriodikTransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportPeriodikTransaksiToolStripMenuItem.Click
        Report_Data_Pelanggan.Show()
    End Sub

    Private Sub ReportTransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportTransaksiToolStripMenuItem.Click
        Report_Data_Makanan.Show()
    End Sub

    Private Sub ReportDataMinumanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportDataMinumanToolStripMenuItem.Click
        Report_Data_Minuman.Show()
    End Sub

    Private Sub ReportPeriodikTransaksiToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ReportPeriodikTransaksiToolStripMenuItem1.Click
        Cetak_Laporan_Periodik.Show()
    End Sub

    Private Sub ReportPerHargaMakananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportPerHargaMakananToolStripMenuItem.Click
        Per_Harga_Makanan.Show()
    End Sub

    Private Sub TransaksiToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TransaksiToolStripMenuItem1.Click
        Transaksi.Show()
    End Sub

End Class
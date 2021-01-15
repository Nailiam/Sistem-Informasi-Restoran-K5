Public Class Main_Menu
    Private Sub DataKaryawanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataKaryawanToolStripMenuItem.Click
        Data_Karyawan.Show() 'ok
    End Sub
    Private Sub DataMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataMenuToolStripMenuItem.Click
        Data_Menu.Show() 'ok
    End Sub
    Private Sub TransaksiToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles TransaksiToolStripMenuItem1.Click
        Transaksi.Show() 'ok
    End Sub
    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub ReportDataMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportDataMenuToolStripMenuItem.Click
        Form_Report_Data_Menu.Show() 'ok
    End Sub

    Private Sub ReportDataPelanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportDataPelanToolStripMenuItem.Click
        Form_Report_Data_Pelanggan.Show() 'ok
    End Sub

    Private Sub ReportPeriodikTransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportPeriodikTransaksiToolStripMenuItem.Click
        Interval_Tanggal.Show() 'ok
    End Sub

    Private Sub ReportBerdasarkanHargaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportBerdasarkanHargaToolStripMenuItem.Click
        Interval_Harga.Show() 'ok
    End Sub

    Private Sub ReportCobaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportCobaToolStripMenuItem.Click
        Form_Report_Coba.Show() 'ok
    End Sub

    Private Sub DataPelangganToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DataPelangganToolStripMenuItem1.Click
        Pelanggan.Show() 'ok
    End Sub

    Private Sub DataKasirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DataKasirToolStripMenuItem1.Click
        Kasir.Show() 'ok
    End Sub

    Private Sub IDCardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IDCardToolStripMenuItem.Click
        Cari_ID_card.Show() 'ok
    End Sub

    Private Sub QRCodeGeneratorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QRCodeGeneratorToolStripMenuItem.Click
        QRCodeGenerator.Show()
    End Sub

    Private Sub ScanReaderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScanReaderToolStripMenuItem.Click
        ScanReader.Show()
    End Sub

    Private Sub BCQRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BCQRToolStripMenuItem.Click
        BCQR_Reader.Show()
    End Sub
End Class
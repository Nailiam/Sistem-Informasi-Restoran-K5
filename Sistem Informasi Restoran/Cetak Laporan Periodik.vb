Public Class Cetak_Laporan_Periodik
    Private Sub btn_tampil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_tampil.Click
        Cetak_Laporan_1.Report_Transaksi2.SetParameterValue("Tanggal_Awal", DateTimePicker1.Value)
        Cetak_Laporan_1.Report_Transaksi2.SetParameterValue("Tanggal_Akhir", DateTimePicker2.Value)
        Cetak_Laporan_1.Show()
    End Sub
End Class
Public Class Interval_Tanggal
    Private Sub btn_tampil_Click(sender As Object, e As EventArgs) Handles btn_tampil.Click
        Form_Report_Periodik_Transaksi.Report_Transaksi_New1.SetParameterValue("Tanggal_Awal", DateTimePicker1.Value)
        Form_Report_Periodik_Transaksi.Report_Transaksi_New1.SetParameterValue("Tanggal_Akhir", DateTimePicker2.Value)
        Form_Report_Periodik_Transaksi.Show()
    End Sub
End Class
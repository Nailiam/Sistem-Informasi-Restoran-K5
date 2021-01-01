Public Class Interval_Harga
    Private Sub btn_tampil_Click(sender As Object, e As EventArgs) Handles btn_tampil.Click
        Form_Report_Berdasarkan_Harga.Report_Berdasarkan_Harga1.SetParameterValue("Harga Dimulai Dari", CInt(TextBox1.Text))
        Form_Report_Berdasarkan_Harga.Show()
    End Sub
End Class
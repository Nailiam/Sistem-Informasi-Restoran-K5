Public Class Per_Harga_Makanan
    Private Sub btn_tampilkan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_tampilkan.Click
        CrystalReportViewer1.SelectionFormula = "totext ({Menu_Makanan.Harga_Makanan})= ' " & TextBox1.Text & "'"
        CrystalReportViewer1.ReportSource = Nothing
        CrystalReportViewer1.RefreshReport()
        CrystalReportViewer1.ReportSource = Report_Per_Harga_Makanan1
        CrystalReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Report_Per_Harga_Makanan1.SetParameterValue("Harga Mulai Dari", TextBox1.Text)
    End Sub
End Class
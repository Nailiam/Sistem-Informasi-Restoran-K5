﻿Public Class Per_Harga_Makanan
    Private Sub btn_tampilkan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_tampilkan.Click
        CrystalReportViewer1.SelectionFormula = "totext ({Menu_Makanan.Harga_Makanan})= ' " & TextBox1.Text & "'"
        CrystalReportViewer1.ReportSource = Nothing
        CrystalReportViewer1.RefreshReport()
        CrystalReportViewer1.ReportSource = CrystalReport11
        CrystalReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Report_Per_Harga_Makanan1.SetParameterValue("Harga Mulai Dari", CStr(TextBox1.Text))
    End Sub
End Class
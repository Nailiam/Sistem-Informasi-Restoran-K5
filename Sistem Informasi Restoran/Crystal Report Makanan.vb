Public Class Crystal_Report_Makanan
    Private Sub Crystal_Report_Makanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrystalReport1.rpt.show()
    End Sub

    Private Sub btn_open_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_open.Click
        With CrystalReport1.reportfilename = App.Path & "\Report Data Makanan.rpt".connect = app.path & "dbpegawai.mdb".discardsaveddata = True
        End With
    End Sub
End Class
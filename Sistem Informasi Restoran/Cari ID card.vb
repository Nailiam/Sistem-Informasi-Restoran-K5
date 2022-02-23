Public Class Cari_ID_card
    Private Sub cari_Click(sender As Object, e As EventArgs) Handles cari.Click
        Form_ID_Card.Crystal_Report_ID_Card1.SetParameterValue("ID Kasir", (TextBox1.Text))
        Form_ID_Card.Show()
        Me.Close()
    End Sub
End Class
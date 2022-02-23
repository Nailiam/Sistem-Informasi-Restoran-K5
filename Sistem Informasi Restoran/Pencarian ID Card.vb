Public Class Pencarian_ID_Card
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ID_Card.Report_ID_card1.SetParameterValue("ID Kasir", (TextBox1.Text))
        ID_Card.Show()
    End Sub
End Class
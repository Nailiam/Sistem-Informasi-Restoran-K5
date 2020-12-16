Public Class Transaksi
    Private Sub txt_Kode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Kode.KeyPress
        If e.KeyChar = Chr(13) Then
            'Chr(13) itu Tombol ENTER
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand("Select * from Makanan & Minuman where Kode ='" & txt_Kode.Text & "'", Conn)
            DM = CMD.ExecuteReader
            DM.Read()
            If Not DM.HasRows Then
                MsgBox("Kode Tidak Ada")
            Else
                txt_Kode.Text = DM.Item("Kode")
                txtnama.Text = DM.Item("Nama")
                txtharga.Text = DM.Item("Harga")
                txtjumlah.Enabled = True
                txtjumlah.Focus()
                'coding txtjumlah.Focus maksudnya ketika tombol Enter dipencet , maka kursor keyboard akan langsung mengarah ke txtjumlah
            End If
        End If
    End Sub


    Sub RumusGrandTotal()
        Dim hitung As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            hitung = hitung + DataGridView1.Rows(i).Cells(4).Value
            txtGrandtotal.Text = hitung
        Next
    End Sub


End Class


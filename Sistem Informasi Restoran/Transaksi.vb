Public Class Transaksi
    Private Sub TransaksiPenjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call kondisiawal()
        Call Nomorfakturotomatis()
    End Sub
    Private Sub txt_Kode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Kodepesanan.KeyPress
        If e.KeyChar = Chr(13) Then
            'Chr(13) itu Tombol ENTER
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand("Select * from Menu where Kode ='" & txt_Kodepesanan.Text & "'", Conn)
            DM = CMD.ExecuteReader
            DM.Read()
            If Not DM.HasRows Then
                MsgBox("Kode Tidak Ada")
            Else
                txt_Kodepesanan.Text = DM.Item("Kode")
                txtnama.Text = DM.Item("Nama")
                txtharga.Text = DM.Item("Harga")
                txtjumlah.Enabled = True
                txtjumlah.Focus()
            End If
        End If
    End Sub

    Sub RumusGrandTotal()
        Dim hitung As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            hitung = hitung + DataGridView1.Rows(i).Cells(5).Value
            txtGrandtotal.Text = hitung
        Next
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Private Sub txtbayar_keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbayar.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(txtbayar.Text) < Val(txtGrandtotal.Text) Then
                MsgBox("Uang Pembayaran Kurang")
            ElseIf Val(txtbayar.Text) = Val(txtGrandtotal.Text) Then
                txtkembali.Text = 0
            ElseIf Val(txtbayar.Text) > Val(txtGrandtotal.Text) Then
                txtkembali.Text = Val(txtbayar.Text) - Val(txtGrandtotal.Text)
                btnCancel.Focus()
            End If
        End If
    End Sub
    Sub kosongkanitem()
        txtkodestruk.Text = ""
        txtidpelanggan.Text = ""
        txtnamapelanggan.Text = ""
        txtnomeja.Text = ""
    End Sub
    Sub kondisiawal()
        txttgltransaksi.Text = Today
        txtjamtransaksi.Text = TimeOfDay
        txtkasir.Text = Login.txtUN.Text
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        txtjamtransaksi.Text = TimeOfDay
    End Sub
    Private Sub txtjumlah_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtjumlah.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtnama.Text = "" Or txtharga.Text = "" Or txtpajak.Text = "" Then
                MsgBox("Masukkan Kode Kode Barang dan tekan enter ")
            Else
                DataGridView1.Rows.Add(New String() {txt_Kodepesanan.Text,
                 txtnama.Text, txtharga.Text, txtjumlah.Text, Val(txtharga.Text) * Val(txtjumlah.Text) * Val(txtpajak.Text), Val(txtharga.Text) * Val(txtjumlah.Text) + Val(txtharga.Text) * Val(txtjumlah.Text) * Val(txtpajak.Text)})
                Call RumusGrandTotal()
                Call kosongkanitem()
                txt_Kodepesanan.Focus()
                Call carijumlahitem()
            End If
        End If
    End Sub

    Sub Nomorfakturotomatis()
        Call koneksiDB()
        CMD = New OleDb.OleDbCommand("Select * from Transaksi where Kode_Struk in (select max(Kode_Struk) from Transaksi)", Conn)
        Dim urutankode As String
        Dim hitung As Long
        DM = CMD.ExecuteReader
        DM.Read()

        If Not DM.HasRows Then
            urutankode = "J" + Format(Now, "yyMMdd") + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(DM.GetString(0), 3)
            urutankode = "J" + Format(Now, "yyMMdd") +
           Microsoft.VisualBasic.Right("000" & hitung.ToString, 3)
        End If
        txtkodestruk.Text = urutankode
    End Sub

    Private Sub txtidpelanggan_TextChanged(sender As Object, e As EventArgs) Handles txtidpelanggan.TextChanged
        Try
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand(" select * from Karyawan where id_Kasir ='" & txtkodestruk.Text & "'", Conn)
            DM = CMD.ExecuteReader

            If DM.HasRows = True Then
                DM.Read()
                txtkodestruk.Text = DM.Item("id_Kasir")
                txtnamapelanggan.Text = DM.Item("Nama_Pelanggan")
                txtnomeja.Text = DM.Item("Nomer_Meja")
                txt_Kodepesanan.Focus()
            End If
        Catch ex As Exception
            MsgBox("Data pelanggan tidak ada")
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Call kosongkanitem()
    End Sub
<<<<<<< Updated upstream
    Private Sub txtbayar_TextChanged(sender As Object, e As EventArgs) Handles txtbayar.TextChanged
=======


    Private Sub txtkembali_TextChanged(sender As Object, e As EventArgs) Handles txtkembali.TextChanged
        Kembali.Text = Val(txtGrandtotal.Text) - Val(txtbayar.Text)
    End Sub

    Private Sub txtpajak_TextChanged(sender As Object, e As EventArgs) Handles txtpajak.TextChanged
        Pajak.Text = Val(txtpajak.Text) + Val(txtharga.Text) * 0.1
    End Sub

    Private Sub txtbayar_TextChanged(sender As Object, e As EventArgs) Handles Button1.Click
>>>>>>> Stashed changes
        If Val(txtbayar.Text) < Val(txtGrandtotal.Text) Then
            MsgBox("Uang Pembayaran Kurang")
        ElseIf Val(txtbayar.Text) = Val(txtGrandtotal.Text) Then
            txtkembali.Text = 0
        ElseIf Val(txtbayar.Text) > Val(txtGrandtotal.Text) Then
            txtkembali.Text = Val(txtbayar.Text) - Val(txtGrandtotal.Text)
            btn_save.Focus()
        End If
    End Sub

    Private Sub btn_tutup_Click(sender As Object, e As EventArgs) Handles btn_tutup.Click
        Me.Close()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If txtkembali.Text = "" Or txtGrandtotal.Text = "" Then
            MsgBox("Data Transaksi Belum Lengkap")
            'Pengecekan , apabila transaksi belum terjadi maka tidak bisa di ENTER
        Else
            Dim Simpantransaksi As String = "Insert into Penjualan values ('" &
txtkodestruk.Text & "' , '" & txttgltransaksi.Text & "' , '" & txtjamtransaksi.Text &
"', '" & txtidpelanggan.Text & "', '" & txtnamapelanggan.Text & "', '" & txtitems.Text &
"','" & txtbayar.Text & "','" & txtkembali.Text & "', '" & txtGrandtotal.Text & "')"
            CMD = New OleDb.OleDbCommand(Simpantransaksi, Conn)
            CMD.ExecuteNonQuery()
            'Data disimpan di tabel Penjualan
            For baris As Integer = 0 To DataGridView1.Rows.Count - 2
                Dim Simpandetail As String = "Insert into Detail_jual values ('" &
txtkodestruk.Text & "', '" & DataGridView1.Rows(baris).Cells(0).Value & "', '" &
DataGridView1.Rows(baris).Cells(1).Value & "', '" &
DataGridView1.Rows(baris).Cells(2).Value & "', '" &
DataGridView1.Rows(baris).Cells(3).Value & "', '" &
DataGridView1.Rows(baris).Cells(4).Value & "')"
                CMD = New OleDb.OleDbCommand(Simpandetail, Conn)
                CMD.ExecuteNonQuery()
                CMD = New OleDb.OleDbCommand("select * from Trasaksi where Kode_struk = '" &
DataGridView1.Rows(baris).Cells(0).Value & "'", Conn)
                DM = CMD.ExecuteReader
                DM.Read()
                Dim kurangistok As String = "Update Transaksi set Stok = '" &
DM.Item("Stok") - DataGridView1.Rows(baris).Cells(3).Value & "' where Kode_struk = '" &
DataGridView1.Rows(baris).Cells(0).Value & "'"
                CMD = New OleDb.OleDbCommand(kurangistok, Conn)
                CMD.ExecuteNonQuery()
            Next
            MsgBox("Transaksi Telah Tersimpan")
            Call kondisiawal()
        End If
    End Sub
    Sub carijumlahitem()
        Dim hitungitem As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            hitungitem = hitungitem + DataGridView1.Rows(i).Cells(3).Value
            txtitems.Text = hitungitem
        Next
    End Sub

 

    Private Sub txt_Kodepesanan_TextChanged(sender As Object, e As EventArgs) Handles txt_Kodepesanan.TextChanged

    End Sub
End Class



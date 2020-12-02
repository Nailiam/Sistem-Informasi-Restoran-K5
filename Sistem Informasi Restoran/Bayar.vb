Public Class Bayar
    Private Sub Bayar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MatikanForm()
        Call TampilkanData()
    End Sub


    Sub KosongkanForm()
        txtkodetransaksi.Text = ""
        txtjamtransaksi.Text = ""
        txtidkasir.Text = ""
        txtkodepesanan.Text = ""
        txtsubtotal.Text = ""
        txtpajak.Text = ""
        txttotalbayar.Text = ""
        txtuangbayar.Text = ""
        txtkembalian.Text = ""
        txtfreekembalian.Text = ""
        txttotalkembalian.Text = ""
    End Sub
    Sub MatikanForm()
        txtkodetransaksi.Enabled = False
        txtjamtransaksi.Enabled = False
        txtidkasir.Enabled = False
        txtkodepesanan.Enabled = False
        txtsubtotal.Enabled = False
        txtpajak.Enabled = False
        txttotalbayar.Enabled = False
        txtuangbayar.Enabled = False
        txtkembalian.Enabled = False
        txtfreekembalian.Enabled = False
        txttotalkembalian.Enabled = False
    End Sub
    Sub HidupkanForm()
        txtkodetransaksi.Enabled = True
        txtjamtransaksi.Enabled = True
        txtidkasir.Enabled = True
        txtkodepesanan.Enabled = True
        txtsubtotal.Enabled = True
        txtpajak.Enabled = True
        txttotalbayar.Enabled = True
        txtuangbayar.Enabled = True
        txtkembalian.Enabled = True
        txtfreekembalian.Enabled = True
        txttotalkembalian.Enabled = True
    End Sub
    Sub TampilkanData()
        Call koneksiDB()
        DA = New OleDb.OleDbDataAdapter("select * from Bayar", Conn)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub btninput_Click(sender As Object, e As EventArgs) Handles btninput.Click
        Call HidupkanForm()
        Call KosongkanForm()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Call MatikanForm()
        Call KosongkanForm()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If txtkodetransaksi.Text = "" Or DateTimePicker1.Format = "" Or txtjamtransaksi.Text = "" Or txtidkasir.Text = "" Or
             txtkodepesanan.Text = "" Or txtsubtotal.Text = "" Or txtpajak.Text = "" Or
            txttotalbayar.Text = "" Or txtuangbayar.Text = "" Or txtkembalian.Text = "" Or
            txtfreekembalian.Text = "" Or txttotalkembalian.Text = "" Then
            MsgBox("Data Pembayaran Belum Lengkap")
            Exit Sub
        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand(" select * from Bayar where Kode_Transaksi ='" & txtkodetransaksi.Text & "'", Conn)
            DM = CMD.ExecuteReader
            DM.Read()
            If Not DM.HasRows Then
                Call koneksiDB()
                Dim simpan As String
                simpan = "insert into Bayar values ('" & txtkodetransaksi.Text & "', '" & DateTimePicker1.Value & "',
                '" & txtjamtransaksi.Text & "', '" & txtidkasir.Text & "', '" & txtkodepesanan.Text & "', 
                '" & txtsubtotal.Text & "', '" & txtpajak.Text & "', '" & txttotalbayar.Text & "',
                '" & txtuangbayar.Text & "', '" & txtkembalian.Text & "', '" & txtfreekembalian.Text & "',
                '" & txttotalkembalian.Text & "')"
                CMD = New OleDb.OleDbCommand(simpan, Conn)
                CMD.ExecuteNonQuery()
                MsgBox("Input Data Sukses")
            Else
                MsgBox("Data Sudah Ada")
            End If
            Call MatikanForm()
            Call KosongkanForm()
            Call TampilkanData()
        End If
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        If txtkodetransaksi.Text = "" Or DateTimePicker1.Value = "" Or txtjamtransaksi.Text = "" Or txtidkasir.Text = "" Or
            txtkodepesanan.Text = "" Or txtsubtotal.Text = "" Or txtpajak.Text = "" Or
            txttotalbayar.Text = "" Or txtuangbayar.Text = "" Or txtkembalian.Text = "" Or
            txtfreekembalian.Text = "" Or txttotalkembalian.Text = "" Then
            MsgBox("Data Pembayaran Belum Lengkap")
            Exit Sub
        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand("update Bayar Set Kode_Transaksi = '" & txtkodetransaksi.Text & "', Tanggal_Transaksi = '" & DateTimePicker1.Format & "',
            Jam_Transaksi = '" & txtjamtransaksi.Text & "', Id_Kasir = '" & txtidkasir.Text & "', Kode_Pesanan = '" & txtkodepesanan.Text & "', Sub_Total = '" & txtsubtotal.Text & "',  Paja_Resto 10% = '" & txtpajak.Text & "', Total_Bayar = '" & txttotalbayar.Text & "', Uang_Bayar = '" & txtuangbayar.Text & "', 
            Kembalian = '" & txtkembalian.Text & "', Free_Kembalian = '" & txtfreekembalian.Text & "', Total_Kembalian = '" & txttotalkembalian.Text & "'", Conn)
            DM = CMD.ExecuteReader
            MsgBox("Update Data Berhasil")
        End If
        Call KosongkanForm()
        Call MatikanForm()
        Call TampilkanData()
    End Sub
    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If txtkodetransaksi.Text = "" Then
            MsgBox("Tidak ada data yang dipilih")
            Exit Sub
        Else
            If MessageBox.Show(" Are you sure to delete this data?", "Konfirmasi", MessageBoxButtons.YesNoCancel) Then
                Call koneksiDB()
                CMD = New OleDb.OleDbCommand(" delete from Pesan where Kode_Transaksi = '" & txtkodetransaksi.Text & "'", Conn)
                DM = CMD.ExecuteReader
                MsgBox("Hapus Data Berhasil")
                Call MatikanForm()
                Call KosongkanForm()
                Call TampilkanData()
            Else
                Call KosongkanForm()
                Call TampilkanData()
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        On Error Resume Next
        txtkodetransaksi.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dddd, dd/MM/yyyy"
        DateTimePicker1.Value = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        txtjamtransaksi.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        txtidkasir.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        txtkodepesanan.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        txtsubtotal.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
        txtpajak.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value
        txttotalbayar.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value
        txtuangbayar.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value
        txtkembalian.Text = DataGridView1.Rows(e.RowIndex).Cells(9).Value
        txtfreekembalian.Text = DataGridView1.Rows(e.RowIndex).Cells(10).Value
        txttotalkembalian.Text = DataGridView1.Rows(e.RowIndex).Cells(11).Value
        Call HidupkanForm()
        txtkodetransaksi.Enabled = False
    End Sub

End Class



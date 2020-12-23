Public Class Pesan
    Private Sub Pesan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MatikanForm()
        Call TampilkanData()
    End Sub
    Sub KosongkanForm()
        kode_pemesanan.Text = ""
        Kode_Struk.Text = ""
        ID_Makanan.Text = ""
        ID_Minuman.Text = ""
        jumlah_pemesanan.Text = ""
    End Sub
    Sub MatikanForm()
        kode_pemesanan.Enabled = False
        Kode_Struk.Enabled = False
        DateTimePicker1.Enabled = False
        ID_Makanan.Enabled = False
        ID_Minuman.Enabled = False
        jumlah_pemesanan.Enabled = False
    End Sub
    Sub HidupkanForm()
        kode_pemesanan.Enabled = True
        Kode_Struk.Enabled = True
        DateTimePicker1.Enabled = True
        ID_Makanan.Enabled = True
        ID_Minuman.Enabled = True
        jumlah_pemesanan.Enabled = True
    End Sub
    Sub TampilkanData()
        Call koneksiDB()
        DA = New OleDb.OleDbDataAdapter("select * from Pesan", Conn)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles input.Click
        Call HidupkanForm()
        Call KosongkanForm()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Call MatikanForm()
        Call KosongkanForm()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles save.Click
        If kode_pemesanan.Text = "" Or Kode_Struk.Text = "" Or ID_Makanan.Text = "" Or ID_Minuman.Text = "" Or jumlah_pemesanan.Text = "" Then
            MsgBox("Data Pesanan Belum Lengkap")
            Exit Sub
        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand(" select * from Pesan where kode_Pesanan ='" & kode_pemesanan.Text & "'", Conn)
            DM = CMD.ExecuteReader
            DM.Read()
            If Not DM.HasRows Then
                Call koneksiDB()
                Dim simpan As String
                simpan = "insert into Pesan values ('" & kode_pemesanan.Text & "', '" & Kode_Struk.Text & "', '" & DateTimePicker1.Value & "','" & ID_Makanan.Text & "','" & ID_Minuman.Text & "','" & jumlah_pemesanan.Text & "')"
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles edit.Click
        If kode_pemesanan.Text = "" Or Kode_Struk.Text = "" Or ID_Makanan.Text = "" Or ID_Minuman.Text = "" Or jumlah_pemesanan.Text = "" Then
            MsgBox("Data Pesanan Belum Lengkap")
            Exit Sub
        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand("update Pesan set Kode_Struk = '" & Kode_Struk.Text & "', Tanggal_Pesanan = '" & DateTimePicker1.Value & "', ID_Makanan = '" & ID_Makanan.Text & "', ID_Minuman = '" & ID_Minuman.Text & "',Jumlah_Pesanan = '" & jumlah_pemesanan.Text & "' where kode_Pesanan ='" & kode_pemesanan.Text & "'", Conn)
            DM = CMD.ExecuteReader
            MsgBox("Update Data Berhasil")
        End If
        Call KosongkanForm()
        Call MatikanForm()
        Call TampilkanData()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles delete.Click
        If kode_pemesanan.Text = "" Then
            MsgBox("Tidak ada data yang dipilih")
            Exit Sub
        Else
            If MessageBox.Show(" Are you sure to delete this data?", "Konfirmasi", MessageBoxButtons.YesNoCancel) Then
                Call koneksiDB()
                CMD = New OleDb.OleDbCommand(" delete from Pesan where kode_Pesanan = '" & kode_pemesanan.Text & "'", Conn)
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
        kode_pemesanan.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Kode_Struk.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dddd, dd/MM/yyyy"
        DateTimePicker1.Value = Format(DataGridView1.Rows(e.RowIndex).Cells(2).Value)
        ID_Makanan.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        ID_Minuman.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        jumlah_pemesanan.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
        Call HidupkanForm()
        kode_pemesanan.Enabled = False
    End Sub
End Class
Imports System.Diagnostics.Eventing.Reader

Public Class Data_Karyawan
    Sub KosongkanForm()
        txt_id_karyawan.Text = ""
        txt_nama_karyawan.Text = ""
        txt_lahir.Text = ""
        cmb_jk.Text = ""
        cmb_agama.Text = ""
        txt_hp.Text = ""
        txt_alamat.Text = ""
        cmb_status.Text = ""
        txt_id_karyawan.Focus()
    End Sub
    Sub MatikanForm()
        txt_id_karyawan.Enabled = False
        txt_nama_karyawan.Enabled = False
        txt_lahir.Enabled = False
        DateTimePicker1.Enabled = False
        cmb_jk.Enabled = False
        cmb_agama.Enabled = False
        txt_hp.Enabled = False
        txt_alamat.Enabled = False
        cmb_status.Enabled = False
    End Sub
    Sub HidupkanForm()
        txt_id_karyawan.Enabled = True
        txt_nama_karyawan.Enabled = True
        txt_lahir.Enabled = True
        DateTimePicker1.Enabled = True
        cmb_jk.Enabled = True
        cmb_agama.Enabled = True
        txt_hp.Enabled = True
        txt_alamat.Enabled = True
        cmb_status.Enabled = True
    End Sub
    Sub TampilkanData()
        Call koneksiDB()
        DA = New OleDb.OleDbDataAdapter("Select * from Kasir", Conn)
        DS = New DataSet
        DA.Fill(DS)
        DGV2.DataSource = DS.Tables(0)
        DGV2.ReadOnly = True
    End Sub
    Sub Foto1()
        PictureBox1.ImageLocation = ""
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If txt_id_karyawan.Text = "" Or txt_nama_karyawan.Text = "" Or cmb_jk.Text = "" Or txt_lahir.Text = "" Or cmb_agama.Text = "" Or txt_hp.Text = "" Or txt_alamat.Text = "" Or cmb_status.Text = "" Or txt_foto.Text = "" Then
            MsgBox("Data Karyawan Belum Lengkap")
            Exit Sub
        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand(" select * from Kasir where Id_Kasir ='" & txt_id_karyawan.Text & "'", Conn)
            DM = CMD.ExecuteReader
            DM.Read()
            If Not DM.HasRows Then
                Call koneksiDB()
                Dim simpan As String
                simpan = "insert into Kasir values ('" &
           txt_id_karyawan.Text & "', '" & txt_nama_karyawan.Text & "', '" & cmb_jk.Text & "','" & txt_lahir.Text & "','" & DateTimePicker1.Value & "','" & cmb_agama.Text & "','" & txt_hp.Text & "','" & txt_alamat.Text & "', '" & cmb_status.Text & "','" &
                txt_foto.Text & "')"
                CMD = New OleDb.OleDbCommand(simpan, Conn)
                CMD.ExecuteNonQuery()
                MsgBox("Input Data Sukses")
                Call Foto1()
            Else
                MsgBox("Data Sudah Ada")
            End If
            Call MatikanForm()
            Call KosongkanForm()
            Call TampilkanData()
        End If
    End Sub

    Private Sub btn_browse_Click(sender As Object, e As EventArgs) Handles btn_browse.Click
        Try
            OpenFileDialog1.Filter = " Image File 
(*.jpeg;*jpg;*.png;*.bmp;*.gif)| *.jpeg;*jpg;*.png;*.bmp;*.gif"
            If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                PictureBox1.Image = New Bitmap(OpenFileDialog1.FileName)
                txt_foto.Text = OpenFileDialog1.FileName
            End If
        Catch ex As Exception
            Throw New ApplicationException("Gambar Gagal Masuk")
        End Try
    End Sub

    Private Sub btn_caridata_Click(sender As Object, e As EventArgs) Handles btn_caridata.Click
        Call HidupkanForm()
        Dim pegawai = InputBox("Silahkan Masukan ID Karyawan")
        Try
            DS.Tables(0).PrimaryKey = New DataColumn() {DS.Tables(0).Columns("Id_Kasir")}

            Dim row As DataRow
            row = DS.Tables(0).Rows.Find(pegawai)
            txt_id_karyawan.Text = row("Id_Kasir")
            txt_nama_karyawan.Text = row("Nama_Kasir")
            txt_lahir.Text = row("Tempat_Lahir")
            DateTimePicker1.Text = row("Tanggal_Lahir")
            cmb_jk.Text = row("Jenis_Kelamin")
            cmb_agama.Text = row("Agama")
            txt_hp.Text = row("No_Telepon")
            txt_alamat.Text = row("Alamat")
            cmb_status.Text = row("Status")
            txt_foto.Text = row("Photo")

            Refresh()

            MsgBox("Pencarian Sukses!")
            Refresh()

        Catch ex As Exception
            MsgBox("Anda Salah Memasukkan Id Admin / Id Admin Tersebut Belum Terdaftar!")
        End Try
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim Umur, Bulan, Hari, TL, TS As Integer
        TL = Year(DateTimePicker1.Value)
        TS = Year(Now)
        Umur = TS - TL
        Bulan = DateDiff(DateInterval.Month, CDate(DateTimePicker1.Value), CDate(Now))
        Hari = DateDiff(DateInterval.Day, CDate(DateTimePicker1.Value), CDate(Now))
        txtumur.Text = (Umur & " Tahun " & Bulan & " Bulan " & Hari & "Hari")
    End Sub

    Private Sub btn_cari_Click(sender As Object, e As EventArgs) Handles btn_cari.Click
        Call koneksiDB()

        DA = New OleDb.OleDbDataAdapter("SELECT * form Kasir where
        Id_Kasir like '%" & txt_cari.Text.Replace("'", "''") & "%' or Nama_Kasir 
        like '%" & txt_cari.Text.Replace("'", "''") & "%' or Alamat like '%" &
        txt_cari.Text.Replace("'", "''") & "%' ", Conn)

        DS = New DataSet
        Dim SRT As New DataTable
        SRT.Clear()
        DA.Fill(SRT)
        DGV2.DataSource = SRT

    End Sub
End Class
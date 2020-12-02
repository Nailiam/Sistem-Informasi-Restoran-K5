Public Class Kasir
    Sub KosongkanForm()
        txt_id.Text = ""
        txt_nama.Text = ""
        cmb_jeniskelamin.Text = ""
        txt_tempatlahir.Text = ""
        cmb_agama.Text = ""
        txt_notelp.Text = ""
        txt_alamat.Text = ""
        cmb_status.Text = ""
        txt_id.Focus()
    End Sub
    Sub MatikanForm()
        txt_id.Enabled = False
        txt_nama.Enabled = False
        cmb_jeniskelamin.Enabled = False
        txt_tempatlahir.Enabled = False
        cmb_agama.Enabled = False
        txt_notelp.Enabled = False
        txt_alamat.Enabled = False
        cmb_status.Enabled = False
    End Sub
    Sub HidupkanForm()
        txt_id.Enabled = True
        txt_nama.Enabled = True
        cmb_jeniskelamin.Enabled = True
        txt_tempatlahir.Enabled = True
        cmb_agama.Enabled = True
        txt_notelp.Enabled = True
        txt_alamat.Enabled = True
        cmb_status.Enabled = True
    End Sub
    Sub TampilkanData()
        Call koneksiDB()
        DA = New OleDb.OleDbDataAdapter("select * from Kasir", Conn)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
    End Sub
    Private Sub Kasir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MatikanForm()
        Call TampilkanData()
    End Sub

    Private Sub btn_input_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_input.Click
        Call HidupkanForm()
        Call KosongkanForm()
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Call MatikanForm()
        Call KosongkanForm()
    End Sub

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        If txt_id.Text = "" Or txt_nama.Text = "" Or cmb_jeniskelamin.Text = "" Or
            txt_tempatlahir.Text = "" Or cmb_agama.Text = "" Or txt_notelp.Text = "" Or txt_alamat.Text = "" Or cmb_status.Text = "" Then
            MsgBox("Data Kasir Belum Lengkap")
            Exit Sub
        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand(" select * from Kasir where txt_id ='" & txt_id.Text & "'", Conn)
            DM = CMD.ExecuteReader
            DM.Read()
            If Not DM.HasRows Then
                Call koneksiDB()
                Dim simpan As String
                simpan = "insert into Kasir values ('" & txt_id.Text &
               "', '" & txt_nama.Text & "', '" & cmb_jeniskelamin.Text & "', '" & txt_tempatlahir.Text &
               "', '" & cmb_agama.Text & "', '" & txt_notelp.Text & "', '" & txt_alamat.Text & "', '" & cmb_status.Text & "')"
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

    Private Sub DataGridView1_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        On Error Resume Next
        txt_id.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        txt_nama.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        cmb_jeniskelamin.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        txt_tempatlahir.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dddd, dd/MM/yyyy"
        DateTimePicker1.Value = Format(DataGridView1.Rows(e.RowIndex).Cells(4).Value)
        cmb_agama.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
        txt_notelp.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value
        txt_alamat.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value
        cmb_status.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value
        Call HidupkanForm()
        txt_id.Enabled = False
    End Sub

    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        If txt_id.Text = "" Or txt_nama.Text = "" Or cmb_jeniskelamin.Text = "" Or txt_tempatlahir.Text = "" Or
            cmb_agama.Text = "" Or txt_notelp.Text = "" Or txt_alamat.Text = "" Or cmb_status.Text = "" Then
            MsgBox("Data Kasir Belum Lengkap")
            Exit Sub
        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand("update Kasir set Nama_Kasir = '" &
           txt_nama.Text & "', Jenis_Kelamin = '" & cmb_jeniskelamin.Text & "', Tempat_Lahir = '" &
           txt_tempatlahir.Text & "', Tanggal_Lahir = '" & DateTimePicker1.Format & "', Agama = '" &
           cmb_agama.Text & "', No_Telepon = '" & txt_notelp.Text & "', Alamat = '" &
           txt_alamat.Text & "', Status = '" & cmb_status.Text & "'", Conn)
            DM = CMD.ExecuteReader
            MsgBox("Update Data Berhasil")
        End If
        Call KosongkanForm()
        Call MatikanForm()
        Call TampilkanData()
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        If txt_id.Text = "" Then
            MsgBox("Tidak ada data yang dipilih")
            Exit Sub
        Else
            If MessageBox.Show(" Are you sure to delete this data?", "Konfirmasi", MessageBoxButtons.YesNoCancel) Then
                Call koneksiDB()
                CMD = New OleDb.OleDbCommand(" delete from Kasir where txt_id = '" & txt_id.Text & "'", Conn)
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
End Class
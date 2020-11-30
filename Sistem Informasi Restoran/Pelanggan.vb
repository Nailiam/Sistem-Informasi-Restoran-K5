Public Class Pelanggan
    Sub KosongkanForm()
        txt_id.Text = ""
        txt_nama.Text = ""
        txt_nomor.Text = ""
        txt_idmakanan.Text = ""
        txt_idminuman.Text = ""
    End Sub
    Sub MatikanForm()
        txt_id.Enabled = False
        txt_nama.Enabled = False
        txt_nomor.Enabled = False
        txt_idmakanan.Enabled = False
        txt_idminuman.Enabled = False
    End Sub
    Sub HidupkanForm()
        txt_id.Enabled = True
        txt_nama.Enabled = True
        txt_nomor.Enabled = True
        txt_idmakanan.Enabled = True
        txt_idminuman.Enabled = True
    End Sub
    Sub TampilkanData()
        Call koneksiDB()
        DA = New OleDb.OleDbDataAdapter("select * from Pelanggan ", Conn)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
    End Sub
    Private Sub Pelanggan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub btn_sv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sv.Click
        If txt_id.Text = "" Or txt_nama.Text = "" Or txt_nomor.Text = "" Or txt_idmakanan.Text = "" Or txt_idminuman.Text = "" Then
            MsgBox("Data Pelanggan Belum Lengkap")
            Exit Sub
        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand(" select * from Pelanggan where Id_pelanggan='" & txt_id.Text & "'", Conn)
            DM = CMD.ExecuteReader
            DM.Read()
            If Not DM.HasRows Then
                Call koneksiDB()
                Dim simpan As String
                simpan = "insert into Pelanggan values ('" & txt_id.Text &
               "', '" & txt_nama.Text & "', '" & txt_nomor.Text & "', '" & txt_idmakanan.Text & "', '" & txt_idminuman.Text & "')"
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
        txt_nomor.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        txt_idmakanan.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        txt_idminuman.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        Call HidupkanForm()
        txt_id.Enabled = False
    End Sub

    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        If txt_id.Text = "" Or txt_nama.Text = "" Or txt_nomor.Text = "" Or txt_idmakanan.Text = "" Or txt_idminuman.Text = "" Then
            MsgBox("Data Pelanggan Belum Lengkap")
            Exit Sub
        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand("update Pelanggan set Nama_Pelanggan = '" &
           txt_nama.Text & "', Nomer_Meja = '" & txt_nomor.Text & "', ID_Makanan = '" & txt_idmakanan.Text & "', ID_Minuman = '" & txt_idminuman.Text & "' where ID_Pelanggan ='" & txt_id.Text & "'", Conn)
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
                CMD = New OleDb.OleDbCommand(" delete from pelanggan where ID_Pelanggan = '" & txt_id.Text & "'", Conn)
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
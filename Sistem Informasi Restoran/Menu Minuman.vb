Public Class Menu_Minuman
    Sub KosongkanForm()
        txt_id_minuman.Text = ""
        txt_jenis_minuman.Text = ""
        txt_harga_minuman.Text = ""
    End Sub
    Sub MatikanForm()
        txt_id_minuman.Enabled = False
        txt_jenis_minuman.Enabled = False
        txt_harga_minuman.Enabled = False
    End Sub
    Sub HidupkanForm()
        txt_id_minuman.Enabled = True
        txt_jenis_minuman.Enabled = True
        txt_harga_minuman.Enabled = True
    End Sub
    Sub TampilkanData()
        Call koneksiDB()
        DA = New OleDb.OleDbDataAdapter("select * from Menu_Minuman", Conn)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
    End Sub
    Private Sub Pramusaji_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        If txt_id_minuman.Text = "" Or txt_jenis_minuman.Text = "" Or txt_harga_minuman.Text = "" Then
            MsgBox("Data Menu_Minuman Belum Lengkap")
            Exit Sub
        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand(" select * from Menu_Minuman where Id_minuman='" & txt_id_minuman.Text & "'", Conn)
            DM = CMD.ExecuteReader
            DM.Read()
            If Not DM.HasRows Then
                Call koneksiDB()
                Dim simpan As String
                simpan = "insert into Menu_Minuman values ('" & txt_id_minuman.Text &
               "', '" & txt_jenis_minuman.Text & "', '" & txt_harga_minuman.Text & "')"
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
        txt_id_minuman.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        txt_jenis_minuman.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        txt_harga_minuman.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        Call HidupkanForm()
        txt_id_minuman.Enabled = False
    End Sub

    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        If txt_id_minuman.Text = "" Or txt_jenis_minuman.Text = "" Or txt_harga_minuman.Text = "" Then
            MsgBox("Data Menu_Minuman Belum Lengkap")
            Exit Sub
        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand("update Menu_Minuman set Jenis_Minuman = '" &
           txt_jenis_minuman.Text & "', Harga_Minuman = '" & txt_harga_minuman.Text & "'  where ID_Minuman ='" & txt_id_minuman.Text & "'", Conn)
            DM = CMD.ExecuteReader
            MsgBox("Update Data Berhasil")
        End If
        Call KosongkanForm()
        Call MatikanForm()
        Call TampilkanData()
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        If txt_id_minuman.Text = "" Then
            MsgBox("Tidak ada data yang dipilih")
            Exit Sub
        Else
            If MessageBox.Show(" Are you sure to delete this data?", "Konfirmasi", MessageBoxButtons.YesNoCancel) Then
                Call koneksiDB()
                CMD = New OleDb.OleDbCommand(" delete from Menu_Minuman where ID_Minuman = '" & txt_id_minuman.Text & "'", Conn)
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
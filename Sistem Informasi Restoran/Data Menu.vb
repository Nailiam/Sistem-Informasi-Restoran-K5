Public Class Data_Menu
    Private Property ID_Makanan As Object

    Sub KosongkanForm()
        txt_IdMenu.Text = ""
        txt_NamaMenu.Text = ""
        cmb_JenisMenu.Text = ""
        txt_HargaMenu.Text = ""
        txt_IdMenu.Focus()
    End Sub
    Sub MatikanForm()
        txt_IdMenu.Enabled = False
        txt_NamaMenu.Enabled = False
        cmb_JenisMenu.Enabled = False
        txt_HargaMenu.Enabled = False
    End Sub
    Sub HidupkanForm()
        txt_IdMenu.Enabled = True
        txt_NamaMenu.Enabled = True
        cmb_JenisMenu.Enabled = True
        txt_HargaMenu.Enabled = True
    End Sub
    Sub TampilkanData()
        Call koneksiDB()
        DA = New OleDb.OleDbDataAdapter("select  * From Menu ", Conn)
        DS = New DataSet
        DA.Fill(DS)
        DGV.DataSource = DS.Tables(0)
        DGV.ReadOnly = True
    End Sub
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MatikanForm()
        Call TampilkanData()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        Call HidupkanForm()
        Call KosongkanForm()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Call MatikanForm()
        Call KosongkanForm()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txt_IdMenu.Text = "" Or cmb_JenisMenu.Text = "" Or txt_NamaMenu.Text = "" Or txt_HargaMenu.Text = "" Then
            MsgBox("Data Menu Belum Lengkap")
            Exit Sub

        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand(" select * from Menu where ID_Menu='" & txt_IdMenu.Text & "'", Conn)
            DM = CMD.ExecuteReader
            DM.Read()

            If Not DM.HasRows Then
                Call koneksiDB()
                Dim simpan As String
                simpan = "insert into Menu values ('" & txt_IdMenu.Text & "', '" & cmb_JenisMenu.Text & "','" & txt_NamaMenu.Text & "', '" & txt_HargaMenu.Text & "')"

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

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick
        On Error Resume Next
        txt_IdMenu.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        cmb_JenisMenu.Text = DGV.Rows(e.RowIndex).Cells(1).Value
        txt_NamaMenu.Text = DGV.Rows(e.RowIndex).Cells(2).Value
        txt_HargaMenu.Text = DGV.Rows(e.RowIndex).Cells(3).Value

        Call HidupkanForm()
        txt_IdMenu.Enabled = False
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        If txt_IdMenu.Text = "" Or cmb_JenisMenu.Text = "" Or txt_NamaMenu.Text = "" Or txt_HargaMenu.Text = "" Then
            MsgBox("Data Menu Belum Lengkap")
            Exit Sub

        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand(" update Menu set Jenis = '" & cmb_JenisMenu.Text & "', Nama = '" & txt_NamaMenu.Text & "', Harga = '" & txt_HargaMenu.Text & "'  where ID_Menu ='" & txt_IdMenu.Text & "'", Conn)
            DM = CMD.ExecuteReader
            MsgBox("Update Data Berhasil")

        End If
        Call KosongkanForm()
        Call MatikanForm()
        Call TampilkanData()

    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If txt_IdMenu.Text = "" Then
            MsgBox("Tidak ada data yang dipilih")
            Exit Sub

        Else
            If MessageBox.Show("Are you sure to delete this data ? ",
           "Konfirmasi", MessageBoxButtons.YesNoCancel) Then

                Call koneksiDB()
                CMD = New OleDb.OleDbCommand(" delete from Menu where ID_Menu ='" & txt_IdMenu.Text & "'", Conn)
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

    Private Sub btnstock_Click(sender As Object, e As EventArgs) Handles btnstock.Click

    End Sub
End Class


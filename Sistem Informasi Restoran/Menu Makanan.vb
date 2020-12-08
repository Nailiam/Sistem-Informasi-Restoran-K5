Public Class Menu_Makanan
    Private Property ID_Makanan As Object

    Sub KosongkanForm()
        txtIdMakanan.Text = ""
        txtNamamakanan.Text = ""
        cmbJenismakanan.Text = ""
        txtHargamakan.Text = ""
        txtIdMakanan.Focus()
    End Sub
    Sub MatikanForm()
        txtIdMakanan.Enabled = False
        txtNamamakanan.Enabled = False
        cmbJenismakanan.Enabled = False
        txtHargamakan.Enabled = False
    End Sub
    Sub HidupkanForm()
        txtIdMakanan.Enabled = True
        txtNamamakanan.Enabled = True
        cmbJenismakanan.Enabled = True
        txtHargamakan.Enabled = True
    End Sub
    Sub TampilkanData()
        Call koneksiDB()
        DA = New OleDb.OleDbDataAdapter("select  * From Menu_Makanan ", Conn)
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
        If txtIdMakanan.Text = "" Or txtNamamakanan.Text = "" Or cmbJenismakanan.Text = "" Or txtHargamakan.Text = "" Then
            MsgBox("Data Menu Makanan Belum Lengkap")
            Exit Sub

        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand(" select * from Menu_Makanan where ID_Makanan='" & txtIdMakanan.Text & "'", Conn)
            DM = CMD.ExecuteReader
            DM.Read()

            If Not DM.HasRows Then
                Call koneksiDB()
                Dim simpan As String
                simpan = "insert into Menu_Makanan values ('" & txtIdMakanan.Text & "', '" & txtNamamakanan.Text & "', '" &
                cmbJenismakanan.Text & "', '" & txtHargamakan.Text & "')"

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
        txtIdMakanan.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        txtNamamakanan.Text = DGV.Rows(e.RowIndex).Cells(1).Value
        cmbJenismakanan.Text = DGV.Rows(e.RowIndex).Cells(2).Value
        txtHargamakan.Text = DGV.Rows(e.RowIndex).Cells(3).Value

        Call HidupkanForm()
        txtIdMakanan.Enabled = False
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        If txtIdMakanan.Text = "" Or txtNamamakanan.Text = "" Or cmbJenismakanan.Text = "" Or txtHargamakan.Text = "" Then
            MsgBox("Data Menu Makanan Belum Lengkap")
            Exit Sub

        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand(" update Menu_Makanan set Nama_Makanan = '" & txtNamamakanan.Text & "', Jenis_Makanan = '" &
            cmbJenismakanan.Text & "', Harga_Makanan = '" & txtHargamakan.Text & "'  where ID_Makanan ='" & txtIdMakanan.Text & "'", Conn)
            DM = CMD.ExecuteReader
            MsgBox("Update Data Berhasil")

        End If
        Call KosongkanForm()
        Call MatikanForm()
        Call TampilkanData()

    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If txtIdMakanan.Text = "" Then
            MsgBox("Tidak ada data yang dipilih")
            Exit Sub

        Else
            If MessageBox.Show("Are you sure to delete this data ? ",
           "Konfirmasi", MessageBoxButtons.YesNoCancel) Then

                Call koneksiDB()
                CMD = New OleDb.OleDbCommand(" delete from Menu_Makanan where ID_Makanan ='" & txtIdMakanan.Text & "'", Conn)
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

Public Class Detail_Transaksi
    Private Property Kode_Struk As Object

    Sub KosongkanForm()
        txt_KodeStruk.Text = ""
        txt_IDMenu.Text = ""
        txt_NamaMenu.Text = ""
        txt_Harga.Text = ""
        txt_Jumlah.Text = ""
        txt_Subtotal.Text = ""
        txt_KodeStruk.Focus()
    End Sub
    Sub MatikanForm()
        txt_KodeStruk.Enabled = False
        txt_IDMenu.Enabled = False
        txt_NamaMenu.Enabled = False
        txt_Harga.Enabled = False
        txt_Jumlah.Enabled = False
        txt_Subtotal.Enabled = False
    End Sub
    Sub HidupkanForm()
        txt_KodeStruk.Enabled = True
        txt_IDMenu.Enabled = True
        txt_NamaMenu.Enabled = True
        txt_Harga.Enabled = True
        txt_Jumlah.Enabled = True
        txt_Subtotal.Enabled = True
    End Sub
    Sub TampilkanData()
        Call koneksiDB()
        DA = New OleDb.OleDbDataAdapter("select * From Detail Transaksi ", Conn)
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
        If txt_KodeStruk.Text = "" Or txt_IDMenu.Text = "" Or txt_NamaMenu.Text = "" Or txt_Harga.Text = "" Or txt_Jumlah.Text = "" Or txt_Subtotal.Text = "" Then
            MsgBox("Data Menu Belum Lengkap")
            Exit Sub

        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand(" select * from Detail Transaksi where Kode_Struk ='" & txt_KodeStruk.Text & "'", Conn)
            DM = CMD.ExecuteReader
            DM.Read()

            If Not DM.HasRows Then
                Call koneksiDB()
                Dim simpan As String
                simpan = "insert into Detail Transaksi values ('" & txt_KodeStruk.Text & "', '" & txt_IDMenu.Text & "','" & txt_NamaMenu.Text & "', '" & txt_Harga.Text & "','" & txt_Jumlah.Text & "', '" & txt_Subtotal.Text & "')"

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
        txt_KodeStruk.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        txt_IDMenu.Text = DGV.Rows(e.RowIndex).Cells(1).Value
        txt_NamaMenu.Text = DGV.Rows(e.RowIndex).Cells(2).Value
        txt_Harga.Text = DGV.Rows(e.RowIndex).Cells(3).Value
        txt_Jumlah.Text = DGV.Rows(e.RowIndex).Cells(4).Value
        txt_Subtotal.Text = DGV.Rows(e.RowIndex).Cells(5).Value

        Call HidupkanForm()
        txt_KodeStruk.Enabled = False
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        If txt_KodeStruk.Text = "" Or txt_IDMenu.Text = "" Or txt_NamaMenu.Text = "" Or txt_Harga.Text = "" Or txt_Jumlah.Text = "" Or txt_Subtotal.Text = "" Then
            MsgBox("Data Detail Transaksi Belum Lengkap")
            Exit Sub

        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand(" update Data Transaksi set Jumlah = '" & txt_Subtotal.Text & "', Nama = '" & txt_IDMenu.Text & "', Harga = '" & txt_NamaMenu.Text & "'  where ID_Menu ='" & txt_KodeStruk.Text & "'", Conn)
            DM = CMD.ExecuteReader
            MsgBox("Update Data Berhasil")

        End If
        Call KosongkanForm()
        Call MatikanForm()
        Call TampilkanData()

    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If txt_KodeStruk.Text = "" Then
            MsgBox("Tidak ada data yang dipilih")
            Exit Sub

        Else
            If MessageBox.Show("Are you sure to delete this data ? ",
           "Konfirmasi", MessageBoxButtons.YesNoCancel) Then

                Call koneksiDB()
                CMD = New OleDb.OleDbCommand(" delete from Detail Transaksi where Kode_Struk ='" & txt_KodeStruk.Text & "'", Conn)
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


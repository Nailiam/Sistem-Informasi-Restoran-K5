Public Class Menu_Makanan
    Private Property ID_Makanan As Object
    Sub KosongkanForm()
        txtIdMakanan.Text = ""
        cmbJenismakanan.Text = ""
        txtHargamakan.Text = ""
        txtIdMakanan.Focus()
    End Sub
    Sub MatikanForm()
        txtIdMakanan.Enabled = False
        cmbJenismakanan.Enabled = False
        txtHargamakan.Enabled = False
    End Sub
    Sub HidupkanForm()
        txtIdMakanan.Enabled = True
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
End Class

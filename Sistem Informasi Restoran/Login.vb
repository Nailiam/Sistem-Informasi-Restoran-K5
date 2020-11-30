Public Class Login
    Private Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click
        Call koneksiDB()
        Dim cek As String
        cek = "Select * From Login Where Username= '" & txtUN.Text & "'and Password = '" & txtPass.Text & "'"
        CMD = New OleDb.OleDbCommand(cek, Conn)
        CMD.ExecuteNonQuery()
        DM = CMD.ExecuteReader
        If DM.HasRows = True Then
            DM.Read()
            Main_Menu.Show()
            Me.Hide()
        Else
            MsgBox(" Maaf Username atau Password Anda Salah ")
            Me.Show()
        End If
        Data_Karyawan.lblselamat.Text = txtUN.Text
    End Sub
End Class
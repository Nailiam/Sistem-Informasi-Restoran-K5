Public Class cls_Stok
    Public Shared database As New List(Of cls_Stok)
    Public Property stok As Integer
    Sub New(newstok As Integer)
        stok = newstok
    End Sub
    Sub savedata()
        database.Add(Me)
    End Sub
End Class

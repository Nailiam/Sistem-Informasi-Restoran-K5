<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bayar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btninput = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txttotalkembalian = New System.Windows.Forms.TextBox()
        Me.txtfreekembalian = New System.Windows.Forms.TextBox()
        Me.txtkembalian = New System.Windows.Forms.TextBox()
        Me.txtuangbayar = New System.Windows.Forms.TextBox()
        Me.txttotalbayar = New System.Windows.Forms.TextBox()
        Me.txtpajak = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtsubtotal = New System.Windows.Forms.TextBox()
        Me.txtkodepesanan = New System.Windows.Forms.TextBox()
        Me.txtidkasir = New System.Windows.Forms.TextBox()
        Me.txtjamtransaksi = New System.Windows.Forms.TextBox()
        Me.txtkodetransaksi = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(678, 407)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 23)
        Me.btnexit.TabIndex = 15
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(564, 407)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 14
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(461, 407)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 23)
        Me.btndelete.TabIndex = 13
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(678, 357)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(75, 23)
        Me.btnedit.TabIndex = 12
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(564, 357)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 11
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btninput
        '
        Me.btninput.Location = New System.Drawing.Point(461, 357)
        Me.btninput.Name = "btninput"
        Me.btninput.Size = New System.Drawing.Size(75, 23)
        Me.btninput.TabIndex = 10
        Me.btninput.Text = "Input"
        Me.btninput.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(356, 30)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(439, 297)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detail Pembayaran"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 31)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(407, 249)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txttotalkembalian)
        Me.GroupBox1.Controls.Add(Me.txtfreekembalian)
        Me.GroupBox1.Controls.Add(Me.txtkembalian)
        Me.GroupBox1.Controls.Add(Me.txtuangbayar)
        Me.GroupBox1.Controls.Add(Me.txttotalbayar)
        Me.GroupBox1.Controls.Add(Me.txtpajak)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.txtsubtotal)
        Me.GroupBox1.Controls.Add(Me.txtkodepesanan)
        Me.GroupBox1.Controls.Add(Me.txtidkasir)
        Me.GroupBox1.Controls.Add(Me.txtjamtransaksi)
        Me.GroupBox1.Controls.Add(Me.txtkodetransaksi)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(321, 426)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Data Pembayaran"
        '
        'txttotalkembalian
        '
        Me.txttotalkembalian.Location = New System.Drawing.Point(138, 388)
        Me.txttotalkembalian.Name = "txttotalkembalian"
        Me.txttotalkembalian.Size = New System.Drawing.Size(166, 20)
        Me.txttotalkembalian.TabIndex = 22
        '
        'txtfreekembalian
        '
        Me.txtfreekembalian.Location = New System.Drawing.Point(138, 355)
        Me.txtfreekembalian.Name = "txtfreekembalian"
        Me.txtfreekembalian.Size = New System.Drawing.Size(166, 20)
        Me.txtfreekembalian.TabIndex = 21
        '
        'txtkembalian
        '
        Me.txtkembalian.Location = New System.Drawing.Point(138, 318)
        Me.txtkembalian.Name = "txtkembalian"
        Me.txtkembalian.Size = New System.Drawing.Size(166, 20)
        Me.txtkembalian.TabIndex = 20
        '
        'txtuangbayar
        '
        Me.txtuangbayar.Location = New System.Drawing.Point(138, 285)
        Me.txtuangbayar.Name = "txtuangbayar"
        Me.txtuangbayar.Size = New System.Drawing.Size(166, 20)
        Me.txtuangbayar.TabIndex = 19
        '
        'txttotalbayar
        '
        Me.txttotalbayar.Location = New System.Drawing.Point(138, 252)
        Me.txttotalbayar.Name = "txttotalbayar"
        Me.txttotalbayar.Size = New System.Drawing.Size(166, 20)
        Me.txttotalbayar.TabIndex = 18
        '
        'txtpajak
        '
        Me.txtpajak.Location = New System.Drawing.Point(138, 220)
        Me.txtpajak.Name = "txtpajak"
        Me.txtpajak.Size = New System.Drawing.Size(166, 20)
        Me.txtpajak.TabIndex = 17
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(20, 395)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 13)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Total Kembalian"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(20, 362)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 13)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Free Kembalian"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 325)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Kembalian"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 292)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Uang Bayar"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 259)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Total Bayar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 227)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Pajak Resto 10%"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(138, 63)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(166, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'txtsubtotal
        '
        Me.txtsubtotal.Location = New System.Drawing.Point(138, 192)
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.Size = New System.Drawing.Size(166, 20)
        Me.txtsubtotal.TabIndex = 10
        '
        'txtkodepesanan
        '
        Me.txtkodepesanan.Location = New System.Drawing.Point(138, 162)
        Me.txtkodepesanan.Name = "txtkodepesanan"
        Me.txtkodepesanan.Size = New System.Drawing.Size(166, 20)
        Me.txtkodepesanan.TabIndex = 9
        '
        'txtidkasir
        '
        Me.txtidkasir.Location = New System.Drawing.Point(138, 131)
        Me.txtidkasir.Name = "txtidkasir"
        Me.txtidkasir.Size = New System.Drawing.Size(166, 20)
        Me.txtidkasir.TabIndex = 8
        '
        'txtjamtransaksi
        '
        Me.txtjamtransaksi.Location = New System.Drawing.Point(138, 97)
        Me.txtjamtransaksi.Name = "txtjamtransaksi"
        Me.txtjamtransaksi.Size = New System.Drawing.Size(166, 20)
        Me.txtjamtransaksi.TabIndex = 7
        '
        'txtkodetransaksi
        '
        Me.txtkodetransaksi.Location = New System.Drawing.Point(138, 31)
        Me.txtkodetransaksi.Name = "txtkodetransaksi"
        Me.txtkodetransaksi.Size = New System.Drawing.Size(166, 20)
        Me.txtkodetransaksi.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Sub Total"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Kode Pesanan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jam Transaksi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Id Kasir"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tanggal Transasksi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Transaksi"
        '
        'Bayar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 471)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btninput)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Bayar"
        Me.Text = "Bayar"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnexit As Button
    Friend WithEvents btncancel As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents btninput As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txttotalkembalian As TextBox
    Friend WithEvents txtfreekembalian As TextBox
    Friend WithEvents txtkembalian As TextBox
    Friend WithEvents txtuangbayar As TextBox
    Friend WithEvents txttotalbayar As TextBox
    Friend WithEvents txtpajak As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtsubtotal As TextBox
    Friend WithEvents txtkodepesanan As TextBox
    Friend WithEvents txtidkasir As TextBox
    Friend WithEvents txtjamtransaksi As TextBox
    Friend WithEvents txtkodetransaksi As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class

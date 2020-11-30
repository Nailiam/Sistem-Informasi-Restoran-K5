<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pesan
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
        Me.cancel = New System.Windows.Forms.Button()
        Me.delete = New System.Windows.Forms.Button()
        Me.edit = New System.Windows.Forms.Button()
        Me.save = New System.Windows.Forms.Button()
        Me.input = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.jumlah_pemesanan = New System.Windows.Forms.TextBox()
        Me.ID_Pelanggan = New System.Windows.Forms.TextBox()
        Me.kode_pemesanan = New System.Windows.Forms.TextBox()
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
        Me.btnexit.Location = New System.Drawing.Point(224, 265)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(73, 36)
        Me.btnexit.TabIndex = 23
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'cancel
        '
        Me.cancel.Location = New System.Drawing.Point(140, 265)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(73, 36)
        Me.cancel.TabIndex = 22
        Me.cancel.Text = "CANCEL"
        Me.cancel.UseVisualStyleBackColor = True
        '
        'delete
        '
        Me.delete.Location = New System.Drawing.Point(55, 265)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(73, 36)
        Me.delete.TabIndex = 21
        Me.delete.Text = "DELETE"
        Me.delete.UseVisualStyleBackColor = True
        '
        'edit
        '
        Me.edit.Location = New System.Drawing.Point(224, 215)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(73, 36)
        Me.edit.TabIndex = 20
        Me.edit.Text = "EDIT"
        Me.edit.UseVisualStyleBackColor = True
        '
        'save
        '
        Me.save.Location = New System.Drawing.Point(140, 215)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(73, 36)
        Me.save.TabIndex = 19
        Me.save.Text = "SAVE"
        Me.save.UseVisualStyleBackColor = True
        '
        'input
        '
        Me.input.Location = New System.Drawing.Point(55, 215)
        Me.input.Name = "input"
        Me.input.Size = New System.Drawing.Size(73, 36)
        Me.input.TabIndex = 18
        Me.input.Text = "INPUT"
        Me.input.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(339, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(415, 277)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detail Pesanan"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(34, 31)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(347, 230)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.jumlah_pemesanan)
        Me.GroupBox1.Controls.Add(Me.ID_Pelanggan)
        Me.GroupBox1.Controls.Add(Me.kode_pemesanan)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(311, 185)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Data Pesanan"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(151, 86)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(117, 20)
        Me.DateTimePicker1.TabIndex = 11
        '
        'jumlah_pemesanan
        '
        Me.jumlah_pemesanan.Location = New System.Drawing.Point(151, 117)
        Me.jumlah_pemesanan.Name = "jumlah_pemesanan"
        Me.jumlah_pemesanan.Size = New System.Drawing.Size(117, 20)
        Me.jumlah_pemesanan.TabIndex = 8
        '
        'ID_Pelanggan
        '
        Me.ID_Pelanggan.Location = New System.Drawing.Point(151, 56)
        Me.ID_Pelanggan.Name = "ID_Pelanggan"
        Me.ID_Pelanggan.Size = New System.Drawing.Size(117, 20)
        Me.ID_Pelanggan.TabIndex = 7
        '
        'kode_pemesanan
        '
        Me.kode_pemesanan.Location = New System.Drawing.Point(151, 23)
        Me.kode_pemesanan.Name = "kode_pemesanan"
        Me.kode_pemesanan.Size = New System.Drawing.Size(117, 20)
        Me.kode_pemesanan.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jumlah Pesanan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tanggal Pesanan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID Pelanggan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Pesanan"
        '
        'Pesan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 339)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.edit)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.input)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Pesan"
        Me.Text = "Pesan"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnexit As Button
    Friend WithEvents cancel As Button
    Friend WithEvents delete As Button
    Friend WithEvents edit As Button
    Friend WithEvents save As Button
    Friend WithEvents input As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents jumlah_pemesanan As TextBox
    Friend WithEvents ID_Pelanggan As TextBox
    Friend WithEvents kode_pemesanan As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class

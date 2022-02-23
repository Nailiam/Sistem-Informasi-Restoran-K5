<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Detail_Transaksi
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
        Me.lblwelcome = New System.Windows.Forms.GroupBox()
        Me.txt_Subtotal = New System.Windows.Forms.TextBox()
        Me.txt_Jumlah = New System.Windows.Forms.TextBox()
        Me.txt_Harga = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_IDMenu = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_NamaMenu = New System.Windows.Forms.TextBox()
        Me.txt_KodeStruk = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblwelcome.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblwelcome
        '
        Me.lblwelcome.Controls.Add(Me.txt_Subtotal)
        Me.lblwelcome.Controls.Add(Me.txt_Jumlah)
        Me.lblwelcome.Controls.Add(Me.txt_Harga)
        Me.lblwelcome.Controls.Add(Me.Label6)
        Me.lblwelcome.Controls.Add(Me.Label4)
        Me.lblwelcome.Controls.Add(Me.txt_IDMenu)
        Me.lblwelcome.Controls.Add(Me.Label3)
        Me.lblwelcome.Controls.Add(Me.txt_NamaMenu)
        Me.lblwelcome.Controls.Add(Me.txt_KodeStruk)
        Me.lblwelcome.Controls.Add(Me.Label5)
        Me.lblwelcome.Controls.Add(Me.Label2)
        Me.lblwelcome.Controls.Add(Me.Label1)
        Me.lblwelcome.Location = New System.Drawing.Point(25, 34)
        Me.lblwelcome.Name = "lblwelcome"
        Me.lblwelcome.Size = New System.Drawing.Size(269, 234)
        Me.lblwelcome.TabIndex = 21
        Me.lblwelcome.TabStop = False
        Me.lblwelcome.Text = "Input Detail Transaksi"
        '
        'txt_Subtotal
        '
        Me.txt_Subtotal.Location = New System.Drawing.Point(125, 187)
        Me.txt_Subtotal.Name = "txt_Subtotal"
        Me.txt_Subtotal.Size = New System.Drawing.Size(121, 20)
        Me.txt_Subtotal.TabIndex = 17
        '
        'txt_Jumlah
        '
        Me.txt_Jumlah.Location = New System.Drawing.Point(125, 159)
        Me.txt_Jumlah.Name = "txt_Jumlah"
        Me.txt_Jumlah.Size = New System.Drawing.Size(121, 20)
        Me.txt_Jumlah.TabIndex = 16
        '
        'txt_Harga
        '
        Me.txt_Harga.Location = New System.Drawing.Point(125, 125)
        Me.txt_Harga.Name = "txt_Harga"
        Me.txt_Harga.Size = New System.Drawing.Size(121, 20)
        Me.txt_Harga.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Subtotal :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Jumlah :"
        '
        'txt_IDMenu
        '
        Me.txt_IDMenu.Location = New System.Drawing.Point(125, 63)
        Me.txt_IDMenu.Name = "txt_IDMenu"
        Me.txt_IDMenu.Size = New System.Drawing.Size(121, 20)
        Me.txt_IDMenu.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Nama Menu :"
        '
        'txt_NamaMenu
        '
        Me.txt_NamaMenu.Location = New System.Drawing.Point(125, 94)
        Me.txt_NamaMenu.Name = "txt_NamaMenu"
        Me.txt_NamaMenu.Size = New System.Drawing.Size(121, 20)
        Me.txt_NamaMenu.TabIndex = 9
        '
        'txt_KodeStruk
        '
        Me.txt_KodeStruk.Location = New System.Drawing.Point(125, 28)
        Me.txt_KodeStruk.Name = "txt_KodeStruk"
        Me.txt_KodeStruk.Size = New System.Drawing.Size(121, 20)
        Me.txt_KodeStruk.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Harga :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID Menu :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Struk :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DGV)
        Me.GroupBox2.Location = New System.Drawing.Point(385, 34)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(364, 212)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detail Menu"
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(15, 19)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(333, 165)
        Me.DGV.TabIndex = 10
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(25, 274)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(75, 23)
        Me.btnInput.TabIndex = 29
        Me.btnInput.Text = "Input"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(122, 274)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 30
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(219, 274)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 31
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(28, 320)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 32
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(122, 320)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 33
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(219, 320)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 34
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Detail_Transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 384)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblwelcome)
        Me.Name = "Detail_Transaksi"
        Me.Text = "Detail Transaksi"
        Me.lblwelcome.ResumeLayout(False)
        Me.lblwelcome.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblwelcome As GroupBox
    Friend WithEvents txt_IDMenu As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_NamaMenu As TextBox
    Friend WithEvents txt_KodeStruk As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DGV As DataGridView
    Friend WithEvents btnInput As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txt_Subtotal As TextBox
    Friend WithEvents txt_Jumlah As TextBox
    Friend WithEvents txt_Harga As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Makanan
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.lblwelcome = New System.Windows.Forms.GroupBox()
        Me.cmbJenismakanan = New System.Windows.Forms.ComboBox()
        Me.txtHargamakan = New System.Windows.Forms.TextBox()
        Me.txtIdMakanan = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lblwelcome.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DGV)
        Me.GroupBox2.Location = New System.Drawing.Point(302, 31)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(364, 212)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detail Menu Makanan"
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(15, 28)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(333, 165)
        Me.DGV.TabIndex = 10
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(206, 220)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(110, 220)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(12, 220)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 23)
        Me.btndelete.TabIndex = 16
        Me.btndelete.Text = "DELETE"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(206, 181)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(75, 23)
        Me.btnedit.TabIndex = 15
        Me.btnedit.Text = "EDIT"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(111, 181)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(12, 181)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(75, 23)
        Me.btnInput.TabIndex = 13
        Me.btnInput.Text = "INPUT"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'lblwelcome
        '
        Me.lblwelcome.Controls.Add(Me.cmbJenismakanan)
        Me.lblwelcome.Controls.Add(Me.txtHargamakan)
        Me.lblwelcome.Controls.Add(Me.txtIdMakanan)
        Me.lblwelcome.Controls.Add(Me.Label5)
        Me.lblwelcome.Controls.Add(Me.Label2)
        Me.lblwelcome.Controls.Add(Me.Label1)
        Me.lblwelcome.Location = New System.Drawing.Point(12, 31)
        Me.lblwelcome.Name = "lblwelcome"
        Me.lblwelcome.Size = New System.Drawing.Size(269, 144)
        Me.lblwelcome.TabIndex = 12
        Me.lblwelcome.TabStop = False
        Me.lblwelcome.Text = "Input Menu Makanan"
        '
        'cmbJenismakanan
        '
        Me.cmbJenismakanan.FormattingEnabled = True
        Me.cmbJenismakanan.Items.AddRange(New Object() {"Nasi Goreng", "Nasi Goreng Ati", "Nasi Goreng Spesial", "Bakso", "Bakso Telur", "Nasi Putih", "Ayam Bakar", "Chitato", "Taro", "Happy Tos"})
        Me.cmbJenismakanan.Location = New System.Drawing.Point(125, 56)
        Me.cmbJenismakanan.Name = "cmbJenismakanan"
        Me.cmbJenismakanan.Size = New System.Drawing.Size(121, 21)
        Me.cmbJenismakanan.TabIndex = 10
        '
        'txtHargamakan
        '
        Me.txtHargamakan.Location = New System.Drawing.Point(125, 87)
        Me.txtHargamakan.Name = "txtHargamakan"
        Me.txtHargamakan.Size = New System.Drawing.Size(121, 20)
        Me.txtHargamakan.TabIndex = 9
        '
        'txtIdMakanan
        '
        Me.txtIdMakanan.Location = New System.Drawing.Point(125, 28)
        Me.txtIdMakanan.Name = "txtIdMakanan"
        Me.txtIdMakanan.Size = New System.Drawing.Size(121, 20)
        Me.txtIdMakanan.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Harga Makanan :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jenis Makanan :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Makanan :"
        '
        'Menu_Makanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 285)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.lblwelcome)
        Me.Name = "Menu_Makanan"
        Me.Text = "Data Menu Makanan"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lblwelcome.ResumeLayout(False)
        Me.lblwelcome.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DGV As DataGridView
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnInput As Button
    Friend WithEvents lblwelcome As GroupBox
    Friend WithEvents cmbJenismakanan As ComboBox
    Friend WithEvents txtHargamakan As TextBox
    Friend WithEvents txtIdMakanan As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Data_Menu
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
        Me.txt_NamaMenu = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_JenisMenu = New System.Windows.Forms.ComboBox()
        Me.txt_HargaMenu = New System.Windows.Forms.TextBox()
        Me.txt_IdMenu = New System.Windows.Forms.TextBox()
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
        Me.GroupBox2.Location = New System.Drawing.Point(302, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(364, 212)
        Me.GroupBox2.TabIndex = 27
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
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(206, 285)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 26
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(111, 285)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 25
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(12, 285)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 23)
        Me.btndelete.TabIndex = 24
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(206, 224)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(75, 23)
        Me.btnedit.TabIndex = 23
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(111, 224)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 22
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(12, 224)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(75, 23)
        Me.btnInput.TabIndex = 21
        Me.btnInput.Text = "Input"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'lblwelcome
        '
        Me.lblwelcome.Controls.Add(Me.txt_NamaMenu)
        Me.lblwelcome.Controls.Add(Me.Label3)
        Me.lblwelcome.Controls.Add(Me.cmb_JenisMenu)
        Me.lblwelcome.Controls.Add(Me.txt_HargaMenu)
        Me.lblwelcome.Controls.Add(Me.txt_IdMenu)
        Me.lblwelcome.Controls.Add(Me.Label5)
        Me.lblwelcome.Controls.Add(Me.Label2)
        Me.lblwelcome.Controls.Add(Me.Label1)
        Me.lblwelcome.Location = New System.Drawing.Point(12, 24)
        Me.lblwelcome.Name = "lblwelcome"
        Me.lblwelcome.Size = New System.Drawing.Size(269, 172)
        Me.lblwelcome.TabIndex = 20
        Me.lblwelcome.TabStop = False
        Me.lblwelcome.Text = "Input Menu"
        '
        'txt_NamaMenu
        '
        Me.txt_NamaMenu.Location = New System.Drawing.Point(125, 61)
        Me.txt_NamaMenu.Name = "txt_NamaMenu"
        Me.txt_NamaMenu.Size = New System.Drawing.Size(121, 20)
        Me.txt_NamaMenu.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Nama Menu :"
        '
        'cmb_JenisMenu
        '
        Me.cmb_JenisMenu.FormattingEnabled = True
        Me.cmb_JenisMenu.Items.AddRange(New Object() {"Appetizer", "Main Course", "Dessert", "Snack", "Cold", "Hot", "Juice"})
        Me.cmb_JenisMenu.Location = New System.Drawing.Point(125, 91)
        Me.cmb_JenisMenu.Name = "cmb_JenisMenu"
        Me.cmb_JenisMenu.Size = New System.Drawing.Size(121, 21)
        Me.cmb_JenisMenu.TabIndex = 10
        '
        'txt_HargaMenu
        '
        Me.txt_HargaMenu.Location = New System.Drawing.Point(125, 125)
        Me.txt_HargaMenu.Name = "txt_HargaMenu"
        Me.txt_HargaMenu.Size = New System.Drawing.Size(121, 20)
        Me.txt_HargaMenu.TabIndex = 9
        '
        'txt_IdMenu
        '
        Me.txt_IdMenu.Location = New System.Drawing.Point(125, 28)
        Me.txt_IdMenu.Name = "txt_IdMenu"
        Me.txt_IdMenu.Size = New System.Drawing.Size(121, 20)
        Me.txt_IdMenu.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Harga Menu :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jenis Menu :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Menu :"
        '
        'Data_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 314)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.lblwelcome)
        Me.Name = "Data_Menu"
        Me.Text = "Data_Menu"
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
    Friend WithEvents txt_NamaMenu As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmb_JenisMenu As ComboBox
    Friend WithEvents txt_HargaMenu As TextBox
    Friend WithEvents txt_IdMenu As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class

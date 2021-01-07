<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnsavebarcode = New System.Windows.Forms.Button()
        Me.btnsaveqrcode = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnprosesbarcode = New System.Windows.Forms.Button()
        Me.btnprosesqrcode = New System.Windows.Forms.Button()
        Me.txtbarcode = New System.Windows.Forms.TextBox()
        Me.txtqrcode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnsavebarcode
        '
        Me.btnsavebarcode.Location = New System.Drawing.Point(464, 293)
        Me.btnsavebarcode.Name = "btnsavebarcode"
        Me.btnsavebarcode.Size = New System.Drawing.Size(75, 23)
        Me.btnsavebarcode.TabIndex = 19
        Me.btnsavebarcode.Text = "Save"
        Me.btnsavebarcode.UseVisualStyleBackColor = True
        '
        'btnsaveqrcode
        '
        Me.btnsaveqrcode.Location = New System.Drawing.Point(49, 293)
        Me.btnsaveqrcode.Name = "btnsaveqrcode"
        Me.btnsaveqrcode.Size = New System.Drawing.Size(75, 23)
        Me.btnsaveqrcode.TabIndex = 18
        Me.btnsaveqrcode.Text = "Save"
        Me.btnsaveqrcode.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(404, 138)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(186, 120)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(14, 138)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(159, 120)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'btnprosesbarcode
        '
        Me.btnprosesbarcode.Location = New System.Drawing.Point(440, 91)
        Me.btnprosesbarcode.Name = "btnprosesbarcode"
        Me.btnprosesbarcode.Size = New System.Drawing.Size(75, 23)
        Me.btnprosesbarcode.TabIndex = 15
        Me.btnprosesbarcode.Text = "Proses"
        Me.btnprosesbarcode.UseVisualStyleBackColor = True
        '
        'btnprosesqrcode
        '
        Me.btnprosesqrcode.Location = New System.Drawing.Point(49, 91)
        Me.btnprosesqrcode.Name = "btnprosesqrcode"
        Me.btnprosesqrcode.Size = New System.Drawing.Size(75, 23)
        Me.btnprosesqrcode.TabIndex = 14
        Me.btnprosesqrcode.Text = "Proses"
        Me.btnprosesqrcode.UseVisualStyleBackColor = True
        '
        'txtbarcode
        '
        Me.txtbarcode.Location = New System.Drawing.Point(404, 65)
        Me.txtbarcode.Name = "txtbarcode"
        Me.txtbarcode.Size = New System.Drawing.Size(100, 20)
        Me.txtbarcode.TabIndex = 13
        '
        'txtqrcode
        '
        Me.txtqrcode.Location = New System.Drawing.Point(14, 65)
        Me.txtqrcode.Name = "txtqrcode"
        Me.txtqrcode.Size = New System.Drawing.Size(100, 20)
        Me.txtqrcode.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(401, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Barcode"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "QR Code"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 366)
        Me.Controls.Add(Me.btnsavebarcode)
        Me.Controls.Add(Me.btnsaveqrcode)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnprosesbarcode)
        Me.Controls.Add(Me.btnprosesqrcode)
        Me.Controls.Add(Me.txtbarcode)
        Me.Controls.Add(Me.txtqrcode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnsavebarcode As Button
    Friend WithEvents btnsaveqrcode As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnprosesbarcode As Button
    Friend WithEvents btnprosesqrcode As Button
    Friend WithEvents txtbarcode As TextBox
    Friend WithEvents txtqrcode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class

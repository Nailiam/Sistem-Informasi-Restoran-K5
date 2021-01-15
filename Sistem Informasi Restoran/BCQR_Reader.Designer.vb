<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BCQR_Reader
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btndetect = New System.Windows.Forms.Button()
        Me.btnstop = New System.Windows.Forms.Button()
        Me.btnstart = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(137, 343)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(471, 22)
        Me.TextBox1.TabIndex = 11
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(563, 192)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(100, 28)
        Me.btnsave.TabIndex = 10
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btndetect
        '
        Me.btndetect.Location = New System.Drawing.Point(563, 156)
        Me.btndetect.Margin = New System.Windows.Forms.Padding(4)
        Me.btndetect.Name = "btndetect"
        Me.btndetect.Size = New System.Drawing.Size(100, 28)
        Me.btndetect.TabIndex = 9
        Me.btndetect.Text = "Detect"
        Me.btndetect.UseVisualStyleBackColor = True
        '
        'btnstop
        '
        Me.btnstop.Location = New System.Drawing.Point(563, 120)
        Me.btnstop.Margin = New System.Windows.Forms.Padding(4)
        Me.btnstop.Name = "btnstop"
        Me.btnstop.Size = New System.Drawing.Size(100, 28)
        Me.btnstop.TabIndex = 8
        Me.btnstop.Text = "Stop"
        Me.btnstop.UseVisualStyleBackColor = True
        '
        'btnstart
        '
        Me.btnstart.Location = New System.Drawing.Point(563, 85)
        Me.btnstart.Margin = New System.Windows.Forms.Padding(4)
        Me.btnstart.Name = "btnstart"
        Me.btnstart.Size = New System.Drawing.Size(100, 28)
        Me.btnstart.TabIndex = 7
        Me.btnstart.Text = "Start"
        Me.btnstart.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(137, 85)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(352, 220)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'BCQR_Reader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btndetect)
        Me.Controls.Add(Me.btnstop)
        Me.Controls.Add(Me.btnstart)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "BCQR_Reader"
        Me.Text = "BCQR_Reader"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnsave As Button
    Friend WithEvents btndetect As Button
    Friend WithEvents btnstop As Button
    Friend WithEvents btnstart As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class

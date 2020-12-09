<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Crystal_Report_Makanan
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
        Me.btn_open = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_open
        '
        Me.btn_open.Location = New System.Drawing.Point(328, 140)
        Me.btn_open.Name = "btn_open"
        Me.btn_open.Size = New System.Drawing.Size(112, 32)
        Me.btn_open.TabIndex = 0
        Me.btn_open.Text = "Button1"
        Me.btn_open.UseVisualStyleBackColor = True
        '
        'Crystal_Report_Makanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_open)
        Me.Name = "Crystal_Report_Makanan"
        Me.Text = "Crystal Report Makanan"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_open As Button
End Class

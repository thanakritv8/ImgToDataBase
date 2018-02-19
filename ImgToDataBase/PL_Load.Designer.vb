<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PL_Load
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
        Me.Pic = New System.Windows.Forms.PictureBox()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        CType(Me.Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pic
        '
        Me.Pic.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Pic.Location = New System.Drawing.Point(44, 56)
        Me.Pic.Name = "Pic"
        Me.Pic.Size = New System.Drawing.Size(107, 129)
        Me.Pic.TabIndex = 0
        Me.Pic.TabStop = False
        '
        'PL_Load
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 262)
        Me.Controls.Add(Me.Pic)
        Me.Name = "PL_Load"
        Me.Text = "Form1"
        CType(Me.Pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Pic As System.Windows.Forms.PictureBox
    Friend WithEvents OFD As System.Windows.Forms.OpenFileDialog

End Class

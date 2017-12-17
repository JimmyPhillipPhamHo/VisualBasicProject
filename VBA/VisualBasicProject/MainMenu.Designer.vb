<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.btnChapter1_2 = New System.Windows.Forms.Button()
        Me.btnChapter3 = New System.Windows.Forms.Button()
        Me.btnChapter5 = New System.Windows.Forms.Button()
        Me.btnChapter4 = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnChapter8 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnChapter1_2
        '
        Me.btnChapter1_2.Location = New System.Drawing.Point(48, 87)
        Me.btnChapter1_2.Name = "btnChapter1_2"
        Me.btnChapter1_2.Size = New System.Drawing.Size(98, 33)
        Me.btnChapter1_2.TabIndex = 0
        Me.btnChapter1_2.Text = "Chapter 1 and  2"
        Me.btnChapter1_2.UseVisualStyleBackColor = True
        '
        'btnChapter3
        '
        Me.btnChapter3.Location = New System.Drawing.Point(48, 164)
        Me.btnChapter3.Name = "btnChapter3"
        Me.btnChapter3.Size = New System.Drawing.Size(98, 33)
        Me.btnChapter3.TabIndex = 1
        Me.btnChapter3.Text = "Chapter 3"
        Me.btnChapter3.UseVisualStyleBackColor = True
        '
        'btnChapter5
        '
        Me.btnChapter5.Location = New System.Drawing.Point(229, 164)
        Me.btnChapter5.Name = "btnChapter5"
        Me.btnChapter5.Size = New System.Drawing.Size(98, 33)
        Me.btnChapter5.TabIndex = 2
        Me.btnChapter5.Text = "Chapter 5"
        Me.btnChapter5.UseVisualStyleBackColor = True
        '
        'btnChapter4
        '
        Me.btnChapter4.Location = New System.Drawing.Point(229, 87)
        Me.btnChapter4.Name = "btnChapter4"
        Me.btnChapter4.Size = New System.Drawing.Size(98, 33)
        Me.btnChapter4.TabIndex = 3
        Me.btnChapter4.Text = "Chapter 4"
        Me.btnChapter4.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(229, 237)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(98, 33)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnChapter8
        '
        Me.btnChapter8.Location = New System.Drawing.Point(48, 237)
        Me.btnChapter8.Name = "btnChapter8"
        Me.btnChapter8.Size = New System.Drawing.Size(98, 33)
        Me.btnChapter8.TabIndex = 5
        Me.btnChapter8.Text = "Chapter 8"
        Me.btnChapter8.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(171, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Label1"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 336)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnChapter8)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnChapter4)
        Me.Controls.Add(Me.btnChapter5)
        Me.Controls.Add(Me.btnChapter3)
        Me.Controls.Add(Me.btnChapter1_2)
        Me.Name = "MainMenu"
        Me.Text = "Visual Basic"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnChapter1_2 As System.Windows.Forms.Button
    Friend WithEvents btnChapter3 As System.Windows.Forms.Button
    Friend WithEvents btnChapter5 As System.Windows.Forms.Button
    Friend WithEvents btnChapter4 As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnChapter8 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class

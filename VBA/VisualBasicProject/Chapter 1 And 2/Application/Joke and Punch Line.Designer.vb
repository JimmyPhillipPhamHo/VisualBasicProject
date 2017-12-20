<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JokeandPunchLine
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblPunchLine = New System.Windows.Forms.Label()
        Me.lblJoke = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnSetup = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(300, 197)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblPunchLine
        '
        Me.lblPunchLine.AutoSize = True
        Me.lblPunchLine.Location = New System.Drawing.Point(135, 134)
        Me.lblPunchLine.Name = "lblPunchLine"
        Me.lblPunchLine.Size = New System.Drawing.Size(135, 13)
        Me.lblPunchLine.TabIndex = 10
        Me.lblPunchLine.Text = "That's a hardware problem."
        Me.lblPunchLine.Visible = False
        '
        'lblJoke
        '
        Me.lblJoke.AutoSize = True
        Me.lblJoke.Location = New System.Drawing.Point(64, 94)
        Me.lblJoke.Name = "lblJoke"
        Me.lblJoke.Size = New System.Drawing.Size(289, 13)
        Me.lblJoke.TabIndex = 9
        Me.lblJoke.Text = "How many programmers does it take to change a light bulb?"
        Me.lblJoke.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(359, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Click buttons to display joke and punch line."
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(160, 197)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Punch Line"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnSetup
        '
        Me.btnSetup.Location = New System.Drawing.Point(28, 197)
        Me.btnSetup.Name = "btnSetup"
        Me.btnSetup.Size = New System.Drawing.Size(75, 23)
        Me.btnSetup.TabIndex = 6
        Me.btnSetup.Text = "Setup"
        Me.btnSetup.UseVisualStyleBackColor = True
        '
        'JokeandPunchLine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 256)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblPunchLine)
        Me.Controls.Add(Me.lblJoke)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnSetup)
        Me.Name = "JokeandPunchLine"
        Me.Text = "Joke and Punch Line"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblPunchLine As System.Windows.Forms.Label
    Friend WithEvents lblJoke As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnSetup As System.Windows.Forms.Button
End Class

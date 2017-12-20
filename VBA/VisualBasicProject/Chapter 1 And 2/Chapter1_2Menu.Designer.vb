<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chapter1_2Menu
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
        Me.btnGermanNumber = New System.Windows.Forms.Button()
        Me.btnKiloConverter = New System.Windows.Forms.Button()
        Me.btnJokeAndPunchLine = New System.Windows.Forms.Button()
        Me.btnLatinTranslator = New System.Windows.Forms.Button()
        Me.btnMathTutor = New System.Windows.Forms.Button()
        Me.btnNameAndAddress = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnGermanNumber
        '
        Me.btnGermanNumber.Location = New System.Drawing.Point(29, 81)
        Me.btnGermanNumber.Name = "btnGermanNumber"
        Me.btnGermanNumber.Size = New System.Drawing.Size(75, 37)
        Me.btnGermanNumber.TabIndex = 0
        Me.btnGermanNumber.Text = "German Number"
        Me.btnGermanNumber.UseVisualStyleBackColor = True
        '
        'btnKiloConverter
        '
        Me.btnKiloConverter.Location = New System.Drawing.Point(132, 81)
        Me.btnKiloConverter.Name = "btnKiloConverter"
        Me.btnKiloConverter.Size = New System.Drawing.Size(75, 37)
        Me.btnKiloConverter.TabIndex = 1
        Me.btnKiloConverter.Text = "Kilo Converter"
        Me.btnKiloConverter.UseVisualStyleBackColor = True
        '
        'btnJokeAndPunchLine
        '
        Me.btnJokeAndPunchLine.Location = New System.Drawing.Point(29, 149)
        Me.btnJokeAndPunchLine.Name = "btnJokeAndPunchLine"
        Me.btnJokeAndPunchLine.Size = New System.Drawing.Size(75, 37)
        Me.btnJokeAndPunchLine.TabIndex = 2
        Me.btnJokeAndPunchLine.Text = "Joke And Punch Line"
        Me.btnJokeAndPunchLine.UseVisualStyleBackColor = True
        '
        'btnLatinTranslator
        '
        Me.btnLatinTranslator.Location = New System.Drawing.Point(132, 149)
        Me.btnLatinTranslator.Name = "btnLatinTranslator"
        Me.btnLatinTranslator.Size = New System.Drawing.Size(75, 37)
        Me.btnLatinTranslator.TabIndex = 3
        Me.btnLatinTranslator.Text = "Latin Translator"
        Me.btnLatinTranslator.UseVisualStyleBackColor = True
        '
        'btnMathTutor
        '
        Me.btnMathTutor.Location = New System.Drawing.Point(234, 81)
        Me.btnMathTutor.Name = "btnMathTutor"
        Me.btnMathTutor.Size = New System.Drawing.Size(75, 37)
        Me.btnMathTutor.TabIndex = 4
        Me.btnMathTutor.Text = "Math Tutor"
        Me.btnMathTutor.UseVisualStyleBackColor = True
        '
        'btnNameAndAddress
        '
        Me.btnNameAndAddress.Location = New System.Drawing.Point(234, 149)
        Me.btnNameAndAddress.Name = "btnNameAndAddress"
        Me.btnNameAndAddress.Size = New System.Drawing.Size(75, 37)
        Me.btnNameAndAddress.TabIndex = 5
        Me.btnNameAndAddress.Text = "Name and Address"
        Me.btnNameAndAddress.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(187, 210)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 37)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(45, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 24)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Chapter 1 And 2 Application"
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(78, 210)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(75, 37)
        Me.btnReturn.TabIndex = 21
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'Chapter1_2Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 273)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnNameAndAddress)
        Me.Controls.Add(Me.btnMathTutor)
        Me.Controls.Add(Me.btnLatinTranslator)
        Me.Controls.Add(Me.btnJokeAndPunchLine)
        Me.Controls.Add(Me.btnKiloConverter)
        Me.Controls.Add(Me.btnGermanNumber)
        Me.Name = "Chapter1_2Menu"
        Me.Text = "Chapter 1 and Chapter 2 "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGermanNumber As System.Windows.Forms.Button
    Friend WithEvents btnKiloConverter As System.Windows.Forms.Button
    Friend WithEvents btnJokeAndPunchLine As System.Windows.Forms.Button
    Friend WithEvents btnLatinTranslator As System.Windows.Forms.Button
    Friend WithEvents btnMathTutor As System.Windows.Forms.Button
    Friend WithEvents btnNameAndAddress As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnReturn As System.Windows.Forms.Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RaceCarGame
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
        Me.lblWinner = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblRRaceS = New System.Windows.Forms.Label()
        Me.lblBRaceS = New System.Windows.Forms.Label()
        Me.lblORaceS = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.picBCar = New System.Windows.Forms.PictureBox()
        Me.picOCar = New System.Windows.Forms.PictureBox()
        Me.picRCar = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBCar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOCar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRCar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWinner
        '
        Me.lblWinner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWinner.Location = New System.Drawing.Point(528, 31)
        Me.lblWinner.Name = "lblWinner"
        Me.lblWinner.Size = New System.Drawing.Size(113, 31)
        Me.lblWinner.TabIndex = 38
        Me.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblRRaceS)
        Me.GroupBox2.Controls.Add(Me.lblBRaceS)
        Me.GroupBox2.Controls.Add(Me.lblORaceS)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(457, 70)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Scores"
        '
        'lblRRaceS
        '
        Me.lblRRaceS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRRaceS.Location = New System.Drawing.Point(160, 25)
        Me.lblRRaceS.Name = "lblRRaceS"
        Me.lblRRaceS.Size = New System.Drawing.Size(132, 25)
        Me.lblRRaceS.TabIndex = 20
        Me.lblRRaceS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBRaceS
        '
        Me.lblBRaceS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBRaceS.Location = New System.Drawing.Point(311, 25)
        Me.lblBRaceS.Name = "lblBRaceS"
        Me.lblBRaceS.Size = New System.Drawing.Size(132, 25)
        Me.lblBRaceS.TabIndex = 19
        Me.lblBRaceS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblORaceS
        '
        Me.lblORaceS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblORaceS.Location = New System.Drawing.Point(6, 25)
        Me.lblORaceS.Name = "lblORaceS"
        Me.lblORaceS.Size = New System.Drawing.Size(132, 25)
        Me.lblORaceS.TabIndex = 18
        Me.lblORaceS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(238, 376)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(106, 25)
        Me.btnReset.TabIndex = 34
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(363, 376)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(106, 25)
        Me.btnExit.TabIndex = 33
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(115, 376)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(106, 25)
        Me.btnGo.TabIndex = 32
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.VisualBasicProject.My.Resources.Resources.download
        Me.PictureBox8.Location = New System.Drawing.Point(115, 95)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(526, 265)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 39
        Me.PictureBox8.TabStop = False
        '
        'picBCar
        '
        Me.picBCar.Location = New System.Drawing.Point(11, 186)
        Me.picBCar.Name = "picBCar"
        Me.picBCar.Size = New System.Drawing.Size(99, 47)
        Me.picBCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBCar.TabIndex = 27
        Me.picBCar.TabStop = False
        '
        'picOCar
        '
        Me.picOCar.Location = New System.Drawing.Point(11, 108)
        Me.picOCar.Name = "picOCar"
        Me.picOCar.Size = New System.Drawing.Size(99, 47)
        Me.picOCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picOCar.TabIndex = 25
        Me.picOCar.TabStop = False
        '
        'picRCar
        '
        Me.picRCar.Location = New System.Drawing.Point(10, 272)
        Me.picRCar.Name = "picRCar"
        Me.picRCar.Size = New System.Drawing.Size(99, 47)
        Me.picRCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picRCar.TabIndex = 26
        Me.picRCar.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(604, 95)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 265)
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Location = New System.Drawing.Point(507, 325)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(111, 35)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 37
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Location = New System.Drawing.Point(408, 325)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(111, 35)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 31
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Location = New System.Drawing.Point(309, 325)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(111, 35)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 30
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(217, 325)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(111, 35)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 29
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(115, 95)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(37, 265)
        Me.PictureBox2.TabIndex = 24
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(132, 325)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(111, 35)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 28
        Me.PictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(478, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Winner:"
        '
        'RaceCarGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 424)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblWinner)
        Me.Controls.Add(Me.picBCar)
        Me.Controls.Add(Me.picOCar)
        Me.Controls.Add(Me.picRCar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox8)
        Me.Name = "RaceCarGame"
        Me.Text = "RaceCarGame"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBCar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOCar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRCar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblWinner As System.Windows.Forms.Label
    Friend WithEvents picBCar As System.Windows.Forms.PictureBox
    Friend WithEvents picOCar As System.Windows.Forms.PictureBox
    Friend WithEvents picRCar As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblRRaceS As System.Windows.Forms.Label
    Friend WithEvents lblBRaceS As System.Windows.Forms.Label
    Friend WithEvents lblORaceS As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class

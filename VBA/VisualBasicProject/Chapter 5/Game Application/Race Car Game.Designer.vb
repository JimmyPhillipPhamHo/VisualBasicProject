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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picBCar = New System.Windows.Forms.PictureBox()
        Me.picOCar = New System.Windows.Forms.PictureBox()
        Me.picRCar = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.picBCar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOCar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRCar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnReset.Location = New System.Drawing.Point(230, 376)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(99, 36)
        Me.btnReset.TabIndex = 34
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(356, 376)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(99, 36)
        Me.btnExit.TabIndex = 33
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(115, 376)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(99, 36)
        Me.btnGo.TabIndex = 32
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
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
        'picBCar
        '
        Me.picBCar.Image = Global.VisualBasicProject.My.Resources.Resources.Star_Destroyer_Render
        Me.picBCar.Location = New System.Drawing.Point(36, 198)
        Me.picBCar.Name = "picBCar"
        Me.picBCar.Size = New System.Drawing.Size(99, 47)
        Me.picBCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBCar.TabIndex = 27
        Me.picBCar.TabStop = False
        '
        'picOCar
        '
        Me.picOCar.Image = Global.VisualBasicProject.My.Resources.Resources.cJuVjz0
        Me.picOCar.Location = New System.Drawing.Point(36, 117)
        Me.picOCar.Name = "picOCar"
        Me.picOCar.Size = New System.Drawing.Size(99, 47)
        Me.picOCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picOCar.TabIndex = 25
        Me.picOCar.TabStop = False
        '
        'picRCar
        '
        Me.picRCar.Image = Global.VisualBasicProject.My.Resources.Resources._5854ffbb4f6ae202fedf2672
        Me.picRCar.Location = New System.Drawing.Point(36, 288)
        Me.picRCar.Name = "picRCar"
        Me.picRCar.Size = New System.Drawing.Size(99, 47)
        Me.picRCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picRCar.TabIndex = 26
        Me.picRCar.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.VisualBasicProject.My.Resources.Resources.download
        Me.PictureBox8.Location = New System.Drawing.Point(184, 95)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(526, 265)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 39
        Me.PictureBox8.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.VisualBasicProject.My.Resources.Resources.Finsh_line
        Me.PictureBox1.Location = New System.Drawing.Point(599, 95)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(266, 265)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.VisualBasicProject.My.Resources.Resources.Start_line
        Me.PictureBox2.Location = New System.Drawing.Point(36, 95)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(257, 265)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 24
        Me.PictureBox2.TabStop = False
        '
        'RaceCarGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 437)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblWinner)
        Me.Controls.Add(Me.picBCar)
        Me.Controls.Add(Me.picOCar)
        Me.Controls.Add(Me.picRCar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "RaceCarGame"
        Me.Text = "RaceCarGame"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.picBCar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOCar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRCar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblWinner As System.Windows.Forms.Label
    Friend WithEvents picBCar As System.Windows.Forms.PictureBox
    Friend WithEvents picOCar As System.Windows.Forms.PictureBox
    Friend WithEvents picRCar As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblRRaceS As System.Windows.Forms.Label
    Friend WithEvents lblBRaceS As System.Windows.Forms.Label
    Friend WithEvents lblORaceS As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class

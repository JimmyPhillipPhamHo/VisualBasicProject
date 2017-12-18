<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RockPaperScissors
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
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblWins = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picRock = New System.Windows.Forms.PictureBox()
        Me.picScissors = New System.Windows.Forms.PictureBox()
        Me.picPaper = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTies = New System.Windows.Forms.Label()
        Me.lblLose = New System.Windows.Forms.Label()
        Me.btnRestart = New System.Windows.Forms.Button()
        CType(Me.picRock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picScissors, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPaper, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(177, 17)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(201, 179)
        Me.lblResult.TabIndex = 1
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(289, 314)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(89, 38)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblWins
        '
        Me.lblWins.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWins.Location = New System.Drawing.Point(254, 216)
        Me.lblWins.Name = "lblWins"
        Me.lblWins.Size = New System.Drawing.Size(95, 18)
        Me.lblWins.TabIndex = 8
        Me.lblWins.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(192, 219)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Your wins:"
        '
        'picRock
        '
        Me.picRock.Image = Global.VisualBasicProject.My.Resources.Resources.png_1345905_960_720
        Me.picRock.Location = New System.Drawing.Point(12, 251)
        Me.picRock.Name = "picRock"
        Me.picRock.Size = New System.Drawing.Size(125, 101)
        Me.picRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picRock.TabIndex = 10
        Me.picRock.TabStop = False
        '
        'picScissors
        '
        Me.picScissors.Image = Global.VisualBasicProject.My.Resources.Resources.Product_7_poz3_530x_2x
        Me.picScissors.Location = New System.Drawing.Point(12, 12)
        Me.picScissors.Name = "picScissors"
        Me.picScissors.Size = New System.Drawing.Size(125, 101)
        Me.picScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picScissors.TabIndex = 6
        Me.picScissors.TabStop = False
        '
        'picPaper
        '
        Me.picPaper.Image = Global.VisualBasicProject.My.Resources.Resources._580b585b2edbce24c47b2467
        Me.picPaper.Location = New System.Drawing.Point(12, 133)
        Me.picPaper.Name = "picPaper"
        Me.picPaper.Size = New System.Drawing.Size(125, 101)
        Me.picPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPaper.TabIndex = 5
        Me.picPaper.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(218, 245)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Ties:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(184, 271)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Your losses:"
        '
        'lblTies
        '
        Me.lblTies.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTies.Location = New System.Drawing.Point(254, 242)
        Me.lblTies.Name = "lblTies"
        Me.lblTies.Size = New System.Drawing.Size(95, 18)
        Me.lblTies.TabIndex = 13
        Me.lblTies.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLose
        '
        Me.lblLose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLose.Location = New System.Drawing.Point(254, 271)
        Me.lblLose.Name = "lblLose"
        Me.lblLose.Size = New System.Drawing.Size(95, 18)
        Me.lblLose.TabIndex = 14
        Me.lblLose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnRestart
        '
        Me.btnRestart.Location = New System.Drawing.Point(187, 314)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(89, 38)
        Me.btnRestart.TabIndex = 15
        Me.btnRestart.Text = "Restart"
        Me.btnRestart.UseVisualStyleBackColor = True
        '
        'RockPaperScissors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 371)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.lblLose)
        Me.Controls.Add(Me.lblTies)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.picRock)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblWins)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.picScissors)
        Me.Controls.Add(Me.picPaper)
        Me.Controls.Add(Me.lblResult)
        Me.Name = "RockPaperScissors"
        Me.Text = "Rock Paper Scissors"
        CType(Me.picRock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picScissors, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPaper, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents picPaper As System.Windows.Forms.PictureBox
    Friend WithEvents picScissors As System.Windows.Forms.PictureBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblWins As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents picRock As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTies As System.Windows.Forms.Label
    Friend WithEvents lblLose As System.Windows.Forms.Label
    Friend WithEvents btnRestart As System.Windows.Forms.Button
End Class

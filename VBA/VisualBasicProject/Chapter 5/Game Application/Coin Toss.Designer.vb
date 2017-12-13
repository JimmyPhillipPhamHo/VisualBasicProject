<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CoinToss
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
        Me.lblTailsTotal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblHeadsTotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnTossCoin = New System.Windows.Forms.Button()
        Me.picTails = New System.Windows.Forms.PictureBox()
        Me.picHeads = New System.Windows.Forms.PictureBox()
        CType(Me.picTails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHeads, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTailsTotal
        '
        Me.lblTailsTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTailsTotal.Location = New System.Drawing.Point(333, 287)
        Me.lblTailsTotal.Name = "lblTailsTotal"
        Me.lblTailsTotal.Size = New System.Drawing.Size(58, 23)
        Me.lblTailsTotal.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(238, 287)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Total of Tails:"
        '
        'lblHeadsTotal
        '
        Me.lblHeadsTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHeadsTotal.Location = New System.Drawing.Point(131, 287)
        Me.lblHeadsTotal.Name = "lblHeadsTotal"
        Me.lblHeadsTotal.Size = New System.Drawing.Size(58, 23)
        Me.lblHeadsTotal.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 287)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Total of Heads:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(285, 243)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnTossCoin
        '
        Me.btnTossCoin.Location = New System.Drawing.Point(67, 243)
        Me.btnTossCoin.Name = "btnTossCoin"
        Me.btnTossCoin.Size = New System.Drawing.Size(75, 23)
        Me.btnTossCoin.TabIndex = 10
        Me.btnTossCoin.Text = "Toss Coin"
        Me.btnTossCoin.UseVisualStyleBackColor = True
        '
        'picTails
        '
        Me.picTails.Image = Global.VisualBasicProject.My.Resources.Resources.coin
        Me.picTails.Location = New System.Drawing.Point(241, 30)
        Me.picTails.Name = "picTails"
        Me.picTails.Size = New System.Drawing.Size(191, 177)
        Me.picTails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTails.TabIndex = 9
        Me.picTails.TabStop = False
        '
        'picHeads
        '
        Me.picHeads.Image = Global.VisualBasicProject.My.Resources.Resources.coin_2
        Me.picHeads.Location = New System.Drawing.Point(17, 30)
        Me.picHeads.Name = "picHeads"
        Me.picHeads.Size = New System.Drawing.Size(191, 177)
        Me.picHeads.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHeads.TabIndex = 8
        Me.picHeads.TabStop = False
        '
        'CoinToss
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 341)
        Me.Controls.Add(Me.lblTailsTotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblHeadsTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnTossCoin)
        Me.Controls.Add(Me.picTails)
        Me.Controls.Add(Me.picHeads)
        Me.Name = "CoinToss"
        Me.Text = "Coin Toss"
        CType(Me.picTails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHeads, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTailsTotal As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblHeadsTotal As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnTossCoin As System.Windows.Forms.Button
    Friend WithEvents picTails As System.Windows.Forms.PictureBox
    Friend WithEvents picHeads As System.Windows.Forms.PictureBox
End Class

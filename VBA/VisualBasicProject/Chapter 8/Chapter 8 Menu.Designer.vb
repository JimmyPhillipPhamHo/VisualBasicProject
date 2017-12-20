<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chapter8Menu
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
        Me.btnSeatingChart = New System.Windows.Forms.Button()
        Me.btnLotteryNumbers = New System.Windows.Forms.Button()
        Me.btnFriendsList = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnFriendsList2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSeatingChart
        '
        Me.btnSeatingChart.Location = New System.Drawing.Point(17, 19)
        Me.btnSeatingChart.Name = "btnSeatingChart"
        Me.btnSeatingChart.Size = New System.Drawing.Size(94, 44)
        Me.btnSeatingChart.TabIndex = 0
        Me.btnSeatingChart.Text = "The Seating Chart"
        Me.btnSeatingChart.UseVisualStyleBackColor = True
        '
        'btnLotteryNumbers
        '
        Me.btnLotteryNumbers.Location = New System.Drawing.Point(17, 77)
        Me.btnLotteryNumbers.Name = "btnLotteryNumbers"
        Me.btnLotteryNumbers.Size = New System.Drawing.Size(94, 44)
        Me.btnLotteryNumbers.TabIndex = 1
        Me.btnLotteryNumbers.Text = "The Lottery Numbers"
        Me.btnLotteryNumbers.UseVisualStyleBackColor = True
        '
        'btnFriendsList
        '
        Me.btnFriendsList.Location = New System.Drawing.Point(128, 19)
        Me.btnFriendsList.Name = "btnFriendsList"
        Me.btnFriendsList.Size = New System.Drawing.Size(94, 44)
        Me.btnFriendsList.TabIndex = 2
        Me.btnFriendsList.Text = "Friends List"
        Me.btnFriendsList.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(281, 105)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(88, 37)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnFriendsList2
        '
        Me.btnFriendsList2.Location = New System.Drawing.Point(128, 77)
        Me.btnFriendsList2.Name = "btnFriendsList2"
        Me.btnFriendsList2.Size = New System.Drawing.Size(94, 44)
        Me.btnFriendsList2.TabIndex = 4
        Me.btnFriendsList2.Text = "Friends List 2"
        Me.btnFriendsList2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnFriendsList2)
        Me.GroupBox1.Controls.Add(Me.btnSeatingChart)
        Me.GroupBox1.Controls.Add(Me.btnLotteryNumbers)
        Me.GroupBox1.Controls.Add(Me.btnFriendsList)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(243, 144)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Array Applications"
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(281, 47)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(89, 37)
        Me.btnReturn.TabIndex = 21
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'Chapter8Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 190)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "Chapter8Menu"
        Me.Text = "Chapter 8"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSeatingChart As System.Windows.Forms.Button
    Friend WithEvents btnLotteryNumbers As System.Windows.Forms.Button
    Friend WithEvents btnFriendsList As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnFriendsList2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnReturn As System.Windows.Forms.Button
End Class

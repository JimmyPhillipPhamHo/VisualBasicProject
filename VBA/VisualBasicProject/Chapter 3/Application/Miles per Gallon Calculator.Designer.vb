<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MilesPerGallonCalculator
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblMilesPerGallon = New System.Windows.Forms.Label()
        Me.txtGallonSize = New System.Windows.Forms.TextBox()
        Me.txtMilesWithFullTank = New System.Windows.Forms.TextBox()
        Me.btnCalculator = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblError = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(30, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gallons of the car can hold:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(30, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 40)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Number of miles it can be driven on a full tank:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Miles per gallon:"
        '
        'lblMilesPerGallon
        '
        Me.lblMilesPerGallon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMilesPerGallon.Location = New System.Drawing.Point(153, 129)
        Me.lblMilesPerGallon.Name = "lblMilesPerGallon"
        Me.lblMilesPerGallon.Size = New System.Drawing.Size(115, 23)
        Me.lblMilesPerGallon.TabIndex = 3
        '
        'txtGallonSize
        '
        Me.txtGallonSize.Location = New System.Drawing.Point(153, 28)
        Me.txtGallonSize.Name = "txtGallonSize"
        Me.txtGallonSize.Size = New System.Drawing.Size(115, 20)
        Me.txtGallonSize.TabIndex = 4
        '
        'txtMilesWithFullTank
        '
        Me.txtMilesWithFullTank.Location = New System.Drawing.Point(153, 76)
        Me.txtMilesWithFullTank.Name = "txtMilesWithFullTank"
        Me.txtMilesWithFullTank.Size = New System.Drawing.Size(115, 20)
        Me.txtMilesWithFullTank.TabIndex = 5
        '
        'btnCalculator
        '
        Me.btnCalculator.Location = New System.Drawing.Point(33, 175)
        Me.btnCalculator.Name = "btnCalculator"
        Me.btnCalculator.Size = New System.Drawing.Size(75, 34)
        Me.btnCalculator.TabIndex = 6
        Me.btnCalculator.Text = "Calculator MPG"
        Me.btnCalculator.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(139, 175)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 34)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(242, 175)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 34)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblError
        '
        Me.lblError.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblError.Location = New System.Drawing.Point(2, 232)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(356, 22)
        Me.lblError.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 254)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculator)
        Me.Controls.Add(Me.txtMilesWithFullTank)
        Me.Controls.Add(Me.txtGallonSize)
        Me.Controls.Add(Me.lblMilesPerGallon)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MilesPerGallonCalculator"
        Me.Text = "Miles per Gallon Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblMilesPerGallon As System.Windows.Forms.Label
    Friend WithEvents txtGallonSize As System.Windows.Forms.TextBox
    Friend WithEvents txtMilesWithFullTank As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculator As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblError As System.Windows.Forms.Label

End Class

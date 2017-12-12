<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RadioButtonCheckBoxDemo
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
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radSoftDrink = New System.Windows.Forms.RadioButton()
        Me.radTea = New System.Windows.Forms.RadioButton()
        Me.radCoffee = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkAmaretto = New System.Windows.Forms.CheckBox()
        Me.chkMoca = New System.Windows.Forms.CheckBox()
        Me.chkWhippedCream = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(101, 202)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(269, 202)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 282)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(447, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radSoftDrink)
        Me.GroupBox1.Controls.Add(Me.radTea)
        Me.GroupBox1.Controls.Add(Me.radCoffee)
        Me.GroupBox1.Location = New System.Drawing.Point(40, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(145, 133)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a Drink"
        '
        'radSoftDrink
        '
        Me.radSoftDrink.AutoSize = True
        Me.radSoftDrink.Location = New System.Drawing.Point(24, 92)
        Me.radSoftDrink.Name = "radSoftDrink"
        Me.radSoftDrink.Size = New System.Drawing.Size(72, 17)
        Me.radSoftDrink.TabIndex = 2
        Me.radSoftDrink.TabStop = True
        Me.radSoftDrink.Text = "Soft Drink"
        Me.radSoftDrink.UseVisualStyleBackColor = True
        '
        'radTea
        '
        Me.radTea.AutoSize = True
        Me.radTea.Location = New System.Drawing.Point(24, 58)
        Me.radTea.Name = "radTea"
        Me.radTea.Size = New System.Drawing.Size(44, 17)
        Me.radTea.TabIndex = 1
        Me.radTea.TabStop = True
        Me.radTea.Text = "Tea"
        Me.radTea.UseVisualStyleBackColor = True
        '
        'radCoffee
        '
        Me.radCoffee.AutoSize = True
        Me.radCoffee.Location = New System.Drawing.Point(24, 30)
        Me.radCoffee.Name = "radCoffee"
        Me.radCoffee.Size = New System.Drawing.Size(56, 17)
        Me.radCoffee.TabIndex = 0
        Me.radCoffee.TabStop = True
        Me.radCoffee.Text = "Coffee"
        Me.radCoffee.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkAmaretto)
        Me.GroupBox2.Controls.Add(Me.chkMoca)
        Me.GroupBox2.Controls.Add(Me.chkWhippedCream)
        Me.GroupBox2.Location = New System.Drawing.Point(224, 29)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(182, 133)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select Extras"
        '
        'chkAmaretto
        '
        Me.chkAmaretto.AutoSize = True
        Me.chkAmaretto.Location = New System.Drawing.Point(25, 92)
        Me.chkAmaretto.Name = "chkAmaretto"
        Me.chkAmaretto.Size = New System.Drawing.Size(68, 17)
        Me.chkAmaretto.TabIndex = 2
        Me.chkAmaretto.Text = "Amaretto"
        Me.chkAmaretto.UseVisualStyleBackColor = True
        '
        'chkMoca
        '
        Me.chkMoca.AutoSize = True
        Me.chkMoca.Location = New System.Drawing.Point(25, 58)
        Me.chkMoca.Name = "chkMoca"
        Me.chkMoca.Size = New System.Drawing.Size(53, 17)
        Me.chkMoca.TabIndex = 1
        Me.chkMoca.Text = "Moca"
        Me.chkMoca.UseVisualStyleBackColor = True
        '
        'chkWhippedCream
        '
        Me.chkWhippedCream.AutoSize = True
        Me.chkWhippedCream.Location = New System.Drawing.Point(25, 35)
        Me.chkWhippedCream.Name = "chkWhippedCream"
        Me.chkWhippedCream.Size = New System.Drawing.Size(102, 17)
        Me.chkWhippedCream.TabIndex = 0
        Me.chkWhippedCream.Text = "Whipped Cream"
        Me.chkWhippedCream.UseVisualStyleBackColor = True
        '
        'RadioButtonCheckBoxDemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 304)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOK)
        Me.Name = "RadioButtonCheckBoxDemo"
        Me.Text = "RadioButtonCheckBoxDemo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radSoftDrink As System.Windows.Forms.RadioButton
    Friend WithEvents radTea As System.Windows.Forms.RadioButton
    Friend WithEvents radCoffee As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkAmaretto As System.Windows.Forms.CheckBox
    Friend WithEvents chkMoca As System.Windows.Forms.CheckBox
    Friend WithEvents chkWhippedCream As System.Windows.Forms.CheckBox
End Class

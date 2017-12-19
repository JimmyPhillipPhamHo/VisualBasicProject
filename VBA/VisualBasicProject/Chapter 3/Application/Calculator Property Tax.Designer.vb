<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalculatingPropertyTax
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
        Me.btnCalculateAAT = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblError = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblAssessmentVaule = New System.Windows.Forms.Label()
        Me.txtActualPropertyValue = New System.Windows.Forms.TextBox()
        Me.lblPropertyTax = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalculateAAT
        '
        Me.btnCalculateAAT.Location = New System.Drawing.Point(50, 113)
        Me.btnCalculateAAT.Name = "btnCalculateAAT"
        Me.btnCalculateAAT.Size = New System.Drawing.Size(93, 23)
        Me.btnCalculateAAT.TabIndex = 0
        Me.btnCalculateAAT.Text = "Calculate AAT"
        Me.btnCalculateAAT.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(198, 113)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(93, 23)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(337, 113)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(93, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter actual property value here:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(201, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Assesment value:"
        '
        'lblError
        '
        Me.lblError.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblError.Location = New System.Drawing.Point(1, 149)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(472, 20)
        Me.lblError.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(225, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Property tax:"
        '
        'lblAssessmentVaule
        '
        Me.lblAssessmentVaule.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAssessmentVaule.Location = New System.Drawing.Point(318, 33)
        Me.lblAssessmentVaule.Name = "lblAssessmentVaule"
        Me.lblAssessmentVaule.Size = New System.Drawing.Size(112, 20)
        Me.lblAssessmentVaule.TabIndex = 7
        '
        'txtActualPropertyValue
        '
        Me.txtActualPropertyValue.Location = New System.Drawing.Point(26, 62)
        Me.txtActualPropertyValue.Name = "txtActualPropertyValue"
        Me.txtActualPropertyValue.Size = New System.Drawing.Size(147, 20)
        Me.txtActualPropertyValue.TabIndex = 9
        '
        'lblPropertyTax
        '
        Me.lblPropertyTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPropertyTax.Location = New System.Drawing.Point(318, 65)
        Me.lblPropertyTax.Name = "lblPropertyTax"
        Me.lblPropertyTax.Size = New System.Drawing.Size(112, 20)
        Me.lblPropertyTax.TabIndex = 10
        '
        'CalculatingPropertyTax
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 170)
        Me.Controls.Add(Me.lblPropertyTax)
        Me.Controls.Add(Me.txtActualPropertyValue)
        Me.Controls.Add(Me.lblAssessmentVaule)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculateAAT)
        Me.Name = "CalculatingPropertyTax"
        Me.Text = "Calculating Property Tax"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalculateAAT As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblAssessmentVaule As System.Windows.Forms.Label
    Friend WithEvents txtActualPropertyValue As System.Windows.Forms.TextBox
    Friend WithEvents lblPropertyTax As System.Windows.Forms.Label

End Class


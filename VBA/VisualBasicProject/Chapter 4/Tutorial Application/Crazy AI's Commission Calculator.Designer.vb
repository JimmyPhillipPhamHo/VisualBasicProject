<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrazyAI_sCommissionCalculator
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
        Me.lblStatus = New System.Windows.Forms.StatusStrip()
        Me.lblNetPay = New System.Windows.Forms.Label()
        Me.lblCommissionAmount = New System.Windows.Forms.Label()
        Me.txtSalesAmount = New System.Windows.Forms.TextBox()
        Me.txtAdvancePayAmount = New System.Windows.Forms.TextBox()
        Me.lblCommissionRate = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(0, 310)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(429, 22)
        Me.lblStatus.TabIndex = 32
        Me.lblStatus.Text = "StatusStrip1"
        '
        'lblNetPay
        '
        Me.lblNetPay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNetPay.Location = New System.Drawing.Point(211, 188)
        Me.lblNetPay.Name = "lblNetPay"
        Me.lblNetPay.Size = New System.Drawing.Size(129, 23)
        Me.lblNetPay.TabIndex = 31
        '
        'lblCommissionAmount
        '
        Me.lblCommissionAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCommissionAmount.Location = New System.Drawing.Point(211, 147)
        Me.lblCommissionAmount.Name = "lblCommissionAmount"
        Me.lblCommissionAmount.Size = New System.Drawing.Size(129, 23)
        Me.lblCommissionAmount.TabIndex = 30
        '
        'txtSalesAmount
        '
        Me.txtSalesAmount.Location = New System.Drawing.Point(211, 17)
        Me.txtSalesAmount.Name = "txtSalesAmount"
        Me.txtSalesAmount.Size = New System.Drawing.Size(129, 20)
        Me.txtSalesAmount.TabIndex = 29
        '
        'txtAdvancePayAmount
        '
        Me.txtAdvancePayAmount.Location = New System.Drawing.Point(211, 57)
        Me.txtAdvancePayAmount.Name = "txtAdvancePayAmount"
        Me.txtAdvancePayAmount.Size = New System.Drawing.Size(129, 20)
        Me.txtAdvancePayAmount.TabIndex = 28
        '
        'lblCommissionRate
        '
        Me.lblCommissionRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCommissionRate.Location = New System.Drawing.Point(211, 106)
        Me.lblCommissionRate.Name = "lblCommissionRate"
        Me.lblCommissionRate.Size = New System.Drawing.Size(129, 23)
        Me.lblCommissionRate.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(143, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Net Pay:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(126, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Commission:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(100, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Commission Rate:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Advance pay awarded:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(90, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Sales for the month:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(289, 245)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(99, 23)
        Me.btnExit.TabIndex = 21
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(165, 245)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(96, 23)
        Me.btnClear.TabIndex = 20
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(31, 245)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(96, 23)
        Me.btnCalculate.TabIndex = 19
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'CrazyAI_sCommissionCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 332)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblNetPay)
        Me.Controls.Add(Me.lblCommissionAmount)
        Me.Controls.Add(Me.txtSalesAmount)
        Me.Controls.Add(Me.txtAdvancePayAmount)
        Me.Controls.Add(Me.lblCommissionRate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "CrazyAI_sCommissionCalculator"
        Me.Text = "CrazyAI_sCommissionCalculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblStatus As System.Windows.Forms.StatusStrip
    Friend WithEvents lblNetPay As System.Windows.Forms.Label
    Friend WithEvents lblCommissionAmount As System.Windows.Forms.Label
    Friend WithEvents txtSalesAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtAdvancePayAmount As System.Windows.Forms.TextBox
    Friend WithEvents lblCommissionRate As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
End Class

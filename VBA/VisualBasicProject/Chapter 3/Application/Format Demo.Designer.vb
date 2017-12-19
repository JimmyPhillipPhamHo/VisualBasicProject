<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormatDemo
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
        Me.btnNumberFormat = New System.Windows.Forms.Button()
        Me.btnShortDate = New System.Windows.Forms.Button()
        Me.btnFixedPointFormat = New System.Windows.Forms.Button()
        Me.btnLongDate = New System.Windows.Forms.Button()
        Me.btnExponentialFormat = New System.Windows.Forms.Button()
        Me.btnShortTime = New System.Windows.Forms.Button()
        Me.btnCurrencyFormat = New System.Windows.Forms.Button()
        Me.btnLongTime = New System.Windows.Forms.Button()
        Me.btnFullDateTime = New System.Windows.Forms.Button()
        Me.lblNumberDate = New System.Windows.Forms.Label()
        Me.lblFormatted = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnPercentFormat = New System.Windows.Forms.Button()
        Me.txtUserInput = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNumberFormat
        '
        Me.btnNumberFormat.Location = New System.Drawing.Point(49, 58)
        Me.btnNumberFormat.Name = "btnNumberFormat"
        Me.btnNumberFormat.Size = New System.Drawing.Size(117, 23)
        Me.btnNumberFormat.TabIndex = 0
        Me.btnNumberFormat.Text = "Number format (n)"
        Me.btnNumberFormat.UseVisualStyleBackColor = True
        '
        'btnShortDate
        '
        Me.btnShortDate.Location = New System.Drawing.Point(233, 58)
        Me.btnShortDate.Name = "btnShortDate"
        Me.btnShortDate.Size = New System.Drawing.Size(103, 23)
        Me.btnShortDate.TabIndex = 1
        Me.btnShortDate.Text = "Short date (d)"
        Me.btnShortDate.UseVisualStyleBackColor = True
        '
        'btnFixedPointFormat
        '
        Me.btnFixedPointFormat.Location = New System.Drawing.Point(49, 87)
        Me.btnFixedPointFormat.Name = "btnFixedPointFormat"
        Me.btnFixedPointFormat.Size = New System.Drawing.Size(117, 23)
        Me.btnFixedPointFormat.TabIndex = 2
        Me.btnFixedPointFormat.Text = "Fixed-point format (f)"
        Me.btnFixedPointFormat.UseVisualStyleBackColor = True
        '
        'btnLongDate
        '
        Me.btnLongDate.Location = New System.Drawing.Point(233, 87)
        Me.btnLongDate.Name = "btnLongDate"
        Me.btnLongDate.Size = New System.Drawing.Size(103, 23)
        Me.btnLongDate.TabIndex = 3
        Me.btnLongDate.Text = "Long date (D)"
        Me.btnLongDate.UseVisualStyleBackColor = True
        '
        'btnExponentialFormat
        '
        Me.btnExponentialFormat.Location = New System.Drawing.Point(49, 116)
        Me.btnExponentialFormat.Name = "btnExponentialFormat"
        Me.btnExponentialFormat.Size = New System.Drawing.Size(117, 23)
        Me.btnExponentialFormat.TabIndex = 4
        Me.btnExponentialFormat.Text = "Exponential format (e)"
        Me.btnExponentialFormat.UseVisualStyleBackColor = True
        '
        'btnShortTime
        '
        Me.btnShortTime.Location = New System.Drawing.Point(233, 116)
        Me.btnShortTime.Name = "btnShortTime"
        Me.btnShortTime.Size = New System.Drawing.Size(103, 23)
        Me.btnShortTime.TabIndex = 5
        Me.btnShortTime.Text = "Short time (t)"
        Me.btnShortTime.UseVisualStyleBackColor = True
        '
        'btnCurrencyFormat
        '
        Me.btnCurrencyFormat.Location = New System.Drawing.Point(49, 145)
        Me.btnCurrencyFormat.Name = "btnCurrencyFormat"
        Me.btnCurrencyFormat.Size = New System.Drawing.Size(117, 23)
        Me.btnCurrencyFormat.TabIndex = 6
        Me.btnCurrencyFormat.Text = "Currency format (c)"
        Me.btnCurrencyFormat.UseVisualStyleBackColor = True
        '
        'btnLongTime
        '
        Me.btnLongTime.Location = New System.Drawing.Point(233, 145)
        Me.btnLongTime.Name = "btnLongTime"
        Me.btnLongTime.Size = New System.Drawing.Size(103, 23)
        Me.btnLongTime.TabIndex = 7
        Me.btnLongTime.Text = "Long time (T)"
        Me.btnLongTime.UseVisualStyleBackColor = True
        '
        'btnFullDateTime
        '
        Me.btnFullDateTime.Location = New System.Drawing.Point(233, 174)
        Me.btnFullDateTime.Name = "btnFullDateTime"
        Me.btnFullDateTime.Size = New System.Drawing.Size(103, 23)
        Me.btnFullDateTime.TabIndex = 8
        Me.btnFullDateTime.Text = "Full date/time (F)"
        Me.btnFullDateTime.UseVisualStyleBackColor = True
        '
        'lblNumberDate
        '
        Me.lblNumberDate.AutoSize = True
        Me.lblNumberDate.Location = New System.Drawing.Point(62, 31)
        Me.lblNumberDate.Name = "lblNumberDate"
        Me.lblNumberDate.Size = New System.Drawing.Size(118, 13)
        Me.lblNumberDate.TabIndex = 9
        Me.lblNumberDate.Text = "Enter a number or date:"
        '
        'lblFormatted
        '
        Me.lblFormatted.AutoSize = True
        Me.lblFormatted.Location = New System.Drawing.Point(62, 82)
        Me.lblFormatted.Name = "lblFormatted"
        Me.lblFormatted.Size = New System.Drawing.Size(54, 13)
        Me.lblFormatted.TabIndex = 10
        Me.lblFormatted.Text = "Formatted"
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(140, 81)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(237, 25)
        Me.lblResult.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnPercentFormat)
        Me.GroupBox1.Controls.Add(Me.btnFullDateTime)
        Me.GroupBox1.Controls.Add(Me.btnLongTime)
        Me.GroupBox1.Controls.Add(Me.btnCurrencyFormat)
        Me.GroupBox1.Controls.Add(Me.btnShortTime)
        Me.GroupBox1.Controls.Add(Me.btnExponentialFormat)
        Me.GroupBox1.Controls.Add(Me.btnNumberFormat)
        Me.GroupBox1.Controls.Add(Me.btnShortDate)
        Me.GroupBox1.Controls.Add(Me.btnFixedPointFormat)
        Me.GroupBox1.Controls.Add(Me.btnLongDate)
        Me.GroupBox1.Location = New System.Drawing.Point(41, 127)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(379, 243)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a Format"
        '
        'btnPercentFormat
        '
        Me.btnPercentFormat.Location = New System.Drawing.Point(49, 174)
        Me.btnPercentFormat.Name = "btnPercentFormat"
        Me.btnPercentFormat.Size = New System.Drawing.Size(117, 23)
        Me.btnPercentFormat.TabIndex = 9
        Me.btnPercentFormat.Text = "Percent format (p)"
        Me.btnPercentFormat.UseVisualStyleBackColor = True
        '
        'txtUserInput
        '
        Me.txtUserInput.Location = New System.Drawing.Point(209, 28)
        Me.txtUserInput.Name = "txtUserInput"
        Me.txtUserInput.Size = New System.Drawing.Size(100, 20)
        Me.txtUserInput.TabIndex = 13
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(365, 25)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'FormatDemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 403)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtUserInput)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblFormatted)
        Me.Controls.Add(Me.lblNumberDate)
        Me.Name = "FormatDemo"
        Me.Text = "Format Demo"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNumberFormat As System.Windows.Forms.Button
    Friend WithEvents btnShortDate As System.Windows.Forms.Button
    Friend WithEvents btnFixedPointFormat As System.Windows.Forms.Button
    Friend WithEvents btnLongDate As System.Windows.Forms.Button
    Friend WithEvents btnExponentialFormat As System.Windows.Forms.Button
    Friend WithEvents btnShortTime As System.Windows.Forms.Button
    Friend WithEvents btnCurrencyFormat As System.Windows.Forms.Button
    Friend WithEvents btnLongTime As System.Windows.Forms.Button
    Friend WithEvents btnFullDateTime As System.Windows.Forms.Button
    Friend WithEvents lblNumberDate As System.Windows.Forms.Label
    Friend WithEvents lblFormatted As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtUserInput As System.Windows.Forms.TextBox
    Friend WithEvents btnPercentFormat As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class

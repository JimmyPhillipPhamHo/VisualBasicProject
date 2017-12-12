<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForNextDemo2
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
        Me.btnGo = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picPropellerCap = New System.Windows.Forms.PictureBox()
        CType(Me.picPropellerCap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(176, 174)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 23)
        Me.btnGo.TabIndex = 0
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(354, 174)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'picPropellerCap
        '
        Me.picPropellerCap.Image = Global.VisualBasicProject.My.Resources.Resources.Green_Propeller_Cap_clothing_icon_ID_1075
        Me.picPropellerCap.Location = New System.Drawing.Point(42, 32)
        Me.picPropellerCap.Name = "picPropellerCap"
        Me.picPropellerCap.Size = New System.Drawing.Size(121, 87)
        Me.picPropellerCap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPropellerCap.TabIndex = 2
        Me.picPropellerCap.TabStop = False
        '
        'ForNextDemo2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 238)
        Me.Controls.Add(Me.picPropellerCap)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnGo)
        Me.Name = "ForNextDemo2"
        Me.Text = "For Next Demo 2"
        CType(Me.picPropellerCap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents picPropellerCap As System.Windows.Forms.PictureBox
End Class

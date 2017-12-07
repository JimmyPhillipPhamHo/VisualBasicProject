<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RightTriangle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RightTriangle))
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtSideC = New System.Windows.Forms.TextBox()
        Me.txtSideB = New System.Windows.Forms.TextBox()
        Me.txtSideA = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioC = New System.Windows.Forms.RadioButton()
        Me.RadioB = New System.Windows.Forms.RadioButton()
        Me.RadioA = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        resources.ApplyResources(Me.btnCalculate, "btnCalculate")
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtSideC
        '
        resources.ApplyResources(Me.txtSideC, "txtSideC")
        Me.txtSideC.Name = "txtSideC"
        '
        'txtSideB
        '
        resources.ApplyResources(Me.txtSideB, "txtSideB")
        Me.txtSideB.Name = "txtSideB"
        '
        'txtSideA
        '
        resources.ApplyResources(Me.txtSideA, "txtSideA")
        Me.txtSideA.Name = "txtSideA"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioC)
        Me.GroupBox1.Controls.Add(Me.RadioB)
        Me.GroupBox1.Controls.Add(Me.RadioA)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'RadioC
        '
        resources.ApplyResources(Me.RadioC, "RadioC")
        Me.RadioC.Name = "RadioC"
        Me.RadioC.TabStop = True
        Me.RadioC.UseVisualStyleBackColor = True
        '
        'RadioB
        '
        resources.ApplyResources(Me.RadioB, "RadioB")
        Me.RadioB.Name = "RadioB"
        Me.RadioB.TabStop = True
        Me.RadioB.UseVisualStyleBackColor = True
        '
        'RadioA
        '
        resources.ApplyResources(Me.RadioA, "RadioA")
        Me.RadioA.Name = "RadioA"
        Me.RadioA.TabStop = True
        Me.RadioA.UseVisualStyleBackColor = True
        '
        'RightTriangle
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtSideC)
        Me.Controls.Add(Me.txtSideB)
        Me.Controls.Add(Me.txtSideA)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "RightTriangle"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents txtSideC As System.Windows.Forms.TextBox
    Friend WithEvents txtSideB As System.Windows.Forms.TextBox
    Friend WithEvents txtSideA As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioC As System.Windows.Forms.RadioButton
    Friend WithEvents RadioB As System.Windows.Forms.RadioButton
    Friend WithEvents RadioA As System.Windows.Forms.RadioButton
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderingFood
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.radWalffleFries = New System.Windows.Forms.RadioButton()
        Me.radFries = New System.Windows.Forms.RadioButton()
        Me.radCurlyFries = New System.Windows.Forms.RadioButton()
        Me.radChips = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkSpinach = New System.Windows.Forms.CheckBox()
        Me.chkOnion = New System.Windows.Forms.CheckBox()
        Me.chkPickles = New System.Windows.Forms.CheckBox()
        Me.chkMayo = New System.Windows.Forms.CheckBox()
        Me.chkLettuce = New System.Windows.Forms.CheckBox()
        Me.chkTomato = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radSpicyChickenSandwich = New System.Windows.Forms.RadioButton()
        Me.radChickenSandwich = New System.Windows.Forms.RadioButton()
        Me.radCheeseBurger = New System.Windows.Forms.RadioButton()
        Me.radHamburger = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(603, 199)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(86, 35)
        Me.btnExit.TabIndex = 26
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(650, 158)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(86, 35)
        Me.btnClear.TabIndex = 25
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(613, 124)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(123, 19)
        Me.lblTotal.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Script", 17.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(114, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(520, 36)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Welcome to Generic Fast Food Restaurant"
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(549, 58)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(187, 61)
        Me.lblResult.TabIndex = 21
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(549, 158)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(86, 35)
        Me.btnEnter.TabIndex = 20
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.radWalffleFries)
        Me.GroupBox3.Controls.Add(Me.radFries)
        Me.GroupBox3.Controls.Add(Me.radCurlyFries)
        Me.GroupBox3.Controls.Add(Me.radChips)
        Me.GroupBox3.Location = New System.Drawing.Point(370, 58)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(154, 170)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Side Order"
        '
        'radWalffleFries
        '
        Me.radWalffleFries.AutoSize = True
        Me.radWalffleFries.Location = New System.Drawing.Point(6, 99)
        Me.radWalffleFries.Name = "radWalffleFries"
        Me.radWalffleFries.Size = New System.Drawing.Size(83, 17)
        Me.radWalffleFries.TabIndex = 7
        Me.radWalffleFries.TabStop = True
        Me.radWalffleFries.Text = "Walffle Fries"
        Me.radWalffleFries.UseVisualStyleBackColor = True
        '
        'radFries
        '
        Me.radFries.AutoSize = True
        Me.radFries.Location = New System.Drawing.Point(6, 34)
        Me.radFries.Name = "radFries"
        Me.radFries.Size = New System.Drawing.Size(47, 17)
        Me.radFries.TabIndex = 4
        Me.radFries.TabStop = True
        Me.radFries.Text = "Fries"
        Me.radFries.UseVisualStyleBackColor = True
        '
        'radCurlyFries
        '
        Me.radCurlyFries.AutoSize = True
        Me.radCurlyFries.Location = New System.Drawing.Point(6, 66)
        Me.radCurlyFries.Name = "radCurlyFries"
        Me.radCurlyFries.Size = New System.Drawing.Size(73, 17)
        Me.radCurlyFries.TabIndex = 5
        Me.radCurlyFries.TabStop = True
        Me.radCurlyFries.Text = "Curly Fries"
        Me.radCurlyFries.UseVisualStyleBackColor = True
        '
        'radChips
        '
        Me.radChips.AutoSize = True
        Me.radChips.Location = New System.Drawing.Point(6, 134)
        Me.radChips.Name = "radChips"
        Me.radChips.Size = New System.Drawing.Size(51, 17)
        Me.radChips.TabIndex = 6
        Me.radChips.TabStop = True
        Me.radChips.Text = "Chips"
        Me.radChips.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkSpinach)
        Me.GroupBox2.Controls.Add(Me.chkOnion)
        Me.GroupBox2.Controls.Add(Me.chkPickles)
        Me.GroupBox2.Controls.Add(Me.chkMayo)
        Me.GroupBox2.Controls.Add(Me.chkLettuce)
        Me.GroupBox2.Controls.Add(Me.chkTomato)
        Me.GroupBox2.Location = New System.Drawing.Point(201, 58)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(151, 170)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Toppings"
        '
        'chkSpinach
        '
        Me.chkSpinach.AutoSize = True
        Me.chkSpinach.Location = New System.Drawing.Point(80, 67)
        Me.chkSpinach.Name = "chkSpinach"
        Me.chkSpinach.Size = New System.Drawing.Size(65, 17)
        Me.chkSpinach.TabIndex = 5
        Me.chkSpinach.Text = "Spinach"
        Me.chkSpinach.UseVisualStyleBackColor = True
        '
        'chkOnion
        '
        Me.chkOnion.AutoSize = True
        Me.chkOnion.Location = New System.Drawing.Point(82, 35)
        Me.chkOnion.Name = "chkOnion"
        Me.chkOnion.Size = New System.Drawing.Size(54, 17)
        Me.chkOnion.TabIndex = 4
        Me.chkOnion.Text = "Onion"
        Me.chkOnion.UseVisualStyleBackColor = True
        '
        'chkPickles
        '
        Me.chkPickles.AutoSize = True
        Me.chkPickles.Location = New System.Drawing.Point(6, 135)
        Me.chkPickles.Name = "chkPickles"
        Me.chkPickles.Size = New System.Drawing.Size(60, 17)
        Me.chkPickles.TabIndex = 3
        Me.chkPickles.Text = "Pickles"
        Me.chkPickles.UseVisualStyleBackColor = True
        '
        'chkMayo
        '
        Me.chkMayo.AutoSize = True
        Me.chkMayo.Location = New System.Drawing.Point(6, 100)
        Me.chkMayo.Name = "chkMayo"
        Me.chkMayo.Size = New System.Drawing.Size(52, 17)
        Me.chkMayo.TabIndex = 2
        Me.chkMayo.Text = "Mayo"
        Me.chkMayo.UseVisualStyleBackColor = True
        '
        'chkLettuce
        '
        Me.chkLettuce.AutoSize = True
        Me.chkLettuce.Location = New System.Drawing.Point(6, 68)
        Me.chkLettuce.Name = "chkLettuce"
        Me.chkLettuce.Size = New System.Drawing.Size(62, 17)
        Me.chkLettuce.TabIndex = 1
        Me.chkLettuce.Text = "Lettuce"
        Me.chkLettuce.UseVisualStyleBackColor = True
        '
        'chkTomato
        '
        Me.chkTomato.AutoSize = True
        Me.chkTomato.Location = New System.Drawing.Point(6, 35)
        Me.chkTomato.Name = "chkTomato"
        Me.chkTomato.Size = New System.Drawing.Size(62, 17)
        Me.chkTomato.TabIndex = 0
        Me.chkTomato.Text = "Tomato"
        Me.chkTomato.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radSpicyChickenSandwich)
        Me.GroupBox1.Controls.Add(Me.radChickenSandwich)
        Me.GroupBox1.Controls.Add(Me.radCheeseBurger)
        Me.GroupBox1.Controls.Add(Me.radHamburger)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(167, 170)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select your meal"
        '
        'radSpicyChickenSandwich
        '
        Me.radSpicyChickenSandwich.AutoSize = True
        Me.radSpicyChickenSandwich.Location = New System.Drawing.Point(6, 134)
        Me.radSpicyChickenSandwich.Name = "radSpicyChickenSandwich"
        Me.radSpicyChickenSandwich.Size = New System.Drawing.Size(143, 17)
        Me.radSpicyChickenSandwich.TabIndex = 3
        Me.radSpicyChickenSandwich.TabStop = True
        Me.radSpicyChickenSandwich.Text = "Spicy Chicken Sandwich"
        Me.radSpicyChickenSandwich.UseVisualStyleBackColor = True
        '
        'radChickenSandwich
        '
        Me.radChickenSandwich.AutoSize = True
        Me.radChickenSandwich.Location = New System.Drawing.Point(7, 99)
        Me.radChickenSandwich.Name = "radChickenSandwich"
        Me.radChickenSandwich.Size = New System.Drawing.Size(114, 17)
        Me.radChickenSandwich.TabIndex = 2
        Me.radChickenSandwich.TabStop = True
        Me.radChickenSandwich.Text = "Chicken Sandwich"
        Me.radChickenSandwich.UseVisualStyleBackColor = True
        '
        'radCheeseBurger
        '
        Me.radCheeseBurger.AutoSize = True
        Me.radCheeseBurger.Location = New System.Drawing.Point(6, 67)
        Me.radCheeseBurger.Name = "radCheeseBurger"
        Me.radCheeseBurger.Size = New System.Drawing.Size(95, 17)
        Me.radCheeseBurger.TabIndex = 1
        Me.radCheeseBurger.TabStop = True
        Me.radCheeseBurger.Text = "Cheese Burger"
        Me.radCheeseBurger.UseVisualStyleBackColor = True
        '
        'radHamburger
        '
        Me.radHamburger.AutoSize = True
        Me.radHamburger.Location = New System.Drawing.Point(7, 35)
        Me.radHamburger.Name = "radHamburger"
        Me.radHamburger.Size = New System.Drawing.Size(77, 17)
        Me.radHamburger.TabIndex = 0
        Me.radHamburger.TabStop = True
        Me.radHamburger.Text = "Hamburger"
        Me.radHamburger.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(546, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Total Price:"
        '
        'OrderingFood
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 245)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "OrderingFood"
        Me.Text = "Ordering Food"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents radFries As System.Windows.Forms.RadioButton
    Friend WithEvents radCurlyFries As System.Windows.Forms.RadioButton
    Friend WithEvents radChips As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkPickles As System.Windows.Forms.CheckBox
    Friend WithEvents chkMayo As System.Windows.Forms.CheckBox
    Friend WithEvents chkLettuce As System.Windows.Forms.CheckBox
    Friend WithEvents chkTomato As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radSpicyChickenSandwich As System.Windows.Forms.RadioButton
    Friend WithEvents radChickenSandwich As System.Windows.Forms.RadioButton
    Friend WithEvents radCheeseBurger As System.Windows.Forms.RadioButton
    Friend WithEvents radHamburger As System.Windows.Forms.RadioButton
    Friend WithEvents chkSpinach As System.Windows.Forms.CheckBox
    Friend WithEvents chkOnion As System.Windows.Forms.CheckBox
    Friend WithEvents radWalffleFries As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class

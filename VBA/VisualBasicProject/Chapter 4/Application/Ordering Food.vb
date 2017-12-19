Public Class OrderingFood

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim dblBurger As Double = 5.99
        Dim dblCheese As Double = 5.99
        Dim dblChicken As Double = 5.99
        Dim dblHamTurkey As Double = 5.99
        Dim dblTomato As Double = 0.5
        Dim dblLettuce As Double = 0.5
        Dim dblMayo As Double = 0.5
        Dim dblPickles As Double = 0.5
        Dim dblOnions As Double = 0.5
        Dim dblSpinach As Double = 0.5
        Dim dblFries As Double = 1.99
        Dim dblCurlyFries As Double = 1.99
        Dim dblWalffleFries As Double = 1.99
        Dim dblChips As Double = 1.99
        Dim dblTotal As Double

        If radHamburger.Checked = True Then
            lblResult.Text = "You have selected Hambuger"
            dblTotal = dblBurger + dblTotal
        ElseIf radCheeseBurger.Checked = True Then
            lblResult.Text = "You have selected Cheese Buger"
            dblTotal = dblCheese + dblTotal
        ElseIf radChickenSandwich.Checked = True Then
            lblResult.Text = "You have selected Chicken Sandwich"
            dblTotal = dblChicken + dblTotal
        ElseIf radSpicyChickenSandwich.Checked = True Then
            lblResult.Text = "You have selected Spicy Chicken Sandwich"
            dblTotal = dblHamTurkey + dblTotal
        End If


        If chkTomato.Checked = True Then
            lblResult.Text &= ", and Tomato"
            dblTotal = dblTomato + dblTotal
        End If
        If chkLettuce.Checked = True Then
            lblResult.Text &= ", and Lettuce"
            dblTotal = dblLettuce + dblTotal
        End If
        If chkMayo.Checked = True Then
            lblResult.Text &= ", and Mayo"
            dblTotal = dblMayo + dblTotal
        End If
        If chkPickles.Checked = True Then
            lblResult.Text &= ", and Pickles"
            dblTotal = dblPickles + dblTotal
        End If
        If chkOnion.Checked = True Then
            lblResult.Text &= ", and Onions"
            dblTotal = dblPickles + dblTotal
        End If
        If chkSpinach.Checked = True Then
            lblResult.Text &= ", and Spianch"
            dblTotal = dblPickles + dblTotal
        End If


        If radFries.Checked = True Then
            lblResult.Text &= ", and Fries"
            dblTotal = dblFries + dblTotal
        ElseIf radChips.Checked = True Then
            lblResult.Text &= ", and Chips"
            dblTotal = dblChips + dblTotal
        ElseIf radCurlyFries.Checked = True Then
            lblResult.Text &= ", and Curly Fries"
            dblTotal = dblCurlyFries + dblTotal
        ElseIf radWalffleFries.Checked = True Then
            lblResult.Text &= ", and Walffe Fries"
            dblTotal = dblWalffleFries + dblTotal
        End If
        lblTotal.Text = dblTotal.ToString("c")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblResult.Text = String.Empty
        lblTotal.Text = String.Empty
        radCheeseBurger.Checked = False
        radHamburger.Checked = False
        radChickenSandwich.Checked = False
        radSpicyChickenSandwich.Checked = False
        radFries.Checked = False
        radCurlyFries.Checked = False
        radChips.Checked = False
        chkLettuce.Checked = False
        chkTomato.Checked = False
        chkMayo.Checked = False
        chkPickles.Checked = False
        chkOnion.Checked = False
        chkSpinach.Checked = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
Public Class RightTriangle
    Sub calcSideC(ByVal Aside As Double, ByVal Bside As Double)
        Dim Cside As Double
        Cside = Math.Sqrt(Aside * Aside + Bside * Bside)
        txtSideC.Text = Cside.ToString("n2")
    End Sub

    Sub calcSideB(ByVal Cside As Double, ByVal Aside As Double)
        Dim Bside As Double
        Cside = Math.Sqrt(Cside * Cside - Aside * Aside)
        txtSideB.Text = Bside.ToString("n2")
    End Sub

    Sub calcSideA(ByVal Cside As Double, ByVal Bside As Double)
        Dim Aside As Double
        Cside = Math.Sqrt(Cside * Cside - Bside * Bside)
        txtSideA.Text = Aside.ToString("n2")
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        ' Dim result As Double
        If RadioC.Checked = True Then
            calcSideC(CDbl(txtSideA.Text), CDbl(txtSideB.Text))
        ElseIf RadioB.Checked = True Then
            calcSideB(CDbl(txtSideA.Text), CDbl(txtSideC.Text))
        ElseIf RadioA.Checked = True Then
            calcSideA(CDbl(txtSideC.Text), CDbl(txtSideB.Text))
        End If

    End Sub
End Class
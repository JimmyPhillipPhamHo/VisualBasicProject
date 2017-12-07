Public Class Distance_Calculator

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim Speed
        'Dim Hours

        Speed = InputBox("")
        'Hours = InputBox()

        Dim dblX As Decimal = 0
        Dim dblDidblDistanceTraveled As Decimal
        Do While dblX <= (txtHours.Text)
            dblX = dblX + 1
            dblDidblDistanceTraveled = (txtSpeed.Text) * dblX

            'ListResults.Items.Add()

        Loop

    End Sub
End Class
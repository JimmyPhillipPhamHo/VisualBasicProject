Public Class TestScoreAverage2

    Private Sub btnCalculator_Click(sender As Object, e As EventArgs) Handles btnCalculator.Click
        ' Variable to hold scores and the average score.
        Dim dblScore1, dblScore2, dblScore3, dblAverage As Double

        ' Constants.
        Const NUM_SCORES As Integer = 3
        Const dblHIGH_SCORES As Double = 95.0
        Try
            ' Copy the TextBox scores into the variable.
            dblScore1 = CDbl(txtScore1.Text)
            dblScore2 = CDbl(txtScore2.Text)
            dblScore3 = CDbl(txtScore3.Text)
            ' Calculate the average score.
            dblAverage = (dblScore1 + dblScore2 + dblScore3) / NUM_SCORES

            ' Display the average, round to 2 decimal places.
            lblAverage.Text = dblAverage.ToString("n2")

            ' Display the letter of grade.
            If dblAverage < 60 Then
                lblGrade.Text = "F"
            ElseIf dblAverage < 70 Then
                lblGrade.Text = "D"
            ElseIf dblAverage < 80 Then
                lblGrade.Text = "C"
            ElseIf dblAverage < 90 Then
                lblGrade.Text = "B"
            ElseIf dblAverage <= 100 Then
                lblGrade.Text = "A"
            Else
                lblGrade.Text = "Invliad Score"
            End If


            ' If the score is high, give the student praise.
            ' Otherwise, give some encouragement.
            If dblAverage > dblHIGH_SCORES Then
                lblMessage.Text = "Congratulations ! You can make it in life!"
            Else
                lblMessage.Text = "Sorry you won't make it, try getting good"
            End If

        Catch
            ' Display an error message.
            lblMessage.Text = "Error all input must be numeric values"
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtScore1.Clear()
        txtScore2.Clear()
        txtScore3.Clear()
        lblAverage.Text = String.Empty
        lblMessage.Text = String.Empty
        lblGrade.Text = String.Empty

        ' Reset the Focus
        txtScore1.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
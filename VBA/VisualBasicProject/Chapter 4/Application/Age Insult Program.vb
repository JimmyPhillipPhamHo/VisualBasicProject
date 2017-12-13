Public Class AgeInsultProgram

    Private Sub btnUserAgeInput_Click(sender As Object, e As EventArgs) Handles btnUserAgeInput.Click
        ' Variable to hold Age.
        Dim IntAge As Decimal

        Try
            ' Copy the TextBox UserAgeInput to the Variable
            IntAge = txtUserAgeInput.Text

            ' if age is corrponding with any of the ages below, give user an insult for that age.
            If IntAge < 10 Then
                lblResult.Text = "Can you even read?"
            ElseIf IntAge >= 10 And IntAge < 14 Then
                lblResult.Text = "There are no words to express how naive you are."
            ElseIf IntAge >= 14 And IntAge < 18 Then
                lblResult.Text = "You have no clue how the real world works."
            ElseIf IntAge >= 18 And IntAge < 24 Then
                lblResult.Text = "Being an adult is just walking around wondering what you're forgetting"
            ElseIf IntAge >= 24 And IntAge < 30 Then
                lblResult.Text = "You know you're getting old when you have more candles on your cake than friends at your birthday party."
            ElseIf IntAge >= 30 And IntAge < 40 Then
                lblResult.Text = "Aging gracefully is like the nice way of saying you're slowly looking worse."
            ElseIf IntAge >= 40 And IntAge < 60 Then
                lblResult.Text = "You're old enough to remember when emojis were called hieroglyphics."
            End If
        Catch ex As Exception
            ' Display an error message if user did not enter a numeric value.
            lblMessage.Text = "Enter a numeric value"
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clears TextBox
        txtUserAgeInput.Clear()
        ' Clears Label
        lblResult.Text = String.Empty
        lblResult.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Closes the Program
        Me.Close()
    End Sub
End Class
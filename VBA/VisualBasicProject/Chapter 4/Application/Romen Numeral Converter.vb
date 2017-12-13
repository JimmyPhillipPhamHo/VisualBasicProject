Public Class RomenNumeralConverter
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim intNumber As Integer

        Try
            intNumber = txtUserInput.Text
            If intNumber = 1 Then
                lblResult.Text = "I"
            ElseIf intNumber = 2 Then
                lblResult.Text = "II"
            ElseIf intNumber = 3 Then
                lblResult.Text = "III"
            ElseIf intNumber = 4 Then
                lblResult.Text = "IV"
            ElseIf intNumber = 5 Then
                lblResult.Text = "V"
            ElseIf intNumber = 6 Then
                lblResult.Text = "VI"
            ElseIf intNumber = 7 Then
                lblResult.Text = "VII"
            ElseIf intNumber = 8 Then
                lblResult.Text = "VIII"
            ElseIf intNumber = 9 Then
                lblResult.Text = "IX"
            ElseIf intNumber = 10 Then
                lblResult.Text = "X"
            ElseIf intNumber > 10 Then
                lblMessage.Text = "Make sure it is between 1 and 10."
            End If
        Catch ex As Exception
            ' Display an error message.
            lblMessage.Text = "Make sure you enter a number between 1 and 10."
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear
        lblResult.Text = String.Empty
        lblMessage.Text = String.Empty
        txtUserInput.Clear()
        ' Reset the focus
        txtUserInput.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the Form
        Me.Close()
    End Sub
End Class
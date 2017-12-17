Public Class SumOfNumber

    Private Sub btnEnterNumbers_Click(sender As Object, e As EventArgs) Handles btnEnterNumbers.Click
        Dim strInput As String
        Dim numberInput As Integer = 0
        Dim sumOfNumber As Integer = 0
        strInput = InputBox("Enter a positive integer value")

        If Integer.TryParse(strInput, numberInput) Then
            If numberInput > 0 Then
                sumOfNumber = (numberInput * (numberInput + 1)) / 2
            Else
                MessageBox.Show("Enter a positive integer value")
            End If


        End If


        'sumOfNumber = strInput.ToString * strInput.ToString + 1 / 2

        MessageBox.Show("The sum of the numbers 1 though " & numberInput & " is " & sumOfNumber)

    End Sub
End Class
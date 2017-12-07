Public Class LoanQualifier

    Private Sub btnCheckQualification_Click(sender As Object, e As EventArgs) Handles btnCheckQualification.Click
        ' Variables to hold input data.
        Dim dblSalary As Double
        Dim intYearOnJob As Integer

        Try
            ' Get the user's input.
            dblSalary = CDbl(txtSalary.Text)
            intYearOnJob = CInt(txtNumYearOnJob.Text)

            ' Determine whether the applicant qualifies
            ' for the special loan.
            If dblSalary > 30000 Then
                If intYearOnJob > 2 Then
                    lblMessage.Text = "The applicant qualifies."
                Else
                    lblMessage.Text = "The applicant does not qualify."
                End If
            Else
                If intYearOnJob > 5 Then
                    lblMessage.Text = "The applicant qualifies."
                Else
                    lblMessage.Text = "The applicant does not qualify."
                End If
            End If

        Catch ex As Exception
            ' Display an error message.
            lblMessage.Text = "Please enter numeric values."
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear
        txtSalary.Clear()
        txtNumYearOnJob.Clear()

        lblMessage.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close
        Me.Close()
    End Sub
End Class
Public Class HelloWorldPassword

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim strPassword As String = "Bob'sHouse5478"

        If txtUserPassword.Text = strPassword Then
            MessageBox.Show("Correct!")
        Else
            MessageBox.Show("Password is incorrect!")
            txtUserPassword.Clear()
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class

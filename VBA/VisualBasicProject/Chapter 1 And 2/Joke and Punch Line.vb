Public Class JokeandPunchLine

    Private Sub btnSetup_Click(sender As Object, e As EventArgs) Handles btnSetup.Click
        lblJoke.Visible = True
    End Sub

    Private Sub btnPunchLine_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lblPunchLine.Visible = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
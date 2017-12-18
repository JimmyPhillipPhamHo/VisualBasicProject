Public Class RaceCarGame

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim intCount1, intCount2, intCount3 As Integer
        Dim rand As New Random

        For intCount1 = 16 To rand.Next(250) + 420
            picHaloShip.Left = intCount1
        Next

        For intCount2 = 16 To rand.Next(250) + 420
            picStarWarsShip.Left = intCount2
        Next

        For intCount3 = 16 To rand.Next(250) + 420
            picStarTrekShip.Left = intCount3
        Next

        lblHaloSpeed.Text = ("Halo Ship: " & intCount1)
        lblStarWarsSpeed.Text = ("Star Wars Ship: " & intCount2)
        lbllblStarTrekSpeed.Text = ("Star Trek Ship: " & intCount3)

        If intCount1 > intCount2 And intCount1 > intCount3 Then 'Halo
            lblWinner.Text = ("Halo spaceship Wins!!!")
        End If

        If intCount2 > intCount1 And intCount2 > intCount3 Then 'Star Wars
            lblWinner.Text = ("Star Wars spaceship Wins!!!")
        End If

        If intCount3 > intCount1 And intCount3 > intCount2 Then 'Star Trek
            lblWinner.Text = ("Star Trek spaceship Wins!!!")
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim intCount As Integer

        For intCount = 0 To 0
            picHaloShip.Left = intCount
            picStarWarsShip.Left = intCount
            picStarTrekShip.Left = intCount
        Next
        lblStarWarsSpeed.Text = String.Empty
        lblHaloSpeed.Text = String.Empty
        lbllblStarTrekSpeed.Text = String.Empty
        lblWinner.Text = String.Empty

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form
        Me.Close()

    End Sub
End Class
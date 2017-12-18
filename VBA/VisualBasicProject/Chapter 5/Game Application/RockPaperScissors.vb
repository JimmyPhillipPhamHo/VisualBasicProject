Public Class RockPaperScissors
    Dim intScoreWins As Integer
    Dim intScoreLose As Integer
    Dim intScoreTies As Integer

    Private Sub picScissors_Click(sender As Object, e As EventArgs) Handles picScissors.Click
        Dim intShoot As Integer
        Dim rand As New Random

        intShoot = rand.Next(3)
        '0 Rock
        '1 Paper
        '2 Scissors

        If intShoot = 0 Then
            lblResult.Text = ("Pc VS Player!" & vbCrLf & " Choose- Rock. You Choose- Scissors." & vbCrLf & "You Lose!")
            intScoreLose = intScoreLose + 1
        ElseIf intShoot = 1 Then
            lblResult.Text = ("Pc VS Player!" & vbCrLf & "Pc Choose- Paper. You Choose- Scissors." & vbCrLf & "You Win!")
            intScoreWins = intScoreWins + 1
        ElseIf intShoot = 2 Then
            lblResult.Text = ("Pc VS Player!" & vbCrLf & "Pc Choose- Scissors. You Choose- Scissors." & vbCrLf & "You Tie!")
            intScoreTies = intScoreTies + 1
        End If
        lblWins.Text = intScoreWins.ToString
        lblLose.Text = intScoreLose.ToString
        lblTies.Text = intScoreTies.ToString
    End Sub

    Private Sub picPaper_Click(sender As Object, e As EventArgs) Handles picPaper.Click
        Dim intShoot As Integer
        Dim rand As New Random

        intShoot = rand.Next(3)
        '0 Rock
        '1 Paper
        '2 Scissors

        If intShoot = 0 Then
            lblResult.Text = ("Pc VS Player!" & vbCrLf & "Pc Choose- Rock. You Choose- Paper." & vbCrLf & "You Win!")
            intScoreWins = intScoreWins + 1
        ElseIf intShoot = 1 Then
            lblResult.Text = ("Pc VS Player!" & vbCrLf & "Pc Choose- Paper. You Choose- Paper." & vbCrLf & "You Tie!")
            intScoreTies = intScoreTies + 1
        ElseIf intShoot = 2 Then
            lblResult.Text = ("Pc VS Player!" & vbCrLf & "Pc Choose- Scissors. You Choose- Paper." & vbCrLf & "You Lose!")
            intScoreLose = intScoreLose + 1
        End If
        lblWins.Text = intScoreWins.ToString
        lblLose.Text = intScoreLose.ToString
        lblTies.Text = intScoreTies.ToString
    End Sub


    Private Sub picRock_Click(sender As Object, e As EventArgs) Handles picRock.Click
        Dim intShoot As Integer
        Dim rand As New Random

        intShoot = rand.Next(3)
        '0 Rock
        '1 Paper
        '2 Scissors

        If intShoot = 0 Then
            lblResult.Text = ("Pc VS Player!" & vbCrLf & " Pc Choose- Rock. You Choose- Rock. " & vbCrLf & "You Tie!")
            intScoreTies = intScoreTies + 1
        ElseIf intShoot = 1 Then
            lblResult.Text = ("Pc VS Player!" & vbCrLf & "Pc Choose- Paper. You Choose- Rock." & vbCrLf & "You Lose!")
            intScoreLose = intScoreLose + 1
        ElseIf intShoot = 2 Then
            lblResult.Text = ("Pc VS Player!" & vbCrLf & "Pc Choose- Scissors. You Choose- Rock." & vbCrLf & "You Win!")
            intScoreWins = intScoreWins + 1
        End If
        lblWins.Text = intScoreWins.ToString
        lblLose.Text = intScoreLose.ToString
        lblTies.Text = intScoreTies.ToString
    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        intScoreWins = 0
        intScoreLose = 0
        intScoreTies = 0
        lblWins.Text = String.Empty
        lblLose.Text = String.Empty
        lblTies.Text = String.Empty
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
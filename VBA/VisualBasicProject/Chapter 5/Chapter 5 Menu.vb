Public Class Chapter5Menu

    ' Game Application Button Clome
    Private Sub btnCoinToss_Click(sender As Object, e As EventArgs) Handles btnCoinToss.Click
        Dim Box = New CoinToss
        Box.Show()
    End Sub

    Private Sub btnRockPaperScissors_Click(sender As Object, e As EventArgs) Handles btnRockPaperScissors.Click
        Dim Box = New RockPaperScissors
        Box.Show()
    End Sub

    Private Sub btnRaceCarGame_Click(sender As Object, e As EventArgs) Handles btnRaceCarGame.Click
        Dim Box = New RaceCarGame
        Box.Show()
    End Sub

    Private Sub btnRandomNumberGuessingGameEnhancement_Click(sender As Object, e As EventArgs) Handles btnRandomNumberGuessingGameEnhancement.Click
        Dim Box = New RandomNumberGuessingGameEnhancement
        Box.Show()
    End Sub

    ' Math Application
    Private Sub btnSumOfNumber_Click(sender As Object, e As EventArgs) Handles btnSumOfNumber.Click
        Dim Box = New SumOfNumber
        Box.Show()
    End Sub

    Private Sub btnDistanceCalculator_Click(sender As Object, e As EventArgs) Handles btnDistanceCalculator.Click
        Dim Box = New DistanceCalculator
        Box.Show()
    End Sub

    Private Sub btnPopulation_Click(sender As Object, e As EventArgs) Handles btnPopulation.Click
        Dim Box = New SumOfNumber
        Box.Show()
    End Sub

    Private Sub btnRightTriangle_Click(sender As Object, e As EventArgs) Handles btnRightTriangle.Click
        Dim Box = New RightTriangle
        Box.Show()
    End Sub

    ' Tutotial Application

    Private Sub btnRunningTotal_Click(sender As Object, e As EventArgs) Handles btnRunningTotal.Click
        Dim Box = New RunningTotal
        Box.Show()
    End Sub

    Private Sub btnTestScore_Click(sender As Object, e As EventArgs) Handles btnTestScore.Click
        Dim Box = New TotalScores
        Box.Show()
    End Sub

    Private Sub btnForNextDemo2_Click(sender As Object, e As EventArgs) Handles btnForNextDemo2.Click
        Dim Box = New ForNextDemo2
        Box.Show()
    End Sub

    Private Sub btnComboBoxDemo_Click(sender As Object, e As EventArgs) Handles btnComboBoxDemo.Click
        Dim Box = New ComboBoxDemo
        Box.Show()
    End Sub

    ' Return to MainMenu And Close the Chapter menu
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        MainMenu.Visible = True
        Me.Close()
    End Sub
    ' Close the whole Project
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        MainMenu.Close()
    End Sub
End Class
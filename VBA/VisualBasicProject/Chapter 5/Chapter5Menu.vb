Public Class Chapter5Menu

    ' Game Application Button Clome
    Private Sub btnCoinToss_Click(sender As Object, e As EventArgs) Handles btnCoinToss.Click
        Dim Box = New CoinToss()
        Box.Show()

        Dim Box2 = New Chapter5Menu
        Box2.Close()
    End Sub

    Private Sub btnRockPaperScissors_Click(sender As Object, e As EventArgs) Handles btnRockPaperScissors.Click
        Dim Box = New RockPaperScissors()
        Box.Show()
    End Sub

    Private Sub btnRaceCarGame_Click(sender As Object, e As EventArgs) Handles btnRaceCarGame.Click
        Dim Box = New RaceCarGame()
        Box.Show()
    End Sub

    Private Sub btnRandomNumberGuessingGameEnhancement_Click(sender As Object, e As EventArgs) Handles btnRandomNumberGuessingGameEnhancement.Click
        Dim Box = New RandomNumberGuessingGameEnhancement
        Box.Show()
    End Sub

    ' Math Application
    Private Sub btnSumOfNumber_Click(sender As Object, e As EventArgs) Handles btnSumOfNumber.Click
        Dim Box = New SumOfNumber()
        Box.Show()
    End Sub

    Private Sub btnDistanceCalculator_Click(sender As Object, e As EventArgs) Handles btnDistanceCalculator.Click

    End Sub

    Private Sub btnPopulation_Click(sender As Object, e As EventArgs) Handles btnPopulation.Click

    End Sub

    Private Sub btnRightTriangle_Click(sender As Object, e As EventArgs) Handles btnRightTriangle.Click
        Dim Box = New RightTriangle
        Box.Show()
    End Sub

    ' Tot

    Private Sub btnRunningTotal_Click(sender As Object, e As EventArgs) Handles btnRunningTotal.Click
        Dim Box = New TotalSales
        Box.Show()

    End Sub

    Private Sub btnTestScore_Click(sender As Object, e As EventArgs) Handles btnTestScore.Click

    End Sub

    Private Sub btnForNextDemo2_Click(sender As Object, e As EventArgs) Handles btnForNextDemo2.Click

    End Sub

    Private Sub btnComboBoxDemo_Click(sender As Object, e As EventArgs) Handles btnComboBoxDemo.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        MainMenu.Show()
    End Sub
End Class
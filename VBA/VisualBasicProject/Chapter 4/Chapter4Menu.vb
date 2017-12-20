Public Class Chapter4Menu

    Private Sub btnTestScoreAverage2_Click(sender As Object, e As EventArgs) Handles btnTestScoreAverage2.Click
        Dim Box = New TestScoreAverage2
        Box.Show()
    End Sub

    Private Sub btnLoanQualifier_Click(sender As Object, e As EventArgs) Handles btnLoanQualifier.Click
        Dim Box = New LoanQualifier
        Box.Show()
    End Sub

    Private Sub btnCrazyAIsCommissionCalculator_Click(sender As Object, e As EventArgs) Handles btnCrazyAIsCommissionCalculator.Click
        Dim Box = New CrazyAI_sCommissionCalculator
        Box.Show()
    End Sub

    Private Sub btnRadioButtonCheckBoxDemo_Click(sender As Object, e As EventArgs) Handles btnRadioButtonCheckBoxDemo.Click
        Dim Box = New RadioButtonCheckBoxDemo
        Box.Show()
    End Sub

    Private Sub btnAgeInsultProgram_Click(sender As Object, e As EventArgs) Handles btnAgeInsultProgram.Click
        Dim Box = New AgeInsultProgram
        Box.Show()
    End Sub

    Private Sub btnDebugger1_Click(sender As Object, e As EventArgs) Handles btnDebugger1.Click
        Dim Box = New Debugging1
        Box.Show()
    End Sub

    Private Sub btnHelloWorldPassword_Click(sender As Object, e As EventArgs) Handles btnHelloWorldPassword.Click
        Dim Box = New HelloWorldPassword
        Box.Show()
    End Sub

    Private Sub btnMadLibs_Click(sender As Object, e As EventArgs) Handles btnMadLibs.Click
        Dim Box = New MadLibs
        Box.Show()
    End Sub

    Private Sub btnRomenNumeralConverter_Click(sender As Object, e As EventArgs) Handles btnRomenNumeralConverter.Click
        Dim Box = New RomenNumeralConverter
        Box.Show()
    End Sub

    Private Sub btnRunningtheRace_Click(sender As Object, e As EventArgs) Handles btnRunningtheRace.Click
        Dim Box = New RunningTheRace
        Box.Show()
    End Sub

    Private Sub btnOrderingFood_Click(sender As Object, e As EventArgs) Handles btnOrderingFood.Click
        Dim Box = New OrderingFood
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
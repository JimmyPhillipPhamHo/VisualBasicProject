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
End Class
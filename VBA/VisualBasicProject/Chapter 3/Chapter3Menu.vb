Public Class Chapter3Menu

    Private Sub btnCalculatorPropertyTax_Click(sender As Object, e As EventArgs) Handles btnCalculatorPropertyTax.Click
        Dim Box = New CalculatingPropertyTax
        Box.Show()
    End Sub

    Private Sub btnDateString_Click(sender As Object, e As EventArgs) Handles btnDateString.Click
        Dim Box = New DateString
        Box.Show()
    End Sub

    Private Sub btnFormatDemo_Click(sender As Object, e As EventArgs) Handles btnFormatDemo.Click
        Dim Box = New FormatDemo
        Box.Show()
    End Sub

    Private Sub btnGreetings_Click(sender As Object, e As EventArgs) Handles btnGreetings.Click
        Dim Box = New Greetings
        Box.Show()
    End Sub

    Private Sub btnHighlanderHotel_Click(sender As Object, e As EventArgs) Handles btnHighlanderHotel.Click
        Dim Box = New RoomChangeCalculator
        Box.Show()
    End Sub

    Private Sub btnMilesPerGallonCalculator_Click(sender As Object, e As EventArgs) Handles btnMilesPerGallonCalculator.Click
        Dim Box = New MilesPerGallonCalculator
        Box.Show()
    End Sub

    Private Sub btnSimpleCalculator_Click(sender As Object, e As EventArgs) Handles btnSimpleCalculator.Click
        Dim Box = New SimpleCalculator
        Box.Show()
    End Sub

    Private Sub btnStadiumSeating_Click(sender As Object, e As EventArgs) Handles btnStadiumSeating.Click
        Dim Box = New StadiumSeating
        Box.Show()
    End Sub

    Private Sub btnTemperatureConverter_Click(sender As Object, e As EventArgs) Handles btnTemperatureConverter.Click
        Dim Box = New CelsiusToFahrenheit
        Box.Show()
    End Sub

    Private Sub btnTestScoreAverage_Click(sender As Object, e As EventArgs) Handles btnTestScoreAverage.Click
        Dim Box = New TestScoreAverage
        Box.Show()
    End Sub

    Private Sub btnVariableDemo_Click(sender As Object, e As EventArgs) Handles btnVariableDemo.Click
        Dim Box = New VariableDemo
        Box.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
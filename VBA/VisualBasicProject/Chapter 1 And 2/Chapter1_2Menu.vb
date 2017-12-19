Public Class Chapter1_2Menu

    Private Sub btnGermanNumber_Click(sender As Object, e As EventArgs) Handles btnGermanNumber.Click
        Dim Box = New GermanNumber
        Box.Show()
    End Sub

    Private Sub btnKiloConverter_Click(sender As Object, e As EventArgs) Handles btnKiloConverter.Click
        Dim Box = New KiloConverter
        Box.Show()
    End Sub

    Private Sub btnMathTutor_Click(sender As Object, e As EventArgs) Handles btnMathTutor.Click
        Dim Box = New MathTutor
        Box.Show()
    End Sub

    Private Sub btnJokeAndPunchLine_Click(sender As Object, e As EventArgs) Handles btnJokeAndPunchLine.Click
        Dim Box = New JokeandPunchLine
        Box.Show()
    End Sub

    Private Sub btnLatinTranslator_Click(sender As Object, e As EventArgs) Handles btnLatinTranslator.Click
        Dim Box = New LatinTranslator
        Box.Show()
    End Sub

    Private Sub btnNameAndAddress_Click(sender As Object, e As EventArgs) Handles btnNameAndAddress.Click
        Dim Box = New NameandAddress
        Box.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
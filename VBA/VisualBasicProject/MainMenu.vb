Public Class MainMenu

    Private Sub btnChapter1_2_Click(sender As Object, e As EventArgs) Handles btnChapter1_2.Click
        Dim Box = New Chapter1_2Menu
        Box.Show()

    End Sub

    Private Sub btnChapter3_Click(sender As Object, e As EventArgs) Handles btnChapter3.Click
        Dim Box = New Chapter3Menu
        Box.Show()

    End Sub

    Private Sub btnChapter4_Click(sender As Object, e As EventArgs) Handles btnChapter4.Click
        Dim Box = New Chapter4Menu
        Box.Show()

    End Sub

    Private Sub btnChapter5_Click(sender As Object, e As EventArgs) Handles btnChapter5.Click
        Dim Box = New Chapter5Menu
        Box.Show()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnChapter8_Click(sender As Object, e As EventArgs) Handles btnChapter8.Click

    End Sub
End Class

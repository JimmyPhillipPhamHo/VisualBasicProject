Public Class MainMenu

    Private Sub btnChapter1_2_Click(sender As Object, e As EventArgs) Handles btnChapter1_2.Click
        Chapter1_2Menu.Show()
        Me.Visible = False
    End Sub

    Private Sub btnChapter3_Click(sender As Object, e As EventArgs) Handles btnChapter3.Click
        Chapter3Menu.Show()
        Me.Visible = False
    End Sub

    Private Sub btnChapter4_Click(sender As Object, e As EventArgs) Handles btnChapter4.Click
        Chapter4Menu.Show()
        Me.Visible = False
    End Sub

    Private Sub btnChapter5_Click(sender As Object, e As EventArgs) Handles btnChapter5.Click
        Chapter5Menu.Show()
        Me.Visible = False
    End Sub
    Private Sub btnChapter8_Click(sender As Object, e As EventArgs) Handles btnChapter8.Click
        Chapter8Menu.Show()
        Me.Visible = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class

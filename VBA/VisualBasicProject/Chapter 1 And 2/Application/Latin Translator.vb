Public Class LatinTranslator
    Private Sub btnSinister_Click(sender As Object, e As EventArgs) Handles btnSinister.Click
        lblLeft.Visible = True
    End Sub

    Private Sub btnMedium_Click(sender As Object, e As EventArgs) Handles btnMedium.Click
        lblCenter.Visible = True
    End Sub

    Private Sub btnDexter_Click(sender As Object, e As EventArgs) Handles btnDexter.Click
        lblRight.Visible = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
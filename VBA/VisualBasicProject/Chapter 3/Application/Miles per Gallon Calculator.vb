Public Class MilesPerGallonCalculator

    Private Sub btnCalculator_Click(sender As Object, e As EventArgs) Handles btnCalculator.Click
        Dim decGallonSize As Decimal
        Try
            decGallonSize = (txtMilesWithFullTank.Text) / (txtGallonSize.Text)
            lblMilesPerGallon.Text = decGallonSize.ToString("n2")
        Catch
            lblError.Text = "Error be sure to enter non zero number values "
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtGallonSize.Clear()
        txtMilesWithFullTank.Clear()
        lblMilesPerGallon.Text = String.Empty
        lblError.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
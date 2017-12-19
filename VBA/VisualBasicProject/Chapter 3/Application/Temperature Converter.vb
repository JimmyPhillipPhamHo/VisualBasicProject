Public Class CelsiusToFahrenheit

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim decFahrenheit As Decimal
        Try
            decFahrenheit = (txtCelsius.Text * 1.8) + 32
            lblFahrenheit.Text = decFahrenheit.ToString()

        Catch
            lblError.Text = "Error input must be valid numeric values. "
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblFahrenheit.Text = String.Empty
        lblError.Text = String.Empty

        txtCelsius.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
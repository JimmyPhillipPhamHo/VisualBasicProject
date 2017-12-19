Public Class CalculatingPropertyTax

    Private Sub btnCalculateAAT_Click(sender As Object, e As EventArgs) Handles btnCalculateAAT.Click
        Dim decAssessmentValue, decPropertyTax As Decimal

        Try
            decAssessmentValue = (txtActualPropertyValue.Text) * 0.6
            decPropertyTax = (decAssessmentValue / 100) * 0.64

            lblAssessmentVaule.Text = decAssessmentValue.ToString("c")
            lblPropertyTax.Text = decPropertyTax.ToString("c")

        Catch
            lblError.Text = "Error input must be valid numeric values. "
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        lblAssessmentVaule.Text = String.Empty
        lblPropertyTax.Text = String.Empty
        lblError.Text = String.Empty

        txtActualPropertyValue.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
Public Class StadiumSeating

    Private Sub btnCalculatorRevenue_Click(sender As Object, e As EventArgs) Handles btnCalculatorRevenue.Click
        Dim decTotalRevenue, decClassA, decClassB, decClassC As Decimal
        Try
            decClassA = (txtClassA.Text) * 15
            decClassB = (txtClassB.Text) * 12
            decClassC = (txtClassC.Text) * 9
            decTotalRevenue = (decClassA) + (decClassB) + (decClassC)

            lblClassA.Text = decClassA.ToString("c")
            lblClassB.Text = decClassB.ToString("c")
            lblClassC.Text = decClassC.ToString("c")

            lblTotalRevenue.Text = decTotalRevenue.ToString("c")
        Catch
            lblError.Text = "All input must be vaid numeric values"
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtClassA.Clear()
        txtClassB.Clear()
        txtClassC.Clear()

        lblClassA.Text = String.Empty
        lblClassB.Text = String.Empty
        lblClassC.Text = String.Empty
        lblTotalRevenue.Text = String.Empty
        lblError.Text = String.Empty

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
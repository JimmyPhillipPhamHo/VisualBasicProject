Public Class DateString

    Private Sub btnShowDate_Click(sender As Object, e As EventArgs) Handles btnShowDate.Click
        lblDateString.Text = txtDayofWeek.Text & ", " & txtMonth.Text &
            " " & txtDayofMonth.Text & ", " &
            txtYear.Text
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDayofWeek.Clear()
        txtMonth.Clear()
        txtDayofMonth.Clear()
        txtYear.Clear()
        lblDateString.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
Public Class Chapter8Menu

    Private Sub btnSeatingChart_Click(sender As Object, e As EventArgs) Handles btnSeatingChart.Click
        Dim Box = New TheSeatingChart
        Box.Show()
    End Sub

    Private Sub btnLotteryNumbers_Click(sender As Object, e As EventArgs) Handles btnLotteryNumbers.Click
        Dim Box = New TheLotteryNumbers
        Box.Show()
    End Sub

    Private Sub btnFriendsList_Click(sender As Object, e As EventArgs) Handles btnFriendsList.Click
        Dim Box = New FriendsList
        Box.Show()
    End Sub

    Private Sub btnFriendsList2_Click(sender As Object, e As EventArgs) Handles btnFriendsList2.Click
        Dim Box = New FriendList2
        Box.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
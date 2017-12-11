Public Class FriendList2
    Private lstNames As New List(Of String)

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Add the name to the List.
        lstNames.Add(txtName.Text)

        ' Clear the text box.
        txtName.Clear()
        txtName.Focus()

    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click

        ' Display all names in the box.
        Dim strName As String
        lstFriends.Items.Clear()

        For Each strName In lstNames
            lstFriends.Items.Add(strName)   ' Add to list box
        Next

    End Sub
End Class
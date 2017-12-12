Public Class MadLibs

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim strInput As String ' Hold selected from list

        strInput = listColor.SelectedItem.ToString() & " Dragon is the " &
            listEst.SelectedItem.ToString() & " Dragon of all. It has " &
            listNumber.SelectedItem.ToString() & " " &
            listBodyPart.SelectedItem.ToString() & ", and a " &
            listAnimal.SelectedItem.ToString() & " shaped like a " &
            listNoun.SelectedItem.ToString() & ". " & "It love to eat " &
            listPluralNoun.SelectedItem.ToString()

        MessageBox.Show("The " & strInput & ", although it will feast on nearly anything.")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        listColor.SelectedIndex = -1
        'listEst.SelectedIndex()
        'listNumber()
        'listBodyPart()
        'listAnimal()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim availableCredit As Integer = txtAvailable.Text
        Dim usedCredit As Integer = txtUsed.Text
        Dim remainingCredit As Integer = availableCredit - usedCredit

        lblRemaining.Text = "Remaining Credit: " + Convert.ToString(remainingCredit)

    End Sub

    Private Sub btnName_Click(sender As Object, e As EventArgs) Handles btnName.Click
        MessageBox.Show("Michael Gain")
    End Sub
End Class

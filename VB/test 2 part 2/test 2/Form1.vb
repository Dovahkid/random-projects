Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSinister_Click(sender As Object, e As EventArgs) Handles btnSinister.Click
        lblTranslation.Text = "Left"
    End Sub

    Private Sub btnMedium_Click(sender As Object, e As EventArgs) Handles btnMedium.Click
        lblTranslation.Text = "Middle"
    End Sub

    Private Sub btnDexter_Click(sender As Object, e As EventArgs) Handles btnDexter.Click
        lblTranslation.Text = "Right"
    End Sub
End Class

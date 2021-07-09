Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim dblMiles As Double
        Dim dblGallons As Double
        Dim dblMPG As Double

        Try
            lblStatus.Text = String.Empty
            dblMiles = CDbl(txtMiles.Text)
            dblGallons = CDbl(txtGallons.Text)
            dblMPG = dblMiles / dblGallons
            lblMPG.Text = dblMPG.ToString("n3")
        Catch ex As Exception
            lblStatus.Text = "Please enter a numeric value!"
        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtGallons.Text = String.Empty
        txtMiles.Text = String.Empty
        lblMPG.Text = String.Empty
        lblStatus.Text = String.Empty

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        MessageBox.Show("Michael Gain")
        Me.Close()

    End Sub
End Class

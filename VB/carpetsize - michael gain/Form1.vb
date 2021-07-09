Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim width As Double = txtWidth.Text
        Dim length As Double = txtLength.Text
        Dim area As Double = width * length

        lblArea.Text = "Area: " + Convert.ToString(area)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Application.Exit()

    End Sub
End Class

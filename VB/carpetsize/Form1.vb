Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim width As Double
        Dim length As Double
        Dim area As Double

        width = txtLength.Text
        length = txtLength.Text
        area = width * length

        lblArea.Text = "Area: " + Convert.ToString(area)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Application.Exit()

    End Sub
End Class

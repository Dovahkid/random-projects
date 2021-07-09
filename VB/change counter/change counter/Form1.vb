Public Class Form1
    Dim decFIVE_CENTS As Decimal = 0.05D
    Dim decTEN_CENTS As Decimal = 0.1D
    Dim decTWENTY_FIVE_CENTS As Decimal = 0.25D
    Dim decFIFTY_CENTS As Decimal = 0.5D

    Dim decTotal As Decimal = 0.0D
    Private Sub imgFiveCents_Click(sender As Object, e As EventArgs) Handles imgFiveCents.Click
        decTotal += decFIVE_CENTS
        lblTotal.Text = decTotal.ToString("c")
    End Sub

    Private Sub imgTwentyFiveCents_Click(sender As Object, e As EventArgs) Handles imgTwentyFiveCents.Click
        decTotal += decTWENTY_FIVE_CENTS
        lblTotal.Text = decTotal.ToString("c")
    End Sub

    Private Sub imgTenCents_Click(sender As Object, e As EventArgs) Handles imgTenCents.Click
        decTotal += decTEN_CENTS
        lblTotal.Text = decTotal.ToString("c")
    End Sub

    Private Sub imgFiftyCents_Click(sender As Object, e As EventArgs) Handles imgFiftyCents.Click
        decTotal += decFIFTY_CENTS
        lblTotal.Text = decTotal.ToString("c")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class

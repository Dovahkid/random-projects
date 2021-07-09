Public Class Form1

    Dim bikeType As String
    Dim bikeExtras As String

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        lblOrder.Text = "The bike shop has ben located here for over 10 years. We specialize in custom bikes built just for you."
    End Sub

    Private Sub radRoad_CheckedChanged(sender As Object, e As EventArgs) Handles radRoad.CheckedChanged
        bikeType = "You chose the Road bike. "
    End Sub

    Private Sub radMountain_CheckedChanged(sender As Object, e As EventArgs) Handles radMountain.CheckedChanged
        bikeType = "You chose the Mountain bike. "
    End Sub

    Private Sub radHybrid_CheckedChanged(sender As Object, e As EventArgs) Handles radHybrid.CheckedChanged
        bikeType = "You chose the Hybrid bike. "
    End Sub

    Private Sub chkCustom_CheckedChanged(sender As Object, e As EventArgs) Handles chkCustom.CheckedChanged
        bikeExtras += "You would like to add custom paint. "
    End Sub

    Private Sub chkHeavy_CheckedChanged(sender As Object, e As EventArgs) Handles chkHeavy.CheckedChanged
        bikeExtras += "You would like a heavy duty frame. "
    End Sub

    Private Sub chkComfort_CheckedChanged(sender As Object, e As EventArgs) Handles chkComfort.CheckedChanged
        bikeExtras += "You would like a comfort seat. "
    End Sub
End Class

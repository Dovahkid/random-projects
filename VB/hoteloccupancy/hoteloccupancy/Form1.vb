Public Class Form1
    Dim intTotalRoomsOccupied As Integer = 0
    Const intROOMS As Integer = 30
    Const intFLOORS As Integer = 8
    Const intTOTAL_ROOMS As Integer = intFLOORS * intROOMS
    Dim dblOverallOccupancyRate As Double = 0.0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboFloor.SelectedIndex = 0
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim intRoomsOccupied As Integer
        Dim dblOccupancyRate As Double

        If Integer.TryParse(txtOccupied.Text, intRoomsOccupied) Then
            intTotalRoomsOccupied += intRoomsOccupied
            dblOccupancyRate = intRoomsOccupied / intROOMS

            lstFloorData.Items.Add("Floor: " & cboFloor.Text &
                                   " Rooms Occupied: " & intRoomsOccupied.ToString &
                                   " Occupancy Rate: " & dblOccupancyRate.ToString("p"))

            'Calculate the overall occupancyt rate for all floors.'
            dblOverallOccupancyRate = intTotalRoomsOccupied / intTOTAL_ROOMS

            'Display results'
            lblTotalRooms.Text = intTotalRoomsOccupied.ToString()
            lblOverallRate.Text = dblOverallOccupancyRate.ToString("p")
            If cboFloor.SelectedIndex < intFLOORS - 1 Then
                cboFloor.SelectedIndex += 1
            End If
            txtOccupied.Clear()
        Else
            MessageBox.Show("Please Enter an integer value")
            txtOccupied.Clear()
        End If
    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        intTotalRoomsOccupied = 0
        dblOverallOccupancyRate = 0.0
        cboFloor.SelectedIndex = 0

        lstFloorData.Items.Clear()
        lblTotalRooms.Text = String.Empty
        lblOverallRate.Text = String.Empty
        txtOccupied.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        MessageBox.Show("Created by Michael Gain")
        Me.Close()
    End Sub
End Class

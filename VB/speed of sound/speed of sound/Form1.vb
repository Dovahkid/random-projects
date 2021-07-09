Public Class Form1
    Const dblSPEED_THROUGH_AIR As Double = 1100.0
    Const dblSPEED_THROUGH_WATER As Double = 4900.0
    Const dblSPEED_THROUGH_STEEL As Double = 16400.0

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblSpeed As Double
        Dim dblDistance As Double = Convert.ToDouble(txtDistance.Text)
        Dim dblTime As Double

        If dblDistance >= 0 Then

            If radAir.Checked Then
                dblSpeed = dblSPEED_THROUGH_AIR

            ElseIf radWater.Checked Then
                dblSpeed = dblSPEED_THROUGH_WATER

            ElseIf radSteel.Checked Then
                dblSpeed = dblSPEED_THROUGH_STEEL

            End If

            dblTime = dblDistance / dblSpeed
            lblTime.Text = dblTime.ToString("n2")

        Else
            MessageBox.Show("Distance - Value must be a positive real number.", "Invalid Input")

        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblTime.Text = String.Empty
        radAir.Checked = True
        txtDistance.Clear()
        txtDistance.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        MessageBox.Show("Michael Gain")
        Me.Close()
    End Sub
End Class

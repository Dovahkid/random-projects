Public Class Form1
    Dim dblOilLubeTotal As Double = 0.0D
    Dim dblFlushesTotal As Double = 0.0D
    Dim dblMiscCharges As Double = 0.0D
    Dim dblOtherCharges As Double = 0.0D
    Dim dblPartsCost As Double = 0.0D
    Dim dblLaborCost As Double = 0.0D
    Dim dblTaxCharges As Double = 0.0D
    Dim dblTotalCharges As Double = 0.0D
    Dim dblServiceLaborCost As Double = 0.0D
    Private Function OilLubeCharges() As Double
        If chkOil.Checked Then
            dblOilLubeTotal += 26
        End If
        If chkLube.Checked Then
            dblOilLubeTotal += 18
        End If
        Return dblOilLubeTotal
    End Function

    Private Function FlushCharges() As Double
        If chkRadFlush.Checked Then
            dblFlushesTotal += 30
        End If
        If chkTransFlush.Checked Then
            dblFlushesTotal += 80
        End If
        Return dblFlushesTotal
    End Function

    Private Function MiscCharges() As Double
        If chkInspection.Checked Then
            dblMiscCharges += 15
        End If
        If chkMuffler.Checked Then
            dblMiscCharges += 100
        End If
        If chkTire.Checked Then
            dblMiscCharges += 20
        End If
        Return dblMiscCharges
    End Function

    Private Function OtherCharges() As Double
        Try
            If txtLabor.Text > 0 Then
                dblLaborCost = txtLabor.Text * 20
            Else
                MessageBox.Show("You must enter a positive value")
                ClearFees()
                ClearFlushes()
                ClearMisc()
                ClearOilLube()
                ClearOther()
                ClearValues()
            End If
        Catch ex As Exception
            dblLaborCost = 0.0D
        End Try

        Try
            If txtParts.Text > 0 Then
                dblPartsCost = txtParts.Text * 20
            Else
                MessageBox.Show("You must enter a positive value")
                ClearFees()
                ClearFlushes()
                ClearMisc()
                ClearOilLube()
                ClearOther()
                ClearValues()
            End If
        Catch ex As Exception
            dblPartsCost = 0.0D
        End Try

        Return dblOtherCharges = dblPartsCost + dblLaborCost
    End Function

    Private Function TaxCharges() As Double
        dblTaxCharges = dblPartsCost * 0.06
        Return dblTaxCharges
    End Function

    Private Function TotalCharges() As Double
        dblServiceLaborCost = dblLaborCost + dblOilLubeTotal + dblFlushesTotal + dblMiscCharges
        dblTotalCharges = dblServiceLaborCost + dblOtherCharges + dblTaxCharges
        Return dblTotalCharges
    End Function

    Private Sub WriteValues()
        lblParts.Text = dblPartsCost
        lblServicesLabor.Text = dblServiceLaborCost
        lblTax.Text = dblTaxCharges
        lblTotal.Text = dblTotalCharges

    End Sub

    Private Sub ClearOilLube()
        chkOil.Checked = False
        chkLube.Checked = False
    End Sub

    Private Sub ClearFlushes()
        chkRadFlush.Checked = False
        chkTransFlush.Checked = False
    End Sub

    Private Sub ClearMisc()
        chkInspection.Checked = False
        chkMuffler.Checked = False
        chkTire.Checked = False
    End Sub

    Private Sub ClearOther()
        txtParts.Text = String.Empty
        txtLabor.Text = String.Empty
    End Sub

    Private Sub ClearFees()
        lblServicesLabor.Text = String.Empty
        lblParts.Text = String.Empty
        lblTax.Text = String.Empty
        lblTotal.Text = String.Empty
    End Sub

    Private Sub ClearValues()
        dblOilLubeTotal = 0.0D
        dblFlushesTotal = 0.0D
        dblMiscCharges = 0.0D
        dblOtherCharges = 0.0D
        dblTaxCharges = 0.0D
        dblTotalCharges = 0.0D
    End Sub

    Private Sub BtnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        OilLubeCharges()
        FlushCharges()
        MiscCharges()
        OtherCharges()
        TaxCharges()
        TotalCharges()
        WriteValues()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFees()
        ClearFlushes()
        ClearMisc()
        ClearOilLube()
        ClearOther()
        ClearValues()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        MessageBox.Show("Michael Gain")
        Me.Close()
    End Sub
End Class

Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim softwareLicense As Double = 0
        Dim optionsCosts As Double = 0

        If radYearly.Checked Then
            softwareLicense = 5000
        ElseIf radOneTime.Checked Then
            softwareLicense = 20000
        End If

        If chkTechSupport.Checked Then
            optionsCosts += 3500
        End If

        If chkOnSite.Checked Then
            optionsCosts += 2000
        End If

        If chkCloud.Checked Then
            optionsCosts += 300
        End If

        lblSoftwareLicense.Text = softwareLicense.ToString("n")
        lblOptionalFeatures.Text = optionsCosts.ToString("n")

        radYearly.Focus()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblOptionalFeatures.Text = String.Empty
        lblSoftwareLicense.Text = String.Empty

        chkCloud.Checked = False
        chkOnSite.Checked = False
        chkTechSupport.Checked = False

        radOneTime.Checked = False
        radYearly.Checked = False

        radYearly.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        MessageBox.Show("Michael Gain")
        Me.Close()
    End Sub
End Class

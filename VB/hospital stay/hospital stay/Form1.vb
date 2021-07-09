Public Class Form1
    Const dblCHARGE_PER_DAY As Double = 350.0

    Private intLengthOfStay As Integer
    Private dblMedicationCharges As Double
    Private dblSurgicalCharges As Double
    Private dblLabFees As Double
    Private dblPhysicalRehabCharges As Double

    Private Function CalcStayCharges(ByVal intDays, ByVal dblRate) As Double
        Return intDays * dblRate
    End Function

    Private Function CalcMiscCharges(ByVal dblMedication, ByVal dblSurgical, dblLab, dblPhysical) As Double
        Return dblMedication + dblSurgical + dblLab + dblPhysical
    End Function

    Private Function CalcTotalCharges(ByVal dblStay, ByVal dblMisc) As Double
        Return dblStay + dblMisc
    End Function

    Private Function ValidateInputFieldShortcut(ByVal strInputField As String, ByRef varValue As Double) As Boolean

        If Not Integer.TryParse(strInputField, varValue) OrElse
        varValue < 0.0 Then
            lblMessage.Text = "The input " & strInputField & " must be a positive number."
            Return False
        End If
        Return True
    End Function

    Private Function ValidateInputField() As Boolean
        lblMessage.Text = String.Empty

        If ValidateInputFieldShortcut(txtLengthOfStay.Text, intLengthOfStay) = False Then
            Return False
        End If
        If ValidateInputFieldShortcut(txtMedsCharges.Text, dblMedicationCharges) = False Then
            Return False
        End If
        If ValidateInputFieldShortcut(txtSurgicalCharges.Text, dblSurgicalCharges) = False Then
            Return False
        End If
        If ValidateInputFieldShortcut(txtLabFees.Text, dblLabFees) = False Then
            Return False
        End If
        If ValidateInputFieldShortcut(txtPhysRehabCharges.Text, dblPhysicalRehabCharges) = False Then
            Return False
        End If

        Return True
    End Function

    Private Function ExitProgram()
        MessageBox.Show("Michael Gain")
        Me.Close()
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ExitProgram()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblStayCharges As Double
        Dim dblMiscCharges As Double
        Dim dblTotalCharges As Double

        If ValidateInputField() Then
            dblStayCharges = CalcStayCharges(intLengthOfStay, dblCHARGE_PER_DAY)
            dblMiscCharges = CalcMiscCharges(dblMedicationCharges, dblSurgicalCharges, dblLabFees, dblPhysicalRehabCharges)
            dblTotalCharges = CalcTotalCharges(dblStayCharges, dblMiscCharges)

            lblMessage.Text = "Total Cost: " & dblTotalCharges.ToString("c")
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtLabFees.Clear()
        txtLengthOfStay.Clear()
        txtMedsCharges.Clear()
        txtPhysRehabCharges.Clear()
        txtSurgicalCharges.Clear()
        lblMessage.Text = String.Empty
    End Sub
End Class

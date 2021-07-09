Public Class Form1

    ' Global variables are fun
    Dim currentPlayer As Char = "X"
    Dim roundsCounter As Integer = 0

    Function WinCheck() As Boolean

        ' Increments round counter. Used later to test for draws
        roundsCounter += 1

        ' All the if statements check every combination of possible wins

        If (lbl1.Text = "X" And lbl2.Text = "X" And lbl3.Text = "X") Or (lbl1.Text = "O" And lbl2.Text = "O" And lbl3.Text = "O") Then
            lblOutput.Text = "Player " + currentPlayer + " wins!"
            Return True
        End If

        If (lbl4.Text = "X" And lbl5.Text = "X" And lbl6.Text = "X") Or (lbl4.Text = "O" And lbl5.Text = "O" And lbl6.Text = "O") Then
            lblOutput.Text = "Player " + currentPlayer + " wins!"
            Return True
        End If

        If (lbl7.Text = "X" And lbl8.Text = "X" And lbl8.Text = "X") Or (lbl7.Text = "O" And lbl8.Text = "O" And lbl8.Text = "O") Then
            lblOutput.Text = "Player " + currentPlayer + " wins!"
            Return True
        End If

        If (lbl1.Text = "X" And lbl5.Text = "X" And lbl9.Text = "X") Or (lbl1.Text = "O" And lbl5.Text = "O" And lbl9.Text = "O") Then
            lblOutput.Text = "Player " + currentPlayer + " wins!"
            Return True
        End If

        If (lbl3.Text = "X" And lbl5.Text = "X" And lbl7.Text = "X") Or (lbl3.Text = "O" And lbl5.Text = "O" And lbl7.Text = "O") Then
            lblOutput.Text = "Player " + currentPlayer + " wins!"
            Return True
        End If

        If (lbl1.Text = "X" And lbl4.Text = "X" And lbl7.Text = "X") Or (lbl1.Text = "O" And lbl4.Text = "O" And lbl7.Text = "O") Then
            lblOutput.Text = "Player " + currentPlayer + " wins!"
            Return True
        End If

        If (lbl2.Text = "X" And lbl5.Text = "X" And lbl8.Text = "X") Or (lbl2.Text = "O" And lbl5.Text = "O" And lbl8.Text = "O") Then
            lblOutput.Text = "Player " + currentPlayer + " wins!"
            Return True
        End If

        If (lbl3.Text = "X" And lbl6.Text = "X" And lbl9.Text = "X") Or (lbl3.Text = "O" And lbl6.Text = "O" And lbl9.Text = "O") Then
            lblOutput.Text = "Player " + currentPlayer + " wins!"
            Return True
        End If

        ' This check happens after the win checks to check if a draw happened
        If roundsCounter = 9 Then
            lblOutput.Text = "No one wins!"
            Return True
        End If
        Return False ' This return false is just to keep the compiler happy
    End Function

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        ' These check which radio button is selected
        ' Each if sets the approirate radio button invisible, sets the submit invisible, and is suppose to
        ' uncheck the radio button but isnt?
        ' the submit must be invisible because if it stays visible it is possible tp skip the other players turn
        If rad1.Checked = True Then
            rad1.Visible = False
            lbl1.Text = currentPlayer
            rad1.Checked = False

        ElseIf rad2.Checked = True Then
            rad2.Visible = False
            lbl2.Text = currentPlayer
            rad2.Checked = False

        ElseIf rad3.Checked = True Then
            rad3.Visible = False
            lbl3.Text = currentPlayer
            rad3.Checked = False

        ElseIf rad4.Checked = True Then
            rad4.Visible = False
            lbl4.Text = currentPlayer
            rad4.Checked = False

        ElseIf rad5.Checked = True Then
            rad5.Visible = False
            lbl5.Text = currentPlayer
            rad5.Checked = False

        ElseIf rad6.Checked = True Then
            rad6.Visible = False
            lbl6.Text = currentPlayer
            rad6.Checked = False

        ElseIf rad7.Checked = True Then
            rad7.Visible = False
            lbl7.Text = currentPlayer
            rad7.Checked = False

        ElseIf rad8.Checked = True Then
            rad8.Visible = False
            lbl8.Text = currentPlayer
            rad8.Checked = False

        ElseIf rad9.Checked = True Then
            rad9.Visible = False
            lbl9.Text = currentPlayer
            rad9.Checked = False
        End If

        ' If someone wins or the game draws this gets rid of the submit button so you cant continue "playing"
        If WinCheck() Then
            btnSubmit.Visible = False
            pnlRadioButtons.Visible = False
        End If

        ' This switches who the current player is, just changes what letter is being placed
        If currentPlayer = "X" Then
            currentPlayer = "O"
        Else
            currentPlayer = "X"
        End If

        ' This turns the submit button invisible aftere being clicked
        btnSubmit.Visible = False

    End Sub

    ' All of these make the submit button visible again once a radio button has been selected
    Private Sub rad1_CheckedChanged(sender As Object, e As EventArgs) Handles rad1.CheckedChanged
        btnSubmit.Visible = True
    End Sub

    Private Sub rad2_CheckedChanged(sender As Object, e As EventArgs) Handles rad2.CheckedChanged
        btnSubmit.Visible = True
    End Sub

    Private Sub rad3_CheckedChanged(sender As Object, e As EventArgs) Handles rad3.CheckedChanged
        btnSubmit.Visible = True
    End Sub

    Private Sub rad4_CheckedChanged(sender As Object, e As EventArgs) Handles rad4.CheckedChanged
        btnSubmit.Visible = True
    End Sub

    Private Sub rad5_CheckedChanged(sender As Object, e As EventArgs) Handles rad5.CheckedChanged
        btnSubmit.Visible = True
    End Sub

    Private Sub rad6_CheckedChanged(sender As Object, e As EventArgs) Handles rad6.CheckedChanged
        btnSubmit.Visible = True
    End Sub

    Private Sub rad7_CheckedChanged(sender As Object, e As EventArgs) Handles rad7.CheckedChanged
        btnSubmit.Visible = True
    End Sub

    Private Sub rad8_CheckedChanged(sender As Object, e As EventArgs) Handles rad8.CheckedChanged
        btnSubmit.Visible = True
    End Sub

    Private Sub rad9_CheckedChanged(sender As Object, e As EventArgs) Handles rad9.CheckedChanged
        btnSubmit.Visible = True
    End Sub
End Class

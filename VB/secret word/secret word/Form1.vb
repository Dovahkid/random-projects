Public Class Form1
    Dim strGuess As String
    Dim strSecretWord As String
    Private Sub btnGuess_Click(sender As Object, e As EventArgs) Handles btnGuess.Click

        Try
            strGuess = txtGuess.Text

            If strGuess = strSecretWord Then
                lblAnswer.Text = "You guessed the secret word " + strSecretWord
            Else
                lblAnswer.Text = "Your guess is not correct!"
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        strSecretWord = InputBox("Please enter a word")
    End Sub
End Class

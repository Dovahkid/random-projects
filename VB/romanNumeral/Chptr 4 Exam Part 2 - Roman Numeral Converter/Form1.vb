Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Michael Gain. Challenge 2: Roman Numeral Converter")
    End Sub

    Private Sub BtnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click

        Dim intDigit As Integer

        Try

            intDigit = CInt(txtDigit.Text)

            Select Case intDigit
                Case Is > 10
                    Throw New Exception()
                Case Is < 1
                    Throw New Exception()
            End Select

            Select Case intDigit
                Case 1
                    lblNumeral.Text = "I"
                Case 2
                    lblNumeral.Text = "II"
                Case 3
                    lblNumeral.Text = "III"
                Case 4
                    lblNumeral.Text = "IV"
                Case 5
                    lblNumeral.Text = "V"
                Case 6
                    lblNumeral.Text = "VI"
                Case 7
                    lblNumeral.Text = "VII"
                Case 8
                    lblNumeral.Text = "VIII"
                Case 9
                    lblNumeral.Text = "IX"
                Case 10
                    lblNumeral.Text = "X"
            End Select

        Catch ex As Exception
            MessageBox.Show("Please enter a valid number!")
        End Try

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class

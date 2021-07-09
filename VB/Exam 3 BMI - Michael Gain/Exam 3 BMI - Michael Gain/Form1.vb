Public Class Form1
    Private Sub ExitFunc()
        MessageBox.Show("Michael Gain")
        Me.Close()
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        ExitFunc()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ExitFunc()
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Dim intHeight As Integer
        Dim intWeight As Integer
        Dim intBMI As Integer


        Try

            intHeight = CInt(txtHeight.Text)
            intWeight = CInt(txtWeight.Text)

            intBMI = (intWeight * 703) / (intHeight ^ 2)
            lblBMI.Text = intBMI.ToString()

        Catch ex As Exception
            lblStatus.Text = "Please enter valid values"
        End Try

    End Sub
End Class

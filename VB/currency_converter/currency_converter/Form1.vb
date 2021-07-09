Public Class Form1
    Dim strName As String = String.Empty
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Michael Gain")
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Const dblPOUNDS_FACTOR As Double = 0.68
        Const dblEUROS_FACTOR As Double = 0.83
        Const dblYEN_FACTOR As Double = 108.36
        lblStatus.Text = String.Empty

        Try
            Dim dblDollars As Double = CDbl(txtDollars.Text)
            Dim dblPounds As Double = dblDollars * dblPOUNDS_FACTOR
            Dim dblEuros As Double = dblDollars * dblEUROS_FACTOR
            Dim dblYen As Double = dblDollars * dblYEN_FACTOR

            lblPounds.Text = "£" + dblPounds.ToString()
            lblEuros.Text = "€" + dblEuros.ToString().Replace(".", ",")
            lblYen.Text = "¥" + dblYen.ToString()
            lblStatus.Text = String.Empty

            txtDollars.Focus()
        Catch ex As Exception
            lblStatus.Text = strName + " please input a valid number"
        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDollars.Clear()

        lblEuros.Text = String.Empty
        lblPounds.Text = String.Empty
        lblYen.Text = String.Empty
        lblStatus.Text = String.Empty

        txtDollars.Focus()
    End Sub

    Private Sub PersonalizationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonalizationToolStripMenuItem.Click
        strName = InputBox("Please enter your name")
        lblStatus.Text = strName
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        MessageBox.Show("Michael Gain")
        Me.Close()
    End Sub
End Class

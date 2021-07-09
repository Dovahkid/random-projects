Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Const dblREVENUE_PERCENTAGE As Double = 0.2R

        Try
            Dim dblAdultPrice As Double = CDbl(txtAdultPrice.Text)
            Dim intAdultSold As Integer = CDbl(txtAdultSold.Text)
            Dim dblChildPrice As Double = CDbl(txtChildPrice.Text)
            Dim intChildSold As Integer = CInt(txtChildPrice.Text)

            Dim dblGrossAdult As Double = dblAdultPrice * intAdultSold
            Dim dblGrossChild As Double = dblChildPrice * intChildSold
            Dim dblGrossRevenue As Double = dblGrossAdult + dblGrossChild

            Dim dblNetAdult As Double = dblGrossAdult * dblREVENUE_PERCENTAGE
            Dim dblNetChild As Double = dblGrossChild * dblREVENUE_PERCENTAGE
            Dim dblNetRevenue As Double = dblNetAdult + dblNetChild

            lblGrossAdultSales.Text = dblGrossAdult.ToString("c")
            lblGrossChildSales.Text = dblGrossChild.ToString("c")
            lblGrossRevenue.Text = dblGrossRevenue.ToString("c")

            lblNetAdultSales.Text = dblNetAdult.ToString("c")
            lblNetChildSales.Text = dblNetChild.ToString("c")
            lblNetRevenue.Text = dblNetRevenue.ToString("c")

        Catch ex As Exception
            lblStatus.Text = "Please enter valid information"
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAdultPrice.Text = String.Empty
        txtAdultSold.Text = String.Empty
        txtChildPrice.Text = String.Empty
        txtChildSold.Text = String.Empty

        lblGrossAdultSales.Text = String.Empty
        lblGrossChildSales.Text = String.Empty
        lblGrossRevenue.Text = String.Empty
        lblNetAdultSales.Text = String.Empty
        lblNetChildSales.Text = String.Empty
        lblNetRevenue.Text = String.Empty
        lblStatus.Text = String.Empty

        txtAdultPrice.Focus()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim strEmployee As String = InputBox("Please enter your name")
        lblEmployee.Text = strEmployee

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Michael Gain")
        Me.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        MessageBox.Show("Michael Gain")
        Me.Close()
    End Sub
End Class

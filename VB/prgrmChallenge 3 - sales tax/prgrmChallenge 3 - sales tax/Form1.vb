Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim dblSaleAmount As Double = Convert.ToDouble(txtSaleAmount.Text)
        Dim dblTaxRate As Double = Convert.ToDouble(txtTaxRate.Text)
        Dim dblSalesTaxDue As Double = dblSaleAmount * dblTaxRate

        lblSalesTaxDue.Text = "$" + Convert.ToString(dblSalesTaxDue)

        lblTotalSales.Text = "$" + Convert.ToString(dblSaleAmount + dblSalesTaxDue)

        MessageBox.Show("The total amount is: " + lblTotalSales.Text)


    End Sub
End Class

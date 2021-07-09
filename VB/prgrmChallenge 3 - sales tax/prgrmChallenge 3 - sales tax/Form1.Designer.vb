<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblSalesTaxDue = New System.Windows.Forms.Label()
        Me.lblTotalSales = New System.Windows.Forms.Label()
        Me.txtSaleAmount = New System.Windows.Forms.TextBox()
        Me.txtTaxRate = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sale Amount:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tax Rate:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(72, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Sales tax due:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(72, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Total Sales:"
        '
        'lblSalesTaxDue
        '
        Me.lblSalesTaxDue.AutoSize = True
        Me.lblSalesTaxDue.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSalesTaxDue.Location = New System.Drawing.Point(152, 144)
        Me.lblSalesTaxDue.Name = "lblSalesTaxDue"
        Me.lblSalesTaxDue.Padding = New System.Windows.Forms.Padding(0, 0, 50, 0)
        Me.lblSalesTaxDue.Size = New System.Drawing.Size(69, 13)
        Me.lblSalesTaxDue.TabIndex = 4
        Me.lblSalesTaxDue.Text = "$0"
        '
        'lblTotalSales
        '
        Me.lblTotalSales.AutoSize = True
        Me.lblTotalSales.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTotalSales.Location = New System.Drawing.Point(152, 181)
        Me.lblTotalSales.Name = "lblTotalSales"
        Me.lblTotalSales.Padding = New System.Windows.Forms.Padding(0, 0, 50, 0)
        Me.lblTotalSales.Size = New System.Drawing.Size(69, 13)
        Me.lblTotalSales.TabIndex = 5
        Me.lblTotalSales.Text = "$0"
        '
        'txtSaleAmount
        '
        Me.txtSaleAmount.Location = New System.Drawing.Point(145, 52)
        Me.txtSaleAmount.Name = "txtSaleAmount"
        Me.txtSaleAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtSaleAmount.TabIndex = 6
        '
        'txtTaxRate
        '
        Me.txtTaxRate.Location = New System.Drawing.Point(145, 92)
        Me.txtTaxRate.Name = "txtTaxRate"
        Me.txtTaxRate.Size = New System.Drawing.Size(100, 20)
        Me.txtTaxRate.TabIndex = 7
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(116, 241)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(99, 35)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 332)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtTaxRate)
        Me.Controls.Add(Me.txtSaleAmount)
        Me.Controls.Add(Me.lblTotalSales)
        Me.Controls.Add(Me.lblSalesTaxDue)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblSalesTaxDue As Label
    Friend WithEvents lblTotalSales As Label
    Friend WithEvents txtSaleAmount As TextBox
    Friend WithEvents txtTaxRate As TextBox
    Friend WithEvents btnCalculate As Button
End Class

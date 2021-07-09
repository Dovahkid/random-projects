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
        Me.txtDigit = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNumeral = New System.Windows.Forms.Label()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Your Digit (1-10):"
        '
        'txtDigit
        '
        Me.txtDigit.Location = New System.Drawing.Point(138, 6)
        Me.txtDigit.Name = "txtDigit"
        Me.txtDigit.Size = New System.Drawing.Size(100, 20)
        Me.txtDigit.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(120, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Roman Numeral:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblNumeral
        '
        Me.lblNumeral.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNumeral.Location = New System.Drawing.Point(138, 42)
        Me.lblNumeral.Name = "lblNumeral"
        Me.lblNumeral.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNumeral.Size = New System.Drawing.Size(100, 23)
        Me.lblNumeral.TabIndex = 3
        Me.lblNumeral.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(15, 68)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(100, 34)
        Me.btnConvert.TabIndex = 4
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(138, 68)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 34)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(255, 113)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.lblNumeral)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDigit)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Roman Numeral Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtDigit As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblNumeral As Label
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnExit As Button
End Class

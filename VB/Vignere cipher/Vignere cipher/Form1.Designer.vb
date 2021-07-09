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
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtKey = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblDecipher = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(33, 220)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(281, 200)
        Me.btnSubmit.TabIndex = 0
        Me.btnSubmit.Text = "submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.Location = New System.Drawing.Point(18, 23)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(223, 33)
        Me.lblOutput.TabIndex = 1
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(87, 31)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(174, 20)
        Me.txtInput.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblDecipher)
        Me.GroupBox1.Controls.Add(Me.lblOutput)
        Me.GroupBox1.Location = New System.Drawing.Point(73, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(252, 116)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'txtKey
        '
        Me.txtKey.Location = New System.Drawing.Point(267, 31)
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Size = New System.Drawing.Size(174, 20)
        Me.txtKey.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(363, 262)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 129)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblDecipher
        '
        Me.lblDecipher.Location = New System.Drawing.Point(11, 69)
        Me.lblDecipher.Name = "lblDecipher"
        Me.lblDecipher.Size = New System.Drawing.Size(223, 33)
        Me.lblDecipher.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(355, 140)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 71)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtKey)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.btnSubmit)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblOutput As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtKey As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lblDecipher As Label
    Friend WithEvents Button2 As Button
End Class

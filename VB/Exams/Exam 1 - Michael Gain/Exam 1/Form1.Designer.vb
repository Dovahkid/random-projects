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
        Me.txtAvailable = New System.Windows.Forms.TextBox()
        Me.txtUsed = New System.Windows.Forms.TextBox()
        Me.lblRemaining = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnName = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Available Credit:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Used Credit:"
        '
        'txtAvailable
        '
        Me.txtAvailable.Location = New System.Drawing.Point(99, 20)
        Me.txtAvailable.Name = "txtAvailable"
        Me.txtAvailable.Size = New System.Drawing.Size(100, 20)
        Me.txtAvailable.TabIndex = 2
        '
        'txtUsed
        '
        Me.txtUsed.Location = New System.Drawing.Point(99, 46)
        Me.txtUsed.Name = "txtUsed"
        Me.txtUsed.Size = New System.Drawing.Size(100, 20)
        Me.txtUsed.TabIndex = 3
        '
        'lblRemaining
        '
        Me.lblRemaining.AutoSize = True
        Me.lblRemaining.Location = New System.Drawing.Point(3, 117)
        Me.lblRemaining.Name = "lblRemaining"
        Me.lblRemaining.Size = New System.Drawing.Size(93, 13)
        Me.lblRemaining.TabIndex = 4
        Me.lblRemaining.Text = "Remaining Credit: "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(99, 72)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 26)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnName
        '
        Me.btnName.Location = New System.Drawing.Point(6, 136)
        Me.btnName.Name = "btnName"
        Me.btnName.Size = New System.Drawing.Size(34, 26)
        Me.btnName.TabIndex = 6
        Me.btnName.Text = "Info"
        Me.btnName.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(209, 174)
        Me.Controls.Add(Me.btnName)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblRemaining)
        Me.Controls.Add(Me.txtUsed)
        Me.Controls.Add(Me.txtAvailable)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Credit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAvailable As TextBox
    Friend WithEvents txtUsed As TextBox
    Friend WithEvents lblRemaining As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnName As Button
End Class

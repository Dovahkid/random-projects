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
        Me.imgFiveCents = New System.Windows.Forms.PictureBox()
        Me.imgTenCents = New System.Windows.Forms.PictureBox()
        Me.imgTwentyFiveCents = New System.Windows.Forms.PictureBox()
        Me.imgFiftyCents = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        CType(Me.imgFiveCents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgTenCents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgTwentyFiveCents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgFiftyCents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgFiveCents
        '
        Me.imgFiveCents.Image = Global.change_counter.My.Resources.Resources._5cents
        Me.imgFiveCents.InitialImage = Global.change_counter.My.Resources.Resources._5cents
        Me.imgFiveCents.Location = New System.Drawing.Point(13, 35)
        Me.imgFiveCents.Name = "imgFiveCents"
        Me.imgFiveCents.Size = New System.Drawing.Size(125, 181)
        Me.imgFiveCents.TabIndex = 0
        Me.imgFiveCents.TabStop = False
        '
        'imgTenCents
        '
        Me.imgTenCents.Image = Global.change_counter.My.Resources.Resources._10cents
        Me.imgTenCents.Location = New System.Drawing.Point(144, 35)
        Me.imgTenCents.Name = "imgTenCents"
        Me.imgTenCents.Size = New System.Drawing.Size(125, 181)
        Me.imgTenCents.TabIndex = 1
        Me.imgTenCents.TabStop = False
        '
        'imgTwentyFiveCents
        '
        Me.imgTwentyFiveCents.Image = Global.change_counter.My.Resources.Resources._25cents
        Me.imgTwentyFiveCents.Location = New System.Drawing.Point(13, 222)
        Me.imgTwentyFiveCents.Name = "imgTwentyFiveCents"
        Me.imgTwentyFiveCents.Size = New System.Drawing.Size(125, 181)
        Me.imgTwentyFiveCents.TabIndex = 2
        Me.imgTwentyFiveCents.TabStop = False
        '
        'imgFiftyCents
        '
        Me.imgFiftyCents.Image = Global.change_counter.My.Resources.Resources._50cents
        Me.imgFiftyCents.Location = New System.Drawing.Point(144, 222)
        Me.imgFiftyCents.Name = "imgFiftyCents"
        Me.imgFiftyCents.Size = New System.Drawing.Size(125, 181)
        Me.imgFiftyCents.TabIndex = 3
        Me.imgFiftyCents.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 415)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Total:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(98, 454)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 32)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(84, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Click the Coins"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(112, 414)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(115, 14)
        Me.lblTotal.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 498)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.imgFiftyCents)
        Me.Controls.Add(Me.imgTwentyFiveCents)
        Me.Controls.Add(Me.imgTenCents)
        Me.Controls.Add(Me.imgFiveCents)
        Me.Name = "Form1"
        Me.Text = "Change Counter"
        CType(Me.imgFiveCents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgTenCents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgTwentyFiveCents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgFiftyCents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imgFiveCents As PictureBox
    Friend WithEvents imgTenCents As PictureBox
    Friend WithEvents imgTwentyFiveCents As PictureBox
    Friend WithEvents imgFiftyCents As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotal As Label
End Class

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
        Me.picRock = New System.Windows.Forms.PictureBox()
        Me.picPaper = New System.Windows.Forms.PictureBox()
        Me.picScissors = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblComputer = New System.Windows.Forms.Label()
        Me.lblChoice = New System.Windows.Forms.Label()
        CType(Me.picRock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPaper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picScissors, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picRock
        '
        Me.picRock.Image = Global.rockpaperscissors.My.Resources.Resources.rock
        Me.picRock.Location = New System.Drawing.Point(12, 3)
        Me.picRock.Name = "picRock"
        Me.picRock.Size = New System.Drawing.Size(192, 203)
        Me.picRock.TabIndex = 0
        Me.picRock.TabStop = False
        '
        'picPaper
        '
        Me.picPaper.Image = Global.rockpaperscissors.My.Resources.Resources.paper
        Me.picPaper.Location = New System.Drawing.Point(210, 3)
        Me.picPaper.Name = "picPaper"
        Me.picPaper.Size = New System.Drawing.Size(189, 258)
        Me.picPaper.TabIndex = 1
        Me.picPaper.TabStop = False
        '
        'picScissors
        '
        Me.picScissors.Image = Global.rockpaperscissors.My.Resources.Resources.scissors
        Me.picScissors.Location = New System.Drawing.Point(405, 3)
        Me.picScissors.Name = "picScissors"
        Me.picScissors.Size = New System.Drawing.Size(187, 242)
        Me.picScissors.TabIndex = 2
        Me.picScissors.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 291)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Computer's Choice:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(53, 344)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 29)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Your Selection:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(425, 291)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(179, 163)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblComputer
        '
        Me.lblComputer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblComputer.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComputer.Location = New System.Drawing.Point(236, 291)
        Me.lblComputer.Name = "lblComputer"
        Me.lblComputer.Size = New System.Drawing.Size(172, 32)
        Me.lblComputer.TabIndex = 7
        '
        'lblChoice
        '
        Me.lblChoice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblChoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChoice.Location = New System.Drawing.Point(236, 344)
        Me.lblChoice.Name = "lblChoice"
        Me.lblChoice.Size = New System.Drawing.Size(172, 32)
        Me.lblChoice.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 466)
        Me.Controls.Add(Me.lblChoice)
        Me.Controls.Add(Me.lblComputer)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picScissors)
        Me.Controls.Add(Me.picPaper)
        Me.Controls.Add(Me.picRock)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picRock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPaper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picScissors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picRock As PictureBox
    Friend WithEvents picPaper As PictureBox
    Friend WithEvents picScissors As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents lblComputer As Label
    Friend WithEvents lblChoice As Label
End Class

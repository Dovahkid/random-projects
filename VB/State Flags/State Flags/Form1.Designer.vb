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
        Me.picFlag = New System.Windows.Forms.PictureBox()
        Me.lblAbbreviation = New System.Windows.Forms.Label()
        Me.txtAbbreviation = New System.Windows.Forms.TextBox()
        Me.btnLookup = New System.Windows.Forms.Button()
        Me.lblDetails = New System.Windows.Forms.Label()
        CType(Me.picFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picFlag
        '
        Me.picFlag.Location = New System.Drawing.Point(613, 32)
        Me.picFlag.Name = "picFlag"
        Me.picFlag.Size = New System.Drawing.Size(400, 300)
        Me.picFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picFlag.TabIndex = 0
        Me.picFlag.TabStop = False
        '
        'lblAbbreviation
        '
        Me.lblAbbreviation.Location = New System.Drawing.Point(12, 9)
        Me.lblAbbreviation.Name = "lblAbbreviation"
        Me.lblAbbreviation.Size = New System.Drawing.Size(141, 23)
        Me.lblAbbreviation.TabIndex = 2
        Me.lblAbbreviation.Text = "Enter the State Abbreviation"
        '
        'txtAbbreviation
        '
        Me.txtAbbreviation.Location = New System.Drawing.Point(159, 6)
        Me.txtAbbreviation.Name = "txtAbbreviation"
        Me.txtAbbreviation.Size = New System.Drawing.Size(143, 20)
        Me.txtAbbreviation.TabIndex = 3
        '
        'btnLookup
        '
        Me.btnLookup.Location = New System.Drawing.Point(308, 6)
        Me.btnLookup.Name = "btnLookup"
        Me.btnLookup.Size = New System.Drawing.Size(89, 23)
        Me.btnLookup.TabIndex = 4
        Me.btnLookup.Text = "Lookup State"
        Me.btnLookup.UseVisualStyleBackColor = True
        '
        'lblDetails
        '
        Me.lblDetails.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblDetails.Location = New System.Drawing.Point(12, 32)
        Me.lblDetails.Name = "lblDetails"
        Me.lblDetails.Size = New System.Drawing.Size(595, 594)
        Me.lblDetails.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1025, 635)
        Me.Controls.Add(Me.btnLookup)
        Me.Controls.Add(Me.txtAbbreviation)
        Me.Controls.Add(Me.lblAbbreviation)
        Me.Controls.Add(Me.lblDetails)
        Me.Controls.Add(Me.picFlag)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picFlag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picFlag As PictureBox
    Friend WithEvents lblAbbreviation As Label
    Friend WithEvents txtAbbreviation As TextBox
    Friend WithEvents btnLookup As Button
    Friend WithEvents lblDetails As Label
End Class

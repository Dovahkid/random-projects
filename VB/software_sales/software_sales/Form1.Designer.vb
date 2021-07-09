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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radOneTime = New System.Windows.Forms.RadioButton()
        Me.radYearly = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkCloud = New System.Windows.Forms.CheckBox()
        Me.chkOnSite = New System.Windows.Forms.CheckBox()
        Me.chkTechSupport = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblOptionalFeatures = New System.Windows.Forms.Label()
        Me.lblSoftwareLicense = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radOneTime)
        Me.GroupBox1.Controls.Add(Me.radYearly)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(209, 112)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Licensing Options"
        '
        'radOneTime
        '
        Me.radOneTime.AutoSize = True
        Me.radOneTime.Location = New System.Drawing.Point(6, 70)
        Me.radOneTime.Name = "radOneTime"
        Me.radOneTime.Size = New System.Drawing.Size(119, 17)
        Me.radOneTime.TabIndex = 1
        Me.radOneTime.TabStop = True
        Me.radOneTime.Text = "One-Time Purchase"
        Me.radOneTime.UseVisualStyleBackColor = True
        '
        'radYearly
        '
        Me.radYearly.AutoSize = True
        Me.radYearly.Location = New System.Drawing.Point(6, 30)
        Me.radYearly.Name = "radYearly"
        Me.radYearly.Size = New System.Drawing.Size(90, 17)
        Me.radYearly.TabIndex = 0
        Me.radYearly.TabStop = True
        Me.radYearly.Text = "Yearly license"
        Me.radYearly.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkCloud)
        Me.GroupBox2.Controls.Add(Me.chkOnSite)
        Me.GroupBox2.Controls.Add(Me.chkTechSupport)
        Me.GroupBox2.Location = New System.Drawing.Point(227, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(209, 112)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Optional Features (yearly)"
        '
        'chkCloud
        '
        Me.chkCloud.AutoSize = True
        Me.chkCloud.Location = New System.Drawing.Point(6, 80)
        Me.chkCloud.Name = "chkCloud"
        Me.chkCloud.Size = New System.Drawing.Size(93, 17)
        Me.chkCloud.TabIndex = 2
        Me.chkCloud.Text = "Cloud Backup"
        Me.chkCloud.UseVisualStyleBackColor = True
        '
        'chkOnSite
        '
        Me.chkOnSite.AutoSize = True
        Me.chkOnSite.Location = New System.Drawing.Point(6, 48)
        Me.chkOnSite.Name = "chkOnSite"
        Me.chkOnSite.Size = New System.Drawing.Size(100, 17)
        Me.chkOnSite.TabIndex = 1
        Me.chkOnSite.Text = "On-site Training"
        Me.chkOnSite.UseVisualStyleBackColor = True
        '
        'chkTechSupport
        '
        Me.chkTechSupport.AutoSize = True
        Me.chkTechSupport.Location = New System.Drawing.Point(6, 19)
        Me.chkTechSupport.Name = "chkTechSupport"
        Me.chkTechSupport.Size = New System.Drawing.Size(151, 17)
        Me.chkTechSupport.TabIndex = 0
        Me.chkTechSupport.Text = "Level-3 Technical Support"
        Me.chkTechSupport.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblOptionalFeatures)
        Me.Panel1.Controls.Add(Me.lblSoftwareLicense)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 130)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(259, 83)
        Me.Panel1.TabIndex = 2
        '
        'lblOptionalFeatures
        '
        Me.lblOptionalFeatures.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOptionalFeatures.Location = New System.Drawing.Point(141, 48)
        Me.lblOptionalFeatures.Name = "lblOptionalFeatures"
        Me.lblOptionalFeatures.Size = New System.Drawing.Size(100, 19)
        Me.lblOptionalFeatures.TabIndex = 3
        '
        'lblSoftwareLicense
        '
        Me.lblSoftwareLicense.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSoftwareLicense.Location = New System.Drawing.Point(141, 15)
        Me.lblSoftwareLicense.Name = "lblSoftwareLicense"
        Me.lblSoftwareLicense.Size = New System.Drawing.Size(100, 19)
        Me.lblSoftwareLicense.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(3, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cost of optional features:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(3, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cost of software licensing:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(277, 130)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(81, 83)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(358, 130)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(81, 41)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(358, 172)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(81, 41)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 225)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Software License"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblOptionalFeatures As Label
    Friend WithEvents lblSoftwareLicense As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents radOneTime As RadioButton
    Friend WithEvents radYearly As RadioButton
    Friend WithEvents chkCloud As CheckBox
    Friend WithEvents chkOnSite As CheckBox
    Friend WithEvents chkTechSupport As CheckBox
End Class

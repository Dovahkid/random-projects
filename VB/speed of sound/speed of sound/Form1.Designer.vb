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
        Me.txtDistance = New System.Windows.Forms.TextBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radSteel = New System.Windows.Forms.RadioButton()
        Me.radWater = New System.Windows.Forms.RadioButton()
        Me.radAir = New System.Windows.Forms.RadioButton()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total Time (in seconds):"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter a distance:"
        '
        'txtDistance
        '
        Me.txtDistance.Location = New System.Drawing.Point(138, 9)
        Me.txtDistance.Name = "txtDistance"
        Me.txtDistance.Size = New System.Drawing.Size(126, 20)
        Me.txtDistance.TabIndex = 3
        '
        'lblTime
        '
        Me.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTime.Location = New System.Drawing.Point(138, 107)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(126, 20)
        Me.lblTime.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radSteel)
        Me.GroupBox1.Controls.Add(Me.radWater)
        Me.GroupBox1.Controls.Add(Me.radAir)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(255, 70)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a medium (to determine speed)"
        '
        'radSteel
        '
        Me.radSteel.AutoSize = True
        Me.radSteel.Location = New System.Drawing.Point(170, 33)
        Me.radSteel.Name = "radSteel"
        Me.radSteel.Size = New System.Drawing.Size(49, 17)
        Me.radSteel.TabIndex = 2
        Me.radSteel.TabStop = True
        Me.radSteel.Text = "Steel"
        Me.radSteel.UseVisualStyleBackColor = True
        '
        'radWater
        '
        Me.radWater.AutoSize = True
        Me.radWater.Location = New System.Drawing.Point(92, 33)
        Me.radWater.Name = "radWater"
        Me.radWater.Size = New System.Drawing.Size(54, 17)
        Me.radWater.TabIndex = 1
        Me.radWater.TabStop = True
        Me.radWater.Text = "Water"
        Me.radWater.UseVisualStyleBackColor = True
        '
        'radAir
        '
        Me.radAir.AutoSize = True
        Me.radAir.Checked = True
        Me.radAir.Location = New System.Drawing.Point(29, 33)
        Me.radAir.Name = "radAir"
        Me.radAir.Size = New System.Drawing.Size(37, 17)
        Me.radAir.TabIndex = 0
        Me.radAir.TabStop = True
        Me.radAir.Text = "Air"
        Me.radAir.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(9, 142)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(99, 142)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(189, 142)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 176)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.txtDistance)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Speed of Sound"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDistance As TextBox
    Friend WithEvents lblTime As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radSteel As RadioButton
    Friend WithEvents radWater As RadioButton
    Friend WithEvents radAir As RadioButton
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class

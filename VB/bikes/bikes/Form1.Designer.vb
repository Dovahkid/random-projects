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
        Me.grpBikeType = New System.Windows.Forms.GroupBox()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.grpExtras = New System.Windows.Forms.GroupBox()
        Me.radRoad = New System.Windows.Forms.RadioButton()
        Me.radMountain = New System.Windows.Forms.RadioButton()
        Me.radHybrid = New System.Windows.Forms.RadioButton()
        Me.chkCustom = New System.Windows.Forms.CheckBox()
        Me.chkHeavy = New System.Windows.Forms.CheckBox()
        Me.chkComfort = New System.Windows.Forms.CheckBox()
        Me.grpBikeType.SuspendLayout()
        Me.grpExtras.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpBikeType
        '
        Me.grpBikeType.Controls.Add(Me.radHybrid)
        Me.grpBikeType.Controls.Add(Me.radMountain)
        Me.grpBikeType.Controls.Add(Me.radRoad)
        Me.grpBikeType.Location = New System.Drawing.Point(16, 15)
        Me.grpBikeType.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpBikeType.Name = "grpBikeType"
        Me.grpBikeType.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpBikeType.Size = New System.Drawing.Size(137, 162)
        Me.grpBikeType.TabIndex = 0
        Me.grpBikeType.TabStop = False
        Me.grpBikeType.Text = "Type of Bike"
        '
        'btnAbout
        '
        Me.btnAbout.Location = New System.Drawing.Point(13, 201)
        Me.btnAbout.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(344, 65)
        Me.btnAbout.TabIndex = 2
        Me.btnAbout.Text = "About the Bike Shop"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'lblOrder
        '
        Me.lblOrder.Location = New System.Drawing.Point(13, 283)
        Me.lblOrder.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(344, 144)
        Me.lblOrder.TabIndex = 3
        '
        'grpExtras
        '
        Me.grpExtras.Controls.Add(Me.chkComfort)
        Me.grpExtras.Controls.Add(Me.chkHeavy)
        Me.grpExtras.Controls.Add(Me.chkCustom)
        Me.grpExtras.Location = New System.Drawing.Point(178, 15)
        Me.grpExtras.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpExtras.Name = "grpExtras"
        Me.grpExtras.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpExtras.Size = New System.Drawing.Size(179, 162)
        Me.grpExtras.TabIndex = 1
        Me.grpExtras.TabStop = False
        Me.grpExtras.Text = "Extras"
        '
        'radRoad
        '
        Me.radRoad.AutoSize = True
        Me.radRoad.Location = New System.Drawing.Point(19, 35)
        Me.radRoad.Name = "radRoad"
        Me.radRoad.Size = New System.Drawing.Size(60, 20)
        Me.radRoad.TabIndex = 0
        Me.radRoad.TabStop = True
        Me.radRoad.Text = "Road"
        Me.radRoad.UseVisualStyleBackColor = True
        '
        'radMountain
        '
        Me.radMountain.AutoSize = True
        Me.radMountain.Location = New System.Drawing.Point(19, 73)
        Me.radMountain.Name = "radMountain"
        Me.radMountain.Size = New System.Drawing.Size(80, 20)
        Me.radMountain.TabIndex = 1
        Me.radMountain.TabStop = True
        Me.radMountain.Text = "Mountain"
        Me.radMountain.UseVisualStyleBackColor = True
        '
        'radHybrid
        '
        Me.radHybrid.AutoSize = True
        Me.radHybrid.Location = New System.Drawing.Point(19, 112)
        Me.radHybrid.Name = "radHybrid"
        Me.radHybrid.Size = New System.Drawing.Size(66, 20)
        Me.radHybrid.TabIndex = 2
        Me.radHybrid.TabStop = True
        Me.radHybrid.Text = "Hybrid"
        Me.radHybrid.UseVisualStyleBackColor = True
        '
        'chkCustom
        '
        Me.chkCustom.AutoSize = True
        Me.chkCustom.Location = New System.Drawing.Point(29, 36)
        Me.chkCustom.Name = "chkCustom"
        Me.chkCustom.Size = New System.Drawing.Size(105, 20)
        Me.chkCustom.TabIndex = 0
        Me.chkCustom.Text = "Custom Paint"
        Me.chkCustom.UseVisualStyleBackColor = True
        '
        'chkHeavy
        '
        Me.chkHeavy.AutoSize = True
        Me.chkHeavy.Location = New System.Drawing.Point(29, 73)
        Me.chkHeavy.Name = "chkHeavy"
        Me.chkHeavy.Size = New System.Drawing.Size(139, 20)
        Me.chkHeavy.TabIndex = 1
        Me.chkHeavy.Text = "Heavy Duty Frame"
        Me.chkHeavy.UseVisualStyleBackColor = True
        '
        'chkComfort
        '
        Me.chkComfort.AutoSize = True
        Me.chkComfort.Location = New System.Drawing.Point(29, 112)
        Me.chkComfort.Name = "chkComfort"
        Me.chkComfort.Size = New System.Drawing.Size(104, 20)
        Me.chkComfort.TabIndex = 2
        Me.chkComfort.Text = "Comfort Seat"
        Me.chkComfort.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 450)
        Me.Controls.Add(Me.grpExtras)
        Me.Controls.Add(Me.lblOrder)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.grpBikeType)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Bike Shop"
        Me.grpBikeType.ResumeLayout(False)
        Me.grpBikeType.PerformLayout()
        Me.grpExtras.ResumeLayout(False)
        Me.grpExtras.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpBikeType As GroupBox
    Friend WithEvents btnAbout As Button
    Friend WithEvents lblOrder As Label
    Friend WithEvents grpExtras As GroupBox
    Friend WithEvents radHybrid As RadioButton
    Friend WithEvents radMountain As RadioButton
    Friend WithEvents radRoad As RadioButton
    Friend WithEvents chkComfort As CheckBox
    Friend WithEvents chkHeavy As CheckBox
    Friend WithEvents chkCustom As CheckBox
End Class

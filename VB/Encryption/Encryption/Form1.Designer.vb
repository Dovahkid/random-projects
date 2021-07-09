<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.lblInput = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnEncDec = New System.Windows.Forms.Button()
        Me.grpOutput = New System.Windows.Forms.GroupBox()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.radVigenere = New System.Windows.Forms.RadioButton()
        Me.radNormal = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.radDecrypt = New System.Windows.Forms.RadioButton()
        Me.radEncrypt = New System.Windows.Forms.RadioButton()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSet = New System.Windows.Forms.Button()
        Me.txtAlphabet = New System.Windows.Forms.TextBox()
        Me.lblAlphabet = New System.Windows.Forms.Label()
        Me.txtKey = New System.Windows.Forms.TextBox()
        Me.lblKey = New System.Windows.Forms.Label()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.grpOutput.SuspendLayout()
        Me.grpOptions.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(49, 9)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(158, 20)
        Me.txtInput.TabIndex = 0
        '
        'lblInput
        '
        Me.lblInput.AutoSize = True
        Me.lblInput.Location = New System.Drawing.Point(12, 9)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(31, 13)
        Me.lblInput.TabIndex = 1
        Me.lblInput.Text = "Input"
        '
        'lblOutput
        '
        Me.lblOutput.Location = New System.Drawing.Point(6, 16)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(207, 233)
        Me.lblOutput.TabIndex = 2
        Me.lblOutput.Text = " "
        '
        'btnEncDec
        '
        Me.btnEncDec.Location = New System.Drawing.Point(49, 35)
        Me.btnEncDec.Name = "btnEncDec"
        Me.btnEncDec.Size = New System.Drawing.Size(158, 43)
        Me.btnEncDec.TabIndex = 3
        Me.btnEncDec.Text = "Encrypt"
        Me.btnEncDec.UseVisualStyleBackColor = True
        Me.btnEncDec.Visible = False
        '
        'grpOutput
        '
        Me.grpOutput.Controls.Add(Me.lblOutput)
        Me.grpOutput.Location = New System.Drawing.Point(6, 84)
        Me.grpOutput.Name = "grpOutput"
        Me.grpOutput.Size = New System.Drawing.Size(228, 252)
        Me.grpOutput.TabIndex = 4
        Me.grpOutput.TabStop = False
        Me.grpOutput.Text = "Output"
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.Panel2)
        Me.grpOptions.Controls.Add(Me.Panel1)
        Me.grpOptions.Controls.Add(Me.btnReset)
        Me.grpOptions.Controls.Add(Me.btnSet)
        Me.grpOptions.Controls.Add(Me.txtAlphabet)
        Me.grpOptions.Controls.Add(Me.lblAlphabet)
        Me.grpOptions.Controls.Add(Me.txtKey)
        Me.grpOptions.Controls.Add(Me.lblKey)
        Me.grpOptions.Location = New System.Drawing.Point(240, 9)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(211, 381)
        Me.grpOptions.TabIndex = 5
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.radVigenere)
        Me.Panel2.Controls.Add(Me.radNormal)
        Me.Panel2.Location = New System.Drawing.Point(86, 22)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(118, 53)
        Me.Panel2.TabIndex = 12
        '
        'radVigenere
        '
        Me.radVigenere.AutoSize = True
        Me.radVigenere.Location = New System.Drawing.Point(7, 30)
        Me.radVigenere.Name = "radVigenere"
        Me.radVigenere.Size = New System.Drawing.Size(67, 17)
        Me.radVigenere.TabIndex = 11
        Me.radVigenere.Text = "Vigenere"
        Me.radVigenere.UseVisualStyleBackColor = True
        '
        'radNormal
        '
        Me.radNormal.AutoSize = True
        Me.radNormal.Checked = True
        Me.radNormal.Location = New System.Drawing.Point(7, 4)
        Me.radNormal.Name = "radNormal"
        Me.radNormal.Size = New System.Drawing.Size(89, 17)
        Me.radNormal.TabIndex = 10
        Me.radNormal.TabStop = True
        Me.radNormal.Text = "Swap/Rotate"
        Me.radNormal.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.radDecrypt)
        Me.Panel1.Controls.Add(Me.radEncrypt)
        Me.Panel1.Location = New System.Drawing.Point(3, 26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(68, 46)
        Me.Panel1.TabIndex = 9
        '
        'radDecrypt
        '
        Me.radDecrypt.AutoSize = True
        Me.radDecrypt.Location = New System.Drawing.Point(3, 26)
        Me.radDecrypt.Name = "radDecrypt"
        Me.radDecrypt.Size = New System.Drawing.Size(62, 17)
        Me.radDecrypt.TabIndex = 1
        Me.radDecrypt.Text = "Decrypt"
        Me.radDecrypt.UseVisualStyleBackColor = True
        '
        'radEncrypt
        '
        Me.radEncrypt.AutoSize = True
        Me.radEncrypt.Checked = True
        Me.radEncrypt.Location = New System.Drawing.Point(3, 0)
        Me.radEncrypt.Name = "radEncrypt"
        Me.radEncrypt.Size = New System.Drawing.Size(61, 17)
        Me.radEncrypt.TabIndex = 0
        Me.radEncrypt.TabStop = True
        Me.radEncrypt.Text = "Encrypt"
        Me.radEncrypt.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(130, 350)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 8
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnSet
        '
        Me.btnSet.Location = New System.Drawing.Point(9, 185)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(196, 23)
        Me.btnSet.TabIndex = 6
        Me.btnSet.Text = "Set"
        Me.btnSet.UseVisualStyleBackColor = True
        '
        'txtAlphabet
        '
        Me.txtAlphabet.Location = New System.Drawing.Point(9, 159)
        Me.txtAlphabet.Name = "txtAlphabet"
        Me.txtAlphabet.Size = New System.Drawing.Size(196, 20)
        Me.txtAlphabet.TabIndex = 5
        Me.txtAlphabet.Text = " ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890"
        '
        'lblAlphabet
        '
        Me.lblAlphabet.AutoSize = True
        Me.lblAlphabet.Location = New System.Drawing.Point(6, 143)
        Me.lblAlphabet.Name = "lblAlphabet"
        Me.lblAlphabet.Size = New System.Drawing.Size(52, 13)
        Me.lblAlphabet.TabIndex = 4
        Me.lblAlphabet.Text = "Alphabet:"
        '
        'txtKey
        '
        Me.txtKey.Location = New System.Drawing.Point(9, 111)
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Size = New System.Drawing.Size(196, 20)
        Me.txtKey.TabIndex = 3
        Me.txtKey.Text = "0987654321 QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm"
        '
        'lblKey
        '
        Me.lblKey.AutoSize = True
        Me.lblKey.Location = New System.Drawing.Point(6, 95)
        Me.lblKey.Name = "lblKey"
        Me.lblKey.Size = New System.Drawing.Size(28, 13)
        Me.lblKey.TabIndex = 2
        Me.lblKey.Text = "Key:"
        '
        'btnCopy
        '
        Me.btnCopy.Location = New System.Drawing.Point(6, 342)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(228, 40)
        Me.btnCopy.TabIndex = 9
        Me.btnCopy.Text = "Copy to clipboard"
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 391)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.grpOutput)
        Me.Controls.Add(Me.btnEncDec)
        Me.Controls.Add(Me.lblInput)
        Me.Controls.Add(Me.txtInput)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Encryption/Decryption"
        Me.grpOutput.ResumeLayout(False)
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtInput As TextBox
    Friend WithEvents lblInput As Label
    Friend WithEvents lblOutput As Label
    Friend WithEvents btnEncDec As Button
    Friend WithEvents grpOutput As GroupBox
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents txtKey As TextBox
    Friend WithEvents lblKey As Label
    Friend WithEvents radDecrypt As RadioButton
    Friend WithEvents radEncrypt As RadioButton
    Friend WithEvents txtAlphabet As TextBox
    Friend WithEvents lblAlphabet As Label
    Friend WithEvents btnSet As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnCopy As Button
    Friend WithEvents radVigenere As RadioButton
    Friend WithEvents radNormal As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class

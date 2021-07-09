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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAdultPrice = New System.Windows.Forms.TextBox()
        Me.txtChildPrice = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAdultSold = New System.Windows.Forms.TextBox()
        Me.txtChildSold = New System.Windows.Forms.TextBox()
        Me.lblGrossAdultSales = New System.Windows.Forms.Label()
        Me.lblGrossChildSales = New System.Windows.Forms.Label()
        Me.lblNetAdultSales = New System.Windows.Forms.Label()
        Me.lblNetChildSales = New System.Windows.Forms.Label()
        Me.lblNetRevenue = New System.Windows.Forms.Label()
        Me.lblGrossRevenue = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FIleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblEmployee = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(12, 269)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(100, 40)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(118, 269)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 40)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Adult Price:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(17, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Child Price:"
        '
        'txtAdultPrice
        '
        Me.txtAdultPrice.Location = New System.Drawing.Point(112, 25)
        Me.txtAdultPrice.Name = "txtAdultPrice"
        Me.txtAdultPrice.Size = New System.Drawing.Size(128, 20)
        Me.txtAdultPrice.TabIndex = 0
        '
        'txtChildPrice
        '
        Me.txtChildPrice.Location = New System.Drawing.Point(123, 21)
        Me.txtChildPrice.Name = "txtChildPrice"
        Me.txtChildPrice.Size = New System.Drawing.Size(128, 20)
        Me.txtChildPrice.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Adult Tickets Sold:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(17, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Child Tickets Sold:"
        '
        'txtAdultSold
        '
        Me.txtAdultSold.Location = New System.Drawing.Point(112, 58)
        Me.txtAdultSold.Name = "txtAdultSold"
        Me.txtAdultSold.Size = New System.Drawing.Size(128, 20)
        Me.txtAdultSold.TabIndex = 1
        '
        'txtChildSold
        '
        Me.txtChildSold.Location = New System.Drawing.Point(123, 55)
        Me.txtChildSold.Name = "txtChildSold"
        Me.txtChildSold.Size = New System.Drawing.Size(128, 20)
        Me.txtChildSold.TabIndex = 3
        '
        'lblGrossAdultSales
        '
        Me.lblGrossAdultSales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrossAdultSales.Location = New System.Drawing.Point(93, 25)
        Me.lblGrossAdultSales.Name = "lblGrossAdultSales"
        Me.lblGrossAdultSales.Size = New System.Drawing.Size(100, 16)
        Me.lblGrossAdultSales.TabIndex = 11
        '
        'lblGrossChildSales
        '
        Me.lblGrossChildSales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrossChildSales.Location = New System.Drawing.Point(93, 55)
        Me.lblGrossChildSales.Name = "lblGrossChildSales"
        Me.lblGrossChildSales.Size = New System.Drawing.Size(100, 16)
        Me.lblGrossChildSales.TabIndex = 12
        '
        'lblNetAdultSales
        '
        Me.lblNetAdultSales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNetAdultSales.Location = New System.Drawing.Point(93, 23)
        Me.lblNetAdultSales.Name = "lblNetAdultSales"
        Me.lblNetAdultSales.Size = New System.Drawing.Size(100, 16)
        Me.lblNetAdultSales.TabIndex = 13
        '
        'lblNetChildSales
        '
        Me.lblNetChildSales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNetChildSales.Location = New System.Drawing.Point(93, 53)
        Me.lblNetChildSales.Name = "lblNetChildSales"
        Me.lblNetChildSales.Size = New System.Drawing.Size(100, 16)
        Me.lblNetChildSales.TabIndex = 14
        '
        'lblNetRevenue
        '
        Me.lblNetRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNetRevenue.Location = New System.Drawing.Point(93, 85)
        Me.lblNetRevenue.Name = "lblNetRevenue"
        Me.lblNetRevenue.Size = New System.Drawing.Size(100, 16)
        Me.lblNetRevenue.TabIndex = 15
        '
        'lblGrossRevenue
        '
        Me.lblGrossRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrossRevenue.Location = New System.Drawing.Point(93, 93)
        Me.lblGrossRevenue.Name = "lblGrossRevenue"
        Me.lblGrossRevenue.Size = New System.Drawing.Size(100, 16)
        Me.lblGrossRevenue.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(6, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 16)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Gross Adult"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(6, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 16)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Gross Child"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(6, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 16)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Gross Revenue"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(6, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 16)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Net Revenue"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(6, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 16)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Net Child"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(6, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 16)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Net Adult"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FIleToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(559, 24)
        Me.MenuStrip1.TabIndex = 23
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FIleToolStripMenuItem
        '
        Me.FIleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FIleToolStripMenuItem.Name = "FIleToolStripMenuItem"
        Me.FIleToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FIleToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 319)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(559, 22)
        Me.StatusStrip1.TabIndex = 24
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtAdultPrice)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtAdultSold)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(257, 102)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Adult Tickets"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtChildSold)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtChildPrice)
        Me.GroupBox2.Location = New System.Drawing.Point(288, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(257, 102)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Children Tickets"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.lblGrossRevenue)
        Me.GroupBox3.Controls.Add(Me.lblGrossChildSales)
        Me.GroupBox3.Controls.Add(Me.lblGrossAdultSales)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 139)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(257, 124)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Gross Ticket Revenue"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.lblNetAdultSales)
        Me.GroupBox4.Controls.Add(Me.lblNetChildSales)
        Me.GroupBox4.Controls.Add(Me.lblNetRevenue)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Location = New System.Drawing.Point(288, 139)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(257, 124)
        Me.GroupBox4.TabIndex = 28
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Net Ticket Revenue"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(224, 269)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 40)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblEmployee
        '
        Me.lblEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployee.Location = New System.Drawing.Point(336, 269)
        Me.lblEmployee.Name = "lblEmployee"
        Me.lblEmployee.Size = New System.Drawing.Size(209, 40)
        Me.lblEmployee.TabIndex = 30
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 341)
        Me.Controls.Add(Me.lblEmployee)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Theatre Revenue"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAdultPrice As TextBox
    Friend WithEvents txtChildPrice As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAdultSold As TextBox
    Friend WithEvents txtChildSold As TextBox
    Friend WithEvents lblGrossAdultSales As Label
    Friend WithEvents lblGrossChildSales As Label
    Friend WithEvents lblNetAdultSales As Label
    Friend WithEvents lblNetChildSales As Label
    Friend WithEvents lblNetRevenue As Label
    Friend WithEvents lblGrossRevenue As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FIleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnExit As Button
    Friend WithEvents lblEmployee As Label
End Class

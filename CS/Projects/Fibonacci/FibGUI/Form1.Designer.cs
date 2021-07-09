namespace FibGUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnFib = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radSingle = new System.Windows.Forms.RadioButton();
            this.radSeries = new System.Windows.Forms.RadioButton();
            this.lstAnswers = new System.Windows.Forms.ListBox();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFib
            // 
            this.btnFib.Location = new System.Drawing.Point(118, 42);
            this.btnFib.Name = "btnFib";
            this.btnFib.Size = new System.Drawing.Size(100, 25);
            this.btnFib.TabIndex = 0;
            this.btnFib.Text = "Calculate";
            this.btnFib.UseVisualStyleBackColor = true;
            this.btnFib.Click += new System.EventHandler(this.btnFib_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(118, 11);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 20);
            this.txtNum.TabIndex = 2;
            // 
            // lblNum
            // 
            this.lblNum.Location = new System.Drawing.Point(12, 11);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(100, 56);
            this.lblNum.TabIndex = 3;
            this.lblNum.Text = "How many numbers do you want to generate?\r\n\r\n\r\n";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 267);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(288, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstAnswers);
            this.groupBox1.Location = new System.Drawing.Point(0, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 193);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sequence";
            // 
            // radSingle
            // 
            this.radSingle.AutoSize = true;
            this.radSingle.Location = new System.Drawing.Point(224, 47);
            this.radSingle.Name = "radSingle";
            this.radSingle.Size = new System.Drawing.Size(54, 17);
            this.radSingle.TabIndex = 6;
            this.radSingle.Text = "Single";
            this.radSingle.UseVisualStyleBackColor = true;
            this.radSingle.CheckedChanged += new System.EventHandler(this.radSingle_CheckedChanged);
            // 
            // radSeries
            // 
            this.radSeries.AutoSize = true;
            this.radSeries.Checked = true;
            this.radSeries.Location = new System.Drawing.Point(224, 14);
            this.radSeries.Name = "radSeries";
            this.radSeries.Size = new System.Drawing.Size(54, 17);
            this.radSeries.TabIndex = 7;
            this.radSeries.TabStop = true;
            this.radSeries.Text = "Series";
            this.radSeries.UseVisualStyleBackColor = true;
            this.radSeries.CheckedChanged += new System.EventHandler(this.radSeries_CheckedChanged);
            // 
            // lstAnswers
            // 
            this.lstAnswers.FormattingEnabled = true;
            this.lstAnswers.Location = new System.Drawing.Point(9, 14);
            this.lstAnswers.Name = "lstAnswers";
            this.lstAnswers.Size = new System.Drawing.Size(269, 173);
            this.lstAnswers.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 289);
            this.Controls.Add(this.radSeries);
            this.Controls.Add(this.radSingle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btnFib);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Fibonacci Sequence";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFib;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radSingle;
        private System.Windows.Forms.RadioButton radSeries;
        private System.Windows.Forms.ListBox lstAnswers;
    }
}


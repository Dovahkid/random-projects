namespace Vigenere_Form
{
    partial class SettingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.chkCapitalization = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbAlphabet = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnSaveDefault = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alphabet:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(247, 294);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 29);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(13, 294);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(80, 29);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // chkCapitalization
            // 
            this.chkCapitalization.AutoSize = true;
            this.chkCapitalization.Location = new System.Drawing.Point(23, 92);
            this.chkCapitalization.Name = "chkCapitalization";
            this.chkCapitalization.Size = new System.Drawing.Size(118, 17);
            this.chkCapitalization.TabIndex = 4;
            this.chkCapitalization.Text = "Force Capitalization";
            this.chkCapitalization.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "These settings may have unintended concsequences. Change at your own risk\r\n";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(147, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 46);
            this.label3.TabIndex = 6;
            this.label3.Text = "*Disabling Forced Capitalization will require an alphabet be provided with lower " +
    "case letters\r\n";
            // 
            // cmbAlphabet
            // 
            this.cmbAlphabet.FormattingEnabled = true;
            this.cmbAlphabet.Items.AddRange(new object[] {
            "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
            "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz",
            "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890",
            "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz 1234567890"});
            this.cmbAlphabet.Location = new System.Drawing.Point(22, 50);
            this.cmbAlphabet.Name = "cmbAlphabet";
            this.cmbAlphabet.Size = new System.Drawing.Size(304, 21);
            this.cmbAlphabet.TabIndex = 7;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(23, 155);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(112, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Include Key in File";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnSaveDefault
            // 
            this.btnSaveDefault.Enabled = false;
            this.btnSaveDefault.Location = new System.Drawing.Point(124, 294);
            this.btnSaveDefault.Name = "btnSaveDefault";
            this.btnSaveDefault.Size = new System.Drawing.Size(91, 29);
            this.btnSaveDefault.TabIndex = 9;
            this.btnSaveDefault.Text = "Save as Default";
            this.btnSaveDefault.UseVisualStyleBackColor = true;
            this.btnSaveDefault.Click += new System.EventHandler(this.btnSaveDefault_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 339);
            this.Controls.Add(this.btnSaveDefault);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cmbAlphabet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkCapitalization);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.CheckBox chkCapitalization;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbAlphabet;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnSaveDefault;
    }
}
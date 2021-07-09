namespace Error003EncryptionGUI
{
    partial class MainForm
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radFileKey = new System.Windows.Forms.RadioButton();
            this.radTextKey = new System.Windows.Forms.RadioButton();
            this.btnFileKeyBrowse = new System.Windows.Forms.Button();
            this.grpEncDec = new System.Windows.Forms.GroupBox();
            this.radDecrypt = new System.Windows.Forms.RadioButton();
            this.radEncrypt = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblInputFilePath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpEncryptionTypes = new System.Windows.Forms.GroupBox();
            this.lstEncryptionTypes = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.grpInput.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpEncDec.SuspendLayout();
            this.grpEncryptionTypes.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 264);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(562, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.groupBox1);
            this.grpInput.Controls.Add(this.btnFileKeyBrowse);
            this.grpInput.Controls.Add(this.grpEncDec);
            this.grpInput.Controls.Add(this.btnSubmit);
            this.grpInput.Controls.Add(this.label2);
            this.grpInput.Controls.Add(this.txtPassword);
            this.grpInput.Controls.Add(this.btnBrowse);
            this.grpInput.Controls.Add(this.lblInputFilePath);
            this.grpInput.Controls.Add(this.label1);
            this.grpInput.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInput.Location = new System.Drawing.Point(12, 30);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(329, 228);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Input";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radFileKey);
            this.groupBox1.Controls.Add(this.radTextKey);
            this.groupBox1.Location = new System.Drawing.Point(104, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(97, 64);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Password Type";
            // 
            // radFileKey
            // 
            this.radFileKey.AutoSize = true;
            this.radFileKey.Location = new System.Drawing.Point(6, 42);
            this.radFileKey.Name = "radFileKey";
            this.radFileKey.Size = new System.Drawing.Size(86, 20);
            this.radFileKey.TabIndex = 1;
            this.radFileKey.TabStop = true;
            this.radFileKey.Text = "File as key";
            this.radFileKey.UseVisualStyleBackColor = true;
            this.radFileKey.CheckedChanged += new System.EventHandler(this.radFileKey_CheckedChanged);
            // 
            // radTextKey
            // 
            this.radTextKey.AutoSize = true;
            this.radTextKey.Checked = true;
            this.radTextKey.Location = new System.Drawing.Point(6, 19);
            this.radTextKey.Name = "radTextKey";
            this.radTextKey.Size = new System.Drawing.Size(51, 20);
            this.radTextKey.TabIndex = 0;
            this.radTextKey.TabStop = true;
            this.radTextKey.Text = "Text";
            this.radTextKey.UseVisualStyleBackColor = true;
            this.radTextKey.CheckedChanged += new System.EventHandler(this.radTextKey_CheckedChanged);
            // 
            // btnFileKeyBrowse
            // 
            this.btnFileKeyBrowse.Enabled = false;
            this.btnFileKeyBrowse.Location = new System.Drawing.Point(207, 148);
            this.btnFileKeyBrowse.Name = "btnFileKeyBrowse";
            this.btnFileKeyBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnFileKeyBrowse.TabIndex = 8;
            this.btnFileKeyBrowse.Text = "Browse...";
            this.btnFileKeyBrowse.UseVisualStyleBackColor = true;
            this.btnFileKeyBrowse.Click += new System.EventHandler(this.btnFileKeyBrowse_Click);
            // 
            // grpEncDec
            // 
            this.grpEncDec.Controls.Add(this.radDecrypt);
            this.grpEncDec.Controls.Add(this.radEncrypt);
            this.grpEncDec.Location = new System.Drawing.Point(207, 22);
            this.grpEncDec.Name = "grpEncDec";
            this.grpEncDec.Size = new System.Drawing.Size(115, 64);
            this.grpEncDec.TabIndex = 3;
            this.grpEncDec.TabStop = false;
            this.grpEncDec.Text = "Encrypt/Decrypt";
            // 
            // radDecrypt
            // 
            this.radDecrypt.AutoSize = true;
            this.radDecrypt.Location = new System.Drawing.Point(6, 42);
            this.radDecrypt.Name = "radDecrypt";
            this.radDecrypt.Size = new System.Drawing.Size(69, 20);
            this.radDecrypt.TabIndex = 1;
            this.radDecrypt.TabStop = true;
            this.radDecrypt.Text = "Decrypt";
            this.radDecrypt.UseVisualStyleBackColor = true;
            // 
            // radEncrypt
            // 
            this.radEncrypt.AutoSize = true;
            this.radEncrypt.Checked = true;
            this.radEncrypt.Location = new System.Drawing.Point(6, 19);
            this.radEncrypt.Name = "radEncrypt";
            this.radEncrypt.Size = new System.Drawing.Size(68, 20);
            this.radEncrypt.TabIndex = 0;
            this.radEncrypt.TabStop = true;
            this.radEncrypt.Text = "Encrypt";
            this.radEncrypt.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(9, 177);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(192, 39);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(9, 148);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(192, 23);
            this.txtPassword.TabIndex = 4;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(207, 98);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblInputFilePath
            // 
            this.lblInputFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInputFilePath.Location = new System.Drawing.Point(6, 99);
            this.lblInputFilePath.Name = "lblInputFilePath";
            this.lblInputFilePath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblInputFilePath.Size = new System.Drawing.Size(195, 21);
            this.lblInputFilePath.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input File:";
            // 
            // grpEncryptionTypes
            // 
            this.grpEncryptionTypes.Controls.Add(this.lstEncryptionTypes);
            this.grpEncryptionTypes.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEncryptionTypes.Location = new System.Drawing.Point(347, 30);
            this.grpEncryptionTypes.Name = "grpEncryptionTypes";
            this.grpEncryptionTypes.Size = new System.Drawing.Size(203, 228);
            this.grpEncryptionTypes.TabIndex = 2;
            this.grpEncryptionTypes.TabStop = false;
            this.grpEncryptionTypes.Text = "Encryption Types";
            // 
            // lstEncryptionTypes
            // 
            this.lstEncryptionTypes.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEncryptionTypes.FormattingEnabled = true;
            this.lstEncryptionTypes.ItemHeight = 16;
            this.lstEncryptionTypes.Location = new System.Drawing.Point(6, 22);
            this.lstEncryptionTypes.Name = "lstEncryptionTypes";
            this.lstEncryptionTypes.Size = new System.Drawing.Size(188, 196);
            this.lstEncryptionTypes.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(562, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 286);
            this.Controls.Add(this.grpEncryptionTypes);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "EasyEncrypt";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpEncDec.ResumeLayout(false);
            this.grpEncDec.PerformLayout();
            this.grpEncryptionTypes.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.GroupBox grpEncryptionTypes;
        private System.Windows.Forms.ListBox lstEncryptionTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblInputFilePath;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox grpEncDec;
        private System.Windows.Forms.RadioButton radDecrypt;
        private System.Windows.Forms.RadioButton radEncrypt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radFileKey;
        private System.Windows.Forms.RadioButton radTextKey;
        private System.Windows.Forms.Button btnFileKeyBrowse;
    }
}
namespace MouseJiggler
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.LabProductName = new System.Windows.Forms.Label();
            this.LabByCreator = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RichTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.PicBoxGitHub = new System.Windows.Forms.PictureBox();
            this.PicBodDonate = new System.Windows.Forms.PictureBox();
            this.PicBoxLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxGitHub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBodDonate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // LabProductName
            // 
            this.LabProductName.AutoSize = true;
            this.LabProductName.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabProductName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LabProductName.Location = new System.Drawing.Point(83, 9);
            this.LabProductName.Name = "LabProductName";
            this.LabProductName.Size = new System.Drawing.Size(211, 34);
            this.LabProductName.TabIndex = 1;
            this.LabProductName.Text = "Mouse Jiggler";
            // 
            // LabByCreator
            // 
            this.LabByCreator.AutoSize = true;
            this.LabByCreator.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabByCreator.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LabByCreator.Location = new System.Drawing.Point(86, 43);
            this.LabByCreator.Name = "LabByCreator";
            this.LabByCreator.Size = new System.Drawing.Size(106, 14);
            this.LabByCreator.TabIndex = 2;
            this.LabByCreator.Text = "By SARSOFT Corp.";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.RichTextBoxLog);
            this.panel1.Location = new System.Drawing.Point(12, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 256);
            this.panel1.TabIndex = 5;
            // 
            // RichTextBoxLog
            // 
            this.RichTextBoxLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBoxLog.Location = new System.Drawing.Point(0, 0);
            this.RichTextBoxLog.Name = "RichTextBoxLog";
            this.RichTextBoxLog.ReadOnly = true;
            this.RichTextBoxLog.Size = new System.Drawing.Size(568, 254);
            this.RichTextBoxLog.TabIndex = 0;
            this.RichTextBoxLog.Text = "";
            // 
            // PicBoxGitHub
            // 
            this.PicBoxGitHub.BackColor = System.Drawing.Color.Transparent;
            this.PicBoxGitHub.Image = global::MouseJiggler.Properties.Resources.github;
            this.PicBoxGitHub.Location = new System.Drawing.Point(538, 9);
            this.PicBoxGitHub.Name = "PicBoxGitHub";
            this.PicBoxGitHub.Size = new System.Drawing.Size(44, 43);
            this.PicBoxGitHub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxGitHub.TabIndex = 6;
            this.PicBoxGitHub.TabStop = false;
            // 
            // PicBodDonate
            // 
            this.PicBodDonate.Image = global::MouseJiggler.Properties.Resources.paypal_01;
            this.PicBodDonate.Location = new System.Drawing.Point(445, 9);
            this.PicBodDonate.Name = "PicBodDonate";
            this.PicBodDonate.Size = new System.Drawing.Size(100, 43);
            this.PicBodDonate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBodDonate.TabIndex = 3;
            this.PicBodDonate.TabStop = false;
            // 
            // PicBoxLogo
            // 
            this.PicBoxLogo.Image = global::MouseJiggler.Properties.Resources.Icon;
            this.PicBoxLogo.Location = new System.Drawing.Point(15, 9);
            this.PicBoxLogo.Name = "PicBoxLogo";
            this.PicBoxLogo.Size = new System.Drawing.Size(65, 63);
            this.PicBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxLogo.TabIndex = 0;
            this.PicBoxLogo.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 359);
            this.Controls.Add(this.PicBodDonate);
            this.Controls.Add(this.PicBoxGitHub);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LabByCreator);
            this.Controls.Add(this.LabProductName);
            this.Controls.Add(this.PicBoxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MouseJiggler";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxGitHub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBodDonate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBoxLogo;
        private System.Windows.Forms.Label LabProductName;
        private System.Windows.Forms.Label LabByCreator;
        private System.Windows.Forms.PictureBox PicBodDonate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox RichTextBoxLog;
        private System.Windows.Forms.PictureBox PicBoxGitHub;
    }
}


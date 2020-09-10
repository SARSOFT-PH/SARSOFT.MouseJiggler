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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.LabProductName = new System.Windows.Forms.Label();
            this.LabByCreator = new System.Windows.Forms.Label();
            this.PicBoxGitHub = new System.Windows.Forms.PictureBox();
            this.PicBodDonate = new System.Windows.Forms.PictureBox();
            this.PicBoxLogo = new System.Windows.Forms.PictureBox();
            this.WiggleIntensity = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RichTextBoxLogs = new System.Windows.Forms.RichTextBox();
            this.WiggleTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxGitHub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBodDonate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WiggleIntensity)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // PicBoxGitHub
            // 
            this.PicBoxGitHub.BackColor = System.Drawing.Color.Transparent;
            this.PicBoxGitHub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicBoxGitHub.Image = global::MouseJiggler.Properties.Resources.github;
            this.PicBoxGitHub.Location = new System.Drawing.Point(538, 9);
            this.PicBoxGitHub.Name = "PicBoxGitHub";
            this.PicBoxGitHub.Size = new System.Drawing.Size(44, 43);
            this.PicBoxGitHub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxGitHub.TabIndex = 6;
            this.PicBoxGitHub.TabStop = false;
            this.PicBoxGitHub.Click += new System.EventHandler(this.PicBoxGitHub_Click);
            // 
            // PicBodDonate
            // 
            this.PicBodDonate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicBodDonate.Image = global::MouseJiggler.Properties.Resources.paypal_01;
            this.PicBodDonate.Location = new System.Drawing.Point(445, 9);
            this.PicBodDonate.Name = "PicBodDonate";
            this.PicBodDonate.Size = new System.Drawing.Size(100, 43);
            this.PicBodDonate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBodDonate.TabIndex = 3;
            this.PicBodDonate.TabStop = false;
            this.PicBodDonate.Click += new System.EventHandler(this.PicBodDonate_Click);
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
            // WiggleIntensity
            // 
            this.WiggleIntensity.Location = new System.Drawing.Point(6, 44);
            this.WiggleIntensity.Name = "WiggleIntensity";
            this.WiggleIntensity.Size = new System.Drawing.Size(188, 45);
            this.WiggleIntensity.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.WiggleIntensity);
            this.groupBox1.Location = new System.Drawing.Point(15, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 269);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control Box";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Intensity:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RichTextBoxLogs);
            this.groupBox2.Location = new System.Drawing.Point(221, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 269);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Application Logs";
            // 
            // RichTextBoxLogs
            // 
            this.RichTextBoxLogs.BackColor = System.Drawing.SystemColors.Control;
            this.RichTextBoxLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBoxLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBoxLogs.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichTextBoxLogs.Location = new System.Drawing.Point(3, 16);
            this.RichTextBoxLogs.Name = "RichTextBoxLogs";
            this.RichTextBoxLogs.ReadOnly = true;
            this.RichTextBoxLogs.Size = new System.Drawing.Size(355, 250);
            this.RichTextBoxLogs.TabIndex = 0;
            this.RichTextBoxLogs.Text = "";
            // 
            // WiggleTimer
            // 
            this.WiggleTimer.Tick += new System.EventHandler(this.WiggleTimer_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 359);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PicBodDonate);
            this.Controls.Add(this.PicBoxGitHub);
            this.Controls.Add(this.LabByCreator);
            this.Controls.Add(this.LabProductName);
            this.Controls.Add(this.PicBoxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MouseJiggler";
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxGitHub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBodDonate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WiggleIntensity)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBoxLogo;
        private System.Windows.Forms.Label LabProductName;
        private System.Windows.Forms.Label LabByCreator;
        private System.Windows.Forms.PictureBox PicBodDonate;
        private System.Windows.Forms.PictureBox PicBoxGitHub;
        private System.Windows.Forms.TrackBar WiggleIntensity;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox RichTextBoxLogs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer WiggleTimer;
    }
}


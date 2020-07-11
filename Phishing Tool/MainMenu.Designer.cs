namespace Phishing_Tool
{
    partial class MainMenu
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
            this.TitleText = new System.Windows.Forms.Label();
            this.NewCampaign = new System.Windows.Forms.Button();
            this.LoadCampaign = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleText
            // 
            this.TitleText.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(134)))), ((int)(((byte)(170)))));
            this.TitleText.Location = new System.Drawing.Point(323, 14);
            this.TitleText.Name = "TitleText";
            this.TitleText.Size = new System.Drawing.Size(155, 35);
            this.TitleText.TabIndex = 0;
            this.TitleText.Text = "Phishing Tool";
            // 
            // NewCampaign
            // 
            this.NewCampaign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(198)))), ((int)(((byte)(185)))));
            this.NewCampaign.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(181)))), ((int)(((byte)(167)))));
            this.NewCampaign.FlatAppearance.BorderSize = 2;
            this.NewCampaign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewCampaign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewCampaign.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(79)))), ((int)(((byte)(125)))));
            this.NewCampaign.Location = new System.Drawing.Point(303, 135);
            this.NewCampaign.Name = "NewCampaign";
            this.NewCampaign.Size = new System.Drawing.Size(194, 37);
            this.NewCampaign.TabIndex = 1;
            this.NewCampaign.Text = "New Campaign";
            this.NewCampaign.UseVisualStyleBackColor = false;
            this.NewCampaign.Click += new System.EventHandler(this.NewCampaign_Click);
            // 
            // LoadCampaign
            // 
            this.LoadCampaign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(198)))), ((int)(((byte)(185)))));
            this.LoadCampaign.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(181)))), ((int)(((byte)(167)))));
            this.LoadCampaign.FlatAppearance.BorderSize = 2;
            this.LoadCampaign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadCampaign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadCampaign.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(79)))), ((int)(((byte)(125)))));
            this.LoadCampaign.Location = new System.Drawing.Point(303, 207);
            this.LoadCampaign.Name = "LoadCampaign";
            this.LoadCampaign.Size = new System.Drawing.Size(194, 37);
            this.LoadCampaign.TabIndex = 2;
            this.LoadCampaign.Text = "Load Campaign";
            this.LoadCampaign.UseVisualStyleBackColor = false;
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(198)))), ((int)(((byte)(185)))));
            this.Settings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(181)))), ((int)(((byte)(167)))));
            this.Settings.FlatAppearance.BorderSize = 2;
            this.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(79)))), ((int)(((byte)(125)))));
            this.Settings.Location = new System.Drawing.Point(303, 278);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(194, 37);
            this.Settings.TabIndex = 3;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = false;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(193)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.LoadCampaign);
            this.Controls.Add(this.NewCampaign);
            this.Controls.Add(this.TitleText);
            this.Name = "MainMenu";
            this.Text = "Phishing Tool";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitleText;
        private System.Windows.Forms.Button NewCampaign;
        private System.Windows.Forms.Button LoadCampaign;
        private System.Windows.Forms.Button Settings;
    }
}


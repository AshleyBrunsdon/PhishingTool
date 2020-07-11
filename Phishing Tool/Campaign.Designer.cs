namespace Phishing_Tool
{
    partial class Campaign
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
            this.CampaignTable = new System.Windows.Forms.DataGridView();
            this.EmailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sent = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Replied = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RepliedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SendTestEmail = new System.Windows.Forms.Button();
            this.SendReport = new System.Windows.Forms.Button();
            this.StartCampaign = new System.Windows.Forms.Button();
            this.SearchingEmails = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CampaignTable)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleText
            // 
            this.TitleText.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(134)))), ((int)(((byte)(170)))));
            this.TitleText.Location = new System.Drawing.Point(323, 13);
            this.TitleText.Name = "TitleText";
            this.TitleText.Size = new System.Drawing.Size(155, 35);
            this.TitleText.TabIndex = 1;
            this.TitleText.Text = "Phishing Tool";
            // 
            // CampaignTable
            // 
            this.CampaignTable.AllowUserToAddRows = false;
            this.CampaignTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CampaignTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmailAddress,
            this.Sent,
            this.Replied,
            this.RepliedTime});
            this.CampaignTable.Location = new System.Drawing.Point(193, 70);
            this.CampaignTable.Name = "CampaignTable";
            this.CampaignTable.Size = new System.Drawing.Size(444, 230);
            this.CampaignTable.TabIndex = 2;
            // 
            // EmailAddress
            // 
            this.EmailAddress.HeaderText = "Email Address";
            this.EmailAddress.Name = "EmailAddress";
            this.EmailAddress.Width = 150;
            // 
            // Sent
            // 
            this.Sent.HeaderText = "Sent Successfully?";
            this.Sent.Name = "Sent";
            this.Sent.Width = 80;
            // 
            // Replied
            // 
            this.Replied.HeaderText = "Replied to Email?";
            this.Replied.Name = "Replied";
            this.Replied.Width = 70;
            // 
            // RepliedTime
            // 
            this.RepliedTime.HeaderText = "Time Replied";
            this.RepliedTime.Name = "RepliedTime";
            // 
            // SendTestEmail
            // 
            this.SendTestEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(198)))), ((int)(((byte)(185)))));
            this.SendTestEmail.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(181)))), ((int)(((byte)(167)))));
            this.SendTestEmail.FlatAppearance.BorderSize = 2;
            this.SendTestEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendTestEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SendTestEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(79)))), ((int)(((byte)(125)))));
            this.SendTestEmail.Location = new System.Drawing.Point(193, 337);
            this.SendTestEmail.Name = "SendTestEmail";
            this.SendTestEmail.Size = new System.Drawing.Size(126, 49);
            this.SendTestEmail.TabIndex = 11;
            this.SendTestEmail.Text = "Send Test Email";
            this.SendTestEmail.UseVisualStyleBackColor = false;
            this.SendTestEmail.Click += new System.EventHandler(this.SendTestEmail_Click);
            // 
            // SendReport
            // 
            this.SendReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(198)))), ((int)(((byte)(185)))));
            this.SendReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(181)))), ((int)(((byte)(167)))));
            this.SendReport.FlatAppearance.BorderSize = 2;
            this.SendReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SendReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(79)))), ((int)(((byte)(125)))));
            this.SendReport.Location = new System.Drawing.Point(511, 337);
            this.SendReport.Name = "SendReport";
            this.SendReport.Size = new System.Drawing.Size(126, 49);
            this.SendReport.TabIndex = 12;
            this.SendReport.Text = "Send Email Report";
            this.SendReport.UseVisualStyleBackColor = false;
            // 
            // StartCampaign
            // 
            this.StartCampaign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(198)))), ((int)(((byte)(185)))));
            this.StartCampaign.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(181)))), ((int)(((byte)(167)))));
            this.StartCampaign.FlatAppearance.BorderSize = 2;
            this.StartCampaign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartCampaign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.StartCampaign.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(79)))), ((int)(((byte)(125)))));
            this.StartCampaign.Location = new System.Drawing.Point(352, 337);
            this.StartCampaign.Name = "StartCampaign";
            this.StartCampaign.Size = new System.Drawing.Size(126, 49);
            this.StartCampaign.TabIndex = 13;
            this.StartCampaign.Text = "Continue Campaign";
            this.StartCampaign.UseVisualStyleBackColor = false;
            this.StartCampaign.Click += new System.EventHandler(this.StartCampaign_Click);
            // 
            // SearchingEmails
            // 
            this.SearchingEmails.AutoSize = true;
            this.SearchingEmails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchingEmails.Location = new System.Drawing.Point(341, 401);
            this.SearchingEmails.Name = "SearchingEmails";
            this.SearchingEmails.Size = new System.Drawing.Size(144, 20);
            this.SearchingEmails.TabIndex = 14;
            this.SearchingEmails.Text = "Searching Emails...";
            this.SearchingEmails.Visible = false;
            // 
            // Campaign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(193)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchingEmails);
            this.Controls.Add(this.StartCampaign);
            this.Controls.Add(this.SendReport);
            this.Controls.Add(this.SendTestEmail);
            this.Controls.Add(this.CampaignTable);
            this.Controls.Add(this.TitleText);
            this.Name = "Campaign";
            this.Text = "Campaign";
            ((System.ComponentModel.ISupportInitialize)(this.CampaignTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleText;
        private System.Windows.Forms.DataGridView CampaignTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailAddress;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Sent;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Replied;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepliedTime;
        private System.Windows.Forms.Button SendTestEmail;
        private System.Windows.Forms.Button SendReport;
        private System.Windows.Forms.Button StartCampaign;
        private System.Windows.Forms.Label SearchingEmails;
    }
}
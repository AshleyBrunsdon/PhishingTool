namespace Phishing_Tool
{
    partial class EmailSetup
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
            this.HostServerTxtBox = new System.Windows.Forms.TextBox();
            this.HostUNTxtBox = new System.Windows.Forms.TextBox();
            this.HostPassTxtBox = new System.Windows.Forms.TextBox();
            this.RecipientEAddressTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UseRead = new System.Windows.Forms.CheckBox();
            this.ContinueCampaign = new System.Windows.Forms.Button();
            this.SaveEAddresses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleText
            // 
            this.TitleText.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(134)))), ((int)(((byte)(170)))));
            this.TitleText.Location = new System.Drawing.Point(323, 12);
            this.TitleText.Name = "TitleText";
            this.TitleText.Size = new System.Drawing.Size(155, 35);
            this.TitleText.TabIndex = 2;
            this.TitleText.Text = "Phishing Tool";
            // 
            // HostServerTxtBox
            // 
            this.HostServerTxtBox.Location = new System.Drawing.Point(122, 190);
            this.HostServerTxtBox.Name = "HostServerTxtBox";
            this.HostServerTxtBox.Size = new System.Drawing.Size(162, 20);
            this.HostServerTxtBox.TabIndex = 3;
            this.HostServerTxtBox.Text = "Host Server";
            // 
            // HostUNTxtBox
            // 
            this.HostUNTxtBox.Location = new System.Drawing.Point(122, 217);
            this.HostUNTxtBox.Name = "HostUNTxtBox";
            this.HostUNTxtBox.Size = new System.Drawing.Size(162, 20);
            this.HostUNTxtBox.TabIndex = 4;
            this.HostUNTxtBox.Text = "Username";
            // 
            // HostPassTxtBox
            // 
            this.HostPassTxtBox.Location = new System.Drawing.Point(122, 243);
            this.HostPassTxtBox.Name = "HostPassTxtBox";
            this.HostPassTxtBox.Size = new System.Drawing.Size(162, 20);
            this.HostPassTxtBox.TabIndex = 5;
            this.HostPassTxtBox.Text = "Password";
            this.HostPassTxtBox.UseSystemPasswordChar = true;
            // 
            // RecipientEAddressTxtBox
            // 
            this.RecipientEAddressTxtBox.AcceptsReturn = true;
            this.RecipientEAddressTxtBox.AllowDrop = true;
            this.RecipientEAddressTxtBox.Location = new System.Drawing.Point(445, 139);
            this.RecipientEAddressTxtBox.Multiline = true;
            this.RecipientEAddressTxtBox.Name = "RecipientEAddressTxtBox";
            this.RecipientEAddressTxtBox.Size = new System.Drawing.Size(266, 163);
            this.RecipientEAddressTxtBox.TabIndex = 6;
            this.RecipientEAddressTxtBox.Text = "Recipient Email Addresses";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(134)))), ((int)(((byte)(170)))));
            this.label1.Location = new System.Drawing.Point(118, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sender\'s Login Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(458, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Note: email addresses must \r\nbe seperated by line";
            // 
            // UseRead
            // 
            this.UseRead.AutoSize = true;
            this.UseRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseRead.Location = new System.Drawing.Point(573, 365);
            this.UseRead.Name = "UseRead";
            this.UseRead.Size = new System.Drawing.Size(153, 20);
            this.UseRead.TabIndex = 9;
            this.UseRead.Text = "Use Read Receipts?";
            this.UseRead.UseVisualStyleBackColor = true;
            // 
            // ContinueCampaign
            // 
            this.ContinueCampaign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(198)))), ((int)(((byte)(185)))));
            this.ContinueCampaign.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(181)))), ((int)(((byte)(167)))));
            this.ContinueCampaign.FlatAppearance.BorderSize = 2;
            this.ContinueCampaign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContinueCampaign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ContinueCampaign.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(79)))), ((int)(((byte)(125)))));
            this.ContinueCampaign.Location = new System.Drawing.Point(588, 391);
            this.ContinueCampaign.Name = "ContinueCampaign";
            this.ContinueCampaign.Size = new System.Drawing.Size(123, 34);
            this.ContinueCampaign.TabIndex = 10;
            this.ContinueCampaign.Text = "Continue";
            this.ContinueCampaign.UseVisualStyleBackColor = false;
            this.ContinueCampaign.Click += new System.EventHandler(this.ContinueCampaign_Click);
            // 
            // SaveEAddresses
            // 
            this.SaveEAddresses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(198)))), ((int)(((byte)(185)))));
            this.SaveEAddresses.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(181)))), ((int)(((byte)(167)))));
            this.SaveEAddresses.FlatAppearance.BorderSize = 2;
            this.SaveEAddresses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveEAddresses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SaveEAddresses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(79)))), ((int)(((byte)(125)))));
            this.SaveEAddresses.Location = new System.Drawing.Point(445, 391);
            this.SaveEAddresses.Name = "SaveEAddresses";
            this.SaveEAddresses.Size = new System.Drawing.Size(123, 34);
            this.SaveEAddresses.TabIndex = 11;
            this.SaveEAddresses.Text = "Save Addresses";
            this.SaveEAddresses.UseVisualStyleBackColor = false;
            this.SaveEAddresses.Click += new System.EventHandler(this.SaveEAddresses_Click);
            // 
            // EmailSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(193)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveEAddresses);
            this.Controls.Add(this.ContinueCampaign);
            this.Controls.Add(this.UseRead);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RecipientEAddressTxtBox);
            this.Controls.Add(this.HostPassTxtBox);
            this.Controls.Add(this.HostUNTxtBox);
            this.Controls.Add(this.HostServerTxtBox);
            this.Controls.Add(this.TitleText);
            this.Name = "EmailSetup";
            this.Text = "EmailSetup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleText;
        private System.Windows.Forms.TextBox HostServerTxtBox;
        private System.Windows.Forms.TextBox HostUNTxtBox;
        private System.Windows.Forms.TextBox HostPassTxtBox;
        private System.Windows.Forms.TextBox RecipientEAddressTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox UseRead;
        private System.Windows.Forms.Button ContinueCampaign;
        private System.Windows.Forms.Button SaveEAddresses;
    }
}
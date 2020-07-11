using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Limilabs.Mail;
using Limilabs.Mail.Headers;
using Limilabs.Client.SMTP;
using Limilabs.Client.IMAP;
using PhishingFunctions;

namespace Phishing_Tool
{
    public partial class Campaign : Form
    {
        string[] EmailSettings = File.ReadAllLines("EmailSettings.txt");
        string[] HostSettings = File.ReadAllLines("HostSettings.txt");


        public Campaign()
        {
            //This reads in the email addresses from previously and then adds them to the table
            List<Data> ListEmailAddresses = new List<Data>();
            string[] FileEAddresses = File.ReadAllLines("Datafile.txt");

            for (int EAddress = 0; EAddress < FileEAddresses.Length; EAddress++)
            {
                ListEmailAddresses.Add(new Data { EmailAddress = FileEAddresses[EAddress] });
            }

            InitializeComponent();

            for (int i = 0; i< ListEmailAddresses.Count; i++)
            {
                CampaignTable.Rows.Add(ListEmailAddresses[i].AddSToTable(0), ListEmailAddresses[i].AddBToTable(1), ListEmailAddresses[i].AddBToTable(2), ListEmailAddresses[i].AddSToTable(5));
            }
            CampaignTable.Rows.RemoveAt(CampaignTable.RowCount-1);

        }

        private void SendTestEmail_Click(object sender, EventArgs e)
        {
            //This uses the SendEmail function to send a test email to the first item in the list.
            string ToAddress = CampaignTable.Rows[0].Cells[0].Value.ToString();
            CampaignTable.Rows[0].Cells[1].Value = SendEmail(HostSettings[0], HostSettings[1], HostSettings[2], EmailSettings[0], EmailSettings[1], ToAddress, EmailSettings[2], EmailSettings[3]);
        }

        private void StartCampaign_Click(object sender, EventArgs e)
        {
            //This uses the SendEmail function to send the rest of the emails to the recipients and then performs a search of the inbox for responses
            for (int i = 1; i < CampaignTable.Rows.Count; i++)
            {
                string ToAddress = CampaignTable.Rows[i].Cells[0].Value.ToString();
                CampaignTable.Rows[i].Cells[1].Value = SendEmail(HostSettings[0], HostSettings[1], HostSettings[2], EmailSettings[0], EmailSettings[1], ToAddress, EmailSettings[2], EmailSettings[3]);
            }
            EmailSearch();
        }

        /// <summary>
        /// Uses SMTP to send an email through Mail.dll with the paramenters below. Returns whether it sent successfully
        /// </summary>
        /// <param name="HostServer"></param>
        /// <param name="HostUName"></param>
        /// <param name="HostPass"></param>
        /// <param name="SpoofFrom"></param>
        /// <param name="SpoofName"></param>
        /// <param name="ToAddress"></param>
        /// <param name="Subject"></param>
        /// <param name="Body"></param>
        /// <returns></returns>
        public bool SendEmail(string HostServer, string HostUName, string HostPass, string SpoofFrom, string SpoofName, string ToAddress, string Subject, string Body)
        {
            //The following 5 lines set up the email itself.
            MailBuilder Builder = new MailBuilder();
            Builder.From.Add(new MailBox(SpoofFrom, SpoofName));
            Builder.To.Add(new MailBox(ToAddress));
            Builder.Subject = Subject;
            Builder.Html = Body;

            //The following section creates the email and then sends the email
            IMail Email = Builder.Create();
            using (Smtp smtp = new Smtp())
            {
                //the next three lines defines a local variable and then logs into mail server. For security reasons
                //I have omitted the password from the login line.
                bool Success;
                smtp.ConnectSSL(HostServer);
                smtp.UseBestLogin(HostUName, HostPass);

                //This section attempts to send the email and returns whether it manages to send an email successfully.
                SendMessageResult Result = smtp.SendMessage(Email);
                if (Result.Status == SendMessageStatus.Success)
                {
                    Success = true;
                }
                else
                {
                    Success = false;

                }

                smtp.Close();
                return Success;

            }
        }

        /// <summary>
        /// Procedure for searching the inbox for matching email addresses in the table. NOTE: Need to change search flags to find the most recent response instead of picking whichever has the lowest UID
        /// </summary>
        public void EmailSearch()
        {
            Debug.Print("Search");
            using (Imap imap = new Imap())
            {
                SearchingEmails.Visible = true;
                Refresh();

                //This logs into the mail server as it did before and then selects the inbox
                //as the folder to search
                imap.ConnectSSL(HostSettings[0]);
                imap.UseBestLogin(HostSettings[1], HostSettings[2]);
                imap.SelectInbox();

                //This creates a list that will store all the emails in the inbox in orderof their unique IDs (UID)
                //List<long> uidList = imap.Search().Where(Expression.Subject("report")).Sort(SortBy.Date()).GetList();
                List<long> uidList = imap.Search(Flag.All);

                //This loop will search through the table looking for matches to the emails
                //within the list. If it finds one, it will update the table to say that they
                //have responded, as well as the time it was received in the inbox
                foreach (long uid in uidList)
                {
                    IMail email = new MailBuilder()
                        .CreateFromEml(imap.GetMessageByUID(uid));

                    for (int i = 1; i < CampaignTable.Rows.Count; i++)
                    {
                        if (CampaignTable.Rows[i].Cells[0].Value.ToString() == email.Sender.Address)
                        {
                            Debug.Print(email.Sender.Address);
                            CampaignTable.Rows[i].Cells[2].Value = true;
                            CampaignTable.Rows[i].Cells[3].Value = email.Date;
                            //Refresh is the command called to force the GUI to update
                            Refresh();
                        }
                    }
                }
                //This will finally close the connection to the mail server
                imap.Close();
                SearchingEmails.Visible = false;
                Refresh();
            }
        }
    }
}

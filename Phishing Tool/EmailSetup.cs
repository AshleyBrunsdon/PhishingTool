using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using PhishingFunctions;

namespace Phishing_Tool
{
    public partial class EmailSetup : Form
    {
        
        List<Data> ListEmailAddresses = new List<Data>();
        public EmailSetup()
        {
            InitializeComponent();

            //This reads in any email addresses stored previously (rendering load campaign irrelevent although I do wish to seperate them in future)
            //If the data file cannot be found it outputs an error and moves on
            try
            {
                string[] FileEAddresses = File.ReadAllLines("Datafile.txt");
                RecipientEAddressTxtBox.Text = "";
                for (int EAddress = 0; EAddress < FileEAddresses.Length; EAddress++)
                {
                    ListEmailAddresses.Add(new Data { EmailAddress = FileEAddresses[EAddress] });
                    RecipientEAddressTxtBox.AppendText(ListEmailAddresses[EAddress].EAddressOnly() + "\r\n");
                }
            }
            catch (FileNotFoundException)
            {
                Debug.Print("No email address file");
            }

            //This attempts to read in any host settings that have been saved previously, if there aren't any it outputs an error and moves on
            try
            {
                string[] FileHostSettings = File.ReadAllLines("HostSettings.txt");
                HostServerTxtBox.Text = FileHostSettings[0];
                HostUNTxtBox.Text = FileHostSettings[1];
                HostPassTxtBox.Text = FileHostSettings[2];
            }
            
            catch (FileNotFoundException)
            {
                Debug.Print("No Host settings found");
            }
            
        }

        //When Save Email Addresses is clicked it will save the contents of the text box containing the list of email addresses to a text file to be carried ober to the main campaign
        private void SaveEAddresses_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete("DataFile.txt");
                ListEmailAddresses.Clear();
            }
            catch (DirectoryNotFoundException)
            {
                Debug.Print("File does not exist");
            }
            for (int i = 0; i < RecipientEAddressTxtBox.Lines.Length; i++)
            {
                ListEmailAddresses.Add(new Data { EmailAddress = RecipientEAddressTxtBox.Lines[i] });
            }
            File.Create("DataFile.txt").Close();
            for (int i = 0; i < ListEmailAddresses.Count; i++)
            {
                File.AppendAllText("DataFile.txt", ListEmailAddresses[i].ToString() + "\n");
            }
        }

        //When continue is clicked, it will save the new host settings to carry over to the campaihn and load the campaign menu
        //Note: I plan to add functionality for using read receipts later on
        private void ContinueCampaign_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete("HostSettings.txt");
            }

            catch (DirectoryNotFoundException)
            {
                Debug.Print("Host settings file does not exist");
            }

            File.Create("HostSettings.txt").Close();
            using (StreamWriter sw = File.AppendText("HostSettings.txt"))
            {
                sw.WriteLine(HostServerTxtBox.Text);
                sw.WriteLine(HostUNTxtBox.Text);
                sw.WriteLine(HostPassTxtBox.Text);
            }

            Campaign NewWindow = new Campaign();
            NewWindow.Show();
            this.Close();
        }
    }
}

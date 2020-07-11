using System;
using System.Windows.Forms;


namespace Phishing_Tool
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        //This starts the Email Setup screen when new campaign is clicked
        private void NewCampaign_Click(object sender, EventArgs e)
        {
            EmailSetup Window = new EmailSetup();
            Window.Show();
        }

        //This opens the Settings window when the settings button is clicked
        private void Settings_Click(object sender, EventArgs e)
        {
            Settings Window = new Settings();
            Window.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace v1go
{
    public partial class Loader : Form
    {
        /* Declare string to store the users's name received from AuthLoad */
        private string username;

        public Loader(string loginName)
        {
            /* Assign the loginName parameter to the username class property */
           this.username = loginName;

            InitializeComponent();
        }

        /* Delcare string for the VIP and cheat expiry date - we just take the current time and add two weeks to it */
        string expiryDate = DateTime.Now.AddDays(14).ToString("d MMM yyyy H:mm:ss", new CultureInfo("en-GB"));

        private void Loader_Load(object sender, EventArgs e)
        {
            /* Center Form on screen */
            this.CenterToScreen();

            /* Load chkRememberCheat's check state from properties */
            chkRememberCheat.Checked = Properties.Settings.Default.rememberCheat;

            /* If lstCheats has no item selected, but has items in it */
            if (lstCheats.SelectedIndex == -1 && lstCheats.Items.Count > 0)
            {
                /* Select the first cheat */
                lstCheats.SelectedIndex = 0;

                /* Enable the load button */
                btnLoad.Enabled = true;
            }

            /* If the cheat was remembered last time */
            if (Properties.Settings.Default.rememberCheat)
            {
                /* Select the remembered cheat */
                lstCheats.SelectedIndex = Properties.Settings.Default.selectedCheat;
            }

            /* Replace the placeholder with the expiry date string declared above */
            lblExpiry.Text = lblExpiry.Text.Replace("{expiryDate}", expiryDate);

            /* Replace the placeholder with the count of cheats subscribed to */
            lblActiveSubscriptions.Text = lblActiveSubscriptions.Text.Replace("{activeSubscriptions}", lstCheats.Items.Count.ToString());

            /* Replace the placeholder with the user's name */
            lblWelcome.Text = lblWelcome.Text.Replace("{username}", username);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            /* Exit the loader */
            Application.Exit();
        }

        /* Declare string to store the game's executable name */
        string exeName;

        private void lstCheats_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* Check for the selected cheat's name */
            if (lstCheats.SelectedItem.ToString() == "Counter-Strike: Global Offensive")
            {
                /* Change name and version labels */
                lblGameName.Text = "Counter-Strike: Global Offensive";
                lblVersion.Text = "Version: Latest";

                /* Calculate the days between the current date and the expiration date */
                lblDaysLeft.Text = String.Format("This subscription will expire in {0} days", (DateTime.Now.AddDays(14) - DateTime.Now).TotalDays.ToString());

                /* Change the expiry date to the string declared above */
                lblExpirationDate.Text = String.Format("Expiration Date: {0}", expiryDate);

                /* Change detection status text and color */
                lblStatus.Text = "Undetected";
                lblStatus.ForeColor = Color.LimeGreen;

                /* Set the executable name */
                exeName = "csgo";
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            /* If the cheat should be remembered and the cheat list contains items */
            if (chkRememberCheat.Checked && lstCheats.Items.Count > 0)
            {
                /* Set selectedCheat to the cheat list's SelectedIndex */
                Properties.Settings.Default.selectedCheat = lstCheats.SelectedIndex;
            }
            else
            {
                /* Set the selectedCheat value to the default one */
                Properties.Settings.Default.selectedCheat = 0;
            }

            /* Set the remember state and save the settings */
            Properties.Settings.Default.rememberCheat = chkRememberCheat.Checked;
            Properties.Settings.Default.Save();

            /* Show next Form */
            this.Hide();
            WaitForGame inject = new WaitForGame(lstCheats.SelectedItem.ToString().Trim(), exeName); // Parse the selected cheat's name and executable into the constructor
            inject.ShowDialog();
            this.Close();
        }
    }
}

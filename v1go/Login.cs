using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace v1go
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            /* Center Form on screen */
            this.CenterToScreen();

            /* Load the user's credentials and remember state from Settings */
            txtUsername.Text = Properties.Settings.Default.username;
            txtPassword.Text = Properties.Settings.Default.password;
            chkRemember.Checked = Properties.Settings.Default.remember;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /* If chkRemember is checked, save the users's credentials, otherwise reset them to an empty string */
            if (chkRemember.Checked)
            {
                Properties.Settings.Default.username = txtUsername.Text.Trim();
                Properties.Settings.Default.password = txtPassword.Text;
            }
            else
            {
                Properties.Settings.Default.username = String.Empty;
                Properties.Settings.Default.password = String.Empty;
            }

            /* Set the remember state */
            Properties.Settings.Default.remember = chkRemember.Checked;

            /* Save the settings */
            Properties.Settings.Default.Save();

            /**
             * Because I'm not using AIMWARE myself, I don't know the messages for invalid credentials or HWID failures.
             * We'll accept any combination of credentials here.
             */ 

            /* Hide Login, show Loader and close Login */
            this.Hide();
            AuthLoad loader = new AuthLoad(txtUsername.Text.Trim());
            loader.ShowDialog();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            /* Exit the loader */
            Application.Exit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace v1go
{
    public partial class AuthLoad : Form
    {
        /* Declare string to store the users's name and parse it to the loader Form */
        private string loginName;

        public AuthLoad(string loginName)
        {
            /* Assign the username parameter to the username class property */
            this.loginName = loginName;

            InitializeComponent();
        }

        private void Startup_Load(object sender, EventArgs e)
        {
            /* Center Form on screen */
            this.CenterToScreen();

            /* Configure timer */
            tmrLoad.Interval = 500;
            tmrLoad.Start();     
        }

        /* Variable to stop the loading */
        bool stop = false;

        private void tmrLoad_Tick(object sender, EventArgs e)
        {
            /* Check if stop is true */
            if (stop)
            {
                /* Stop the timer */
                tmrLoad.Stop();

                /* Show next Form */
                this.Hide();
                Loader loader = new Loader(this.loginName);
                loader.ShowDialog();
                this.Close();
            }

            /* Set stop to true */
            stop = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            /* Exit the loader */
            Application.Exit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace v1go
{
    public partial class PleaseWait : Form
    {
        public PleaseWait()
        {
            InitializeComponent();
        }

        private void Startup_Load(object sender, EventArgs e)
        {
            /* Configure timer */
            tmrLoad.Interval = 6000;
            tmrLoad.Start();

            /* Center Form on screen */
            this.CenterToScreen();
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
                UpdateCheck updater = new UpdateCheck();
                updater.ShowDialog();
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

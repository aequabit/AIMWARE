using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace v1go
{
    public partial class WaitForGame : Form
    {
        /* Declare strings for the game's name and it's executable */
        private string game;
        private string exe;

        public WaitForGame(string game, string exe)
        {
            /* Assign the constructor parameters to class properties */
            this.game = game;
            this.exe = exe;

            InitializeComponent();
        }

        private void Startup_Load(object sender, EventArgs e)
        {
            /* Set the loading text */
            lblPleaseWait.Text = String.Format("Waiting for {0}...", this.game);

            /* Configure timer */
            tmrLoad.Interval = 500;
            tmrLoad.Start();

            /* Center Form on screen */
            this.CenterToScreen();
        }

        private void tmrLoad_Tick(object sender, EventArgs e)
        {
            /* Declare array of processes with the game's executable name */
            Process[] pname = Process.GetProcessesByName(this.exe);

            /* Check if game process is running */
            if (pname.Length > 0)
            {
                /* Stop the timer */
                tmrLoad.Stop();

                /* Close loader */
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            /* Exit the loader */
            Application.Exit();
        }
    }
}

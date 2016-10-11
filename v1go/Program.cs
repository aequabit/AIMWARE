using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace v1go
{
    /**
    * This is a recreation of the AIMWARE Loader, made by aequabit.
    * Please don't steal this, it was a lot of work.
    */
    
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Loader("adolf"));
            Application.Run(new PleaseWait());
        }
    }
}

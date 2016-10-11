using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace v1go
{
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

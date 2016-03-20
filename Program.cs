using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace market
{
    static class Program
    {
        public static Form owner;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainMdiForm());
        }
    }
}

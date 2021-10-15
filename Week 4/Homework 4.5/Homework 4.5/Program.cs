using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Homework_4._5
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
            Application.Run(new HW4B());
        }
    }
}

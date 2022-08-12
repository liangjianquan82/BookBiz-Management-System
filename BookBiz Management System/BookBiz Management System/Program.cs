using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBiz_Management_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login lg = new Login();
            MainForm mf = new MainForm();
            if (lg.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm());
            }
           /* else if(mf.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Login());
            }*/
            
        }
    }
}

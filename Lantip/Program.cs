using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lantip.WindowForm
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
			FormLogin formLogin = new FormLogin();
			if (formLogin.ShowDialog() == DialogResult.OK)
			{
				Application.Run(new FormHome());
			}
			else
			{
				Application.Exit();
			}
        }
    }
}

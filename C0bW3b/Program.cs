using System;
using System.Windows.Forms;

namespace C0bW3b
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                ConfigSystem.LoadConfig();

                C0bW3b.Utils.DiscordRPC.Initialize();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Main());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "C0bW3b ~ Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
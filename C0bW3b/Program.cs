using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace C0bW3b
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // if program runs in temp folder
            try
            {
                if (Application.StartupPath == Path.GetTempPath() && args.Length > 0)
                {
                    string path = args[1];
                    File.Copy(Application.ExecutablePath, path, true);
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = Path.Combine(Path.GetTempPath(), "C0bW3b.exe");
                    startInfo.Arguments = "done " + Assembly.GetExecutingAssembly().Location;
                    Process.Start(startInfo);
                    Application.Exit();
                    Environment.Exit(0);
                }
                else
                {
                    if (args.Length > 0)
                        if (args[0] == "done")
                            File.Delete(args[1]);

                    ConfigSystem.LoadConfig();

                    Utils.DiscordRPC.Initialize();

                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Main());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "C0bW3b ~ Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
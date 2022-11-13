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
                    if (args[0] == "update")
                    {
                        try { File.Delete(path); } catch { }
                        try { File.Copy(Application.ExecutablePath, path, true); } catch { }
                        ProcessStartInfo startInfo = new ProcessStartInfo();
                        startInfo.FileName = path;
                        startInfo.Arguments = "updatesuccess";
                        Process.Start(startInfo);
                        Application.Exit();
                        Environment.Exit(0);
                    }
                }
                else
                {
                    try { if (args[0] == "updatesuccess") MessageBox.Show("Successfully updated!", "C0bW3b ~ Update", MessageBoxButtons.OK, MessageBoxIcon.Information); } catch { }

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
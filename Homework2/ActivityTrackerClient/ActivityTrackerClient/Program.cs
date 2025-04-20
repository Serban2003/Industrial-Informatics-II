using System;
using System.IO;
using System.Windows.Forms;

namespace ActivityTrackerClient
{
    internal static class Program
    {
        public static Session currentSession;
        public static ServiceReference.WebServiceSoapClient service;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            service = new ServiceReference.WebServiceSoapClient();

            // Create session info directory in AppData/Local/
            Directory.CreateDirectory(GeneralValues.AppFolder);
            if (!File.Exists(GeneralValues.SessionInfo))
            {
                File.Create(GeneralValues.SessionInfo).Close();
                currentSession = new Session();
                File.WriteAllText(GeneralValues.SessionInfo, currentSession.ToJson());
            }
            else
            {
                currentSession = Session.FromJson(File.ReadAllText(GeneralValues.SessionInfo));
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ActivityTracker());
        }
    }
}

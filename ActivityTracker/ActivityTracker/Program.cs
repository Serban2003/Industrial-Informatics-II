using Microsoft.VisualBasic.FileIO;

namespace ActivityTracker
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.


            Directory.CreateDirectory(GeneralValues.appFolder);
            if (!File.Exists(GeneralValues.activitiesDatabase))
            {
                File.Create(GeneralValues.activitiesDatabase).Close();
                File.WriteAllText(GeneralValues.activitiesDatabase, "Title|Description|Type|Date|Duration|Calories|AvgHR|GpxFile|Elevation|Distance|AvgPace|AvgSpeed|NumberOfSets\n");
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new ActivityTracker());
            //Application.Run(new ActivityForm());
        }

    }
}
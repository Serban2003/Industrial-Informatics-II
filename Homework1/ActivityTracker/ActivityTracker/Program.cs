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

            // Create activity database directory in AppData/Local/
            Directory.CreateDirectory(GeneralValues.AppFolder);
            if (!File.Exists(GeneralValues.ActivitiesDatabase))
            {
                File.Create(GeneralValues.ActivitiesDatabase).Close();
                File.WriteAllText(GeneralValues.ActivitiesDatabase, "Title|Description|Type|Date|Duration|Calories|AvgHR|GpxFile|Elevation|Distance|AvgPace|AvgSpeed|NumberOfSets\n");
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new ActivityTracker());
        }

    }
}
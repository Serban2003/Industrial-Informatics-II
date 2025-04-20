using System;
using System.Collections.Generic;
using System.Data;
using System.Text.Json;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace ActivityTrackerClient
{
    public class Activity
    {
        public enum ActivityType
        {
            All,
            Workout,
            Run,
            Hike,
            Bike_Ride
        }

        private Int32 a_Id;
        private String title;
        private String description;
        private ActivityType type;
        private DateTime date;
        private TimeSpan duration;
        private Int32 calories;
        private Int32 avgHR;
        private String gpxFile;
        private Int32 numberOfSets;
        private Double elevation; //m/feet
        private Double distance; //km/miles

        public Int32 A_Id
        {
            set => a_Id = value; get => a_Id;
        }
        public String Title
        {
            set => title = value; get => title;
        }

        public String Description
        {
            set => description = value; get => description;
        }

        public ActivityType Type
        {
            set => type = value; get => type;
        }

        public DateTime Date
        {
            set => date = value; get => date;
        }

        public TimeSpan Duration
        {
            set => duration = value; get => duration;
        }

        public Int32 Calories
        {
            set => calories = value; get => calories;
        }

        public Int32 AvgHR
        {
            set => avgHR = value; get => avgHR;
        }

        public String GpxFile
        {
            set => gpxFile = value; get => gpxFile;
        }
        public Int32 NumberOfSets
        {
            set => numberOfSets = value; get => numberOfSets;
        }

        public Double Elevation
        {
            set => elevation = value;
            get => elevation;
        }

        public Double Distance
        {
            set => distance = value;
            get => distance;
        }

        public String GetAvgPace()
        {
            return TimeSpan.FromSeconds(Duration.TotalSeconds/ Distance).ToString(@"mm\:ss");
        }

        public String GetAvgSpeed()
        {
            return $"{(Distance / Duration.TotalHours):F2}";
        }

        public Activity(Int32 a_id, String title, String description, ActivityType type, DateTime date, TimeSpan duration, Int32 calories, Int32 avgHR, String gpxFile, Int32 numberOfSets, Double elevation, Double distance)
        {
            this.a_Id = a_id;
            this.title = title;
            this.description = description;
            this.date = date;
            this.type = type;
            this.duration = duration;
            this.calories = calories;
            this.avgHR = avgHR;
            this.gpxFile = gpxFile;
            this.numberOfSets = numberOfSets;
            this.elevation = elevation;
            this.distance = distance;
        }

        //Title|Description|Type|Date|Duration|Calories|AvgHR|GpxFile|NumberOfSets|Elevation|Distance
        public static List<Activity> parseActivityFile(String fileName)
        {
            List<Activity> activityList = new List<Activity>();

            using (TextFieldParser parser = new TextFieldParser(fileName))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters("|");
                string[] header = parser.ReadFields();

                while (!parser.EndOfData)
                {
                    String[] fields = parser.ReadFields();

                    if (fields == null) continue;

                    String title = fields[0];
                    String description = fields[1];
                    String type = fields[2];
                    DateTime date = DateTime.Parse(fields[3]);
                    TimeSpan duration = TimeSpan.Parse(fields[4]);
                    Int32 calories = Int32.Parse(fields[5]);
                    Int32 avgHR = Int32.Parse(fields[6]);
                    String gpxFile = fields[7];

                    Int32 numberOfSets = Int32.Parse(fields[8]);
                    Double elevation = Double.Parse(fields[9]);
                    Double distance = Double.Parse(fields[10]);

                    activityList.Add(new Activity(0, title, description, (ActivityType)Enum.Parse(typeof(ActivityType), type), date, duration, calories, avgHR, gpxFile, numberOfSets, elevation, distance));
                }
            }
            return activityList;
        }

        public String ToJson()
        {
            return JsonSerializer.Serialize(this);
        }
        public static Activity FromJson(String json)
        {
            return JsonSerializer.Deserialize<Activity>(json);
        }
    }
}

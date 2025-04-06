using Microsoft.VisualBasic.FileIO;

namespace ActivityTracker
{
    public class Activity
    {
        public enum ActivityType
        {
            Workout,
            Run,
            Hike,
            Bike_Ride
        }

        private String title;
        private String description;
        private ActivityType type;
        private DateTime date;
        private DateTime duration;
        private Int32 calories;
        private Int32 avgHR;
        private String gpxFile;

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

        public DateTime Duration
        {
            set => duration = value; get => duration;
        }

        public String FormatedDuration
        {
            get => duration.ToString("HH:mm:ss");
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

        public Activity(String title, String description, ActivityType type, DateTime date, DateTime duration, Int32 calories, Int32 avgHR, string gpxFile)
        {
            this.title = title;
            this.description = description;
            this.date = date;
            this.type = type;
            this.duration = duration;
            this.calories = calories;
            this.avgHR = avgHR;
            this.gpxFile = gpxFile;
        }

        public virtual String ToCSVString()
        {
            return $"{title}|{description}|{type}|{date}|{FormatedDuration}|{calories}|{avgHR}|{gpxFile}";
        }

        //Title|Description|Type|Date|Duration|Calories|AvgHR|GpxFile|Elevation|Distance|AvgPace|AvgSpeed|NumberOfSets
        public static List<Object> parseActivityFile(String fileName)
        {
            List<Object> activityList = new List<Object>();

            using (TextFieldParser parser = new TextFieldParser(fileName))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters("|");
                string[] header = parser.ReadFields();
                while (!parser.EndOfData)
                {
                    //Processing row
                    String[] fields = parser.ReadFields();

                    if (fields == null) continue;

                    String title = fields[0];
                    String description = fields[1];
                    DateTime date = DateTime.Parse(fields[3]);
                    DateTime duration = DateTime.Parse(fields[4]);
                    Int32 calories = Int32.Parse(fields[5]);
                    Int32 avgHR = Int32.Parse(fields[6]);
                    String gpxFile = fields[7];
                    Double elevation = Double.Parse(fields[8]);
                    Double distance = Double.Parse(fields[9]);
                    DateTime avgPace = DateTime.Parse(fields[10]);
                    Double avgSpeed = Double.Parse(fields[11]);
                    Int32 numberOfSets = Int32.Parse(fields[12]);
                     
                    switch (fields[2]){
                        case "Run":
                        {
                            activityList.Add(new RunActivity(title, description, date, duration, calories, avgHR, elevation, distance, avgPace, avgSpeed, gpxFile));
                            break;
                        }
                        case "Workout":
                        {
                            activityList.Add(new WorkoutActivity(title, description, date, duration, calories, avgHR, numberOfSets));
                            break;
                        }
                        case "Bike_Ride":
                        {
                            activityList.Add(new BikeRideActivity(title, description, date, duration, calories, avgHR, elevation, distance, avgSpeed, gpxFile));
                            break;
                        }
                        case "Hike":
                        {
                            activityList.Add(new HikeActivity(title, description, date, duration, calories, avgHR, elevation, distance, avgPace, avgSpeed, gpxFile));
                            break;
                        }
                    }
                }
            }
            return activityList;
        }

        public static void AddActivity(Activity activity)
        {
            File.AppendAllText(GeneralValues.activitiesDatabase, $"{activity.ToCSVString()}\n");
        }
    }

    public class WorkoutActivity : Activity
    {
        private Int32 numberOfSets;

        public Int32 NumberOfSets
        {
            set => numberOfSets = value; get => numberOfSets;
        }

        public WorkoutActivity(string title, string description, DateTime date, DateTime duration, Int32 calories, Int32 avgHR, Int32 numberOfSets) : base(title, description, ActivityType.Workout, date, duration, calories, avgHR, "")
        {
            this.numberOfSets = numberOfSets;
        }

        public override String ToCSVString()
        {
            return base.ToCSVString() + $"|0|0|0|0|{numberOfSets}";
        }
    }

    public class RunActivity : Activity
    {
        private Double elevation; //m/feet
        private Double distance; //km/miles
        private DateTime avgPace;
        private Double avgSpeed;

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

        public DateTime AvgPace
        {
            set => avgPace = value; get => avgPace;
        }
        public String FormatedAvgPace
        {
            get => avgPace.ToString("mm:ss");
        }
        public Double AvgSpeed
        {
            set => avgSpeed = value; get => avgSpeed;
        }

        public RunActivity(string title, string description, DateTime date, DateTime duration, Int32 calories, Int32 avgHR, Double elevation, Double distance, DateTime avgPace, Double avgSpeed, String gpxFile) : base(title, description, ActivityType.Run, date, duration, calories, avgHR, gpxFile)
        {
            this.elevation = elevation;
            this.distance = distance;
            this.avgPace = avgPace;
            this.avgSpeed = avgSpeed;
        }
        public override String ToCSVString()
        {
            return base.ToCSVString() + $"|{elevation}|{distance}|{FormatedAvgPace}|{avgSpeed}|0";
        }
    }

    public class BikeRideActivity : Activity
    {
        private Double elevation;
        private Double distance;
        private Double avgSpeed;

        public Double Elevation
        {
            set => elevation = value;
            get => elevation;
        }

        public Double Distance
        {
            set => distance = value; get => distance;
        }

        public Double AvgSpeed
        {
            set => avgSpeed = value; get => avgSpeed;
        }
        public BikeRideActivity(string title, string description, DateTime date, DateTime duration, Int32 calories, Int32 avgHR, Double elevation, Double distance, Double avgSpeed, String gpxFile) : base(title, description, ActivityType.Bike_Ride, date, duration, calories, avgHR, gpxFile)
        {
            this.elevation = elevation;
            this.distance = distance;
            this.avgSpeed = avgSpeed;
        }
        public override String ToCSVString()
        {
            return base.ToCSVString() + $"|{elevation}|{distance}|0|{avgSpeed}|0";
        }
    }

    public class HikeActivity : Activity
    {
        private Double elevation;
        private Double distance;
        private Double avgSpeed;
        private DateTime avgPace;
        public Double Elevation
        {
            set => elevation = value;
            get => elevation;
        }

        public Double Distance
        {
            set => distance = value; get=> distance;
        }

        public DateTime AvgPace
        {
            set => avgPace = value; get => avgPace;
        }

        public String FormatedAvgPace
        {
            get => avgPace.ToString("mm:ss");
        }

        public Double AvgSpeed
        {
            set => avgSpeed = value; get => avgSpeed;
        }

        public HikeActivity(string title, string description, DateTime date, DateTime duration, Int32 calories, Int32 avgHR, Double elevation, Double distance, DateTime avgPace, Double avgSpeed, String gpxFile) : base(title, description, ActivityType.Hike, date, duration, calories, avgHR, gpxFile)
        {
            this.elevation = elevation;
            this.distance = distance;
            this.avgPace = avgPace;
            this.avgSpeed = avgSpeed;
        }
        public override String ToCSVString()
        {
            return base.ToCSVString() + $"|{elevation}|{distance}|{FormatedAvgPace}|{avgSpeed}|0";
        }
    }
}

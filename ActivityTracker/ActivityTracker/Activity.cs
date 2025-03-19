using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityTracker
{
    public class Activity
    {
        private String title;
        private String description;
        private ActivityType type;
        private DateTime date;
        private Double duration;
        private Int32 calories;
        private Double elevation;
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

        public Double Duration
        {
            set => duration = value; get => duration;
        }

        public String FormatedDuration
        {
            get
            {
                TimeSpan time = TimeSpan.FromSeconds(duration);
                String formattedTime;
                if (time.TotalHours >= 1)
                {
                    formattedTime = String.Format("{0:D2}:{1:D2}:{2:D2}", (int)time.TotalHours, time.Minutes, time.Seconds);
                }
                else if (time.Minutes > 0)
                {
                    formattedTime = String.Format("{0:D2}:{1:D2}", time.Minutes, time.Seconds);
                }
                else
                {
                    formattedTime = String.Format("{0:D2}", time.Seconds);
                }

                return formattedTime;
            }
        }

        public Int32 Calories
        {
            set => calories = value; get => calories;
        }

        public Double Elevation
        {
            set => elevation = value; get => elevation;
        }

        public Int32 AvgHR
        {
            set => avgHR = value; get => avgHR;
        }

        public String GpxFile
        {
            set => gpxFile = value; get => gpxFile;
        }

        public Activity(String title, String description, ActivityType type, DateTime date, Double duration, Int32 calories, Double elevation, Int32 avgHR, string gpxFile)
        {
            this.title = title;
            this.description = description;
            this.date = date;
            this.type = type;
            this.duration = duration;
            this.calories = calories;
            this.avgHR = avgHR;
            this.gpxFile = gpxFile;
            this.elevation = elevation;
        }
    }

    public class WorkoutActivity : Activity
    {
        public WorkoutActivity(string title, string description, DateTime date, Double duration, Int32 calories, Int32 avgHR) : base(title, description, ActivityType.Workout, date, duration, calories, 0, avgHR, "")
        {
        }
    }

    public class RunActivity : Activity
    {
        private Double avgPace;
        public Double AvgPace
        {
            set => avgPace = value; get => avgPace;
        }
        public RunActivity(string title, string description, DateTime date, Double duration, Int32 calories, Double elevation, Int32 avgHR, Double avgPace, String gpxFile) : base(title, description, ActivityType.Run, date, duration, calories, elevation, avgHR, gpxFile)
        {
            this.avgPace = avgPace;
        }
    }

    public class BikeRideActivity : Activity
    {
        private Double avgSpeed;
        public Double AvgSpeed
        {
            set => avgSpeed = value; get => avgSpeed;
        }
        public BikeRideActivity(string title, string description, DateTime date, Double duration, Int32 calories, Double elevation, Int32 avgHR, Double avgSpeed, String gpxFile) : base(title, description, ActivityType.Run, date, duration, calories, elevation, avgHR, gpxFile)
        {
            this.avgSpeed = avgSpeed;
        }
    }

    public class HikeActivity : Activity
    {
        private Double avgPace;
        public Double AvgPace
        {
            set => avgPace = value; get => avgPace;
        }
        public HikeActivity(string title, string description, DateTime date, Double duration, Int32 calories, Double elevation, Int32 avgHR, Double avgPace, String gpxFile) : base(title, description, ActivityType.Run, date, duration, calories, elevation, avgHR, gpxFile)
        {
            this.AvgPace = avgPace;
        }
    }
}

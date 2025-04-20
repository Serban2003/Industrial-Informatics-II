using System;
using System.Text.Json;

namespace ActivitiesWebApplication
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

        private Int32 a_id;
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
            set => a_id = value; get => a_id;
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

        public Activity(Int32 a_id, String title, String description, ActivityType type, DateTime date, TimeSpan duration, Int32 calories, Int32 avgHR, String gpxFile, Int32 numberOfSets, Double elevation, Double distance)
        {
            this.a_id = a_id;
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
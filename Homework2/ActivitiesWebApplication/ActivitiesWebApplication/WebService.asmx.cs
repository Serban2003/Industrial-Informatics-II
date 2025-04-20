using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text.Json;
using System.Web.Services;

namespace ActivitiesWebApplication
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "ActivityWebApplication")]
    public class WebService : System.Web.Services.WebService
    {
        private readonly string _connString = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;

        [WebMethod]
        public bool CreateUser(String userJSON)
        {
            User user = ActivitiesWebApplication.User.FromJson(userJSON);
            try
            {
                using (var connection = new SqlConnection(_connString))
                {
                    connection.Open();
                    using (var cmd = new SqlCommand("INSERT INTO Users (Firstname, Lastname, Email, Password) VALUES (@Firstname, @Lastname, @Email, @Password)", connection))
                    {
                        cmd.Parameters.AddWithValue("@Firstname", user.Firstname);
                        cmd.Parameters.AddWithValue("@Lastname", user.Lastname);
                        cmd.Parameters.AddWithValue("@Email", user.Email);
                        cmd.Parameters.AddWithValue("@Password", PasswordHasher.Hash(user.Password));
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        [WebMethod]
        public String GetUser(String email, String password)
        {
            User user = null;
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                using (var cmd = new SqlCommand("SELECT * FROM Users WHERE Email = @Email", connection))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new User(Int32.Parse(reader[0].ToString()), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString());
                        }
                    }
                }
            }
            if (PasswordHasher.Verify(password, user.Password))
                return user.ToJson();

            return null;
        }
        
        [WebMethod]
        public bool CreateActivity(Int32 userID, String activityJSON)
        {
            Activity activity = Activity.FromJson(activityJSON);

            try
            {
                using (var connection = new SqlConnection(_connString))
                {
                    connection.Open();
                    using (var cmd = new SqlCommand("INSERT INTO Activities (U_Id, Title, Description, Type, Date, Duration, Calories, AvgHR, GPXFile, NoOfSets, Elevation, Distance) VALUES (@U_Id, @Title, @Description, @Type, @Date, @Duration, @Calories, @AvgHR, @GPXFile, @NoOfSets, @Elevation, @Distance)", connection))
                    {
                        cmd.Parameters.AddWithValue("@U_Id", userID);
                        cmd.Parameters.AddWithValue("@Title", activity.Title);
                        cmd.Parameters.AddWithValue("@Description", activity.Description);
                        cmd.Parameters.AddWithValue("@Type", activity.Type);
                        cmd.Parameters.AddWithValue("@Date", activity.Date);
                        cmd.Parameters.AddWithValue("@Duration", activity.Duration);
                        cmd.Parameters.AddWithValue("@Calories", activity.Calories);
                        cmd.Parameters.AddWithValue("@AvgHR", activity.AvgHR);
                        cmd.Parameters.AddWithValue("@GPXFile", activity.GpxFile);
                        cmd.Parameters.AddWithValue("@NoOfSets", activity.NumberOfSets);
                        cmd.Parameters.AddWithValue("@Elevation", activity.Elevation);
                        cmd.Parameters.AddWithValue("@Distance", activity.Distance);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        
        [WebMethod]
        public String GetActivities(Int32 userID, String filter)
        {
            List<Activity> activities = new List<Activity>();

            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                using (var cmd = new SqlCommand("SELECT * FROM Activities WHERE U_Id=@U_Id AND (Type=@Type OR @Type IS NULL)", connection))
                {
                    cmd.Parameters.AddWithValue("@U_Id", userID);
                    if((Activity.ActivityType)Enum.Parse(typeof(Activity.ActivityType), filter) == Activity.ActivityType.All) cmd.Parameters.AddWithValue("@Type", DBNull.Value);
                    else cmd.Parameters.AddWithValue("@Type", Int32.Parse(filter));

                    using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Activity activity = new Activity(Int32.Parse(reader[0].ToString()), reader[2].ToString(), reader[3].ToString(), (Activity.ActivityType)Enum.Parse(typeof(Activity.ActivityType), reader[4].ToString()), DateTime.Parse(reader[5].ToString()), TimeSpan.Parse(reader[6].ToString()), Int32.Parse(reader[7].ToString()), Int32.Parse(reader[8].ToString()), reader[9] == null ? "" : reader[9].ToString(), Int32.Parse(reader[10].ToString()), Double.Parse(reader[11].ToString()), Double.Parse(reader[12].ToString()));
                                activities.Add(activity);
                            }
                        }
                }
            }

            return JsonSerializer.Serialize(activities);
        }

        [WebMethod]
        public bool DeleteActivity(Int32 activityID)
        {
            try
            {
                using (var connection = new SqlConnection(_connString))
                {
                    connection.Open();
                    using (var cmd = new SqlCommand("DELETE FROM Activities WHERE A_Id = @A_Id", connection))
                    {
                        cmd.Parameters.AddWithValue("@A_Id", activityID);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        [WebMethod]
        public bool ChangePassword(String userJSON, String newPassword)
        {
            User user = ActivitiesWebApplication.User.FromJson(userJSON);
            try
            {
                using (var connection = new SqlConnection(_connString))
                {
                    connection.Open();
                    using (var cmd = new SqlCommand("UPDATE Users SET Password = @NewPassword WHERE Email = @Email", connection))
                    {
                        cmd.Parameters.AddWithValue("@NewPassword", PasswordHasher.Hash(newPassword));
                        cmd.Parameters.AddWithValue("@Email", user.Email);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

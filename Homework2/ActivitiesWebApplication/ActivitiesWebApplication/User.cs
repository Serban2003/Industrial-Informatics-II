using System;
using System.Text.Json;

namespace ActivitiesWebApplication
{
    public class User
    {
        public Int32 Id { get; set; }
        public String Firstname { set; get; }
        public String Lastname { set; get; }
        public String Email { set; get; }
        public String Password { set; get; }

        public User()
        {
            Id = 0;
            Firstname = null;
            Lastname = null;
            Email = null;
            Password = null;
        }
        public User(Int32 id, String firstname, String lastname, String email, String password)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            Password = password;
        }
        public String ToJson()
        {
            return JsonSerializer.Serialize(this);
        }
        public static User FromJson(String json)
        {
            return JsonSerializer.Deserialize<User>(json);
        }
    }
}
using System;
using System.Text.Json;

namespace ActivityTrackerClient
{
    internal class User
    {
        public Int32 Id { get; set; }
        public String Firstname { set; get; }
        public String Lastname { set; get; }
        public String Email { set; get; }
        public String Password { set; get; }

        public User(Int32 id, String firstname, String lastname, String email, String password) {
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

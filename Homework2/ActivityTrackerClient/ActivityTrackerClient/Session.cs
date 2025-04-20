using System;
using System.Text.Json;

namespace ActivityTrackerClient
{
    internal class Session
    {
        public bool IsAuthenticated { get; set; }
        public User CurrentUser { get; set; }

        public Session() { 
            IsAuthenticated = false;
            CurrentUser = null;
        }
        public Session(bool isAuthenticated, User user)
        {
            IsAuthenticated = isAuthenticated;
            CurrentUser = user;
        }
        public String ToJson()
        {
            return JsonSerializer.Serialize(this);
        }
        public static Session FromJson(String json)
        {
            return JsonSerializer.Deserialize<Session>(json);
        }
    }
}

using System.Text.Json.Serialization;

namespace fitness_app_mvvm.Model
{
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
    [JsonDerivedType(typeof(UserGoal), "user")]
    [JsonDerivedType(typeof(UserHistory), "userhistory")]
    [JsonDerivedType(typeof(UserSettings), "usersettings")]

    //no longer abstract, because something like userHistory shouldn't be "a user"
    public class User
    {
        public string Username { get; set; }
        public UserSettings Settings { get; set; } = new();
        public UserHistory History { get; set; } = new();

        public List<UserGoal> Goals { get; set; } = new();

        public User() { }
    }
}
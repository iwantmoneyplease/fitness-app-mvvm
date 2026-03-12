namespace fitness_app_mvvm.Model
{
    public class User
    {
        //basic account info
        public string Username { get; set; } = string.Empty;
        //public string ProfilePicturePath { get; set; } = "default_avatar.png";

        //user specific stuff in regards to the profile (weight, username)
        public UserSettings Settings { get; set; } = new UserSettings();
        public UserGoal Goals { get; set; } = new UserGoal();

        //a list of completed workouts (history)
        public List<CompletedWorkout> History { get; set; } = new List<CompletedWorkout>();

        public User() { }
    }
}
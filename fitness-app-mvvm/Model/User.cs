using System.Text.Json.Serialization;

namespace fitness_app_mvvm.Model
{
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
    [JsonDerivedType(typeof(UserGoal), "user")]
    [JsonDerivedType(typeof(UserHistory), "userhistory")]
    [JsonDerivedType(typeof(UserSettings), "usersettings")]
    public abstract class User
    {
        // Medlemsvariabler
        public enum Type { UserGoal, UserHistory, UserSettings };
        private Type userSection;

        public abstract string GetDesc();
        public abstract List<string> SortOptions { get; }

        // Konstruktor (en metod med samma namn som klassen, som returnerar ett objekt)
        protected User() { }
        public User(Type userSection) // en konstruktor kan, men måste inte, ta parametrar
        {
            this.userSection = userSection;
        }

        public Type UserType
        {
            get { return userSection; }
            set { userSection = value; }
        }
    }
}
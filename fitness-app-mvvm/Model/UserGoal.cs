using System.Text.Json.Serialization;

namespace fitness_app_mvvm.Model
{
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
    [JsonDerivedType(typeof(GoalArm), "arm_goal")]
    [JsonDerivedType(typeof(GoalLeg), "leg_goal")]
    [JsonDerivedType(typeof(GoalCore), "core_goal")]
    public abstract class UserGoal
    {
        public enum GoalType { Strength, Endurance, Mobility }

        private GoalType goalType;
        private string quantity = string.Empty;
        private string time = string.Empty;
        private string sort = string.Empty;

        // Abtract, because arm/leg/core will provide their own lists
        public abstract List<string> SortOptions { get; }

        public GoalType Goal_Type
        {
            get => goalType;
            set => goalType = value;
        }

        public string Quantity
        {
            get => quantity;
            set => quantity = value;
        }

        public string Time
        {
            get => time;
            set => time = value;
        }

        public string Sort
        {
            get => sort;
            set
            {
                //checks against specific sort value
                if (SortOptions.Contains(value))
                    sort = value;
            }
        }

        public abstract string GetDesc();

        public override string ToString() => GetDesc();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitness_app_mvvm.Model
{
    public class UserGoal : User
    {
        public enum GoalType { Strength, Endurance, Mobility }

        private GoalType goalType;
        private string quantity = string.Empty;
        private string time = string.Empty;
        private string sort = string.Empty;

        public override List<string> SortOptions { get; } = new();

        public UserGoal() : base(Type.UserGoal)
        {
        }

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
                if (SortOptions.Contains(value))
                    sort = value;
            }
        }

        public override string GetDesc()
        {
            return $"{goalType} - {sort} ({time} min, {quantity} reps)";
        }

        public override string ToString()
        {
            return GetDesc();
        }
    }
}

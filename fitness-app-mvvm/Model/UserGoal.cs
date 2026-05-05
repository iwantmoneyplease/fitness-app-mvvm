using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitness_app_mvvm.Model
{
    public class UserGoal : User
    {
        public string GoalText { get; set; } = string.Empty;

        public UserGoal() : base(Type.UserGoal)
        {
        }

        public override string GetDesc()
        {
            return GoalText;
        }

        public override string ToString()
        {
            return GoalText;
        }
    }
}

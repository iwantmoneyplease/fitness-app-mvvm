using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitness_app_mvvm.Model
{
    public class GoalArm : UserGoal
    {
        public override List<string> SortOptions => new()
        {
            "Bicep Curls",
            "Tricep Dips",
            "Hammer Curls",
            "Pushdowns"
        };

        public override string GetDesc()
        {
            return $"Core goal: {Sort}";
        }

    }
}

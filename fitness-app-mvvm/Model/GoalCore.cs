using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitness_app_mvvm.Model
{
    public class GoalCore : UserGoal
    {
        public override List<string> SortOptions => new()
        {
            "Plank",
            "Situps",
            "Russian Twist",
            "Leg Raises"
        };

        public override string GetDesc()
        {
            return $"Core goal: {Sort}";
        }

    }
}

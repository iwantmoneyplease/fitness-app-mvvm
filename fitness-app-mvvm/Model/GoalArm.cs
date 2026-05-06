using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitness_app_mvvm.Model
{
    public class GoalArm : UserGoal
    {
        public override List<string> SortOptions => new() { "Bicep Curls", "Tricep Dips", "Hammer Curls" };
        //This makes the generic list in userGoal specific to the type of exercise
        public override string GetDesc() => $"arm goal: {Sort} ({Quantity} reps)"; //ooo inline data this must be a high quality app
    }
}

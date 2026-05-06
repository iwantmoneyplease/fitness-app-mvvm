using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitness_app_mvvm.Model
{
    public class GoalLeg : UserGoal
    {
        public override List<string> SortOptions => new() { "Jumping Jacks", "Squats", "Step Ups", "Running" };
        //This makes the generic list in userGoal specific to the type of exercise
        public override string GetDesc() => $"leg goal: {Sort} ({Quantity} reps)";
    }
}
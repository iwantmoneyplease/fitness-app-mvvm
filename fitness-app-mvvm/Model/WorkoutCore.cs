using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitness_app_mvvm.Model
{
    public class WorkoutCore : Workout
    {
        public WorkoutCore() : base(Type.Core)
        {

        }
        public override List<string> SortOptions => new()
        {
            "Plank",
            "Situps",
            "Russian Twist",
            "Leg Raises"
        };
        // Controlls the sorts shown in both Goal and Create

        public override string GetDesc()
        {
            return "Core workout";
        }
        public override string ToString()
        {
            return $"{Quantity} {Time} {Sort} {WorkoutType}";
        }
    }
}

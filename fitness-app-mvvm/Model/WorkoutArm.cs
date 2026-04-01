using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitness_app_mvvm.Model
{
    public class WorkoutArm : Workout
    {
        public WorkoutArm() : base(Type.Arm)
        {

        }
        public override List<string> SortOptions => new()
        {
            "Bicep Curls",
            "Tricep Dips",
            "Hammer Curls",
            "Pushdowns"
        };
        public override string GetDesc()
        {
            return "Arm workout";
        }
        public override string ToString()
        {
            return $"{Quantity} {Time} {Sort} {WorkoutType}";
        }
    }
}

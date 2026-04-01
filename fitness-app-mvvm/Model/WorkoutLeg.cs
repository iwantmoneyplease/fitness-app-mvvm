using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitness_app_mvvm.Model
{
    public class WorkoutLeg : Workout
    {
        public WorkoutLeg() : base(Type.Leg)
        {

        }
        public override List<string> SortOptions => new()
        {
            "Jumping Jacks",
            "Squats",
            "Step Ups",
            "Running"
        };
        public override string GetDesc()
        {
            return "Leg workout";
        }
        public override string ToString()
        {
            return $"{Quantity} {Time} {Sort} {WorkoutType}";
        }
    }
}

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
        public override string GetDesc()
        {
            return "This is a Truck. They usually have more than four wheels, and usually carry a maximum of 2 people, 30 if counting the trailer, another 10 if counting the roof if you're really brave.";
        }
        public override string ToString()
        {
            return $"{Quantity} {Time} {Sort} {WorkoutType}";
        }
    }
}

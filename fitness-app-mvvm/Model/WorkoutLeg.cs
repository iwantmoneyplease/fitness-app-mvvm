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
        public override string GetDesc()
        {
            return "This is a car. They have four wheels, and usually carry a maximum of five people";
        }
        public override string ToString()
        {
            return $"{RegistrationNumber} {Manufacturer} {ModelName} {ModelYear} - Bil";
        }
    }
}

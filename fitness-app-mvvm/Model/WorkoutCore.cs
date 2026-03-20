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
        public override string GetDesc()
        {
            return "This is a motorcycle. Sewilius seems like the type to own one.";
        }

        public override string ToString()
        {
            return $"{Quantity} {Time} {Sort} {WorkoutType}";
        }
    }
}

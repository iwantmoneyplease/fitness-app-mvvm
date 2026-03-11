using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitness_app_mvvm.Model
{
    public class UserGoal : User
    {
        public UserGoal() : base(Type.UserGoal)
        {

        }
        public override string GetDesc()
        {
            return "Subclass for the goals of the user";
        }

        public override string ToString()
        {
            return $"return - UserGoal";
        }
    }
}

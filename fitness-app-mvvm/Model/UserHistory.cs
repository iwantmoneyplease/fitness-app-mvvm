using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitness_app_mvvm.Model
{
    public class UserHistory : User
    {
        public UserHistory() : base(Type.UserHistory)
        {

        }
        public override string GetDesc()
        {
            return "Subclass for the done workouts of the user";
        }

        public override string ToString()
        {
            return $"return - UserHistory";
        }
    }
}

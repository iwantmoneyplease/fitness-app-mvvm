using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitness_app_mvvm.Model
{
    public class UserSettings : User
    {
        public UserSettings() : base(Type.UserSettings)
        {

        }
        public override string GetDesc()
        {
            return "Subclass for the customizations and content (username, profile picture, etc.) of the user";
        }

        public override string ToString()
        {
            return $"return - UserSettings";
        }
    }
}

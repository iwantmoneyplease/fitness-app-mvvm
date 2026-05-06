using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitness_app_mvvm.Model
{
    public class UserSettings
    {
        public string Username { get; set; } = "Pelle";
        //public string ProfilePicture { get; set; } = "";
        //public bool UseMetricSystem { get; set; } = true;
        //ifall man vill lägga till detta

        public UserSettings()
        {

        }

        public string GetDesc()
        {
            return "customize the app";
        }

        public override string ToString()
        {
            return "UserSettings";
        }
    }
}

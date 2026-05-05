using fitness_app_mvvm.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitness_app_mvvm.Model
{
    public class UserHistory : User
    {
        public ObservableCollection<Workout> Workouts { get; set; }
        public override List<string> SortOptions { get; } = new();

        public UserHistory() : base(Type.UserHistory)
        {
            Workouts = WorkoutService.Instance.WorkoutItems;
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

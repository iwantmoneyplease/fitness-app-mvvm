using System.Collections.ObjectModel;
using fitness_app_mvvm.ViewModel;

namespace fitness_app_mvvm.Model
{
    public class UserHistory
    {
        public ObservableCollection<Workout> Workouts { get; set; }

        public UserHistory()
        {
            Workouts = WorkoutService.Instance.WorkoutItems;
        }

        public string GetDesc() //nice if you want to know the nr of workouts
        {
            if (Workouts == null || Workouts.Count == 0)
                return "No workouts completed";

            return $"You have completed {Workouts.Count} workouts";
        }

        public override string ToString()
        {
            return $"UserHistory: {Workouts.Count} items";
        }
    }
}
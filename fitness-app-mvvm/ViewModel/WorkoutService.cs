using fitness_app_mvvm.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.Maui.ApplicationModel.Permissions;
using static System.Reflection.Metadata.BlobBuilder;

namespace fitness_app_mvvm.ViewModel
{
    class WorkoutService
    {
        private static WorkoutService _instance;
        public static WorkoutService Instance => _instance ??= new WorkoutService();

        //Workout items is the final destination for saved workouts
        public ObservableCollection<Workout> WorkoutItems { get; set; }

        private WorkoutService()
        {
            WorkoutItems = new ObservableCollection<Workout>();
        }
    }

}

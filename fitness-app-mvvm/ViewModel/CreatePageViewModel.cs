using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using fitness_app_mvvm.Model;

namespace fitness_app_mvvm.ViewModel
{
    public class CreatePageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string n = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(n));

        private Workout currentWorkout;

        public ObservableCollection<string> SortOptions { get; } = new();

        public bool ShowSortOptions { get; set; }

        public ICommand ArmCommand { get; }
        public ICommand LegCommand { get; }
        public ICommand CoreCommand { get; }

        public CreatePageViewModel()
        {
            ArmCommand = new Command(() => SelectWorkout(new WorkoutArm()));
            LegCommand = new Command(() => SelectWorkout(new WorkoutLeg()));
            CoreCommand = new Command(() => SelectWorkout(new WorkoutCore()));
        }

        private void SelectWorkout(Workout workout)
        {
            currentWorkout = workout;

            SortOptions.Clear();

            foreach (var option in workout.SortOptions)
            {
                SortOptions.Add(option);
            }

            ShowSortOptions = true;
            OnPropertyChanged(nameof(ShowSortOptions));
        }
    }
}
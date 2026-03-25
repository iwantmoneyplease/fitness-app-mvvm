using fitness_app_mvvm.Model;
using fitness_app_mvvm.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace fitness_app_mvvm.ViewModel
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public IList<Workout.Type> WorkoutTypes { get; } =
        Enum.GetValues(typeof(Workout.Type)).Cast<Workout.Type>().ToList();

        //PropertyChanged looks for new input
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string name = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        private readonly IWorkoutStorageService _storage;

        //INPUT (Get:Set) -------------------------------------------------------
        private string _quantity;
        public string Quantity
        {
            get => _quantity;
            set { _quantity = value; OnPropertyChanged(); }
        }

        private string _time;
        public string Time 
        {
            get => _time;
            set { _time = value; OnPropertyChanged(); }
        }

        private string _sort;
        public string Sort      
        {
            get => _sort;
            set { _sort = value; OnPropertyChanged(); }
        }

        private Workout.Type _selectedType = Workout.Type.Arm;
        public Workout.Type SelectedType
        {
            get => _selectedType;
            set { _selectedType = value; OnPropertyChanged(); }
        }

        //COMMAND AND SEARCH ----------------------------------------------------
        public ObservableCollection<Workout> Workouts => WorkoutService.Instance.WorkoutItems;

        //Commands for buttons
        public ICommand RegisterCommand { get; }
        public ICommand SaveCommand { get; }

        public MainPageViewModel()
        {
            _storage = new JsonWorkoutStorageService();

            RegisterCommand = new Command(RegisterExercise);

            SaveCommand = new Command(async () => await SaveAsync());
            _ = LoadAsync();
        }

        private async Task LoadAsync()
        {
            try
            {
                var workouts = await _storage.LoadAsync();
                Workouts.Clear();

                foreach (var workout in workouts)
                    Workouts.Add(workout);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Load failed: " + ex);
            }
        }

        private async Task SaveAsync()
        {
            await _storage.SaveAsync(Workouts);
        }

        //COMMAND METHODS ------------------------------------------------------
        private void RegisterExercise()
        {
            try
            {
                Workout workout;

                switch (SelectedType)
                {
                    case Workout.Type.Arm:
                        workout = new WorkoutLeg();
                        break;

                    case Workout.Type.Leg:
                        workout = new WorkoutCore();
                        break;

                    case Workout.Type.Core:
                        workout = new WorkoutArm();
                        break;

                    default:
                        throw new ArgumentException("Välj en giltig fordons typ");
                }

                workout.Quantity = Quantity;
                workout.Time = Time;
                workout.Sort = Sort;

                WorkoutService.Instance.WorkoutItems.Add(workout);

                //TODO Vad är detta ???
                /*
                foreach (var brum in WorkoutService.Instance.WorkoutItems)
                {
                    Debug.WriteLine($"Bilar finns i MainPage: {brum.Manufacturer}");
                }
                */

                //clear input
                ClearEntryFields();
                SaveAsync();
            }
            catch (ArgumentException ex)
            {
                //shows a friendly pop-up instead of violently exploding the program like it did before
                Application.Current.MainPage.DisplayAlert("Fel", ex.Message, "OK");
            }
        }

        public void ClearEntryFields()
        {
            Quantity = string.Empty;
            Time = string.Empty;
            Sort = string.Empty;
        }
    }
}
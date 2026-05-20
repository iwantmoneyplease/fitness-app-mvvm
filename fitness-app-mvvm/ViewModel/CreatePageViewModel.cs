using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using fitness_app_mvvm.Model;
using fitness_app_mvvm.Services;

namespace fitness_app_mvvm.ViewModel
{
    public class CreatePageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string n = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(n));

        private Workout currentWorkout;
        private readonly IWorkoutStorageService _storage;

        // Properties
        private string selectedExercise;
        public string SelectedExercise
        {
            get => selectedExercise;
            set
            {
                selectedExercise = value;
                OnPropertyChanged();
                ShowQuantityInput = true;
            }
        }


        private string time;
        public string Time
        {
            get => time;
            set
            {
                time = value;
                OnPropertyChanged();
            }
        }


        private string quantity;
        public string Quantity
        {
            get => quantity;
            set
            {
                quantity = value;
                OnPropertyChanged();
            }
        }

        // Shows the Quantity and tine in view after Sort is selected
        private bool showQuantityInput;
        public bool ShowQuantityInput
        {
            get => showQuantityInput;
            set
            {
                showQuantityInput = value;
                OnPropertyChanged();
            }
        }

        // Shows the Sort in view after Type is selected
        private bool showSortOptions;
        public bool ShowSortOptions
        {
            get => showSortOptions;
            set
            {
                showSortOptions = value;
                OnPropertyChanged();
            }
        }


        public ObservableCollection<string> SortOptions { get; } = new();
        // Command
        public ObservableCollection<Workout> Workouts => WorkoutService.Instance.WorkoutItems;
        public ICommand ArmCommand { get; }
        public ICommand LegCommand { get; }
        public ICommand CoreCommand { get; }
        public ICommand SelectExerciseCommand { get; }
        public ICommand SaveCommand { get; }

        public CreatePageViewModel()
        {
            _storage = new JsonWorkoutStorageService(); // Required for Json "Save" and "Load" Methods

            ArmCommand = new Command(() => SelectWorkout(new WorkoutArm()));
            LegCommand = new Command(() => SelectWorkout(new WorkoutLeg()));
            CoreCommand = new Command(() => SelectWorkout(new WorkoutCore()));
            // Saves the current exercise in local variable aswell as making the next option appear

            SelectExerciseCommand = new Command<string>(exercise =>
            {
                SelectedExercise = exercise;
            });

            // No longer displays saved workouts on this page
            SaveCommand = new Command(async () => await SaveWorkout());  
            _ = LoadAsync();

        }

        // Methods
        private async Task LoadAsync() // Loads from json services
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
        private async Task SaveAsync() // Saves to json services
        {
            await _storage.SaveAsync(Workouts);
        } 
        private void SelectWorkout(Workout workout)
        {
            currentWorkout = workout;

            SortOptions.Clear();

            foreach (var option in workout.SortOptions) // Can create a diffrent number of buttons based on the model
            {
                SortOptions.Add(option);
            }

            ShowSortOptions = true; // Shows the sorts 
            OnPropertyChanged(nameof(ShowSortOptions));
        }

        private async Task SaveWorkout()
        {
            if (currentWorkout == null || string.IsNullOrEmpty(SelectedExercise))
            {
                await Application.Current.MainPage.DisplayAlert("Fel", "Välj workout och övning", "OK");
                return;
            }

            currentWorkout.Sort = SelectedExercise;
            currentWorkout.Time = Time;
            currentWorkout.Quantity = Quantity;

            Workouts.Add(currentWorkout); // Summary of workout

            await SaveAsync(); // Sends workout to json file

            ClearFields();
        }
        private void ClearFields()
        {
            SelectedExercise = null;
            Time = string.Empty;
            Quantity = string.Empty;
            ShowQuantityInput = false;
            ShowSortOptions = false;

            OnPropertyChanged(nameof(ShowSortOptions));
        }
    }
}
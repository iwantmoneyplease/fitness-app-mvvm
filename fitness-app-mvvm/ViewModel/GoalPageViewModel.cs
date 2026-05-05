using fitness_app_mvvm.Model;
using fitness_app_mvvm.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;

namespace fitness_app_mvvm.ViewModel
{
    public class GoalPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string n = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(n));

        private readonly IGoalStorageService _storage;

        public ObservableCollection<UserGoal> Goals => GoalService.Instance.GoalItems;

        private string goalText;
        public string GoalText
        {
            get => goalText;
            set { goalText = value; OnPropertyChanged(); }
        }

        public ICommand SaveGoalCommand { get; }

        public GoalPageViewModel()
        {
            _storage = new JsonGoalStorageService();

            SaveGoalCommand = new Command(async () => await SaveGoal());
            _ = LoadAsync();
        }

        private async Task LoadAsync()
        {
            var goals = await _storage.LoadAsync();
            Goals.Clear();

            foreach (var g in goals)
                Goals.Add(g);
        }

        private async Task SaveAsync()
        {
            await _storage.SaveAsync(Goals);
        }

        private async Task SaveGoal()
        {
            if (string.IsNullOrWhiteSpace(GoalText))
                return;

            var goal = new UserGoal();

            Goals.Add(goal);

            await SaveAsync();

            GoalText = string.Empty;
        }
    }
}

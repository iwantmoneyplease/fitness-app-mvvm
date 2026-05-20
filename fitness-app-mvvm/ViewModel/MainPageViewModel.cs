using fitness_app_mvvm.Model;
using fitness_app_mvvm.Services;
using fitness_app_mvvm.View;
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

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string name = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        public string DisplayName => App.CurrentUser.Settings.Username; 
        // Returns direct from SettingsPageViewModel

        public ObservableCollection<Workout> Workouts => App.CurrentUser.History.Workouts;
        public string SummaryText => App.CurrentUser.History.GetDesc();

        // Refresh the summary text
        public void Refresh()
        {
            OnPropertyChanged(nameof(DisplayName));
            OnPropertyChanged(nameof(Workouts));
            OnPropertyChanged(nameof(SummaryText));
        }
    }
}

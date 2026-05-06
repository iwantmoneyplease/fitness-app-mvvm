using fitness_app_mvvm.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace fitness_app_mvvm.ViewModel
{
    public class HistoryPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Workout> Workouts => App.CurrentUser.History.Workouts;

        public string SummaryText => App.CurrentUser.History.GetDesc();

        public HistoryPageViewModel()
        {
        }
    }
}
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
    public class SettingsPageViewModel : INotifyPropertyChanged
    {
        public string Username
        {
            get => App.CurrentUser.Settings.Username;
            set
            {
                App.CurrentUser.Settings.Username = value;
                OnPropertyChanged();
            }
        }

        //public bool IsMetric
        //{
        //    get => App.CurrentUser.Settings.IsMetric;
        //    set { App.CurrentUser.Settings.IsMetric = value; OnPropertyChanged(); }
        //}

                public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string name = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
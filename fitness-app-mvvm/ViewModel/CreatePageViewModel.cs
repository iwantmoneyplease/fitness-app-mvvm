using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace fitness_app_mvvm.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        //PropertyChanged looks for new input
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string name = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        //  GETS AND SETS

        private bool showCoffeeOptions;
        public bool ShowCoffeeOptions
        {
            get => showCoffeeOptions;
            set => SetProperty(ref showCoffeeOptions, value);
        }

        private bool showTeaOptions;
        public bool ShowTeaOptions
        {
            get => showTeaOptions;
            set => SetProperty(ref showTeaOptions, value);
        }

        public ICommand CoffeeCommand { get; }
        public ICommand TeaCommand { get; }

        public MainViewModel()
        {
            CoffeeCommand = new Command(() =>
            {
                ShowCoffeeOptions = true;
                ShowTeaOptions = false;
            });

            TeaCommand = new Command(() =>
            {
                ShowTeaOptions = true;
                ShowCoffeeOptions = false;
            });
        }
    }
}

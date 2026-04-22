using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

//Full Chatgpt kod
//Detta är länken till konversationen: https://chatgpt.com/share/69b19551-bf10-8013-9e70-1f69e97d7a37
namespace fitness_app_mvvm.ViewModel
{
    public class SettingsPageViewModel : INotifyPropertyChanged
    {
        //PropertyChanged looks for new input
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string name = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        /*
        public ObservableCollection<Type> Types { get; } = new();
        public ObservableCollection<string> Properties { get; } = new();

        public Type SelectedType { get; set; }
        public string SelectedProperty { get; set; }

        public ICommand SelectTypeCommand { get; }
        public ICommand SelectPropertyCommand { get; }

        public TypeSelectorViewModel()
        {
            Types.Add(typeof(Person));
            Types.Add(typeof(Product));

            SelectTypeCommand = new Command<Type>(OnTypeSelected);
            SelectPropertyCommand = new Command<string>(OnPropertySelected);
        }

        void OnTypeSelected(Type type)
        {
            SelectedType = type;

            Properties.Clear();

            var props = type.GetProperties();

            foreach (var prop in props)
                Properties.Add(prop.Name);
        }

        void OnPropertySelected(string property)
        {
            SelectedProperty = property;

            // Here you now have BOTH values
            SaveSelection();
        }

        void SaveSelection()
        {
            Console.WriteLine($"Type: {SelectedType.Name}, Sort: {SelectedProperty}");
        }*/
    }
}

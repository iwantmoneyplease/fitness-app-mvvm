using System.Collections.ObjectModel;
using System.Windows.Input;

public class MainViewModel : BaseViewModel
{
    private readonly DrinkModel _model = new();

    public ObservableCollection<DrinkType> DrinkOptions { get; set; }
        = new();

    private bool showOptions;
    public bool ShowOptions
    {
        get => showOptions;
        set => SetProperty(ref showOptions, value);
    }

    public ICommand CoffeeCommand { get; }
    public ICommand TeaCommand { get; }

    public MainViewModel()
    {
        CoffeeCommand = new Command(() =>
        {
            DrinkOptions.Clear();
            foreach (var item in _model.CoffeeTypes)
                DrinkOptions.Add(item);

            ShowOptions = true;
        });

        TeaCommand = new Command(() =>
        {
            DrinkOptions.Clear();
            foreach (var item in _model.TeaTypes)
                DrinkOptions.Add(item);

            ShowOptions = true;
        });
    }
}
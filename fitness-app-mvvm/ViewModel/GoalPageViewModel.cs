using fitness_app_mvvm.Model;
using fitness_app_mvvm.Services;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

public class GoalPageViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;
    void OnPropertyChanged([CallerMemberName] string n = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(n));

    private UserGoal currentGoal;

    public ObservableCollection<UserGoal> Goals => GoalService.Instance.GoalItems;

    public ObservableCollection<string> SortOptions { get; } = new();

    public ICommand ArmCommand { get; }
    public ICommand LegCommand { get; }
    public ICommand CoreCommand { get; }
    public ICommand SelectGoalCommand { get; }
    public ICommand SaveGoalCommand { get; }

    private string selectedSort;
    public string SelectedSort
    {
        get => selectedSort;
        set { selectedSort = value; OnPropertyChanged(); }
    }

    public string Time { get; set; }
    public string Quantity { get; set; }

    public bool ShowSortOptions { get; set; }
    public bool ShowInput { get; set; }

    public GoalPageViewModel()
    {
        ArmCommand = new Command(() => SelectGoal(new GoalArm()));
        LegCommand = new Command(() => SelectGoal(new GoalLeg()));
        CoreCommand = new Command(() => SelectGoal(new GoalCore()));

        SelectGoalCommand = new Command<string>(s =>
        {
            SelectedSort = s;
            ShowInput = true;
            OnPropertyChanged(nameof(ShowInput));
        });

        SaveGoalCommand = new Command(SaveGoal);
    }

    private void SelectGoal(UserGoal goal)
    {
        currentGoal = goal;

        SortOptions.Clear();
        foreach (var s in goal.SortOptions)
            SortOptions.Add(s);

        ShowSortOptions = true;
        OnPropertyChanged(nameof(ShowSortOptions));
    }

    private void SaveGoal()
    {
        if (currentGoal == null || string.IsNullOrEmpty(SelectedSort))
            return;

        currentGoal.Sort = SelectedSort;
        currentGoal.Time = Time;
        currentGoal.Quantity = Quantity;

        Goals.Add(currentGoal);

        // reset
        SelectedSort = null;
        Time = string.Empty;
        Quantity = string.Empty;
        ShowInput = false;
        ShowSortOptions = false;

        OnPropertyChanged(nameof(ShowInput));
        OnPropertyChanged(nameof(ShowSortOptions));
    }
}
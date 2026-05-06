namespace fitness_app_mvvm;

using fitness_app_mvvm.Model;

public partial class App : Application
{
    public static User CurrentUser { get; set; }

    public App()
    {
        InitializeComponent();

        CurrentUser = new User();

        MainPage = new AppShell();
    }
}
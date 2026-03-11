using fitness_app_mvvm.ViewModel;
using fitness_app_mvvm.View;

namespace fitness_app_mvvm.View
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }
    }
}

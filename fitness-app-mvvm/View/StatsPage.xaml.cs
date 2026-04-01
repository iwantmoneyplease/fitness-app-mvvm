using fitness_app_mvvm.ViewModel;
using fitness_app_mvvm.View;

namespace fitness_app_mvvm.View
{
    public partial class StatsPage : ContentPage
    {
        public StatsPage()
        {
            InitializeComponent();
            BindingContext = new UserHistoryViewModel();
        }
    }
}

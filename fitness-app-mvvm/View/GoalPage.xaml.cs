using fitness_app_mvvm.ViewModel;
using fitness_app_mvvm.View;

namespace fitness_app_mvvm.View
{
    public partial class GoalPage : ContentPage
    {
        public GoalPage()
        {
            InitializeComponent();
            BindingContext = new GoalPageViewModel();
        }
    }
}

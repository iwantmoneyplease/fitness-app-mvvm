using fitness_app_mvvm.ViewModel;
using fitness_app_mvvm.View;

namespace fitness_app_mvvm.View
{
    public partial class HistoryPage : ContentPage
    {
        public HistoryPage()
        {
            InitializeComponent();
            BindingContext = new HistoryPageViewModel();
        }
    }
}

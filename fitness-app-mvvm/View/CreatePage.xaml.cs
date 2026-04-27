using fitness_app_mvvm.ViewModel;
using fitness_app_mvvm.View;

namespace fitness_app_mvvm.View
{
    public partial class CreatePage : ContentPage
    {
        public CreatePage()
        {
            InitializeComponent();
            BindingContext = new CreatePageViewModel();
        }                   
    }
}

using fitness_app_mvvm.ViewModel;
using fitness_app_mvvm.View;

namespace fitness_app_mvvm.View
{
    public partial class UserHistory : User
    {
        public UserHistory()
        {
            InitializeComponent();
            BindingContext = new UserHistoryViewModel();
        }
    }
}

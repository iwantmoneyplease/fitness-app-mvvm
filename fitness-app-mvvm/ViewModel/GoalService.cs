using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using fitness_app_mvvm.Model;

namespace fitness_app_mvvm.Services
{
    public class GoalService
    {
        private static GoalService instance;

        public static GoalService Instance => instance ??= new GoalService();

        //Goal items is the final destination for saved goals
        public ObservableCollection<UserGoal> GoalItems { get; } = new();
    }
}

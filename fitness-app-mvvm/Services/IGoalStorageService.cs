using fitness_app_mvvm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitness_app_mvvm.Services
{
    public interface IGoalStorageService
    {
        Task<IList<UserGoal>> LoadAsync();
        Task SaveAsync(IEnumerable<UserGoal> goals);
    }
}
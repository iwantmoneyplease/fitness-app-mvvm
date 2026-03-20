using fitness_app_mvvm.Model;

namespace fitness_app_mvvm.Services
{
    // poängen med detta interface är att vi enkelt ska kunna byta Json till något annat, som SQLite
    public interface IWorkoutStorageService
    {
        Task SaveAsync(IEnumerable<Workout> workouts);
        Task<IList<Workout>> LoadAsync();
    }
}

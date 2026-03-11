using fitness_app_mvvm.Model;

namespace fitness_app_mvvm.Services
{
    // poängen med detta interface är att vi enkelt ska kunna byta Json till något annat, som SQLite
    public interface IVehicleStorageService
    {
        Task SaveAsync(IEnumerable<Workout> vehicles);
        Task<IList<Workout>> LoadAsync();
    }
}

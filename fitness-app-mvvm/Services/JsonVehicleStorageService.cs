using System.Text.Json;
using fitness_app_mvvm.Model;

namespace fitness_app_mvvm.Services
{
    public class JsonVehicleStorageService : IVehicleStorageService
    {
        private readonly string _filePath;

        public JsonVehicleStorageService()
        {
            _filePath = Path.Combine(
                FileSystem.AppDataDirectory,
                "vehicles.json");
        }

        public async Task SaveAsync(IEnumerable<Workout> vehicles)
        {
            var json = JsonSerializer.Serialize(vehicles,
                new JsonSerializerOptions { WriteIndented = true });

            await File.WriteAllTextAsync(_filePath, json);
        }

        public async Task<IList<Workout>> LoadAsync()
        {
            if (!File.Exists(_filePath))
                return new List<Workout>();

            var json = await File.ReadAllTextAsync(_filePath);
            return JsonSerializer.Deserialize<List<Workout>>(json)
                   ?? new List<Workout>();
        }
    }
}

using System.Text.Json;
using fitness_app_mvvm.Model;

namespace fitness_app_mvvm.Services
{
    public class JsonWorkoutStorageService : IWorkoutStorageService
    {
        private readonly string _filePath;

        public JsonWorkoutStorageService()
        {
            _filePath = Path.Combine(
                FileSystem.AppDataDirectory,
                "workouts.json");
        }

        public async Task SaveAsync(IEnumerable<Workout> workouts)
        {
            var json = JsonSerializer.Serialize(workouts,
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

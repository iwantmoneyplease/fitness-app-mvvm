using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using fitness_app_mvvm.Model;

namespace fitness_app_mvvm.Services
{
    public class JsonGoalStorageService : IGoalStorageService
    {
        private readonly string _filePath;

        public JsonGoalStorageService()
        {
            _filePath = Path.Combine(
                FileSystem.AppDataDirectory,
                "goals.json");
        }

        public async Task SaveAsync(IEnumerable<UserGoal> goals)
        {
            var json = JsonSerializer.Serialize(goals,
                new JsonSerializerOptions { WriteIndented = true });

            await File.WriteAllTextAsync(_filePath, json);
        }

        public async Task<IList<UserGoal>> LoadAsync()
        {
            if (!File.Exists(_filePath))
                return new List<UserGoal>();

            var json = await File.ReadAllTextAsync(_filePath);
            return JsonSerializer.Deserialize<List<UserGoal>>(json)
                   ?? new List<UserGoal>();
        }
    }
}
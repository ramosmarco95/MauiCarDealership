using System.Reflection;
using System.Text.Json;
using SortOfNewCarsApp.Models;

namespace SortOfNewCarsApp.Services
{
    public class CarService
    {
        private const string CarsFile = "SortOfNewCarsApp.Resources.cars.json";

        public async Task<IEnumerable<Car>> GetCarsAsync()
        {
            var assembly = Assembly.GetExecutingAssembly();
            using Stream? stream = assembly.GetManifestResourceStream(CarsFile);
            if (stream == null)
                return new List<Car>();

            using StreamReader reader = new StreamReader(stream);
            var json = await reader.ReadToEndAsync();
            return JsonSerializer.Deserialize<List<Car>>(json) ?? new List<Car>();
        }
    }
}

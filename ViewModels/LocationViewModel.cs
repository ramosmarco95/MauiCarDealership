using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SortOfNewCarsApp.ViewModels
{
    public partial class LocationViewModel : ObservableObject
    {
        [ObservableProperty]
        private string address = "9101 Fairview Ave, Boise, ID 83704";

        [ObservableProperty]
        private string locationImage = "location_toyota.png"; 


        [RelayCommand]
        private async Task OpenInMapsAsync()
        {
            try
            {
                // Open Google Maps using address
                string mapsUrl = $"https://www.google.com/maps/search/?api=1&query={Uri.EscapeDataString(Address)}";
                await Launcher.OpenAsync(mapsUrl);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error opening maps: {ex.Message}");
            }
        }
    }
}

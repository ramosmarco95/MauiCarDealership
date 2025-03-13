using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using SortOfNewCarsApp.Services;
using SortOfNewCarsApp.Views;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Car = SortOfNewCarsApp.Models.Car;



namespace SortOfNewCarsApp.ViewModels
{
    public partial class CarInventoryViewModel : ObservableObject
    {
        private readonly CarService _carService;
        public ICommand ShowCarDetailsCommand { get; }

        [ObservableProperty]
        private ObservableCollection<Car> cars = new();

        public CarInventoryViewModel(CarService carService)
        {
            _carService = carService ?? throw new ArgumentNullException(nameof(carService));
            _ = InitializeAsyc();
            ShowCarDetailsCommand = new Command<Car>(ShowCarDetails);
        }

        private async Task InitializeAsyc()
        {
            await LoadCarsAsync();
        }

        private async Task LoadCarsAsync()
        {
            try 
            {
                var carList = await _carService.GetCarsAsync();
                if (carList != null && carList.Any())
                {
                    Cars = new ObservableCollection<Car>(carList);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void ShowCarDetails(Car selectedCar)
        {
            if (selectedCar == null) return;

            var popup = new CarDetailsPopup(selectedCar);
            Shell.Current.CurrentPage.ShowPopup(popup); 
        }

        

    }
}


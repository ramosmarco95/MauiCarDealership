using SortOfNewCarsApp.ViewModels;
namespace SortOfNewCarsApp.Views;

public partial class InventoryPage : ContentPage
{
    
    public InventoryPage(CarInventoryViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
		
	}

    private async void GoHome_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//home");
    }
}
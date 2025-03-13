namespace SortOfNewCarsApp.Views;
public partial class MainPage : ContentPage
{
   
    public MainPage()
	{
		InitializeComponent();
       
    }

    private async void OnInventoryClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//inventory");
    }

    private async void OnLocationClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//location");
    }
}
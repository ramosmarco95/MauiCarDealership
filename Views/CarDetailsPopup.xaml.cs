using CommunityToolkit.Maui.Views;
using SortOfNewCarsApp.Models;
namespace SortOfNewCarsApp.Views;


public partial class CarDetailsPopup : Popup
{
	public CarDetailsPopup(Car selectedCar)
	{
		InitializeComponent();
		BindingContext = selectedCar;
	}
    private void ClosePopup(object sender, EventArgs e)
    {
        Close(); 
    }
}
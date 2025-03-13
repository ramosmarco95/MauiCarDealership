using SortOfNewCarsApp.Views;
namespace SortOfNewCarsApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(InventoryPage), typeof(InventoryPage));
        Routing.RegisterRoute(nameof(LocationPage), typeof(LocationPage));
    }
}

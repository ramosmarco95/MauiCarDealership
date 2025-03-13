using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using SortOfNewCarsApp.Services;
using SortOfNewCarsApp.ViewModels;
using SortOfNewCarsApp.Views;

namespace SortOfNewCarsApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.UseMauiMaps()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
        builder.UseMauiApp<App>().ConfigureFonts().UseMauiCommunityToolkit();

        builder.Logging.AddDebug();
#endif
		builder.Services.AddSingleton<CarService>();
        builder.Services.AddTransient<CarInventoryViewModel>();
        builder.Services.AddTransient<InventoryPage>();
		builder.Services.AddTransient<LocationViewModel>();
        builder.Services.AddTransient<LocationPage>();

        return builder.Build();
	}
}

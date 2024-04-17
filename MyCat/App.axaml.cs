using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using MyCat.ViewModels;
using MyCat.Views;
using Splat;

namespace MyCat;

public partial class App : Application
{
    public override void Initialize()
    {
        
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow
            {
                DataContext = ServicesRegistration.Resolve<MainViewModel>()
            };
        }
        else if (ApplicationLifetime is ISingleViewApplicationLifetime singleViewPlatform)
        {
            singleViewPlatform.MainView = new MainView
            {
                DataContext = ServicesRegistration.Resolve<MainViewModel>()
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
}
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using shanPro.Views;

namespace shanPro;

public partial class App : Application
{
    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new NavigationPage(new MainPage()));
    }
}

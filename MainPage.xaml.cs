using Microsoft.Maui.Controls;
using shanPro.Views;

namespace shanPro;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OpenTerminalClick(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TerminalPage());
    }
}

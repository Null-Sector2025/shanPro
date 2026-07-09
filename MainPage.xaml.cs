namespace shanPro;
using Views;

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

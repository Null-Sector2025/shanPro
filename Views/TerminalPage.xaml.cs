using Microsoft.Maui.Controls;
using shanPro.Models;
using shanPro.Services;

namespace shanPro.Views;

public partial class TerminalPage : ContentPage
{
    private readonly TerminalService _shellService;
    private readonly TerminalSession _session;

    public TerminalPage()
    {
        InitializeComponent();
        _shellService = new TerminalService();
        _session = new TerminalSession();
        AppendOutput("shanPro C# Terminal v1.0\r\n输入命令执行，仿Termux本地Shell\r\n");
    }

    private async void OnCommandEnter(object sender, EventArgs e)
    {
        string cmd = CmdInput.Text?.Trim() ?? "";
        if (string.IsNullOrEmpty(cmd)) return;

        AppendOutput($"{_session.WorkDir} $ {cmd}\r\n");
        string result = await _shellService.RunCommand(cmd, _session.WorkDir);
        AppendOutput(result + "\r\n");
        CmdInput.Text = "";
    }

    private void AppendOutput(string text)
    {
        TerminalOutput.Text += text;
    }
}

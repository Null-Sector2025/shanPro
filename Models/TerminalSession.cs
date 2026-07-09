namespace shanPro.Models;

/// <summary>
/// 终端会话存储（工作目录、历史命令，仿Termux会话）
/// </summary>
public class TerminalSession
{
    public string WorkDir { get; set; } = Android.OS.Environment.ExternalStorageDirectory.AbsolutePath;
    public List<string> CommandHistory { get; set; } = new();
}

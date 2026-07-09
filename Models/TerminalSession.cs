using Android.OS;
using System.Collections.Generic;

namespace shanPro.Models;

public class TerminalSession
{
    // 明确指定 Android.OS.Environment，消除歧义
    public string WorkDir { get; set; } = Android.OS.Environment.ExternalStorageDirectory.AbsolutePath;
    public List<string> CommandHistory { get; set; } = new();
}

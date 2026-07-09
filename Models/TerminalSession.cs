using Android.OS;
using System.Collections.Generic;

namespace shanPro.Models;

public class TerminalSession
{
    public string WorkDir { get; set; } = Android.OS.Environment.ExternalStorageDirectory?.AbsolutePath ?? "/storage/emulated/0";
    public List<string> CommandHistory { get; set; } = new();
}

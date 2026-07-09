using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace shanPro.Services;

/// <summary>
/// C#实现安卓本地Shell命令执行，复刻Termux执行逻辑
/// </summary>
public class TerminalService
{
    public async Task<string> RunCommand(string command, string workingDir)
    {
        try
        {
            Process proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "/system/bin/sh",
                    Arguments = $"-c \"{command}\"",
                    WorkingDirectory = workingDir,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            proc.Start();
            string output = await proc.StandardOutput.ReadToEndAsync();
            string err = await proc.StandardError.ReadToEndAsync();
            proc.WaitForExit();

            return output + err;
        }
        catch (Exception ex)
        {
            return $"执行失败: {ex.Message}";
        }
    }
}

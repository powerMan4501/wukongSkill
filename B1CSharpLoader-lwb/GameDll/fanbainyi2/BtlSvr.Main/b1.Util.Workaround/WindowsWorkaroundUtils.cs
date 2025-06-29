using System;
using System.Diagnostics;
using System.IO;
using UnrealEngine.Runtime;

namespace b1.Util.Workaround;

public class WindowsWorkaroundUtils
{
	public static bool RequireNetListenAllow()
	{
		string text = FPaths.Combine(FPaths.ProjectSavedDir, "AllowNetListen.done");
		if (FPaths.FileExists(text))
		{
			return true;
		}
		string contents = "@echo off\r\n%1 mshta vbscript:CreateObject(\"Shell.Application\").ShellExecute(\"cmd.exe\",\"/c %~s0 ::\",\"\",\"runas\",1)(window.close)&&exit cd /d \"%~dp0\"\r\nnetsh advfirewall firewall delete rule name=\"b1_game_net\" 1>nul 2>nul\r\nnetsh advfirewall firewall add rule name=\"b1_game_net\" dir=in action=allow protocol=UDP localport=7777-7790\r\nif \"%errorlevel%\" == \"0\" (\r\n    echo success\r\n    EXIT /B 0\r\n) else (\r\n    echo fail\r\n    EXIT /B 1\r\n)\r\n";
		string text2 = Path.Combine(Path.GetTempPath(), "AllowGameNetListen.bat");
		File.WriteAllText(text2, contents);
		Process.Start(new ProcessStartInfo
		{
			FileName = "cmd.exe",
			WindowStyle = ProcessWindowStyle.Hidden,
			Arguments = "/C \"" + text2 + "\""
		}).WaitForExit();
		File.WriteAllText(text, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") ?? "");
		return true;
	}
}

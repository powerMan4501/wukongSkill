using System.Security;
using System.Security.Permissions;
using System.Threading;
using Microsoft.Win32;

namespace System.Net;

internal static class ComNetOS
{
	private const string OSInstallTypeRegKey = "Software\\Microsoft\\Windows NT\\CurrentVersion";

	private const string OSInstallTypeRegKeyPath = "HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows NT\\CurrentVersion";

	private const string OSInstallTypeRegName = "InstallationType";

	private const string InstallTypeStringClient = "Client";

	private const string InstallTypeStringServer = "Server";

	private const string InstallTypeStringServerCore = "Server Core";

	private const string InstallTypeStringEmbedded = "Embedded";

	internal static readonly bool IsAspNetServer;

	internal static readonly bool IsWin7orLater;

	internal static readonly bool IsWin7Sp1orLater;

	internal static readonly bool IsWin8orLater;

	internal static readonly WindowsInstallationType InstallationType;

	[EnvironmentPermission(SecurityAction.Assert, Unrestricted = true)]
	static ComNetOS()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		try
		{
			IsAspNetServer = Thread.GetDomain().GetData(".appDomain") != null;
		}
		catch
		{
		}
		IsWin7orLater = oSVersion.Version >= new Version(6, 1);
		IsWin7Sp1orLater = oSVersion.Version >= new Version(6, 1, 7601);
		IsWin8orLater = oSVersion.Version >= new Version(6, 2);
		InstallationType = GetWindowsInstallType();
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.Web, SR.GetString("net_osinstalltype", InstallationType));
		}
	}

	[RegistryPermission(SecurityAction.Assert, Read = "HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows NT\\CurrentVersion")]
	private static WindowsInstallationType GetWindowsInstallType()
	{
		try
		{
			using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion");
			string text = registryKey.GetValue("InstallationType") as string;
			if (string.IsNullOrEmpty(text))
			{
				if (Logging.On)
				{
					Logging.PrintWarning(Logging.Web, SR.GetString("net_empty_osinstalltype", "Software\\Microsoft\\Windows NT\\CurrentVersion\\InstallationType"));
				}
				return WindowsInstallationType.Unknown;
			}
			if (string.Compare(text, "Client", StringComparison.OrdinalIgnoreCase) == 0)
			{
				return WindowsInstallationType.Client;
			}
			if (string.Compare(text, "Server", StringComparison.OrdinalIgnoreCase) == 0)
			{
				return WindowsInstallationType.Server;
			}
			if (string.Compare(text, "Server Core", StringComparison.OrdinalIgnoreCase) == 0)
			{
				return WindowsInstallationType.ServerCore;
			}
			if (string.Compare(text, "Embedded", StringComparison.OrdinalIgnoreCase) == 0)
			{
				return WindowsInstallationType.Embedded;
			}
			if (Logging.On)
			{
				Logging.PrintError(Logging.Web, SR.GetString("net_unknown_osinstalltype", text));
			}
			return WindowsInstallationType.Unknown;
		}
		catch (UnauthorizedAccessException ex)
		{
			if (Logging.On)
			{
				Logging.PrintWarning(Logging.Web, SR.GetString("net_cant_determine_osinstalltype", "Software\\Microsoft\\Windows NT\\CurrentVersion", ex.Message));
			}
			return WindowsInstallationType.Unknown;
		}
		catch (SecurityException ex2)
		{
			if (Logging.On)
			{
				Logging.PrintWarning(Logging.Web, SR.GetString("net_cant_determine_osinstalltype", "Software\\Microsoft\\Windows NT\\CurrentVersion", ex2.Message));
			}
			return WindowsInstallationType.Unknown;
		}
	}
}

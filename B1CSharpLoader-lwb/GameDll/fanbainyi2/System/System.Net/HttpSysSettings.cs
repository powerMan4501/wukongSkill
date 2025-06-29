using System.Globalization;
using System.IO;
using System.Security;
using System.Security.Permissions;
using Microsoft.Win32;

namespace System.Net;

internal static class HttpSysSettings
{
	private const string httpSysParametersKey = "System\\CurrentControlSet\\Services\\HTTP\\Parameters";

	private const bool enableNonUtf8Default = true;

	private const bool favorUtf8Default = true;

	private const string enableNonUtf8Name = "EnableNonUtf8";

	private const string favorUtf8Name = "FavorUtf8";

	private static volatile bool enableNonUtf8;

	private static volatile bool favorUtf8;

	public static bool EnableNonUtf8 => enableNonUtf8;

	public static bool FavorUtf8 => favorUtf8;

	static HttpSysSettings()
	{
		enableNonUtf8 = true;
		favorUtf8 = true;
		ReadHttpSysRegistrySettings();
	}

	[RegistryPermission(SecurityAction.Assert, Read = "HKEY_LOCAL_MACHINE\\System\\CurrentControlSet\\Services\\HTTP\\Parameters")]
	private static void ReadHttpSysRegistrySettings()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("System\\CurrentControlSet\\Services\\HTTP\\Parameters");
			if (registryKey == null)
			{
				LogWarning("ReadHttpSysRegistrySettings", "net_log_listener_httpsys_registry_null", "System\\CurrentControlSet\\Services\\HTTP\\Parameters");
				return;
			}
			using (registryKey)
			{
				enableNonUtf8 = ReadRegistryValue(registryKey, "EnableNonUtf8", defaultValue: true);
				favorUtf8 = ReadRegistryValue(registryKey, "FavorUtf8", defaultValue: true);
			}
		}
		catch (SecurityException e)
		{
			LogRegistryException("ReadHttpSysRegistrySettings", e);
		}
		catch (ObjectDisposedException e2)
		{
			LogRegistryException("ReadHttpSysRegistrySettings", e2);
		}
	}

	private static bool ReadRegistryValue(RegistryKey key, string valueName, bool defaultValue)
	{
		try
		{
			if (key.GetValueKind(valueName) == RegistryValueKind.DWord)
			{
				return Convert.ToBoolean(key.GetValue(valueName), CultureInfo.InvariantCulture);
			}
		}
		catch (UnauthorizedAccessException e)
		{
			LogRegistryException("ReadRegistryValue", e);
		}
		catch (IOException e2)
		{
			LogRegistryException("ReadRegistryValue", e2);
		}
		catch (SecurityException e3)
		{
			LogRegistryException("ReadRegistryValue", e3);
		}
		catch (ObjectDisposedException e4)
		{
			LogRegistryException("ReadRegistryValue", e4);
		}
		return defaultValue;
	}

	private static void LogRegistryException(string methodName, Exception e)
	{
		LogWarning(methodName, "net_log_listener_httpsys_registry_error", "System\\CurrentControlSet\\Services\\HTTP\\Parameters", e);
	}

	private static void LogWarning(string methodName, string message, params object[] args)
	{
		if (Logging.On)
		{
			Logging.PrintWarning(Logging.HttpListener, typeof(HttpSysSettings), methodName, SR.GetString(message, args));
		}
	}
}

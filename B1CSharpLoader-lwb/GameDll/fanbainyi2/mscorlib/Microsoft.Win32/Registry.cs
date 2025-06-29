using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Win32;

[ComVisible(true)]
public static class Registry
{
	public static readonly RegistryKey CurrentUser;

	public static readonly RegistryKey LocalMachine;

	public static readonly RegistryKey ClassesRoot;

	public static readonly RegistryKey Users;

	public static readonly RegistryKey PerformanceData;

	public static readonly RegistryKey CurrentConfig;

	[Obsolete("The DynData registry key only works on Win9x, which is no longer supported by the CLR.  On NT-based operating systems, use the PerformanceData registry key instead.")]
	public static readonly RegistryKey DynData;

	[SecuritySafeCritical]
	static Registry()
	{
		CurrentUser = RegistryKey.GetBaseKey(RegistryKey.HKEY_CURRENT_USER);
		LocalMachine = RegistryKey.GetBaseKey(RegistryKey.HKEY_LOCAL_MACHINE);
		ClassesRoot = RegistryKey.GetBaseKey(RegistryKey.HKEY_CLASSES_ROOT);
		Users = RegistryKey.GetBaseKey(RegistryKey.HKEY_USERS);
		PerformanceData = RegistryKey.GetBaseKey(RegistryKey.HKEY_PERFORMANCE_DATA);
		CurrentConfig = RegistryKey.GetBaseKey(RegistryKey.HKEY_CURRENT_CONFIG);
		DynData = RegistryKey.GetBaseKey(RegistryKey.HKEY_DYN_DATA);
	}

	[SecurityCritical]
	private static RegistryKey GetBaseKeyFromKeyName(string keyName, out string subKeyName)
	{
		if (keyName == null)
		{
			throw new ArgumentNullException("keyName");
		}
		int num = keyName.IndexOf('\\');
		string text = ((num == -1) ? keyName.ToUpper(CultureInfo.InvariantCulture) : keyName.Substring(0, num).ToUpper(CultureInfo.InvariantCulture));
		RegistryKey registryKey = null;
		registryKey = text switch
		{
			"HKEY_CURRENT_USER" => CurrentUser, 
			"HKEY_LOCAL_MACHINE" => LocalMachine, 
			"HKEY_CLASSES_ROOT" => ClassesRoot, 
			"HKEY_USERS" => Users, 
			"HKEY_PERFORMANCE_DATA" => PerformanceData, 
			"HKEY_CURRENT_CONFIG" => CurrentConfig, 
			"HKEY_DYN_DATA" => RegistryKey.GetBaseKey(RegistryKey.HKEY_DYN_DATA), 
			_ => throw new ArgumentException(Environment.GetResourceString("Arg_RegInvalidKeyName", "keyName")), 
		};
		if (num == -1 || num == keyName.Length)
		{
			subKeyName = string.Empty;
		}
		else
		{
			subKeyName = keyName.Substring(num + 1, keyName.Length - num - 1);
		}
		return registryKey;
	}

	[SecuritySafeCritical]
	public static object GetValue(string keyName, string valueName, object defaultValue)
	{
		string subKeyName;
		RegistryKey baseKeyFromKeyName = GetBaseKeyFromKeyName(keyName, out subKeyName);
		RegistryKey registryKey = baseKeyFromKeyName.OpenSubKey(subKeyName);
		if (registryKey == null)
		{
			return null;
		}
		try
		{
			return registryKey.GetValue(valueName, defaultValue);
		}
		finally
		{
			registryKey.Close();
		}
	}

	public static void SetValue(string keyName, string valueName, object value)
	{
		SetValue(keyName, valueName, value, RegistryValueKind.Unknown);
	}

	[SecuritySafeCritical]
	public static void SetValue(string keyName, string valueName, object value, RegistryValueKind valueKind)
	{
		string subKeyName;
		RegistryKey baseKeyFromKeyName = GetBaseKeyFromKeyName(keyName, out subKeyName);
		RegistryKey registryKey = baseKeyFromKeyName.CreateSubKey(subKeyName);
		try
		{
			registryKey.SetValue(valueName, value, valueKind);
		}
		finally
		{
			registryKey.Close();
		}
	}
}

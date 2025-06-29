using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Policy;

namespace System.Security.Util;

internal static class Config
{
	private static volatile string m_machineConfig;

	private static volatile string m_userConfig;

	internal static string MachineDirectory
	{
		[SecurityCritical]
		get
		{
			GetFileLocales();
			return m_machineConfig;
		}
	}

	internal static string UserDirectory
	{
		[SecurityCritical]
		get
		{
			GetFileLocales();
			return m_userConfig;
		}
	}

	[SecurityCritical]
	private static void GetFileLocales()
	{
		if (m_machineConfig == null)
		{
			string s = null;
			GetMachineDirectory(JitHelpers.GetStringHandleOnStack(ref s));
			m_machineConfig = s;
		}
		if (m_userConfig == null)
		{
			string s2 = null;
			GetUserDirectory(JitHelpers.GetStringHandleOnStack(ref s2));
			m_userConfig = s2;
		}
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern int SaveDataByte(string path, [In] byte[] data, int length);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern bool RecoverData(ConfigId id);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern void SetQuickCache(ConfigId id, QuickCacheEntryType quickCacheFlags);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool GetCacheEntry(ConfigId id, int numKey, [In] byte[] key, int keyLength, ObjectHandleOnStack retData);

	[SecurityCritical]
	internal static bool GetCacheEntry(ConfigId id, int numKey, byte[] key, out byte[] data)
	{
		byte[] o = null;
		bool cacheEntry = GetCacheEntry(id, numKey, key, key.Length, JitHelpers.GetObjectHandleOnStack(ref o));
		data = o;
		return cacheEntry;
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void AddCacheEntry(ConfigId id, int numKey, [In] byte[] key, int keyLength, byte[] data, int dataLength);

	[SecurityCritical]
	internal static void AddCacheEntry(ConfigId id, int numKey, byte[] key, byte[] data)
	{
		AddCacheEntry(id, numKey, key, key.Length, data, data.Length);
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern void ResetCacheData(ConfigId id);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void GetMachineDirectory(StringHandleOnStack retDirectory);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void GetUserDirectory(StringHandleOnStack retDirectory);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern bool WriteToEventLog(string message);
}

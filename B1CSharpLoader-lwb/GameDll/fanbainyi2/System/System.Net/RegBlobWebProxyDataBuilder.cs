using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using Microsoft.Win32;

namespace System.Net;

internal class RegBlobWebProxyDataBuilder : WebProxyDataBuilder
{
	[Flags]
	private enum ProxyTypeFlags
	{
		PROXY_TYPE_DIRECT = 1,
		PROXY_TYPE_PROXY = 2,
		PROXY_TYPE_AUTO_PROXY_URL = 4,
		PROXY_TYPE_AUTO_DETECT = 8
	}

	internal const string PolicyKey = "SOFTWARE\\Policies\\Microsoft\\Windows\\CurrentVersion\\Internet Settings";

	internal const string ProxyKey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Internet Settings\\Connections";

	private const string DefaultConnectionSettings = "DefaultConnectionSettings";

	private const string ProxySettingsPerUser = "ProxySettingsPerUser";

	private const int IE50StrucSize = 60;

	private byte[] m_RegistryBytes;

	private int m_ByteOffset;

	private string m_Connectoid;

	private SafeRegistryHandle m_Registry;

	public RegBlobWebProxyDataBuilder(string connectoid, SafeRegistryHandle registry)
	{
		m_Registry = registry;
		m_Connectoid = connectoid;
	}

	[RegistryPermission(SecurityAction.Assert, Read = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\CurrentVersion\\Internet Settings")]
	private bool ReadRegSettings()
	{
		SafeRegistryHandle resultSubKey = null;
		RegistryKey registryKey = null;
		try
		{
			bool flag = true;
			registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\CurrentVersion\\Internet Settings");
			if (registryKey != null)
			{
				object value = registryKey.GetValue("ProxySettingsPerUser");
				if (value != null && value.GetType() == typeof(int) && (int)value == 0)
				{
					flag = false;
				}
			}
			if (((!flag) ? SafeRegistryHandle.RegOpenKeyEx(UnsafeNclNativeMethods.RegistryHelper.HKEY_LOCAL_MACHINE, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Internet Settings\\Connections", 0u, 131097u, out resultSubKey) : ((m_Registry == null) ? 1168u : m_Registry.RegOpenKeyEx("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Internet Settings\\Connections", 0u, 131097u, out resultSubKey))) != 0)
			{
				resultSubKey = null;
			}
			if (resultSubKey != null && resultSubKey.QueryValue((m_Connectoid != null) ? m_Connectoid : "DefaultConnectionSettings", out var data) == 0)
			{
				m_RegistryBytes = (byte[])data;
			}
		}
		catch (Exception exception)
		{
			if (NclUtilities.IsFatal(exception))
			{
				throw;
			}
		}
		finally
		{
			registryKey?.Close();
			resultSubKey?.RegCloseKey();
		}
		return m_RegistryBytes != null;
	}

	public string ReadString()
	{
		string result = null;
		int num = ReadInt32();
		if (num > 0)
		{
			int num2 = m_RegistryBytes.Length - m_ByteOffset;
			if (num >= num2)
			{
				num = num2;
			}
			result = Encoding.UTF8.GetString(m_RegistryBytes, m_ByteOffset, num);
			m_ByteOffset += num;
		}
		return result;
	}

	internal unsafe int ReadInt32()
	{
		int result = 0;
		int num = m_RegistryBytes.Length - m_ByteOffset;
		if (num >= 4)
		{
			fixed (byte* registryBytes = m_RegistryBytes)
			{
				result = ((sizeof(IntPtr) != 4) ? Marshal.ReadInt32((IntPtr)registryBytes, m_ByteOffset) : (*(int*)(registryBytes + m_ByteOffset)));
			}
			m_ByteOffset += 4;
		}
		return result;
	}

	protected override void BuildInternal()
	{
		bool flag = ReadRegSettings();
		if (flag)
		{
			flag = ReadInt32() >= 60;
		}
		if (!flag)
		{
			SetAutoDetectSettings(value: true);
			return;
		}
		ReadInt32();
		ProxyTypeFlags proxyTypeFlags = (ProxyTypeFlags)ReadInt32();
		string addressString = ReadString();
		string bypassListString = ReadString();
		if ((proxyTypeFlags & ProxyTypeFlags.PROXY_TYPE_PROXY) != 0)
		{
			SetProxyAndBypassList(addressString, bypassListString);
		}
		SetAutoDetectSettings((proxyTypeFlags & ProxyTypeFlags.PROXY_TYPE_AUTO_DETECT) != 0);
		string autoProxyUrl = ReadString();
		if ((proxyTypeFlags & ProxyTypeFlags.PROXY_TYPE_AUTO_PROXY_URL) != 0)
		{
			SetAutoProxyUrl(autoProxyUrl);
		}
	}
}

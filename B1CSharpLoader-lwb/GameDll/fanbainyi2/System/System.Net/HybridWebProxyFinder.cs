using System.Collections.Generic;
using System.IO;
using System.Security;
using System.Security.Permissions;
using Microsoft.Win32;

namespace System.Net;

internal sealed class HybridWebProxyFinder : IWebProxyFinder, IDisposable
{
	private const string allowFallbackKey = "SOFTWARE\\Microsoft\\.NETFramework";

	private const string allowFallbackKeyPath = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\.NETFramework";

	private const string allowFallbackValueName = "LegacyWPADSupport";

	private static bool allowFallback;

	private NetWebProxyFinder netFinder;

	private WinHttpWebProxyFinder winHttpFinder;

	private BaseWebProxyFinder currentFinder;

	private AutoWebProxyScriptEngine engine;

	public bool IsValid => currentFinder.IsValid;

	static HybridWebProxyFinder()
	{
		InitializeFallbackSettings();
	}

	public HybridWebProxyFinder(AutoWebProxyScriptEngine engine)
	{
		this.engine = engine;
		winHttpFinder = new WinHttpWebProxyFinder(engine);
		currentFinder = winHttpFinder;
	}

	public bool GetProxies(Uri destination, out IList<string> proxyList)
	{
		if (currentFinder.GetProxies(destination, out proxyList))
		{
			return true;
		}
		if (allowFallback && currentFinder.IsUnrecognizedScheme && currentFinder == winHttpFinder)
		{
			if (netFinder == null)
			{
				netFinder = new NetWebProxyFinder(engine);
			}
			currentFinder = netFinder;
			return currentFinder.GetProxies(destination, out proxyList);
		}
		return false;
	}

	public void Abort()
	{
		currentFinder.Abort();
	}

	public void Reset()
	{
		winHttpFinder.Reset();
		if (netFinder != null)
		{
			netFinder.Reset();
		}
		currentFinder = winHttpFinder;
	}

	public void Dispose()
	{
		Dispose(disposing: true);
	}

	private void Dispose(bool disposing)
	{
		if (disposing)
		{
			winHttpFinder.Dispose();
			if (netFinder != null)
			{
				netFinder.Dispose();
			}
		}
	}

	[RegistryPermission(SecurityAction.Assert, Read = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\.NETFramework")]
	private static void InitializeFallbackSettings()
	{
		allowFallback = false;
		try
		{
			using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\.NETFramework");
			try
			{
				object value = registryKey.GetValue("LegacyWPADSupport", null);
				if (value != null && registryKey.GetValueKind("LegacyWPADSupport") == RegistryValueKind.DWord)
				{
					allowFallback = (int)value == 1;
				}
			}
			catch (UnauthorizedAccessException)
			{
			}
			catch (IOException)
			{
			}
		}
		catch (SecurityException)
		{
		}
		catch (ObjectDisposedException)
		{
		}
	}
}

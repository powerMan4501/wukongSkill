using System.Collections.Generic;
using System.Net.Configuration;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Net;

internal sealed class WinHttpWebProxyFinder : BaseWebProxyFinder
{
	private SafeInternetHandle session;

	private bool autoDetectFailed;

	public WinHttpWebProxyFinder(AutoWebProxyScriptEngine engine)
		: base(engine)
	{
		session = UnsafeNclNativeMethods.WinHttp.WinHttpOpen(null, UnsafeNclNativeMethods.WinHttp.AccessType.NoProxy, null, null, 0);
		if (session == null || session.IsInvalid)
		{
			int lastWin32Error = GetLastWin32Error();
			if (Logging.On)
			{
				Logging.PrintError(Logging.Web, SR.GetString("net_log_proxy_winhttp_cant_open_session", lastWin32Error));
			}
			return;
		}
		int downloadTimeout = SettingsSectionInternal.Section.DownloadTimeout;
		if (!UnsafeNclNativeMethods.WinHttp.WinHttpSetTimeouts(session, downloadTimeout, downloadTimeout, downloadTimeout, downloadTimeout))
		{
			int lastWin32Error2 = GetLastWin32Error();
			if (Logging.On)
			{
				Logging.PrintError(Logging.Web, SR.GetString("net_log_proxy_winhttp_timeout_error", lastWin32Error2));
			}
		}
	}

	public override bool GetProxies(Uri destination, out IList<string> proxyList)
	{
		proxyList = null;
		if (session == null || session.IsInvalid)
		{
			return false;
		}
		if (base.State == AutoWebProxyState.UnrecognizedScheme)
		{
			return false;
		}
		string proxyListString = null;
		int num = 12180;
		if (base.Engine.AutomaticallyDetectSettings && !autoDetectFailed)
		{
			num = GetProxies(destination, null, out proxyListString);
			autoDetectFailed = IsErrorFatalForAutoDetect(num);
			if (num == 12006)
			{
				base.State = AutoWebProxyState.UnrecognizedScheme;
				return false;
			}
		}
		if (base.Engine.AutomaticConfigurationScript != null && IsRecoverableAutoProxyError(num))
		{
			num = GetProxies(destination, base.Engine.AutomaticConfigurationScript, out proxyListString);
		}
		base.State = GetStateFromErrorCode(num);
		if (base.State == AutoWebProxyState.Completed)
		{
			if (string.IsNullOrEmpty(proxyListString))
			{
				proxyList = new string[1];
			}
			else
			{
				proxyListString = RemoveWhitespaces(proxyListString);
				proxyList = proxyListString.Split(';');
			}
			return true;
		}
		return false;
	}

	public override void Abort()
	{
	}

	public override void Reset()
	{
		base.Reset();
		autoDetectFailed = false;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && session != null && !session.IsInvalid)
		{
			session.Close();
		}
	}

	private int GetProxies(Uri destination, Uri scriptLocation, out string proxyListString)
	{
		int num = 0;
		proxyListString = null;
		UnsafeNclNativeMethods.WinHttp.WINHTTP_AUTOPROXY_OPTIONS autoProxyOptions = new UnsafeNclNativeMethods.WinHttp.WINHTTP_AUTOPROXY_OPTIONS
		{
			AutoLogonIfChallenged = false
		};
		if (scriptLocation == null)
		{
			autoProxyOptions.Flags = UnsafeNclNativeMethods.WinHttp.AutoProxyFlags.AutoDetect;
			autoProxyOptions.AutoConfigUrl = null;
			autoProxyOptions.AutoDetectFlags = UnsafeNclNativeMethods.WinHttp.AutoDetectType.Dhcp | UnsafeNclNativeMethods.WinHttp.AutoDetectType.DnsA;
		}
		else
		{
			autoProxyOptions.Flags = UnsafeNclNativeMethods.WinHttp.AutoProxyFlags.AutoProxyConfigUrl;
			autoProxyOptions.AutoConfigUrl = scriptLocation.ToString();
			autoProxyOptions.AutoDetectFlags = UnsafeNclNativeMethods.WinHttp.AutoDetectType.None;
		}
		if (!WinHttpGetProxyForUrl(destination.ToString(), ref autoProxyOptions, out proxyListString))
		{
			num = GetLastWin32Error();
			if (num == 12015 && base.Engine.Credentials != null)
			{
				autoProxyOptions.AutoLogonIfChallenged = true;
				if (!WinHttpGetProxyForUrl(destination.ToString(), ref autoProxyOptions, out proxyListString))
				{
					num = GetLastWin32Error();
				}
			}
			if (Logging.On)
			{
				Logging.PrintError(Logging.Web, SR.GetString("net_log_proxy_winhttp_getproxy_failed", destination, num));
			}
		}
		return num;
	}

	private bool WinHttpGetProxyForUrl(string destination, ref UnsafeNclNativeMethods.WinHttp.WINHTTP_AUTOPROXY_OPTIONS autoProxyOptions, out string proxyListString)
	{
		proxyListString = null;
		bool flag = false;
		UnsafeNclNativeMethods.WinHttp.WINHTTP_PROXY_INFO proxyInfo = default(UnsafeNclNativeMethods.WinHttp.WINHTTP_PROXY_INFO);
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			flag = UnsafeNclNativeMethods.WinHttp.WinHttpGetProxyForUrl(session, destination, ref autoProxyOptions, out proxyInfo);
			if (flag)
			{
				proxyListString = Marshal.PtrToStringUni(proxyInfo.Proxy);
			}
		}
		finally
		{
			Marshal.FreeHGlobal(proxyInfo.Proxy);
			Marshal.FreeHGlobal(proxyInfo.ProxyBypass);
		}
		return flag;
	}

	private static int GetLastWin32Error()
	{
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (lastWin32Error == 8)
		{
			throw new OutOfMemoryException();
		}
		return lastWin32Error;
	}

	private static bool IsRecoverableAutoProxyError(int errorCode)
	{
		switch ((UnsafeNclNativeMethods.WinHttp.ErrorCodes)errorCode)
		{
		case UnsafeNclNativeMethods.WinHttp.ErrorCodes.Timeout:
		case UnsafeNclNativeMethods.WinHttp.ErrorCodes.UnrecognizedScheme:
		case UnsafeNclNativeMethods.WinHttp.ErrorCodes.LoginFailure:
		case UnsafeNclNativeMethods.WinHttp.ErrorCodes.OperationCancelled:
		case UnsafeNclNativeMethods.WinHttp.ErrorCodes.BadAutoProxyScript:
		case UnsafeNclNativeMethods.WinHttp.ErrorCodes.UnableToDownloadScript:
		case UnsafeNclNativeMethods.WinHttp.ErrorCodes.AutoProxyServiceError:
		case UnsafeNclNativeMethods.WinHttp.ErrorCodes.AudodetectionFailed:
			return true;
		default:
			return false;
		}
	}

	private static AutoWebProxyState GetStateFromErrorCode(int errorCode)
	{
		if (errorCode == 0L)
		{
			return AutoWebProxyState.Completed;
		}
		switch ((UnsafeNclNativeMethods.WinHttp.ErrorCodes)errorCode)
		{
		case UnsafeNclNativeMethods.WinHttp.ErrorCodes.AudodetectionFailed:
			return AutoWebProxyState.DiscoveryFailure;
		case UnsafeNclNativeMethods.WinHttp.ErrorCodes.UnableToDownloadScript:
			return AutoWebProxyState.DownloadFailure;
		case UnsafeNclNativeMethods.WinHttp.ErrorCodes.UnrecognizedScheme:
			return AutoWebProxyState.UnrecognizedScheme;
		case UnsafeNclNativeMethods.WinHttp.ErrorCodes.InvalidUrl:
		case UnsafeNclNativeMethods.WinHttp.ErrorCodes.BadAutoProxyScript:
		case UnsafeNclNativeMethods.WinHttp.ErrorCodes.AutoProxyServiceError:
			return AutoWebProxyState.Completed;
		default:
			return AutoWebProxyState.CompilationFailure;
		}
	}

	private static string RemoveWhitespaces(string value)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (char c in value)
		{
			if (!char.IsWhiteSpace(c))
			{
				stringBuilder.Append(c);
			}
		}
		return stringBuilder.ToString();
	}

	private static bool IsErrorFatalForAutoDetect(int errorCode)
	{
		switch ((UnsafeNclNativeMethods.WinHttp.ErrorCodes)errorCode)
		{
		case UnsafeNclNativeMethods.WinHttp.ErrorCodes.Success:
		case UnsafeNclNativeMethods.WinHttp.ErrorCodes.InvalidUrl:
		case UnsafeNclNativeMethods.WinHttp.ErrorCodes.BadAutoProxyScript:
		case UnsafeNclNativeMethods.WinHttp.ErrorCodes.AutoProxyServiceError:
			return false;
		default:
			return true;
		}
	}
}

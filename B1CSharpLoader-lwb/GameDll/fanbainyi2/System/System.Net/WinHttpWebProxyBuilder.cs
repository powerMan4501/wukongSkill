using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Net;

internal sealed class WinHttpWebProxyBuilder : WebProxyDataBuilder
{
	protected override void BuildInternal()
	{
		UnsafeNclNativeMethods.WinHttp.WINHTTP_CURRENT_USER_IE_PROXY_CONFIG proxyConfig = default(UnsafeNclNativeMethods.WinHttp.WINHTTP_CURRENT_USER_IE_PROXY_CONFIG);
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			if (UnsafeNclNativeMethods.WinHttp.WinHttpGetIEProxyConfigForCurrentUser(ref proxyConfig))
			{
				string text = null;
				string text2 = null;
				string text3 = null;
				text = Marshal.PtrToStringUni(proxyConfig.Proxy);
				text2 = Marshal.PtrToStringUni(proxyConfig.ProxyBypass);
				text3 = Marshal.PtrToStringUni(proxyConfig.AutoConfigUrl);
				SetProxyAndBypassList(text, text2);
				SetAutoDetectSettings(proxyConfig.AutoDetect);
				SetAutoProxyUrl(text3);
			}
			else
			{
				int lastWin32Error = Marshal.GetLastWin32Error();
				if (lastWin32Error == 8)
				{
					throw new OutOfMemoryException();
				}
				SetAutoDetectSettings(value: true);
			}
		}
		finally
		{
			Marshal.FreeHGlobal(proxyConfig.Proxy);
			Marshal.FreeHGlobal(proxyConfig.ProxyBypass);
			Marshal.FreeHGlobal(proxyConfig.AutoConfigUrl);
		}
	}
}

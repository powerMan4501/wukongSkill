using System.Net;
using STUN.Enums;

namespace STUN.Proxy;

public static class ProxyFactory
{
	public static IUdpProxy CreateProxy(ProxyType type, IPEndPoint local)
	{
		return new NoneUdpProxy(local);
	}
}

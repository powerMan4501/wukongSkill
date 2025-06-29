using System.Collections.Generic;

namespace GSE.GSNet;

internal class ReverseProxyState
{
	public NetDriver driver;

	public string bindUrl;

	public List<ProxyRoleClientConnx> connxs = new List<ProxyRoleClientConnx>();

	public List<ProxyRoleServerUpstream> upstreams = new List<ProxyRoleServerUpstream>();
}

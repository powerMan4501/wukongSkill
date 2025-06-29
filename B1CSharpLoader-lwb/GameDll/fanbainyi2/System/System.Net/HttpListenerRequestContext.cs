using System.Collections.Generic;
using System.Security.Authentication.ExtendedProtection;

namespace System.Net;

internal class HttpListenerRequestContext : TransportContext
{
	private HttpListenerRequest request;

	internal HttpListenerRequestContext(HttpListenerRequest request)
	{
		this.request = request;
	}

	public override ChannelBinding GetChannelBinding(ChannelBindingKind kind)
	{
		if (kind != ChannelBindingKind.Endpoint)
		{
			throw new NotSupportedException(SR.GetString("net_listener_invalid_cbt_type", kind.ToString()));
		}
		return request.GetChannelBinding();
	}

	public override IEnumerable<TokenBinding> GetTlsTokenBindings()
	{
		return request.GetTlsTokenBindings();
	}
}

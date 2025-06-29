using System.Net.Security;
using System.Security.Authentication.ExtendedProtection;

namespace System.Net;

internal class SslStreamContext : TransportContext
{
	private SslStream sslStream;

	internal SslStreamContext(SslStream sslStream)
	{
		this.sslStream = sslStream;
	}

	public override ChannelBinding GetChannelBinding(ChannelBindingKind kind)
	{
		return sslStream.GetChannelBinding(kind);
	}
}

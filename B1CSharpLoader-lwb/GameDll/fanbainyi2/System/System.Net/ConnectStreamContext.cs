using System.Security.Authentication.ExtendedProtection;

namespace System.Net;

internal class ConnectStreamContext : TransportContext
{
	private ConnectStream connectStream;

	internal ConnectStreamContext(ConnectStream connectStream)
	{
		this.connectStream = connectStream;
	}

	public override ChannelBinding GetChannelBinding(ChannelBindingKind kind)
	{
		return connectStream.GetChannelBinding(kind);
	}
}

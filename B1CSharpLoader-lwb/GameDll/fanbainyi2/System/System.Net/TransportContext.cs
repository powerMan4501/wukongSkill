using System.Collections.Generic;
using System.Security.Authentication.ExtendedProtection;

namespace System.Net;

[global::__DynamicallyInvokable]
public abstract class TransportContext
{
	[global::__DynamicallyInvokable]
	public abstract ChannelBinding GetChannelBinding(ChannelBindingKind kind);

	public virtual IEnumerable<TokenBinding> GetTlsTokenBindings()
	{
		throw new NotSupportedException();
	}

	[global::__DynamicallyInvokable]
	protected TransportContext()
	{
	}
}

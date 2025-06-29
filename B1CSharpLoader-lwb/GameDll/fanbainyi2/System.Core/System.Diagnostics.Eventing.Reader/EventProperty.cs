using System.Security.Permissions;

namespace System.Diagnostics.Eventing.Reader;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class EventProperty
{
	private object value;

	public object Value => value;

	internal EventProperty(object value)
	{
		this.value = value;
	}
}

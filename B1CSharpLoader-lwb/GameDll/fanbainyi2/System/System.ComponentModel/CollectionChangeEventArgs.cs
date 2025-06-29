using System.Security.Permissions;

namespace System.ComponentModel;

[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
public class CollectionChangeEventArgs : EventArgs
{
	private CollectionChangeAction action;

	private object element;

	public virtual CollectionChangeAction Action => action;

	public virtual object Element => element;

	public CollectionChangeEventArgs(CollectionChangeAction action, object element)
	{
		this.action = action;
		this.element = element;
	}
}

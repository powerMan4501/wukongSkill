using System.Security.Permissions;

namespace System.ComponentModel;

[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
public class RefreshEventArgs : EventArgs
{
	private object componentChanged;

	private Type typeChanged;

	public object ComponentChanged => componentChanged;

	public Type TypeChanged => typeChanged;

	public RefreshEventArgs(object componentChanged)
	{
		this.componentChanged = componentChanged;
		typeChanged = componentChanged.GetType();
	}

	public RefreshEventArgs(Type typeChanged)
	{
		this.typeChanged = typeChanged;
	}
}

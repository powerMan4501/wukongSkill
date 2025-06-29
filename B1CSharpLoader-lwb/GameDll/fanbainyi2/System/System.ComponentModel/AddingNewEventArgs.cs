using System.Security.Permissions;

namespace System.ComponentModel;

[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
public class AddingNewEventArgs : EventArgs
{
	private object newObject;

	public object NewObject
	{
		get
		{
			return newObject;
		}
		set
		{
			newObject = value;
		}
	}

	public AddingNewEventArgs()
	{
	}

	public AddingNewEventArgs(object newObject)
	{
		this.newObject = newObject;
	}
}

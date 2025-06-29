using System.Security.Permissions;

namespace System.ComponentModel;

[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
public class HandledEventArgs : EventArgs
{
	private bool handled;

	public bool Handled
	{
		get
		{
			return handled;
		}
		set
		{
			handled = value;
		}
	}

	public HandledEventArgs()
		: this(defaultHandledValue: false)
	{
	}

	public HandledEventArgs(bool defaultHandledValue)
	{
		handled = defaultHandledValue;
	}
}

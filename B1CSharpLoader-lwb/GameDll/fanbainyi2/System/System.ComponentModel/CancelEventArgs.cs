using System.Security.Permissions;

namespace System.ComponentModel;

[global::__DynamicallyInvokable]
[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
public class CancelEventArgs : EventArgs
{
	private bool cancel;

	[global::__DynamicallyInvokable]
	public bool Cancel
	{
		[global::__DynamicallyInvokable]
		get
		{
			return cancel;
		}
		[global::__DynamicallyInvokable]
		set
		{
			cancel = value;
		}
	}

	[global::__DynamicallyInvokable]
	public CancelEventArgs()
		: this(cancel: false)
	{
	}

	[global::__DynamicallyInvokable]
	public CancelEventArgs(bool cancel)
	{
		this.cancel = cancel;
	}
}

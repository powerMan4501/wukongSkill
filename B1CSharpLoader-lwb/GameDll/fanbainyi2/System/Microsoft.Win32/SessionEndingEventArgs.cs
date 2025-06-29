using System;
using System.Security.Permissions;

namespace Microsoft.Win32;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
public class SessionEndingEventArgs : EventArgs
{
	private bool cancel;

	private readonly SessionEndReasons reason;

	public bool Cancel
	{
		get
		{
			return cancel;
		}
		set
		{
			cancel = value;
		}
	}

	public SessionEndReasons Reason => reason;

	public SessionEndingEventArgs(SessionEndReasons reason)
	{
		this.reason = reason;
	}
}

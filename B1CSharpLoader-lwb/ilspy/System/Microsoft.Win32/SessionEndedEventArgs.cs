using System;
using System.Security.Permissions;

namespace Microsoft.Win32;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
public class SessionEndedEventArgs : EventArgs
{
	private readonly SessionEndReasons reason;

	public SessionEndReasons Reason => reason;

	public SessionEndedEventArgs(SessionEndReasons reason)
	{
		this.reason = reason;
	}
}

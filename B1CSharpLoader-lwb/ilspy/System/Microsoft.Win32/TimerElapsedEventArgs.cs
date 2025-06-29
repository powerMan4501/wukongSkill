using System;
using System.Security.Permissions;

namespace Microsoft.Win32;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
public class TimerElapsedEventArgs : EventArgs
{
	private readonly IntPtr timerId;

	public IntPtr TimerId => timerId;

	public TimerElapsedEventArgs(IntPtr timerId)
	{
		this.timerId = timerId;
	}
}

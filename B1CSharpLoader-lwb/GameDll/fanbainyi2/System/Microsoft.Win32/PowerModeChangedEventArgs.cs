using System;
using System.Security.Permissions;

namespace Microsoft.Win32;

[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public class PowerModeChangedEventArgs : EventArgs
{
	private readonly PowerModes mode;

	public PowerModes Mode => mode;

	public PowerModeChangedEventArgs(PowerModes mode)
	{
		this.mode = mode;
	}
}

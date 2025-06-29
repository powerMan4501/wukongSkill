using System;
using System.Security.Permissions;

namespace Microsoft.Win32;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
public class UserPreferenceChangedEventArgs : EventArgs
{
	private readonly UserPreferenceCategory category;

	public UserPreferenceCategory Category => category;

	public UserPreferenceChangedEventArgs(UserPreferenceCategory category)
	{
		this.category = category;
	}
}

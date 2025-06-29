using System.Security.Permissions;

namespace System.Security;

[SecurityCritical]
[PermissionSet(SecurityAction.InheritanceDemand, Unrestricted = true)]
public abstract class SecurityState
{
	[SecurityCritical]
	public bool IsStateAvailable()
	{
		return AppDomainManager.CurrentAppDomainManager?.CheckSecuritySettings(this) ?? false;
	}

	public abstract void EnsureState();
}

using System.Security.Principal;

namespace System.Security.AccessControl;

public sealed class RegistryAccessRule : AccessRule
{
	public RegistryRights RegistryRights => (RegistryRights)base.AccessMask;

	public RegistryAccessRule(IdentityReference identity, RegistryRights registryRights, AccessControlType type)
		: this(identity, (int)registryRights, isInherited: false, InheritanceFlags.None, PropagationFlags.None, type)
	{
	}

	public RegistryAccessRule(string identity, RegistryRights registryRights, AccessControlType type)
		: this(new NTAccount(identity), (int)registryRights, isInherited: false, InheritanceFlags.None, PropagationFlags.None, type)
	{
	}

	public RegistryAccessRule(IdentityReference identity, RegistryRights registryRights, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type)
		: this(identity, (int)registryRights, isInherited: false, inheritanceFlags, propagationFlags, type)
	{
	}

	public RegistryAccessRule(string identity, RegistryRights registryRights, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type)
		: this(new NTAccount(identity), (int)registryRights, isInherited: false, inheritanceFlags, propagationFlags, type)
	{
	}

	internal RegistryAccessRule(IdentityReference identity, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type)
		: base(identity, accessMask, isInherited, inheritanceFlags, propagationFlags, type)
	{
	}
}

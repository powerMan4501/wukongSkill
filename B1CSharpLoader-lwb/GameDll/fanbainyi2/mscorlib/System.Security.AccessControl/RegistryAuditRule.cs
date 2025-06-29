using System.Security.Principal;

namespace System.Security.AccessControl;

public sealed class RegistryAuditRule : AuditRule
{
	public RegistryRights RegistryRights => (RegistryRights)base.AccessMask;

	public RegistryAuditRule(IdentityReference identity, RegistryRights registryRights, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags)
		: this(identity, (int)registryRights, isInherited: false, inheritanceFlags, propagationFlags, flags)
	{
	}

	public RegistryAuditRule(string identity, RegistryRights registryRights, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags)
		: this(new NTAccount(identity), (int)registryRights, isInherited: false, inheritanceFlags, propagationFlags, flags)
	{
	}

	internal RegistryAuditRule(IdentityReference identity, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags)
		: base(identity, accessMask, isInherited, inheritanceFlags, propagationFlags, flags)
	{
	}
}

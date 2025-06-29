using System.Security.Principal;

namespace System.Security.AccessControl;

public sealed class MutexAuditRule : AuditRule
{
	public MutexRights MutexRights => (MutexRights)base.AccessMask;

	public MutexAuditRule(IdentityReference identity, MutexRights eventRights, AuditFlags flags)
		: this(identity, (int)eventRights, isInherited: false, InheritanceFlags.None, PropagationFlags.None, flags)
	{
	}

	internal MutexAuditRule(IdentityReference identity, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags)
		: base(identity, accessMask, isInherited, inheritanceFlags, propagationFlags, flags)
	{
	}
}

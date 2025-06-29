using System.Runtime.InteropServices;
using System.Security.Principal;

namespace System.Security.AccessControl;

[ComVisible(false)]
public sealed class SemaphoreAuditRule : AuditRule
{
	public SemaphoreRights SemaphoreRights => (SemaphoreRights)base.AccessMask;

	public SemaphoreAuditRule(IdentityReference identity, SemaphoreRights eventRights, AuditFlags flags)
		: this(identity, (int)eventRights, isInherited: false, InheritanceFlags.None, PropagationFlags.None, flags)
	{
	}

	internal SemaphoreAuditRule(IdentityReference identity, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags)
		: base(identity, accessMask, isInherited, inheritanceFlags, propagationFlags, flags)
	{
	}
}

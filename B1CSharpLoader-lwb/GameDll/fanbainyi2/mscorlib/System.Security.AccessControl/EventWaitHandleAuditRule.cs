using System.Security.Principal;

namespace System.Security.AccessControl;

public sealed class EventWaitHandleAuditRule : AuditRule
{
	public EventWaitHandleRights EventWaitHandleRights => (EventWaitHandleRights)base.AccessMask;

	public EventWaitHandleAuditRule(IdentityReference identity, EventWaitHandleRights eventRights, AuditFlags flags)
		: this(identity, (int)eventRights, isInherited: false, InheritanceFlags.None, PropagationFlags.None, flags)
	{
	}

	internal EventWaitHandleAuditRule(IdentityReference identity, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags)
		: base(identity, accessMask, isInherited, inheritanceFlags, propagationFlags, flags)
	{
	}
}

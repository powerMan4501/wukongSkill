using System.Security.Principal;

namespace System.Security.AccessControl;

public sealed class EventWaitHandleAccessRule : AccessRule
{
	public EventWaitHandleRights EventWaitHandleRights => (EventWaitHandleRights)base.AccessMask;

	public EventWaitHandleAccessRule(IdentityReference identity, EventWaitHandleRights eventRights, AccessControlType type)
		: this(identity, (int)eventRights, isInherited: false, InheritanceFlags.None, PropagationFlags.None, type)
	{
	}

	public EventWaitHandleAccessRule(string identity, EventWaitHandleRights eventRights, AccessControlType type)
		: this(new NTAccount(identity), (int)eventRights, isInherited: false, InheritanceFlags.None, PropagationFlags.None, type)
	{
	}

	internal EventWaitHandleAccessRule(IdentityReference identity, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type)
		: base(identity, accessMask, isInherited, inheritanceFlags, propagationFlags, type)
	{
	}
}

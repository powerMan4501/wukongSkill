using System.Security.Principal;

namespace System.Security.AccessControl;

public sealed class MutexAccessRule : AccessRule
{
	public MutexRights MutexRights => (MutexRights)base.AccessMask;

	public MutexAccessRule(IdentityReference identity, MutexRights eventRights, AccessControlType type)
		: this(identity, (int)eventRights, isInherited: false, InheritanceFlags.None, PropagationFlags.None, type)
	{
	}

	public MutexAccessRule(string identity, MutexRights eventRights, AccessControlType type)
		: this(new NTAccount(identity), (int)eventRights, isInherited: false, InheritanceFlags.None, PropagationFlags.None, type)
	{
	}

	internal MutexAccessRule(IdentityReference identity, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type)
		: base(identity, accessMask, isInherited, inheritanceFlags, propagationFlags, type)
	{
	}
}

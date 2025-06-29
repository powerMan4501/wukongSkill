using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading;
using Microsoft.Win32.SafeHandles;

namespace System.Security.AccessControl;

public sealed class EventWaitHandleSecurity : NativeObjectSecurity
{
	public override Type AccessRightType => typeof(EventWaitHandleRights);

	public override Type AccessRuleType => typeof(EventWaitHandleAccessRule);

	public override Type AuditRuleType => typeof(EventWaitHandleAuditRule);

	public EventWaitHandleSecurity()
		: base(isContainer: true, ResourceType.KernelObject)
	{
	}

	[SecurityCritical]
	internal EventWaitHandleSecurity(string name, AccessControlSections includeSections)
		: base(isContainer: true, ResourceType.KernelObject, name, includeSections, _HandleErrorCode, null)
	{
	}

	[SecurityCritical]
	internal EventWaitHandleSecurity(SafeWaitHandle handle, AccessControlSections includeSections)
		: base(isContainer: true, ResourceType.KernelObject, handle, includeSections, _HandleErrorCode, null)
	{
	}

	[SecurityCritical]
	private static Exception _HandleErrorCode(int errorCode, string name, SafeHandle handle, object context)
	{
		Exception result = null;
		if (errorCode == 2 || errorCode == 6 || errorCode == 123)
		{
			result = ((name == null || name.Length == 0) ? new WaitHandleCannotBeOpenedException() : new WaitHandleCannotBeOpenedException(Environment.GetResourceString("Threading.WaitHandleCannotBeOpenedException_InvalidHandle", name)));
		}
		return result;
	}

	public override AccessRule AccessRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type)
	{
		return new EventWaitHandleAccessRule(identityReference, accessMask, isInherited, inheritanceFlags, propagationFlags, type);
	}

	public override AuditRule AuditRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags)
	{
		return new EventWaitHandleAuditRule(identityReference, accessMask, isInherited, inheritanceFlags, propagationFlags, flags);
	}

	internal AccessControlSections GetAccessControlSectionsFromChanges()
	{
		AccessControlSections accessControlSections = AccessControlSections.None;
		if (base.AccessRulesModified)
		{
			accessControlSections = AccessControlSections.Access;
		}
		if (base.AuditRulesModified)
		{
			accessControlSections |= AccessControlSections.Audit;
		}
		if (base.OwnerModified)
		{
			accessControlSections |= AccessControlSections.Owner;
		}
		if (base.GroupModified)
		{
			accessControlSections |= AccessControlSections.Group;
		}
		return accessControlSections;
	}

	[SecurityCritical]
	internal void Persist(SafeWaitHandle handle)
	{
		WriteLock();
		try
		{
			AccessControlSections accessControlSectionsFromChanges = GetAccessControlSectionsFromChanges();
			if (accessControlSectionsFromChanges != AccessControlSections.None)
			{
				Persist(handle, accessControlSectionsFromChanges);
				bool flag = (base.AccessRulesModified = false);
				bool flag3 = (base.AuditRulesModified = flag);
				bool ownerModified = (base.GroupModified = flag3);
				base.OwnerModified = ownerModified;
			}
		}
		finally
		{
			WriteUnlock();
		}
	}

	public void AddAccessRule(EventWaitHandleAccessRule rule)
	{
		AddAccessRule((AccessRule)rule);
	}

	public void SetAccessRule(EventWaitHandleAccessRule rule)
	{
		SetAccessRule((AccessRule)rule);
	}

	public void ResetAccessRule(EventWaitHandleAccessRule rule)
	{
		ResetAccessRule((AccessRule)rule);
	}

	public bool RemoveAccessRule(EventWaitHandleAccessRule rule)
	{
		return RemoveAccessRule((AccessRule)rule);
	}

	public void RemoveAccessRuleAll(EventWaitHandleAccessRule rule)
	{
		RemoveAccessRuleAll((AccessRule)rule);
	}

	public void RemoveAccessRuleSpecific(EventWaitHandleAccessRule rule)
	{
		RemoveAccessRuleSpecific((AccessRule)rule);
	}

	public void AddAuditRule(EventWaitHandleAuditRule rule)
	{
		AddAuditRule((AuditRule)rule);
	}

	public void SetAuditRule(EventWaitHandleAuditRule rule)
	{
		SetAuditRule((AuditRule)rule);
	}

	public bool RemoveAuditRule(EventWaitHandleAuditRule rule)
	{
		return RemoveAuditRule((AuditRule)rule);
	}

	public void RemoveAuditRuleAll(EventWaitHandleAuditRule rule)
	{
		RemoveAuditRuleAll((AuditRule)rule);
	}

	public void RemoveAuditRuleSpecific(EventWaitHandleAuditRule rule)
	{
		RemoveAuditRuleSpecific((AuditRule)rule);
	}
}

using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading;
using Microsoft.Win32.SafeHandles;

namespace System.Security.AccessControl;

[ComVisible(false)]
public sealed class SemaphoreSecurity : NativeObjectSecurity
{
	public override Type AccessRightType => typeof(SemaphoreRights);

	public override Type AccessRuleType => typeof(SemaphoreAccessRule);

	public override Type AuditRuleType => typeof(SemaphoreAuditRule);

	public SemaphoreSecurity()
		: base(isContainer: true, ResourceType.KernelObject)
	{
	}

	public SemaphoreSecurity(string name, AccessControlSections includeSections)
		: base(isContainer: true, ResourceType.KernelObject, name, includeSections, _HandleErrorCode, null)
	{
	}

	internal SemaphoreSecurity(SafeWaitHandle handle, AccessControlSections includeSections)
		: base(isContainer: true, ResourceType.KernelObject, handle, includeSections, _HandleErrorCode, null)
	{
	}

	private static Exception _HandleErrorCode(int errorCode, string name, SafeHandle handle, object context)
	{
		Exception result = null;
		if (errorCode == 2 || errorCode == 6 || errorCode == 123)
		{
			result = ((name == null || name.Length == 0) ? new WaitHandleCannotBeOpenedException() : new WaitHandleCannotBeOpenedException(SR.GetString("WaitHandleCannotBeOpenedException_InvalidHandle", name)));
		}
		return result;
	}

	public override AccessRule AccessRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type)
	{
		return new SemaphoreAccessRule(identityReference, accessMask, isInherited, inheritanceFlags, propagationFlags, type);
	}

	public override AuditRule AuditRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags)
	{
		return new SemaphoreAuditRule(identityReference, accessMask, isInherited, inheritanceFlags, propagationFlags, flags);
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

	public void AddAccessRule(SemaphoreAccessRule rule)
	{
		AddAccessRule((AccessRule)rule);
	}

	public void SetAccessRule(SemaphoreAccessRule rule)
	{
		SetAccessRule((AccessRule)rule);
	}

	public void ResetAccessRule(SemaphoreAccessRule rule)
	{
		ResetAccessRule((AccessRule)rule);
	}

	public bool RemoveAccessRule(SemaphoreAccessRule rule)
	{
		return RemoveAccessRule((AccessRule)rule);
	}

	public void RemoveAccessRuleAll(SemaphoreAccessRule rule)
	{
		RemoveAccessRuleAll((AccessRule)rule);
	}

	public void RemoveAccessRuleSpecific(SemaphoreAccessRule rule)
	{
		RemoveAccessRuleSpecific((AccessRule)rule);
	}

	public void AddAuditRule(SemaphoreAuditRule rule)
	{
		AddAuditRule((AuditRule)rule);
	}

	public void SetAuditRule(SemaphoreAuditRule rule)
	{
		SetAuditRule((AuditRule)rule);
	}

	public bool RemoveAuditRule(SemaphoreAuditRule rule)
	{
		return RemoveAuditRule((AuditRule)rule);
	}

	public void RemoveAuditRuleAll(SemaphoreAuditRule rule)
	{
		RemoveAuditRuleAll((AuditRule)rule);
	}

	public void RemoveAuditRuleSpecific(SemaphoreAuditRule rule)
	{
		RemoveAuditRuleSpecific((AuditRule)rule);
	}
}

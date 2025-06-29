using System.IO;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Security.Principal;
using Microsoft.Win32.SafeHandles;

namespace System.Security.AccessControl;

public sealed class RegistrySecurity : NativeObjectSecurity
{
	public override Type AccessRightType => typeof(RegistryRights);

	public override Type AccessRuleType => typeof(RegistryAccessRule);

	public override Type AuditRuleType => typeof(RegistryAuditRule);

	public RegistrySecurity()
		: base(isContainer: true, ResourceType.RegistryKey)
	{
	}

	[SecurityCritical]
	[SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
	internal RegistrySecurity(SafeRegistryHandle hKey, string name, AccessControlSections includeSections)
		: base(isContainer: true, ResourceType.RegistryKey, hKey, includeSections, _HandleErrorCode, null)
	{
		new RegistryPermission(RegistryPermissionAccess.NoAccess, AccessControlActions.View, name).Demand();
	}

	[SecurityCritical]
	private static Exception _HandleErrorCode(int errorCode, string name, SafeHandle handle, object context)
	{
		Exception result = null;
		switch (errorCode)
		{
		case 2:
			result = new IOException(Environment.GetResourceString("Arg_RegKeyNotFound", errorCode));
			break;
		case 123:
			result = new ArgumentException(Environment.GetResourceString("Arg_RegInvalidKeyName", "name"));
			break;
		case 6:
			result = new ArgumentException(Environment.GetResourceString("AccessControl_InvalidHandle"));
			break;
		}
		return result;
	}

	public override AccessRule AccessRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type)
	{
		return new RegistryAccessRule(identityReference, accessMask, isInherited, inheritanceFlags, propagationFlags, type);
	}

	public override AuditRule AuditRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags)
	{
		return new RegistryAuditRule(identityReference, accessMask, isInherited, inheritanceFlags, propagationFlags, flags);
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
	[SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
	internal void Persist(SafeRegistryHandle hKey, string keyName)
	{
		new RegistryPermission(RegistryPermissionAccess.NoAccess, AccessControlActions.Change, keyName).Demand();
		WriteLock();
		try
		{
			AccessControlSections accessControlSectionsFromChanges = GetAccessControlSectionsFromChanges();
			if (accessControlSectionsFromChanges != AccessControlSections.None)
			{
				Persist(hKey, accessControlSectionsFromChanges);
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

	public void AddAccessRule(RegistryAccessRule rule)
	{
		AddAccessRule((AccessRule)rule);
	}

	public void SetAccessRule(RegistryAccessRule rule)
	{
		SetAccessRule((AccessRule)rule);
	}

	public void ResetAccessRule(RegistryAccessRule rule)
	{
		ResetAccessRule((AccessRule)rule);
	}

	public bool RemoveAccessRule(RegistryAccessRule rule)
	{
		return RemoveAccessRule((AccessRule)rule);
	}

	public void RemoveAccessRuleAll(RegistryAccessRule rule)
	{
		RemoveAccessRuleAll((AccessRule)rule);
	}

	public void RemoveAccessRuleSpecific(RegistryAccessRule rule)
	{
		RemoveAccessRuleSpecific((AccessRule)rule);
	}

	public void AddAuditRule(RegistryAuditRule rule)
	{
		AddAuditRule((AuditRule)rule);
	}

	public void SetAuditRule(RegistryAuditRule rule)
	{
		SetAuditRule((AuditRule)rule);
	}

	public bool RemoveAuditRule(RegistryAuditRule rule)
	{
		return RemoveAuditRule((AuditRule)rule);
	}

	public void RemoveAuditRuleAll(RegistryAuditRule rule)
	{
		RemoveAuditRuleAll((AuditRule)rule);
	}

	public void RemoveAuditRuleSpecific(RegistryAuditRule rule)
	{
		RemoveAuditRuleSpecific((AuditRule)rule);
	}
}

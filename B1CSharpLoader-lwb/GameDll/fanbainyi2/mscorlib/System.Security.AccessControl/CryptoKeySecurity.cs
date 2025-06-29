using System.Runtime.CompilerServices;
using System.Security.Principal;

namespace System.Security.AccessControl;

public sealed class CryptoKeySecurity : NativeObjectSecurity
{
	private const ResourceType s_ResourceType = ResourceType.FileObject;

	public override Type AccessRightType => typeof(CryptoKeyRights);

	public override Type AccessRuleType => typeof(CryptoKeyAccessRule);

	public override Type AuditRuleType => typeof(CryptoKeyAuditRule);

	internal AccessControlSections ChangedAccessControlSections
	{
		[SecurityCritical]
		get
		{
			AccessControlSections accessControlSections = AccessControlSections.None;
			bool flag = false;
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
				RuntimeHelpers.PrepareConstrainedRegions();
				try
				{
				}
				finally
				{
					ReadLock();
					flag = true;
				}
				if (base.AccessRulesModified)
				{
					accessControlSections |= AccessControlSections.Access;
				}
				if (base.AuditRulesModified)
				{
					accessControlSections |= AccessControlSections.Audit;
				}
				if (base.GroupModified)
				{
					accessControlSections |= AccessControlSections.Group;
				}
				if (base.OwnerModified)
				{
					accessControlSections |= AccessControlSections.Owner;
				}
			}
			finally
			{
				if (flag)
				{
					ReadUnlock();
				}
			}
			return accessControlSections;
		}
	}

	public CryptoKeySecurity()
		: base(isContainer: false, ResourceType.FileObject)
	{
	}

	[SecuritySafeCritical]
	public CryptoKeySecurity(CommonSecurityDescriptor securityDescriptor)
		: base(ResourceType.FileObject, securityDescriptor)
	{
	}

	public sealed override AccessRule AccessRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type)
	{
		return new CryptoKeyAccessRule(identityReference, CryptoKeyAccessRule.RightsFromAccessMask(accessMask), type);
	}

	public sealed override AuditRule AuditRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags)
	{
		return new CryptoKeyAuditRule(identityReference, CryptoKeyAuditRule.RightsFromAccessMask(accessMask), flags);
	}

	public void AddAccessRule(CryptoKeyAccessRule rule)
	{
		AddAccessRule((AccessRule)rule);
	}

	public void SetAccessRule(CryptoKeyAccessRule rule)
	{
		SetAccessRule((AccessRule)rule);
	}

	public void ResetAccessRule(CryptoKeyAccessRule rule)
	{
		ResetAccessRule((AccessRule)rule);
	}

	public bool RemoveAccessRule(CryptoKeyAccessRule rule)
	{
		return RemoveAccessRule((AccessRule)rule);
	}

	public void RemoveAccessRuleAll(CryptoKeyAccessRule rule)
	{
		RemoveAccessRuleAll((AccessRule)rule);
	}

	public void RemoveAccessRuleSpecific(CryptoKeyAccessRule rule)
	{
		RemoveAccessRuleSpecific((AccessRule)rule);
	}

	public void AddAuditRule(CryptoKeyAuditRule rule)
	{
		AddAuditRule((AuditRule)rule);
	}

	public void SetAuditRule(CryptoKeyAuditRule rule)
	{
		SetAuditRule((AuditRule)rule);
	}

	public bool RemoveAuditRule(CryptoKeyAuditRule rule)
	{
		return RemoveAuditRule((AuditRule)rule);
	}

	public void RemoveAuditRuleAll(CryptoKeyAuditRule rule)
	{
		RemoveAuditRuleAll((AuditRule)rule);
	}

	public void RemoveAuditRuleSpecific(CryptoKeyAuditRule rule)
	{
		RemoveAuditRuleSpecific((AuditRule)rule);
	}
}

using System.Collections;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Security.Policy;
using System.Security.Util;
using System.Text;
using System.Threading;

namespace System.Security;

internal class PolicyManager
{
	private object m_policyLevels;

	private static volatile QuickCacheEntryType[] FullTrustMap;

	private IList PolicyLevels
	{
		[SecurityCritical]
		get
		{
			if (m_policyLevels == null)
			{
				ArrayList arrayList = new ArrayList();
				string locationFromType = PolicyLevel.GetLocationFromType(PolicyLevelType.Enterprise);
				arrayList.Add(new PolicyLevel(PolicyLevelType.Enterprise, locationFromType, ConfigId.EnterprisePolicyLevel));
				string locationFromType2 = PolicyLevel.GetLocationFromType(PolicyLevelType.Machine);
				arrayList.Add(new PolicyLevel(PolicyLevelType.Machine, locationFromType2, ConfigId.MachinePolicyLevel));
				if (Config.UserDirectory != null)
				{
					string locationFromType3 = PolicyLevel.GetLocationFromType(PolicyLevelType.User);
					arrayList.Add(new PolicyLevel(PolicyLevelType.User, locationFromType3, ConfigId.UserPolicyLevel));
				}
				Interlocked.CompareExchange(ref m_policyLevels, arrayList, null);
			}
			return m_policyLevels as ArrayList;
		}
	}

	internal PolicyManager()
	{
	}

	[SecurityCritical]
	internal void AddLevel(PolicyLevel level)
	{
		PolicyLevels.Add(level);
	}

	[SecurityCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlPolicy)]
	internal IEnumerator PolicyHierarchy()
	{
		return PolicyLevels.GetEnumerator();
	}

	[SecurityCritical]
	internal PermissionSet Resolve(Evidence evidence)
	{
		PermissionSet grantSet = null;
		if (CodeAccessSecurityEngine.TryResolveGrantSet(evidence, out grantSet))
		{
			return grantSet;
		}
		return CodeGroupResolve(evidence, systemPolicy: false);
	}

	[SecurityCritical]
	internal PermissionSet CodeGroupResolve(Evidence evidence, bool systemPolicy)
	{
		PermissionSet permissionSet = null;
		PolicyLevel policyLevel = null;
		IEnumerator enumerator = PolicyLevels.GetEnumerator();
		evidence.GetHostEvidence<Zone>();
		evidence.GetHostEvidence<StrongName>();
		evidence.GetHostEvidence<Url>();
		byte[] serializedEvidence = evidence.RawSerialize();
		int rawCount = evidence.RawCount;
		bool flag = AppDomain.CurrentDomain.GetData("IgnoreSystemPolicy") != null;
		bool flag2 = false;
		while (enumerator.MoveNext())
		{
			policyLevel = (PolicyLevel)enumerator.Current;
			if (systemPolicy)
			{
				if (policyLevel.Type == PolicyLevelType.AppDomain)
				{
					continue;
				}
			}
			else if (flag && policyLevel.Type != PolicyLevelType.AppDomain)
			{
				continue;
			}
			PolicyStatement policyStatement = policyLevel.Resolve(evidence, rawCount, serializedEvidence);
			if (permissionSet == null)
			{
				permissionSet = policyStatement.PermissionSet;
			}
			else
			{
				permissionSet.InplaceIntersect(policyStatement.GetPermissionSetNoCopy());
			}
			if (permissionSet == null || permissionSet.FastIsEmpty())
			{
				break;
			}
			if ((policyStatement.Attributes & PolicyStatementAttribute.LevelFinal) == PolicyStatementAttribute.LevelFinal)
			{
				if (policyLevel.Type != PolicyLevelType.AppDomain)
				{
					flag2 = true;
				}
				break;
			}
		}
		if (permissionSet != null && flag2)
		{
			PolicyLevel policyLevel2 = null;
			for (int num = PolicyLevels.Count - 1; num >= 0; num--)
			{
				policyLevel = (PolicyLevel)PolicyLevels[num];
				if (policyLevel.Type == PolicyLevelType.AppDomain)
				{
					policyLevel2 = policyLevel;
					break;
				}
			}
			if (policyLevel2 != null)
			{
				PolicyStatement policyStatement = policyLevel2.Resolve(evidence, rawCount, serializedEvidence);
				permissionSet.InplaceIntersect(policyStatement.GetPermissionSetNoCopy());
			}
		}
		if (permissionSet == null)
		{
			permissionSet = new PermissionSet(PermissionState.None);
		}
		if (!permissionSet.IsUnrestricted())
		{
			IEnumerator hostEnumerator = evidence.GetHostEnumerator();
			while (hostEnumerator.MoveNext())
			{
				object current = hostEnumerator.Current;
				if (current is IIdentityPermissionFactory identityPermissionFactory)
				{
					IPermission permission = identityPermissionFactory.CreateIdentityPermission(evidence);
					if (permission != null)
					{
						permissionSet.AddPermission(permission);
					}
				}
			}
		}
		permissionSet.IgnoreTypeLoadFailures = true;
		return permissionSet;
	}

	internal static bool IsGacAssembly(Evidence evidence)
	{
		return new GacMembershipCondition().Check(evidence);
	}

	[SecurityCritical]
	internal IEnumerator ResolveCodeGroups(Evidence evidence)
	{
		ArrayList arrayList = new ArrayList();
		IEnumerator enumerator = PolicyLevels.GetEnumerator();
		while (enumerator.MoveNext())
		{
			CodeGroup codeGroup = ((PolicyLevel)enumerator.Current).ResolveMatchingCodeGroups(evidence);
			if (codeGroup != null)
			{
				arrayList.Add(codeGroup);
			}
		}
		return arrayList.GetEnumerator(0, arrayList.Count);
	}

	internal static PolicyStatement ResolveCodeGroup(CodeGroup codeGroup, Evidence evidence)
	{
		if (codeGroup.GetType().Assembly != typeof(UnionCodeGroup).Assembly)
		{
			evidence.MarkAllEvidenceAsUsed();
		}
		return codeGroup.Resolve(evidence);
	}

	internal static bool CheckMembershipCondition(IMembershipCondition membershipCondition, Evidence evidence, out object usedEvidence)
	{
		if (membershipCondition is IReportMatchMembershipCondition reportMatchMembershipCondition)
		{
			return reportMatchMembershipCondition.Check(evidence, out usedEvidence);
		}
		usedEvidence = null;
		evidence.MarkAllEvidenceAsUsed();
		return membershipCondition.Check(evidence);
	}

	[SecurityCritical]
	internal void Save()
	{
		EncodeLevel(Environment.GetResourceString("Policy_PL_Enterprise"));
		EncodeLevel(Environment.GetResourceString("Policy_PL_Machine"));
		EncodeLevel(Environment.GetResourceString("Policy_PL_User"));
	}

	[SecurityCritical]
	private void EncodeLevel(string label)
	{
		for (int i = 0; i < PolicyLevels.Count; i++)
		{
			PolicyLevel policyLevel = (PolicyLevel)PolicyLevels[i];
			if (policyLevel.Label.Equals(label))
			{
				EncodeLevel(policyLevel);
				break;
			}
		}
	}

	[SecurityCritical]
	internal static void EncodeLevel(PolicyLevel level)
	{
		if (level.Path == null)
		{
			string resourceString = Environment.GetResourceString("Policy_UnableToSave", level.Label, Environment.GetResourceString("Policy_SaveNotFileBased"));
			throw new PolicyException(resourceString);
		}
		SecurityElement securityElement = new SecurityElement("configuration");
		SecurityElement securityElement2 = new SecurityElement("mscorlib");
		SecurityElement securityElement3 = new SecurityElement("security");
		SecurityElement securityElement4 = new SecurityElement("policy");
		securityElement.AddChild(securityElement2);
		securityElement2.AddChild(securityElement3);
		securityElement3.AddChild(securityElement4);
		securityElement4.AddChild(level.ToXml());
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			Encoding uTF = Encoding.UTF8;
			SecurityElement securityElement5 = new SecurityElement("xml");
			securityElement5.m_type = SecurityElementType.Format;
			securityElement5.AddAttribute("version", "1.0");
			securityElement5.AddAttribute("encoding", uTF.WebName);
			stringBuilder.Append(securityElement5.ToString());
			stringBuilder.Append(securityElement.ToString());
			byte[] bytes = uTF.GetBytes(stringBuilder.ToString());
			int errorCode = Config.SaveDataByte(level.Path, bytes, bytes.Length);
			Exception exceptionForHR = Marshal.GetExceptionForHR(errorCode);
			if (exceptionForHR != null)
			{
				string text = ((exceptionForHR != null) ? exceptionForHR.Message : string.Empty);
				throw new PolicyException(Environment.GetResourceString("Policy_UnableToSave", level.Label, text), exceptionForHR);
			}
		}
		catch (Exception ex)
		{
			if (ex is PolicyException)
			{
				throw ex;
			}
			throw new PolicyException(Environment.GetResourceString("Policy_UnableToSave", level.Label, ex.Message), ex);
		}
		Config.ResetCacheData(level.ConfigId);
		if (CanUseQuickCache(level.RootCodeGroup))
		{
			Config.SetQuickCache(level.ConfigId, GenerateQuickCache(level));
		}
	}

	internal static bool CanUseQuickCache(CodeGroup group)
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(group);
		for (int i = 0; i < arrayList.Count; i++)
		{
			group = (CodeGroup)arrayList[i];
			if (group is IUnionSemanticCodeGroup)
			{
				if (!TestPolicyStatement(group.PolicyStatement))
				{
					return false;
				}
				IMembershipCondition membershipCondition = group.MembershipCondition;
				if (membershipCondition != null && !(membershipCondition is IConstantMembershipCondition))
				{
					return false;
				}
				IList children = group.Children;
				if (children != null && children.Count > 0)
				{
					IEnumerator enumerator = children.GetEnumerator();
					while (enumerator.MoveNext())
					{
						arrayList.Add(enumerator.Current);
					}
				}
				continue;
			}
			return false;
		}
		return true;
	}

	private static bool TestPolicyStatement(PolicyStatement policy)
	{
		if (policy == null)
		{
			return true;
		}
		return (policy.Attributes & PolicyStatementAttribute.Exclusive) == 0;
	}

	private static QuickCacheEntryType GenerateQuickCache(PolicyLevel level)
	{
		if (FullTrustMap == null)
		{
			FullTrustMap = new QuickCacheEntryType[5]
			{
				QuickCacheEntryType.FullTrustZoneMyComputer,
				QuickCacheEntryType.FullTrustZoneIntranet,
				QuickCacheEntryType.FullTrustZoneTrusted,
				QuickCacheEntryType.FullTrustZoneInternet,
				QuickCacheEntryType.FullTrustZoneUntrusted
			};
		}
		QuickCacheEntryType quickCacheEntryType = (QuickCacheEntryType)0;
		Evidence evidence = new Evidence();
		PermissionSet permissionSet = null;
		try
		{
			permissionSet = level.Resolve(evidence).PermissionSet;
			if (permissionSet.IsUnrestricted())
			{
				quickCacheEntryType |= QuickCacheEntryType.FullTrustAll;
			}
		}
		catch (PolicyException)
		{
		}
		foreach (SecurityZone value in Enum.GetValues(typeof(SecurityZone)))
		{
			if (value == SecurityZone.NoZone)
			{
				continue;
			}
			Evidence evidence2 = new Evidence();
			evidence2.AddHostEvidence(new Zone(value));
			PermissionSet permissionSet2 = null;
			try
			{
				permissionSet2 = level.Resolve(evidence2).PermissionSet;
				if (permissionSet2.IsUnrestricted())
				{
					quickCacheEntryType |= FullTrustMap[(int)value];
				}
			}
			catch (PolicyException)
			{
			}
		}
		return quickCacheEntryType;
	}
}

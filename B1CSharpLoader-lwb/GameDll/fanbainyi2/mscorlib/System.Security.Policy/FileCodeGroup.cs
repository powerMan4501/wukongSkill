using System.Collections;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Security.Util;

namespace System.Security.Policy;

[Serializable]
[ComVisible(true)]
public sealed class FileCodeGroup : CodeGroup, IUnionSemanticCodeGroup
{
	private FileIOPermissionAccess m_access;

	public override string MergeLogic => Environment.GetResourceString("MergeLogic_Union");

	public override string PermissionSetName => Environment.GetResourceString("FileCodeGroup_PermissionSet", XMLUtil.BitFieldEnumToString(typeof(FileIOPermissionAccess), m_access));

	public override string AttributeString => null;

	internal FileCodeGroup()
	{
	}

	public FileCodeGroup(IMembershipCondition membershipCondition, FileIOPermissionAccess access)
		: base(membershipCondition, (PolicyStatement)null)
	{
		m_access = access;
	}

	[SecuritySafeCritical]
	public override PolicyStatement Resolve(Evidence evidence)
	{
		if (evidence == null)
		{
			throw new ArgumentNullException("evidence");
		}
		object usedEvidence = null;
		if (PolicyManager.CheckMembershipCondition(base.MembershipCondition, evidence, out usedEvidence))
		{
			PolicyStatement policyStatement = CalculateAssemblyPolicy(evidence);
			if (usedEvidence is IDelayEvaluatedEvidence { IsVerified: false } delayEvaluatedEvidence)
			{
				policyStatement.AddDependentEvidence(delayEvaluatedEvidence);
			}
			bool flag = false;
			IEnumerator enumerator = base.Children.GetEnumerator();
			while (enumerator.MoveNext() && !flag)
			{
				PolicyStatement policyStatement2 = PolicyManager.ResolveCodeGroup(enumerator.Current as CodeGroup, evidence);
				if (policyStatement2 != null)
				{
					policyStatement.InplaceUnion(policyStatement2);
					if ((policyStatement2.Attributes & PolicyStatementAttribute.Exclusive) == PolicyStatementAttribute.Exclusive)
					{
						flag = true;
					}
				}
			}
			return policyStatement;
		}
		return null;
	}

	PolicyStatement IUnionSemanticCodeGroup.InternalResolve(Evidence evidence)
	{
		if (evidence == null)
		{
			throw new ArgumentNullException("evidence");
		}
		if (base.MembershipCondition.Check(evidence))
		{
			return CalculateAssemblyPolicy(evidence);
		}
		return null;
	}

	public override CodeGroup ResolveMatchingCodeGroups(Evidence evidence)
	{
		if (evidence == null)
		{
			throw new ArgumentNullException("evidence");
		}
		if (base.MembershipCondition.Check(evidence))
		{
			CodeGroup codeGroup = Copy();
			codeGroup.Children = new ArrayList();
			IEnumerator enumerator = base.Children.GetEnumerator();
			while (enumerator.MoveNext())
			{
				CodeGroup codeGroup2 = ((CodeGroup)enumerator.Current).ResolveMatchingCodeGroups(evidence);
				if (codeGroup2 != null)
				{
					codeGroup.AddChild(codeGroup2);
				}
			}
			return codeGroup;
		}
		return null;
	}

	internal PolicyStatement CalculatePolicy(Url url)
	{
		URLString uRLString = url.GetURLString();
		if (string.Compare(uRLString.Scheme, "file", StringComparison.OrdinalIgnoreCase) != 0)
		{
			return null;
		}
		string directoryName = uRLString.GetDirectoryName();
		PermissionSet permissionSet = new PermissionSet(PermissionState.None);
		permissionSet.SetPermission(new FileIOPermission(m_access, Path.GetFullPath(directoryName)));
		return new PolicyStatement(permissionSet, PolicyStatementAttribute.Nothing);
	}

	private PolicyStatement CalculateAssemblyPolicy(Evidence evidence)
	{
		PolicyStatement policyStatement = null;
		Url hostEvidence = evidence.GetHostEvidence<Url>();
		if (hostEvidence != null)
		{
			policyStatement = CalculatePolicy(hostEvidence);
		}
		if (policyStatement == null)
		{
			policyStatement = new PolicyStatement(new PermissionSet(fUnrestricted: false), PolicyStatementAttribute.Nothing);
		}
		return policyStatement;
	}

	public override CodeGroup Copy()
	{
		FileCodeGroup fileCodeGroup = new FileCodeGroup(base.MembershipCondition, m_access);
		fileCodeGroup.Name = base.Name;
		fileCodeGroup.Description = base.Description;
		IEnumerator enumerator = base.Children.GetEnumerator();
		while (enumerator.MoveNext())
		{
			fileCodeGroup.AddChild((CodeGroup)enumerator.Current);
		}
		return fileCodeGroup;
	}

	protected override void CreateXml(SecurityElement element, PolicyLevel level)
	{
		element.AddAttribute("Access", XMLUtil.BitFieldEnumToString(typeof(FileIOPermissionAccess), m_access));
	}

	protected override void ParseXml(SecurityElement e, PolicyLevel level)
	{
		string text = e.Attribute("Access");
		if (text != null)
		{
			m_access = (FileIOPermissionAccess)Enum.Parse(typeof(FileIOPermissionAccess), text);
		}
		else
		{
			m_access = FileIOPermissionAccess.NoAccess;
		}
	}

	public override bool Equals(object o)
	{
		if (o is FileCodeGroup fileCodeGroup && base.Equals((object)fileCodeGroup) && m_access == fileCodeGroup.m_access)
		{
			return true;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return base.GetHashCode() + m_access.GetHashCode();
	}

	internal override string GetTypeName()
	{
		return "System.Security.Policy.FileCodeGroup";
	}
}

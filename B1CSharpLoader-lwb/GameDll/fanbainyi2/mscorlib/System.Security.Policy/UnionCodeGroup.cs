using System.Collections;
using System.Runtime.InteropServices;

namespace System.Security.Policy;

[Serializable]
[ComVisible(true)]
[Obsolete("This type is obsolete and will be removed in a future release of the .NET Framework. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
public sealed class UnionCodeGroup : CodeGroup, IUnionSemanticCodeGroup
{
	public override string MergeLogic => Environment.GetResourceString("MergeLogic_Union");

	internal UnionCodeGroup()
	{
	}

	internal UnionCodeGroup(IMembershipCondition membershipCondition, PermissionSet permSet)
		: base(membershipCondition, permSet)
	{
	}

	public UnionCodeGroup(IMembershipCondition membershipCondition, PolicyStatement policy)
		: base(membershipCondition, policy)
	{
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
			PolicyStatement policyStatement = base.PolicyStatement;
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
			return base.PolicyStatement;
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

	public override CodeGroup Copy()
	{
		UnionCodeGroup unionCodeGroup = new UnionCodeGroup();
		unionCodeGroup.MembershipCondition = base.MembershipCondition;
		unionCodeGroup.PolicyStatement = base.PolicyStatement;
		unionCodeGroup.Name = base.Name;
		unionCodeGroup.Description = base.Description;
		IEnumerator enumerator = base.Children.GetEnumerator();
		while (enumerator.MoveNext())
		{
			unionCodeGroup.AddChild((CodeGroup)enumerator.Current);
		}
		return unionCodeGroup;
	}

	internal override string GetTypeName()
	{
		return "System.Security.Policy.UnionCodeGroup";
	}
}

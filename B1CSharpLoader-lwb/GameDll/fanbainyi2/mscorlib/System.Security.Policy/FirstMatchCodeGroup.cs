using System.Collections;
using System.Runtime.InteropServices;

namespace System.Security.Policy;

[Serializable]
[ComVisible(true)]
[Obsolete("This type is obsolete and will be removed in a future release of the .NET Framework. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
public sealed class FirstMatchCodeGroup : CodeGroup
{
	public override string MergeLogic => Environment.GetResourceString("MergeLogic_FirstMatch");

	internal FirstMatchCodeGroup()
	{
	}

	public FirstMatchCodeGroup(IMembershipCondition membershipCondition, PolicyStatement policy)
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
			PolicyStatement policyStatement = null;
			IEnumerator enumerator = base.Children.GetEnumerator();
			while (enumerator.MoveNext())
			{
				policyStatement = PolicyManager.ResolveCodeGroup(enumerator.Current as CodeGroup, evidence);
				if (policyStatement != null)
				{
					break;
				}
			}
			IDelayEvaluatedEvidence delayEvaluatedEvidence = usedEvidence as IDelayEvaluatedEvidence;
			bool flag = delayEvaluatedEvidence != null && !delayEvaluatedEvidence.IsVerified;
			PolicyStatement policyStatement2 = base.PolicyStatement;
			if (policyStatement2 == null)
			{
				if (flag)
				{
					policyStatement = policyStatement.Copy();
					policyStatement.AddDependentEvidence(delayEvaluatedEvidence);
				}
				return policyStatement;
			}
			if (policyStatement != null)
			{
				PolicyStatement policyStatement3 = policyStatement2.Copy();
				if (flag)
				{
					policyStatement3.AddDependentEvidence(delayEvaluatedEvidence);
				}
				policyStatement3.InplaceUnion(policyStatement);
				return policyStatement3;
			}
			if (flag)
			{
				policyStatement2.AddDependentEvidence(delayEvaluatedEvidence);
			}
			return policyStatement2;
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
					break;
				}
			}
			return codeGroup;
		}
		return null;
	}

	public override CodeGroup Copy()
	{
		FirstMatchCodeGroup firstMatchCodeGroup = new FirstMatchCodeGroup();
		firstMatchCodeGroup.MembershipCondition = base.MembershipCondition;
		firstMatchCodeGroup.PolicyStatement = base.PolicyStatement;
		firstMatchCodeGroup.Name = base.Name;
		firstMatchCodeGroup.Description = base.Description;
		IEnumerator enumerator = base.Children.GetEnumerator();
		while (enumerator.MoveNext())
		{
			firstMatchCodeGroup.AddChild((CodeGroup)enumerator.Current);
		}
		return firstMatchCodeGroup;
	}

	internal override string GetTypeName()
	{
		return "System.Security.Policy.FirstMatchCodeGroup";
	}
}

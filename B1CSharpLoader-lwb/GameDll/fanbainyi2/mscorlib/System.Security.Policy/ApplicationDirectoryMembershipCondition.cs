using System.Runtime.InteropServices;
using System.Security.Util;

namespace System.Security.Policy;

[Serializable]
[ComVisible(true)]
public sealed class ApplicationDirectoryMembershipCondition : IMembershipCondition, ISecurityEncodable, ISecurityPolicyEncodable, IConstantMembershipCondition, IReportMatchMembershipCondition
{
	public bool Check(Evidence evidence)
	{
		object usedEvidence = null;
		return ((IReportMatchMembershipCondition)this).Check(evidence, out usedEvidence);
	}

	bool IReportMatchMembershipCondition.Check(Evidence evidence, out object usedEvidence)
	{
		usedEvidence = null;
		if (evidence == null)
		{
			return false;
		}
		ApplicationDirectory hostEvidence = evidence.GetHostEvidence<ApplicationDirectory>();
		Url hostEvidence2 = evidence.GetHostEvidence<Url>();
		if (hostEvidence != null && hostEvidence2 != null)
		{
			string directory = hostEvidence.Directory;
			if (directory != null && directory.Length > 1)
			{
				directory = ((directory[directory.Length - 1] != '/') ? (directory + "/*") : (directory + "*"));
				URLString operand = new URLString(directory);
				if (hostEvidence2.GetURLString().IsSubsetOf(operand))
				{
					usedEvidence = hostEvidence;
					return true;
				}
			}
		}
		return false;
	}

	public IMembershipCondition Copy()
	{
		return new ApplicationDirectoryMembershipCondition();
	}

	public SecurityElement ToXml()
	{
		return ToXml(null);
	}

	public void FromXml(SecurityElement e)
	{
		FromXml(e, null);
	}

	public SecurityElement ToXml(PolicyLevel level)
	{
		SecurityElement securityElement = new SecurityElement("IMembershipCondition");
		XMLUtil.AddClassAttribute(securityElement, GetType(), "System.Security.Policy.ApplicationDirectoryMembershipCondition");
		securityElement.AddAttribute("version", "1");
		return securityElement;
	}

	public void FromXml(SecurityElement e, PolicyLevel level)
	{
		if (e == null)
		{
			throw new ArgumentNullException("e");
		}
		if (!e.Tag.Equals("IMembershipCondition"))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MembershipConditionElement"));
		}
	}

	public override bool Equals(object o)
	{
		return o is ApplicationDirectoryMembershipCondition;
	}

	public override int GetHashCode()
	{
		return typeof(ApplicationDirectoryMembershipCondition).GetHashCode();
	}

	public override string ToString()
	{
		return Environment.GetResourceString("ApplicationDirectory_ToString");
	}
}

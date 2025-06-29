using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Util;

namespace System.Security.Policy;

[Serializable]
[ComVisible(true)]
public sealed class ZoneMembershipCondition : IMembershipCondition, ISecurityEncodable, ISecurityPolicyEncodable, IConstantMembershipCondition, IReportMatchMembershipCondition
{
	private static readonly string[] s_names = new string[5] { "MyComputer", "Intranet", "Trusted", "Internet", "Untrusted" };

	private SecurityZone m_zone;

	private SecurityElement m_element;

	public SecurityZone SecurityZone
	{
		get
		{
			if (m_zone == SecurityZone.NoZone && m_element != null)
			{
				ParseZone();
			}
			return m_zone;
		}
		set
		{
			VerifyZone(value);
			m_zone = value;
		}
	}

	internal ZoneMembershipCondition()
	{
		m_zone = SecurityZone.NoZone;
	}

	public ZoneMembershipCondition(SecurityZone zone)
	{
		VerifyZone(zone);
		SecurityZone = zone;
	}

	private static void VerifyZone(SecurityZone zone)
	{
		if (zone < SecurityZone.MyComputer || zone > SecurityZone.Untrusted)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_IllegalZone"));
		}
	}

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
		Zone hostEvidence = evidence.GetHostEvidence<Zone>();
		if (hostEvidence != null)
		{
			if (m_zone == SecurityZone.NoZone && m_element != null)
			{
				ParseZone();
			}
			if (hostEvidence.SecurityZone == m_zone)
			{
				usedEvidence = hostEvidence;
				return true;
			}
		}
		return false;
	}

	public IMembershipCondition Copy()
	{
		if (m_zone == SecurityZone.NoZone && m_element != null)
		{
			ParseZone();
		}
		return new ZoneMembershipCondition(m_zone);
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
		if (m_zone == SecurityZone.NoZone && m_element != null)
		{
			ParseZone();
		}
		SecurityElement securityElement = new SecurityElement("IMembershipCondition");
		XMLUtil.AddClassAttribute(securityElement, GetType(), "System.Security.Policy.ZoneMembershipCondition");
		securityElement.AddAttribute("version", "1");
		if (m_zone != SecurityZone.NoZone)
		{
			securityElement.AddAttribute("Zone", Enum.GetName(typeof(SecurityZone), m_zone));
		}
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
		lock (this)
		{
			m_zone = SecurityZone.NoZone;
			m_element = e;
		}
	}

	private void ParseZone()
	{
		lock (this)
		{
			if (m_element != null)
			{
				string text = m_element.Attribute("Zone");
				m_zone = SecurityZone.NoZone;
				if (text == null)
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_ZoneCannotBeNull"));
				}
				m_zone = (SecurityZone)Enum.Parse(typeof(SecurityZone), text);
				VerifyZone(m_zone);
				m_element = null;
			}
		}
	}

	public override bool Equals(object o)
	{
		if (o is ZoneMembershipCondition zoneMembershipCondition)
		{
			if (m_zone == SecurityZone.NoZone && m_element != null)
			{
				ParseZone();
			}
			if (zoneMembershipCondition.m_zone == SecurityZone.NoZone && zoneMembershipCondition.m_element != null)
			{
				zoneMembershipCondition.ParseZone();
			}
			if (m_zone == zoneMembershipCondition.m_zone)
			{
				return true;
			}
		}
		return false;
	}

	public override int GetHashCode()
	{
		if (m_zone == SecurityZone.NoZone && m_element != null)
		{
			ParseZone();
		}
		return (int)m_zone;
	}

	public override string ToString()
	{
		if (m_zone == SecurityZone.NoZone && m_element != null)
		{
			ParseZone();
		}
		return string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Zone_ToString"), s_names[(int)m_zone]);
	}
}

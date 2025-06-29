using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Util;

namespace System.Security.Policy;

[Serializable]
[ComVisible(true)]
public sealed class SiteMembershipCondition : IMembershipCondition, ISecurityEncodable, ISecurityPolicyEncodable, IConstantMembershipCondition, IReportMatchMembershipCondition
{
	private SiteString m_site;

	private SecurityElement m_element;

	public string Site
	{
		get
		{
			if (m_site == null && m_element != null)
			{
				ParseSite();
			}
			if (m_site != null)
			{
				return m_site.ToString();
			}
			return "";
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			m_site = new SiteString(value);
		}
	}

	internal SiteMembershipCondition()
	{
		m_site = null;
	}

	public SiteMembershipCondition(string site)
	{
		if (site == null)
		{
			throw new ArgumentNullException("site");
		}
		m_site = new SiteString(site);
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
		Site hostEvidence = evidence.GetHostEvidence<Site>();
		if (hostEvidence != null)
		{
			if (m_site == null && m_element != null)
			{
				ParseSite();
			}
			if (hostEvidence.GetSiteString().IsSubsetOf(m_site))
			{
				usedEvidence = hostEvidence;
				return true;
			}
		}
		return false;
	}

	public IMembershipCondition Copy()
	{
		if (m_site == null && m_element != null)
		{
			ParseSite();
		}
		return new SiteMembershipCondition(m_site.ToString());
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
		if (m_site == null && m_element != null)
		{
			ParseSite();
		}
		SecurityElement securityElement = new SecurityElement("IMembershipCondition");
		XMLUtil.AddClassAttribute(securityElement, GetType(), "System.Security.Policy.SiteMembershipCondition");
		securityElement.AddAttribute("version", "1");
		if (m_site != null)
		{
			securityElement.AddAttribute("Site", m_site.ToString());
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
			m_site = null;
			m_element = e;
		}
	}

	private void ParseSite()
	{
		lock (this)
		{
			if (m_element != null)
			{
				string text = m_element.Attribute("Site");
				if (text == null)
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_SiteCannotBeNull"));
				}
				m_site = new SiteString(text);
				m_element = null;
			}
		}
	}

	public override bool Equals(object o)
	{
		if (o is SiteMembershipCondition siteMembershipCondition)
		{
			if (m_site == null && m_element != null)
			{
				ParseSite();
			}
			if (siteMembershipCondition.m_site == null && siteMembershipCondition.m_element != null)
			{
				siteMembershipCondition.ParseSite();
			}
			if (object.Equals(m_site, siteMembershipCondition.m_site))
			{
				return true;
			}
		}
		return false;
	}

	public override int GetHashCode()
	{
		if (m_site == null && m_element != null)
		{
			ParseSite();
		}
		if (m_site != null)
		{
			return m_site.GetHashCode();
		}
		return typeof(SiteMembershipCondition).GetHashCode();
	}

	public override string ToString()
	{
		if (m_site == null && m_element != null)
		{
			ParseSite();
		}
		if (m_site != null)
		{
			return string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Site_ToStringArg"), m_site);
		}
		return Environment.GetResourceString("Site_ToString");
	}
}

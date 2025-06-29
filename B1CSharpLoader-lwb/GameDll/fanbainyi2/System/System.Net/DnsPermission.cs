using System.Security;
using System.Security.Permissions;

namespace System.Net;

[Serializable]
public sealed class DnsPermission : CodeAccessPermission, IUnrestrictedPermission
{
	private bool m_noRestriction;

	public DnsPermission(PermissionState state)
	{
		m_noRestriction = state == PermissionState.Unrestricted;
	}

	internal DnsPermission(bool free)
	{
		m_noRestriction = free;
	}

	public bool IsUnrestricted()
	{
		return m_noRestriction;
	}

	public override IPermission Copy()
	{
		return new DnsPermission(m_noRestriction);
	}

	public override IPermission Union(IPermission target)
	{
		if (target == null)
		{
			return Copy();
		}
		if (!(target is DnsPermission dnsPermission))
		{
			throw new ArgumentException(SR.GetString("net_perm_target"), "target");
		}
		return new DnsPermission(m_noRestriction || dnsPermission.m_noRestriction);
	}

	public override IPermission Intersect(IPermission target)
	{
		if (target == null)
		{
			return null;
		}
		if (!(target is DnsPermission dnsPermission))
		{
			throw new ArgumentException(SR.GetString("net_perm_target"), "target");
		}
		if (m_noRestriction && dnsPermission.m_noRestriction)
		{
			return new DnsPermission(free: true);
		}
		return null;
	}

	public override bool IsSubsetOf(IPermission target)
	{
		if (target == null)
		{
			return !m_noRestriction;
		}
		if (!(target is DnsPermission dnsPermission))
		{
			throw new ArgumentException(SR.GetString("net_perm_target"), "target");
		}
		if (m_noRestriction)
		{
			return dnsPermission.m_noRestriction;
		}
		return true;
	}

	public override void FromXml(SecurityElement securityElement)
	{
		if (securityElement == null)
		{
			throw new ArgumentNullException("securityElement");
		}
		if (!securityElement.Tag.Equals("IPermission"))
		{
			throw new ArgumentException(SR.GetString("net_no_classname"), "securityElement");
		}
		string text = securityElement.Attribute("class");
		if (text == null)
		{
			throw new ArgumentException(SR.GetString("net_no_classname"), "securityElement");
		}
		if (text.IndexOf(GetType().FullName) < 0)
		{
			throw new ArgumentException(SR.GetString("net_no_typename"), "securityElement");
		}
		string text2 = securityElement.Attribute("Unrestricted");
		m_noRestriction = text2 != null && string.Compare(text2, "true", StringComparison.OrdinalIgnoreCase) == 0;
	}

	public override SecurityElement ToXml()
	{
		SecurityElement securityElement = new SecurityElement("IPermission");
		securityElement.AddAttribute("class", GetType().FullName + ", " + GetType().Module.Assembly.FullName.Replace('"', '\''));
		securityElement.AddAttribute("version", "1");
		if (m_noRestriction)
		{
			securityElement.AddAttribute("Unrestricted", "true");
		}
		return securityElement;
	}
}

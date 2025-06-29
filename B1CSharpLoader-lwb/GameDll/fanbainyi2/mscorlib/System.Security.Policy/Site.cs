using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Security.Util;

namespace System.Security.Policy;

[Serializable]
[ComVisible(true)]
public sealed class Site : EvidenceBase, IIdentityPermissionFactory
{
	private SiteString m_name;

	public string Name => m_name.ToString();

	public Site(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		m_name = new SiteString(name);
	}

	private Site(SiteString name)
	{
		m_name = name;
	}

	public static Site CreateFromUrl(string url)
	{
		return new Site(ParseSiteFromUrl(url));
	}

	private static SiteString ParseSiteFromUrl(string name)
	{
		URLString uRLString = new URLString(name);
		if (string.Compare(uRLString.Scheme, "file", StringComparison.OrdinalIgnoreCase) == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidSite"));
		}
		return new SiteString(new URLString(name).Host);
	}

	internal SiteString GetSiteString()
	{
		return m_name;
	}

	public IPermission CreateIdentityPermission(Evidence evidence)
	{
		return new SiteIdentityPermission(Name);
	}

	public override bool Equals(object o)
	{
		if (!(o is Site site))
		{
			return false;
		}
		return string.Equals(Name, site.Name, StringComparison.OrdinalIgnoreCase);
	}

	public override int GetHashCode()
	{
		return Name.GetHashCode();
	}

	public override EvidenceBase Clone()
	{
		return new Site(m_name);
	}

	public object Copy()
	{
		return Clone();
	}

	internal SecurityElement ToXml()
	{
		SecurityElement securityElement = new SecurityElement("System.Security.Policy.Site");
		securityElement.AddAttribute("version", "1");
		if (m_name != null)
		{
			securityElement.AddChild(new SecurityElement("Name", m_name.ToString()));
		}
		return securityElement;
	}

	public override string ToString()
	{
		return ToXml().ToString();
	}

	internal object Normalize()
	{
		return m_name.ToString().ToUpper(CultureInfo.InvariantCulture);
	}
}

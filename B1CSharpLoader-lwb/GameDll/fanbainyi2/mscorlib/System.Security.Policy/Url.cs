using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Security.Util;

namespace System.Security.Policy;

[Serializable]
[ComVisible(true)]
public sealed class Url : EvidenceBase, IIdentityPermissionFactory
{
	private URLString m_url;

	public string Value => m_url.ToString();

	internal Url(string name, bool parsed)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		m_url = new URLString(name, parsed);
	}

	public Url(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		m_url = new URLString(name);
	}

	private Url(Url url)
	{
		m_url = url.m_url;
	}

	internal URLString GetURLString()
	{
		return m_url;
	}

	public IPermission CreateIdentityPermission(Evidence evidence)
	{
		return new UrlIdentityPermission(m_url);
	}

	public override bool Equals(object o)
	{
		if (!(o is Url url))
		{
			return false;
		}
		return url.m_url.Equals(m_url);
	}

	public override int GetHashCode()
	{
		return m_url.GetHashCode();
	}

	public override EvidenceBase Clone()
	{
		return new Url(this);
	}

	public object Copy()
	{
		return Clone();
	}

	internal SecurityElement ToXml()
	{
		SecurityElement securityElement = new SecurityElement("System.Security.Policy.Url");
		securityElement.AddAttribute("version", "1");
		if (m_url != null)
		{
			securityElement.AddChild(new SecurityElement("Url", m_url.ToString()));
		}
		return securityElement;
	}

	public override string ToString()
	{
		return ToXml().ToString();
	}

	internal object Normalize()
	{
		return m_url.NormalizeUrl();
	}
}

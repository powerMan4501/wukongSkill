using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Security.Policy;

[Serializable]
[ComVisible(true)]
public sealed class Zone : EvidenceBase, IIdentityPermissionFactory
{
	[OptionalField(VersionAdded = 2)]
	private string m_url;

	private SecurityZone m_zone;

	private static readonly string[] s_names = new string[6] { "MyComputer", "Intranet", "Trusted", "Internet", "Untrusted", "NoZone" };

	public SecurityZone SecurityZone
	{
		[SecuritySafeCritical]
		get
		{
			if (m_url != null)
			{
				m_zone = _CreateFromUrl(m_url);
			}
			return m_zone;
		}
	}

	public Zone(SecurityZone zone)
	{
		if (zone < SecurityZone.NoZone || zone > SecurityZone.Untrusted)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_IllegalZone"));
		}
		m_zone = zone;
	}

	private Zone(Zone zone)
	{
		m_url = zone.m_url;
		m_zone = zone.m_zone;
	}

	private Zone(string url)
	{
		m_url = url;
		m_zone = SecurityZone.NoZone;
	}

	public static Zone CreateFromUrl(string url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return new Zone(url);
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern SecurityZone _CreateFromUrl(string url);

	public IPermission CreateIdentityPermission(Evidence evidence)
	{
		return new ZoneIdentityPermission(SecurityZone);
	}

	public override bool Equals(object o)
	{
		if (!(o is Zone zone))
		{
			return false;
		}
		return SecurityZone == zone.SecurityZone;
	}

	public override int GetHashCode()
	{
		return (int)SecurityZone;
	}

	public override EvidenceBase Clone()
	{
		return new Zone(this);
	}

	public object Copy()
	{
		return Clone();
	}

	internal SecurityElement ToXml()
	{
		SecurityElement securityElement = new SecurityElement("System.Security.Policy.Zone");
		securityElement.AddAttribute("version", "1");
		if (SecurityZone != SecurityZone.NoZone)
		{
			securityElement.AddChild(new SecurityElement("Zone", s_names[(int)SecurityZone]));
		}
		else
		{
			securityElement.AddChild(new SecurityElement("Zone", s_names[s_names.Length - 1]));
		}
		return securityElement;
	}

	public override string ToString()
	{
		return ToXml().ToString();
	}

	internal object Normalize()
	{
		return s_names[(int)SecurityZone];
	}
}

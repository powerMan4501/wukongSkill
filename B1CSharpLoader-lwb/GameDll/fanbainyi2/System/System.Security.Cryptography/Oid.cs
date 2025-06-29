using System.Security.Cryptography.X509Certificates;

namespace System.Security.Cryptography;

public sealed class Oid
{
	private string m_value;

	private string m_friendlyName;

	private OidGroup m_group;

	public string Value
	{
		get
		{
			return m_value;
		}
		set
		{
			m_value = value;
		}
	}

	public string FriendlyName
	{
		get
		{
			if (m_friendlyName == null && m_value != null)
			{
				m_friendlyName = X509Utils.FindOidInfoWithFallback(1u, m_value, m_group);
			}
			return m_friendlyName;
		}
		set
		{
			m_friendlyName = value;
			if (m_friendlyName != null)
			{
				string text = X509Utils.FindOidInfoWithFallback(2u, m_friendlyName, m_group);
				if (text != null)
				{
					m_value = text;
				}
			}
		}
	}

	public Oid()
	{
	}

	public Oid(string oid)
		: this(oid, OidGroup.All, lookupFriendlyName: true)
	{
	}

	internal Oid(string oid, OidGroup group, bool lookupFriendlyName)
	{
		if (lookupFriendlyName)
		{
			string text = X509Utils.FindOidInfoWithFallback(2u, oid, group);
			if (text == null)
			{
				text = oid;
			}
			Value = text;
		}
		else
		{
			Value = oid;
		}
		m_group = group;
	}

	public Oid(string value, string friendlyName)
	{
		m_value = value;
		m_friendlyName = friendlyName;
	}

	public Oid(Oid oid)
	{
		if (oid == null)
		{
			throw new ArgumentNullException("oid");
		}
		m_value = oid.m_value;
		m_friendlyName = oid.m_friendlyName;
		m_group = oid.m_group;
	}

	private Oid(string value, string friendlyName, OidGroup group)
	{
		m_value = value;
		m_friendlyName = friendlyName;
		m_group = group;
	}

	public static Oid FromFriendlyName(string friendlyName, OidGroup group)
	{
		if (friendlyName == null)
		{
			throw new ArgumentNullException("friendlyName");
		}
		string text = X509Utils.FindOidInfo(2u, friendlyName, group);
		if (text == null)
		{
			throw new CryptographicException(SR.GetString("Cryptography_Oid_InvalidValue"));
		}
		return new Oid(text, friendlyName, group);
	}

	public static Oid FromOidValue(string oidValue, OidGroup group)
	{
		if (oidValue == null)
		{
			throw new ArgumentNullException("oidValue");
		}
		string text = X509Utils.FindOidInfo(1u, oidValue, group);
		if (text == null)
		{
			throw new CryptographicException(SR.GetString("Cryptography_Oid_InvalidValue"));
		}
		return new Oid(oidValue, text, group);
	}
}

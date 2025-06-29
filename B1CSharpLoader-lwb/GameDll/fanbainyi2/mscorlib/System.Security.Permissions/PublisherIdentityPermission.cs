using System.Collections;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Util;

namespace System.Security.Permissions;

[Serializable]
[ComVisible(true)]
public sealed class PublisherIdentityPermission : CodeAccessPermission, IBuiltInPermission
{
	private bool m_unrestricted;

	private X509Certificate[] m_certs;

	public X509Certificate Certificate
	{
		get
		{
			if (m_certs == null || m_certs.Length < 1)
			{
				return null;
			}
			if (m_certs.Length > 1)
			{
				throw new NotSupportedException(Environment.GetResourceString("NotSupported_AmbiguousIdentity"));
			}
			if (m_certs[0] == null)
			{
				return null;
			}
			return new X509Certificate(m_certs[0]);
		}
		set
		{
			CheckCertificate(value);
			m_unrestricted = false;
			m_certs = new X509Certificate[1];
			m_certs[0] = new X509Certificate(value);
		}
	}

	public PublisherIdentityPermission(PermissionState state)
	{
		switch (state)
		{
		case PermissionState.Unrestricted:
			m_unrestricted = true;
			break;
		case PermissionState.None:
			m_unrestricted = false;
			break;
		default:
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidPermissionState"));
		}
	}

	public PublisherIdentityPermission(X509Certificate certificate)
	{
		Certificate = certificate;
	}

	private static void CheckCertificate(X509Certificate certificate)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		if (certificate.GetRawCertData() == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_UninitializedCertificate"));
		}
	}

	public override IPermission Copy()
	{
		PublisherIdentityPermission publisherIdentityPermission = new PublisherIdentityPermission(PermissionState.None);
		publisherIdentityPermission.m_unrestricted = m_unrestricted;
		if (m_certs != null)
		{
			publisherIdentityPermission.m_certs = new X509Certificate[m_certs.Length];
			for (int i = 0; i < m_certs.Length; i++)
			{
				publisherIdentityPermission.m_certs[i] = ((m_certs[i] == null) ? null : new X509Certificate(m_certs[i]));
			}
		}
		return publisherIdentityPermission;
	}

	public override bool IsSubsetOf(IPermission target)
	{
		if (target == null)
		{
			if (m_unrestricted)
			{
				return false;
			}
			if (m_certs == null)
			{
				return true;
			}
			if (m_certs.Length == 0)
			{
				return true;
			}
			return false;
		}
		if (!(target is PublisherIdentityPermission publisherIdentityPermission))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_WrongType", GetType().FullName));
		}
		if (publisherIdentityPermission.m_unrestricted)
		{
			return true;
		}
		if (m_unrestricted)
		{
			return false;
		}
		if (m_certs != null)
		{
			X509Certificate[] certs = m_certs;
			foreach (X509Certificate x509Certificate in certs)
			{
				bool flag = false;
				if (publisherIdentityPermission.m_certs != null)
				{
					X509Certificate[] certs2 = publisherIdentityPermission.m_certs;
					foreach (X509Certificate other in certs2)
					{
						if (x509Certificate.Equals(other))
						{
							flag = true;
							break;
						}
					}
				}
				if (!flag)
				{
					return false;
				}
			}
		}
		return true;
	}

	public override IPermission Intersect(IPermission target)
	{
		if (target == null)
		{
			return null;
		}
		if (!(target is PublisherIdentityPermission publisherIdentityPermission))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_WrongType", GetType().FullName));
		}
		if (m_unrestricted && publisherIdentityPermission.m_unrestricted)
		{
			PublisherIdentityPermission publisherIdentityPermission2 = new PublisherIdentityPermission(PermissionState.None);
			publisherIdentityPermission2.m_unrestricted = true;
			return publisherIdentityPermission2;
		}
		if (m_unrestricted)
		{
			return publisherIdentityPermission.Copy();
		}
		if (publisherIdentityPermission.m_unrestricted)
		{
			return Copy();
		}
		if (m_certs == null || publisherIdentityPermission.m_certs == null || m_certs.Length == 0 || publisherIdentityPermission.m_certs.Length == 0)
		{
			return null;
		}
		ArrayList arrayList = new ArrayList();
		X509Certificate[] certs = m_certs;
		foreach (X509Certificate x509Certificate in certs)
		{
			X509Certificate[] certs2 = publisherIdentityPermission.m_certs;
			foreach (X509Certificate other in certs2)
			{
				if (x509Certificate.Equals(other))
				{
					arrayList.Add(new X509Certificate(x509Certificate));
				}
			}
		}
		if (arrayList.Count == 0)
		{
			return null;
		}
		PublisherIdentityPermission publisherIdentityPermission3 = new PublisherIdentityPermission(PermissionState.None);
		publisherIdentityPermission3.m_certs = (X509Certificate[])arrayList.ToArray(typeof(X509Certificate));
		return publisherIdentityPermission3;
	}

	public override IPermission Union(IPermission target)
	{
		if (target == null)
		{
			if ((m_certs == null || m_certs.Length == 0) && !m_unrestricted)
			{
				return null;
			}
			return Copy();
		}
		if (!(target is PublisherIdentityPermission publisherIdentityPermission))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_WrongType", GetType().FullName));
		}
		if (m_unrestricted || publisherIdentityPermission.m_unrestricted)
		{
			PublisherIdentityPermission publisherIdentityPermission2 = new PublisherIdentityPermission(PermissionState.None);
			publisherIdentityPermission2.m_unrestricted = true;
			return publisherIdentityPermission2;
		}
		if (m_certs == null || m_certs.Length == 0)
		{
			if (publisherIdentityPermission.m_certs == null || publisherIdentityPermission.m_certs.Length == 0)
			{
				return null;
			}
			return publisherIdentityPermission.Copy();
		}
		if (publisherIdentityPermission.m_certs == null || publisherIdentityPermission.m_certs.Length == 0)
		{
			return Copy();
		}
		ArrayList arrayList = new ArrayList();
		X509Certificate[] certs = m_certs;
		foreach (X509Certificate value in certs)
		{
			arrayList.Add(value);
		}
		X509Certificate[] certs2 = publisherIdentityPermission.m_certs;
		foreach (X509Certificate x509Certificate in certs2)
		{
			bool flag = false;
			foreach (X509Certificate item in arrayList)
			{
				if (x509Certificate.Equals(item))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				arrayList.Add(x509Certificate);
			}
		}
		PublisherIdentityPermission publisherIdentityPermission3 = new PublisherIdentityPermission(PermissionState.None);
		publisherIdentityPermission3.m_certs = (X509Certificate[])arrayList.ToArray(typeof(X509Certificate));
		return publisherIdentityPermission3;
	}

	public override void FromXml(SecurityElement esd)
	{
		m_unrestricted = false;
		m_certs = null;
		CodeAccessPermission.ValidateElement(esd, this);
		string text = esd.Attribute("Unrestricted");
		if (text != null && string.Compare(text, "true", StringComparison.OrdinalIgnoreCase) == 0)
		{
			m_unrestricted = true;
			return;
		}
		string text2 = esd.Attribute("X509v3Certificate");
		ArrayList arrayList = new ArrayList();
		if (text2 != null)
		{
			arrayList.Add(new X509Certificate(Hex.DecodeHexString(text2)));
		}
		ArrayList children = esd.Children;
		if (children != null)
		{
			foreach (SecurityElement item in children)
			{
				text2 = item.Attribute("X509v3Certificate");
				if (text2 != null)
				{
					arrayList.Add(new X509Certificate(Hex.DecodeHexString(text2)));
				}
			}
		}
		if (arrayList.Count != 0)
		{
			m_certs = (X509Certificate[])arrayList.ToArray(typeof(X509Certificate));
		}
	}

	public override SecurityElement ToXml()
	{
		SecurityElement securityElement = CodeAccessPermission.CreatePermissionElement(this, "System.Security.Permissions.PublisherIdentityPermission");
		if (m_unrestricted)
		{
			securityElement.AddAttribute("Unrestricted", "true");
		}
		else if (m_certs != null)
		{
			if (m_certs.Length == 1)
			{
				securityElement.AddAttribute("X509v3Certificate", m_certs[0].GetRawCertDataString());
			}
			else
			{
				for (int i = 0; i < m_certs.Length; i++)
				{
					SecurityElement securityElement2 = new SecurityElement("Cert");
					securityElement2.AddAttribute("X509v3Certificate", m_certs[i].GetRawCertDataString());
					securityElement.AddChild(securityElement2);
				}
			}
		}
		return securityElement;
	}

	int IBuiltInPermission.GetTokenIndex()
	{
		return GetTokenIndex();
	}

	internal static int GetTokenIndex()
	{
		return 10;
	}
}

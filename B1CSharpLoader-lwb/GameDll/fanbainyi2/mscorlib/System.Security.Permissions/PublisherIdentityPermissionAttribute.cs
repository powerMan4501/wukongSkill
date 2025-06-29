using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Util;

namespace System.Security.Permissions;

[Serializable]
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
[ComVisible(true)]
public sealed class PublisherIdentityPermissionAttribute : CodeAccessSecurityAttribute
{
	private string m_x509cert;

	private string m_certFile;

	private string m_signedFile;

	public string X509Certificate
	{
		get
		{
			return m_x509cert;
		}
		set
		{
			m_x509cert = value;
		}
	}

	public string CertFile
	{
		get
		{
			return m_certFile;
		}
		set
		{
			m_certFile = value;
		}
	}

	public string SignedFile
	{
		get
		{
			return m_signedFile;
		}
		set
		{
			m_signedFile = value;
		}
	}

	public PublisherIdentityPermissionAttribute(SecurityAction action)
		: base(action)
	{
		m_x509cert = null;
		m_certFile = null;
		m_signedFile = null;
	}

	public override IPermission CreatePermission()
	{
		if (m_unrestricted)
		{
			return new PublisherIdentityPermission(PermissionState.Unrestricted);
		}
		if (m_x509cert != null)
		{
			return new PublisherIdentityPermission(new X509Certificate(Hex.DecodeHexString(m_x509cert)));
		}
		if (m_certFile != null)
		{
			return new PublisherIdentityPermission(System.Security.Cryptography.X509Certificates.X509Certificate.CreateFromCertFile(m_certFile));
		}
		if (m_signedFile != null)
		{
			return new PublisherIdentityPermission(System.Security.Cryptography.X509Certificates.X509Certificate.CreateFromSignedFile(m_signedFile));
		}
		return new PublisherIdentityPermission(PermissionState.None);
	}
}

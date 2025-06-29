using System.Globalization;

namespace System.Security.Cryptography.X509Certificates;

public sealed class X509ChainPolicy
{
	private OidCollection m_applicationPolicy;

	private OidCollection m_certificatePolicy;

	private X509RevocationMode m_revocationMode;

	private X509RevocationFlag m_revocationFlag;

	private DateTime m_verificationTime;

	private TimeSpan m_timeout;

	private X509Certificate2Collection m_extraStore;

	private X509VerificationFlags m_verificationFlags;

	public OidCollection ApplicationPolicy => m_applicationPolicy;

	public OidCollection CertificatePolicy => m_certificatePolicy;

	public X509RevocationMode RevocationMode
	{
		get
		{
			return m_revocationMode;
		}
		set
		{
			if (value < X509RevocationMode.NoCheck || value > X509RevocationMode.Offline)
			{
				throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, System.SR.GetString("Arg_EnumIllegalVal"), new object[1] { "value" }));
			}
			m_revocationMode = value;
		}
	}

	public X509RevocationFlag RevocationFlag
	{
		get
		{
			return m_revocationFlag;
		}
		set
		{
			if (value < X509RevocationFlag.EndCertificateOnly || value > X509RevocationFlag.ExcludeRoot)
			{
				throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, System.SR.GetString("Arg_EnumIllegalVal"), new object[1] { "value" }));
			}
			m_revocationFlag = value;
		}
	}

	public X509VerificationFlags VerificationFlags
	{
		get
		{
			return m_verificationFlags;
		}
		set
		{
			if (value < X509VerificationFlags.NoFlag || value > X509VerificationFlags.AllFlags)
			{
				throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, System.SR.GetString("Arg_EnumIllegalVal"), new object[1] { "value" }));
			}
			m_verificationFlags = value;
		}
	}

	public DateTime VerificationTime
	{
		get
		{
			return m_verificationTime;
		}
		set
		{
			m_verificationTime = value;
		}
	}

	public TimeSpan UrlRetrievalTimeout
	{
		get
		{
			return m_timeout;
		}
		set
		{
			m_timeout = value;
		}
	}

	public X509Certificate2Collection ExtraStore => m_extraStore;

	public X509ChainPolicy()
	{
		Reset();
	}

	public void Reset()
	{
		m_applicationPolicy = new OidCollection();
		m_certificatePolicy = new OidCollection();
		m_revocationMode = X509RevocationMode.Online;
		m_revocationFlag = X509RevocationFlag.ExcludeRoot;
		m_verificationFlags = X509VerificationFlags.NoFlag;
		m_verificationTime = DateTime.Now;
		m_timeout = new TimeSpan(0, 0, 0);
		m_extraStore = new X509Certificate2Collection();
	}
}

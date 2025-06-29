using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Util;

namespace System.Security.Policy;

[Serializable]
[ComVisible(true)]
public sealed class PublisherMembershipCondition : IMembershipCondition, ISecurityEncodable, ISecurityPolicyEncodable, IConstantMembershipCondition, IReportMatchMembershipCondition
{
	private X509Certificate m_certificate;

	private SecurityElement m_element;

	public X509Certificate Certificate
	{
		get
		{
			if (m_certificate == null && m_element != null)
			{
				ParseCertificate();
			}
			if (m_certificate != null)
			{
				return new X509Certificate(m_certificate);
			}
			return null;
		}
		set
		{
			CheckCertificate(value);
			m_certificate = new X509Certificate(value);
		}
	}

	internal PublisherMembershipCondition()
	{
		m_element = null;
		m_certificate = null;
	}

	public PublisherMembershipCondition(X509Certificate certificate)
	{
		CheckCertificate(certificate);
		m_certificate = new X509Certificate(certificate);
	}

	private static void CheckCertificate(X509Certificate certificate)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
	}

	public override string ToString()
	{
		if (m_certificate == null && m_element != null)
		{
			ParseCertificate();
		}
		if (m_certificate == null)
		{
			return Environment.GetResourceString("Publisher_ToString");
		}
		string subject = m_certificate.Subject;
		if (subject != null)
		{
			return string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Publisher_ToStringArg"), Hex.EncodeHexString(m_certificate.GetPublicKey()));
		}
		return Environment.GetResourceString("Publisher_ToString");
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
		Publisher hostEvidence = evidence.GetHostEvidence<Publisher>();
		if (hostEvidence != null)
		{
			if (m_certificate == null && m_element != null)
			{
				ParseCertificate();
			}
			if (hostEvidence.Equals(new Publisher(m_certificate)))
			{
				usedEvidence = hostEvidence;
				return true;
			}
		}
		return false;
	}

	public IMembershipCondition Copy()
	{
		if (m_certificate == null && m_element != null)
		{
			ParseCertificate();
		}
		return new PublisherMembershipCondition(m_certificate);
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
		if (m_certificate == null && m_element != null)
		{
			ParseCertificate();
		}
		SecurityElement securityElement = new SecurityElement("IMembershipCondition");
		XMLUtil.AddClassAttribute(securityElement, GetType(), "System.Security.Policy.PublisherMembershipCondition");
		securityElement.AddAttribute("version", "1");
		if (m_certificate != null)
		{
			securityElement.AddAttribute("X509Certificate", m_certificate.GetRawCertDataString());
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
			m_element = e;
			m_certificate = null;
		}
	}

	private void ParseCertificate()
	{
		lock (this)
		{
			if (m_element != null)
			{
				string text = m_element.Attribute("X509Certificate");
				m_certificate = ((text == null) ? null : new X509Certificate(Hex.DecodeHexString(text)));
				CheckCertificate(m_certificate);
				m_element = null;
			}
		}
	}

	public override bool Equals(object o)
	{
		if (o is PublisherMembershipCondition publisherMembershipCondition)
		{
			if (m_certificate == null && m_element != null)
			{
				ParseCertificate();
			}
			if (publisherMembershipCondition.m_certificate == null && publisherMembershipCondition.m_element != null)
			{
				publisherMembershipCondition.ParseCertificate();
			}
			if (Publisher.PublicKeyEquals(m_certificate, publisherMembershipCondition.m_certificate))
			{
				return true;
			}
		}
		return false;
	}

	public override int GetHashCode()
	{
		if (m_certificate == null && m_element != null)
		{
			ParseCertificate();
		}
		if (m_certificate != null)
		{
			return m_certificate.GetHashCode();
		}
		return typeof(PublisherMembershipCondition).GetHashCode();
	}
}

using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Security.Util;

namespace System.Security.Policy;

[Serializable]
[ComVisible(true)]
public sealed class StrongNameMembershipCondition : IMembershipCondition, ISecurityEncodable, ISecurityPolicyEncodable, IConstantMembershipCondition, IReportMatchMembershipCondition
{
	private StrongNamePublicKeyBlob m_publicKeyBlob;

	private string m_name;

	private Version m_version;

	private SecurityElement m_element;

	private const string s_tagName = "Name";

	private const string s_tagVersion = "AssemblyVersion";

	private const string s_tagPublicKeyBlob = "PublicKeyBlob";

	public StrongNamePublicKeyBlob PublicKey
	{
		get
		{
			if (m_publicKeyBlob == null && m_element != null)
			{
				ParseKeyBlob();
			}
			return m_publicKeyBlob;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("PublicKey");
			}
			m_publicKeyBlob = value;
		}
	}

	public string Name
	{
		get
		{
			if (m_name == null && m_element != null)
			{
				ParseName();
			}
			return m_name;
		}
		set
		{
			if (value == null)
			{
				if (m_publicKeyBlob == null && m_element != null)
				{
					ParseKeyBlob();
				}
				if ((object)m_version == null && m_element != null)
				{
					ParseVersion();
				}
				m_element = null;
			}
			else if (value.Length == 0)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_EmptyName"));
			}
			m_name = value;
		}
	}

	public Version Version
	{
		get
		{
			if ((object)m_version == null && m_element != null)
			{
				ParseVersion();
			}
			return m_version;
		}
		set
		{
			if (value == null)
			{
				if (m_name == null && m_element != null)
				{
					ParseName();
				}
				if (m_publicKeyBlob == null && m_element != null)
				{
					ParseKeyBlob();
				}
				m_element = null;
			}
			m_version = value;
		}
	}

	internal StrongNameMembershipCondition()
	{
	}

	public StrongNameMembershipCondition(StrongNamePublicKeyBlob blob, string name, Version version)
	{
		if (blob == null)
		{
			throw new ArgumentNullException("blob");
		}
		if (name != null && name.Equals(""))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyStrongName"));
		}
		m_publicKeyBlob = blob;
		m_name = name;
		m_version = version;
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
		StrongName delayEvaluatedHostEvidence = evidence.GetDelayEvaluatedHostEvidence<StrongName>();
		if (delayEvaluatedHostEvidence != null)
		{
			bool flag = PublicKey != null && PublicKey.Equals(delayEvaluatedHostEvidence.PublicKey);
			bool flag2 = Name == null || (delayEvaluatedHostEvidence.Name != null && StrongName.CompareNames(delayEvaluatedHostEvidence.Name, Name));
			bool flag3 = (object)Version == null || ((object)delayEvaluatedHostEvidence.Version != null && delayEvaluatedHostEvidence.Version.CompareTo(Version) == 0);
			if (flag && flag2 && flag3)
			{
				usedEvidence = delayEvaluatedHostEvidence;
				return true;
			}
		}
		return false;
	}

	public IMembershipCondition Copy()
	{
		return new StrongNameMembershipCondition(PublicKey, Name, Version);
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
		SecurityElement securityElement = new SecurityElement("IMembershipCondition");
		XMLUtil.AddClassAttribute(securityElement, GetType(), "System.Security.Policy.StrongNameMembershipCondition");
		securityElement.AddAttribute("version", "1");
		if (PublicKey != null)
		{
			securityElement.AddAttribute("PublicKeyBlob", Hex.EncodeHexString(PublicKey.PublicKey));
		}
		if (Name != null)
		{
			securityElement.AddAttribute("Name", Name);
		}
		if ((object)Version != null)
		{
			securityElement.AddAttribute("AssemblyVersion", Version.ToString());
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
			m_name = null;
			m_publicKeyBlob = null;
			m_version = null;
			m_element = e;
		}
	}

	private void ParseName()
	{
		lock (this)
		{
			if (m_element != null)
			{
				string text = m_element.Attribute("Name");
				m_name = ((text == null) ? null : text);
				if ((object)m_version != null && m_name != null && m_publicKeyBlob != null)
				{
					m_element = null;
				}
			}
		}
	}

	private void ParseKeyBlob()
	{
		lock (this)
		{
			if (m_element != null)
			{
				string text = m_element.Attribute("PublicKeyBlob");
				StrongNamePublicKeyBlob strongNamePublicKeyBlob = new StrongNamePublicKeyBlob();
				if (text == null)
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_BlobCannotBeNull"));
				}
				strongNamePublicKeyBlob.PublicKey = Hex.DecodeHexString(text);
				m_publicKeyBlob = strongNamePublicKeyBlob;
				if ((object)m_version != null && m_name != null && m_publicKeyBlob != null)
				{
					m_element = null;
				}
			}
		}
	}

	private void ParseVersion()
	{
		lock (this)
		{
			if (m_element != null)
			{
				string text = m_element.Attribute("AssemblyVersion");
				m_version = ((text == null) ? null : new Version(text));
				if ((object)m_version != null && m_name != null && m_publicKeyBlob != null)
				{
					m_element = null;
				}
			}
		}
	}

	public override string ToString()
	{
		string arg = "";
		string arg2 = "";
		if (Name != null)
		{
			arg = " " + string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("StrongName_Name"), Name);
		}
		if ((object)Version != null)
		{
			arg2 = " " + string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("StrongName_Version"), Version);
		}
		return string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("StrongName_ToString"), Hex.EncodeHexString(PublicKey.PublicKey), arg, arg2);
	}

	public override bool Equals(object o)
	{
		if (o is StrongNameMembershipCondition strongNameMembershipCondition)
		{
			if (m_publicKeyBlob == null && m_element != null)
			{
				ParseKeyBlob();
			}
			if (strongNameMembershipCondition.m_publicKeyBlob == null && strongNameMembershipCondition.m_element != null)
			{
				strongNameMembershipCondition.ParseKeyBlob();
			}
			if (object.Equals(m_publicKeyBlob, strongNameMembershipCondition.m_publicKeyBlob))
			{
				if (m_name == null && m_element != null)
				{
					ParseName();
				}
				if (strongNameMembershipCondition.m_name == null && strongNameMembershipCondition.m_element != null)
				{
					strongNameMembershipCondition.ParseName();
				}
				if (object.Equals(m_name, strongNameMembershipCondition.m_name))
				{
					if (m_version == null && m_element != null)
					{
						ParseVersion();
					}
					if (strongNameMembershipCondition.m_version == null && strongNameMembershipCondition.m_element != null)
					{
						strongNameMembershipCondition.ParseVersion();
					}
					if (object.Equals(m_version, strongNameMembershipCondition.m_version))
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	public override int GetHashCode()
	{
		if (m_publicKeyBlob == null && m_element != null)
		{
			ParseKeyBlob();
		}
		if (m_publicKeyBlob != null)
		{
			return m_publicKeyBlob.GetHashCode();
		}
		if (m_name == null && m_element != null)
		{
			ParseName();
		}
		if (m_version == null && m_element != null)
		{
			ParseVersion();
		}
		if (m_name != null || m_version != null)
		{
			return ((m_name != null) ? m_name.GetHashCode() : 0) + ((!(m_version == null)) ? m_version.GetHashCode() : 0);
		}
		return typeof(StrongNameMembershipCondition).GetHashCode();
	}
}

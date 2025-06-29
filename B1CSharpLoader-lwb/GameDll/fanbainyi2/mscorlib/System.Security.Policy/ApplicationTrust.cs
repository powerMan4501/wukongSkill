using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Permissions;
using System.Security.Util;

namespace System.Security.Policy;

[Serializable]
[ComVisible(true)]
public sealed class ApplicationTrust : EvidenceBase, ISecurityEncodable
{
	private ApplicationIdentity m_appId;

	private bool m_appTrustedToRun;

	private bool m_persist;

	private object m_extraInfo;

	private SecurityElement m_elExtraInfo;

	private PolicyStatement m_psDefaultGrant;

	private IList<StrongName> m_fullTrustAssemblies;

	[NonSerialized]
	private int m_grantSetSpecialFlags;

	public ApplicationIdentity ApplicationIdentity
	{
		get
		{
			return m_appId;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException(Environment.GetResourceString("Argument_InvalidAppId"));
			}
			m_appId = value;
		}
	}

	public PolicyStatement DefaultGrantSet
	{
		get
		{
			if (m_psDefaultGrant == null)
			{
				return new PolicyStatement(new PermissionSet(PermissionState.None));
			}
			return m_psDefaultGrant;
		}
		set
		{
			if (value == null)
			{
				m_psDefaultGrant = null;
				m_grantSetSpecialFlags = 0;
			}
			else
			{
				m_psDefaultGrant = value;
				m_grantSetSpecialFlags = SecurityManager.GetSpecialFlags(m_psDefaultGrant.PermissionSet, null);
			}
		}
	}

	public IList<StrongName> FullTrustAssemblies => m_fullTrustAssemblies;

	public bool IsApplicationTrustedToRun
	{
		get
		{
			return m_appTrustedToRun;
		}
		set
		{
			m_appTrustedToRun = value;
		}
	}

	public bool Persist
	{
		get
		{
			return m_persist;
		}
		set
		{
			m_persist = value;
		}
	}

	public object ExtraInfo
	{
		get
		{
			if (m_elExtraInfo != null)
			{
				m_extraInfo = ObjectFromXml(m_elExtraInfo);
				m_elExtraInfo = null;
			}
			return m_extraInfo;
		}
		set
		{
			m_elExtraInfo = null;
			m_extraInfo = value;
		}
	}

	public ApplicationTrust(ApplicationIdentity applicationIdentity)
		: this()
	{
		ApplicationIdentity = applicationIdentity;
	}

	public ApplicationTrust()
		: this(new PermissionSet(PermissionState.None))
	{
	}

	internal ApplicationTrust(PermissionSet defaultGrantSet)
	{
		InitDefaultGrantSet(defaultGrantSet);
		m_fullTrustAssemblies = new List<StrongName>().AsReadOnly();
	}

	public ApplicationTrust(PermissionSet defaultGrantSet, IEnumerable<StrongName> fullTrustAssemblies)
	{
		if (fullTrustAssemblies == null)
		{
			throw new ArgumentNullException("fullTrustAssemblies");
		}
		InitDefaultGrantSet(defaultGrantSet);
		List<StrongName> list = new List<StrongName>();
		foreach (StrongName fullTrustAssembly in fullTrustAssemblies)
		{
			if (fullTrustAssembly == null)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_NullFullTrustAssembly"));
			}
			list.Add(new StrongName(fullTrustAssembly.PublicKey, fullTrustAssembly.Name, fullTrustAssembly.Version));
		}
		m_fullTrustAssemblies = list.AsReadOnly();
	}

	private void InitDefaultGrantSet(PermissionSet defaultGrantSet)
	{
		if (defaultGrantSet == null)
		{
			throw new ArgumentNullException("defaultGrantSet");
		}
		DefaultGrantSet = new PolicyStatement(defaultGrantSet);
	}

	public SecurityElement ToXml()
	{
		SecurityElement securityElement = new SecurityElement("ApplicationTrust");
		securityElement.AddAttribute("version", "1");
		if (m_appId != null)
		{
			securityElement.AddAttribute("FullName", SecurityElement.Escape(m_appId.FullName));
		}
		if (m_appTrustedToRun)
		{
			securityElement.AddAttribute("TrustedToRun", "true");
		}
		if (m_persist)
		{
			securityElement.AddAttribute("Persist", "true");
		}
		if (m_psDefaultGrant != null)
		{
			SecurityElement securityElement2 = new SecurityElement("DefaultGrant");
			securityElement2.AddChild(m_psDefaultGrant.ToXml());
			securityElement.AddChild(securityElement2);
		}
		if (m_fullTrustAssemblies.Count > 0)
		{
			SecurityElement securityElement3 = new SecurityElement("FullTrustAssemblies");
			foreach (StrongName fullTrustAssembly in m_fullTrustAssemblies)
			{
				securityElement3.AddChild(fullTrustAssembly.ToXml());
			}
			securityElement.AddChild(securityElement3);
		}
		if (ExtraInfo != null)
		{
			securityElement.AddChild(ObjectToXml("ExtraInfo", ExtraInfo));
		}
		return securityElement;
	}

	public void FromXml(SecurityElement element)
	{
		if (element == null)
		{
			throw new ArgumentNullException("element");
		}
		if (string.Compare(element.Tag, "ApplicationTrust", StringComparison.Ordinal) != 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidXML"));
		}
		m_appTrustedToRun = false;
		string text = element.Attribute("TrustedToRun");
		if (text != null && string.Compare(text, "true", StringComparison.Ordinal) == 0)
		{
			m_appTrustedToRun = true;
		}
		m_persist = false;
		string text2 = element.Attribute("Persist");
		if (text2 != null && string.Compare(text2, "true", StringComparison.Ordinal) == 0)
		{
			m_persist = true;
		}
		m_appId = null;
		string text3 = element.Attribute("FullName");
		if (text3 != null && text3.Length > 0)
		{
			m_appId = new ApplicationIdentity(text3);
		}
		m_psDefaultGrant = null;
		m_grantSetSpecialFlags = 0;
		SecurityElement securityElement = element.SearchForChildByTag("DefaultGrant");
		if (securityElement != null)
		{
			SecurityElement securityElement2 = securityElement.SearchForChildByTag("PolicyStatement");
			if (securityElement2 != null)
			{
				PolicyStatement policyStatement = new PolicyStatement(null);
				policyStatement.FromXml(securityElement2);
				m_psDefaultGrant = policyStatement;
				m_grantSetSpecialFlags = SecurityManager.GetSpecialFlags(policyStatement.PermissionSet, null);
			}
		}
		List<StrongName> list = new List<StrongName>();
		SecurityElement securityElement3 = element.SearchForChildByTag("FullTrustAssemblies");
		if (securityElement3 != null && securityElement3.InternalChildren != null)
		{
			IEnumerator enumerator = securityElement3.Children.GetEnumerator();
			while (enumerator.MoveNext())
			{
				StrongName strongName = new StrongName();
				strongName.FromXml(enumerator.Current as SecurityElement);
				list.Add(strongName);
			}
		}
		m_fullTrustAssemblies = list.AsReadOnly();
		m_elExtraInfo = element.SearchForChildByTag("ExtraInfo");
	}

	private static SecurityElement ObjectToXml(string tag, object obj)
	{
		SecurityElement securityElement;
		if (obj is ISecurityEncodable securityEncodable)
		{
			securityElement = securityEncodable.ToXml();
			if (!securityElement.Tag.Equals(tag))
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_InvalidXML"));
			}
		}
		MemoryStream memoryStream = new MemoryStream();
		BinaryFormatter binaryFormatter = new BinaryFormatter();
		binaryFormatter.Serialize(memoryStream, obj);
		byte[] sArray = memoryStream.ToArray();
		securityElement = new SecurityElement(tag);
		securityElement.AddAttribute("Data", Hex.EncodeHexString(sArray));
		return securityElement;
	}

	private static object ObjectFromXml(SecurityElement elObject)
	{
		if (elObject.Attribute("class") != null && XMLUtil.CreateCodeGroup(elObject) is ISecurityEncodable securityEncodable)
		{
			securityEncodable.FromXml(elObject);
			return securityEncodable;
		}
		string hexString = elObject.Attribute("Data");
		MemoryStream serializationStream = new MemoryStream(Hex.DecodeHexString(hexString));
		BinaryFormatter binaryFormatter = new BinaryFormatter();
		return binaryFormatter.Deserialize(serializationStream);
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
	public override EvidenceBase Clone()
	{
		return base.Clone();
	}
}

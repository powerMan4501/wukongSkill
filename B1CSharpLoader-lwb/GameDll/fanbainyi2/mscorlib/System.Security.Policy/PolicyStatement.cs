using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Security.Util;
using System.Text;

namespace System.Security.Policy;

[Serializable]
[ComVisible(true)]
public sealed class PolicyStatement : ISecurityPolicyEncodable, ISecurityEncodable
{
	internal PermissionSet m_permSet;

	[NonSerialized]
	private List<IDelayEvaluatedEvidence> m_dependentEvidence;

	internal PolicyStatementAttribute m_attributes;

	public PermissionSet PermissionSet
	{
		get
		{
			lock (this)
			{
				return m_permSet.Copy();
			}
		}
		set
		{
			lock (this)
			{
				if (value == null)
				{
					m_permSet = new PermissionSet(fUnrestricted: false);
				}
				else
				{
					m_permSet = value.Copy();
				}
			}
		}
	}

	public PolicyStatementAttribute Attributes
	{
		get
		{
			return m_attributes;
		}
		set
		{
			if (ValidProperties(value))
			{
				m_attributes = value;
			}
		}
	}

	public string AttributeString
	{
		get
		{
			StringBuilder stringBuilder = new StringBuilder();
			bool flag = true;
			if (GetFlag(1))
			{
				stringBuilder.Append("Exclusive");
				flag = false;
			}
			if (GetFlag(2))
			{
				if (!flag)
				{
					stringBuilder.Append(" ");
				}
				stringBuilder.Append("LevelFinal");
			}
			return stringBuilder.ToString();
		}
	}

	internal IEnumerable<IDelayEvaluatedEvidence> DependentEvidence => m_dependentEvidence.AsReadOnly();

	internal bool HasDependentEvidence
	{
		get
		{
			if (m_dependentEvidence != null)
			{
				return m_dependentEvidence.Count > 0;
			}
			return false;
		}
	}

	internal PolicyStatement()
	{
		m_permSet = null;
		m_attributes = PolicyStatementAttribute.Nothing;
	}

	public PolicyStatement(PermissionSet permSet)
		: this(permSet, PolicyStatementAttribute.Nothing)
	{
	}

	public PolicyStatement(PermissionSet permSet, PolicyStatementAttribute attributes)
	{
		if (permSet == null)
		{
			m_permSet = new PermissionSet(fUnrestricted: false);
		}
		else
		{
			m_permSet = permSet.Copy();
		}
		if (ValidProperties(attributes))
		{
			m_attributes = attributes;
		}
	}

	private PolicyStatement(PermissionSet permSet, PolicyStatementAttribute attributes, bool copy)
	{
		if (permSet != null)
		{
			if (copy)
			{
				m_permSet = permSet.Copy();
			}
			else
			{
				m_permSet = permSet;
			}
		}
		else
		{
			m_permSet = new PermissionSet(fUnrestricted: false);
		}
		m_attributes = attributes;
	}

	internal void SetPermissionSetNoCopy(PermissionSet permSet)
	{
		m_permSet = permSet;
	}

	internal PermissionSet GetPermissionSetNoCopy()
	{
		lock (this)
		{
			return m_permSet;
		}
	}

	public PolicyStatement Copy()
	{
		PolicyStatement policyStatement = new PolicyStatement(m_permSet, Attributes, copy: true);
		if (HasDependentEvidence)
		{
			policyStatement.m_dependentEvidence = new List<IDelayEvaluatedEvidence>(m_dependentEvidence);
		}
		return policyStatement;
	}

	private static bool ValidProperties(PolicyStatementAttribute attributes)
	{
		if ((attributes & ~PolicyStatementAttribute.All) == 0)
		{
			return true;
		}
		throw new ArgumentException(Environment.GetResourceString("Argument_InvalidFlag"));
	}

	private bool GetFlag(int flag)
	{
		return ((uint)flag & (uint)m_attributes) != 0;
	}

	internal void AddDependentEvidence(IDelayEvaluatedEvidence dependentEvidence)
	{
		if (m_dependentEvidence == null)
		{
			m_dependentEvidence = new List<IDelayEvaluatedEvidence>();
		}
		m_dependentEvidence.Add(dependentEvidence);
	}

	internal void InplaceUnion(PolicyStatement childPolicy)
	{
		if ((Attributes & childPolicy.Attributes & PolicyStatementAttribute.Exclusive) == PolicyStatementAttribute.Exclusive)
		{
			throw new PolicyException(Environment.GetResourceString("Policy_MultipleExclusive"));
		}
		if (childPolicy.HasDependentEvidence)
		{
			bool flag = m_permSet.IsSubsetOf(childPolicy.GetPermissionSetNoCopy()) && !childPolicy.GetPermissionSetNoCopy().IsSubsetOf(m_permSet);
			if (HasDependentEvidence || flag)
			{
				if (m_dependentEvidence == null)
				{
					m_dependentEvidence = new List<IDelayEvaluatedEvidence>();
				}
				m_dependentEvidence.AddRange(childPolicy.DependentEvidence);
			}
		}
		if ((childPolicy.Attributes & PolicyStatementAttribute.Exclusive) == PolicyStatementAttribute.Exclusive)
		{
			m_permSet = childPolicy.GetPermissionSetNoCopy();
			Attributes = childPolicy.Attributes;
		}
		else
		{
			m_permSet.InplaceUnion(childPolicy.GetPermissionSetNoCopy());
			Attributes |= childPolicy.Attributes;
		}
	}

	public SecurityElement ToXml()
	{
		return ToXml(null);
	}

	public void FromXml(SecurityElement et)
	{
		FromXml(et, null);
	}

	public SecurityElement ToXml(PolicyLevel level)
	{
		return ToXml(level, useInternal: false);
	}

	internal SecurityElement ToXml(PolicyLevel level, bool useInternal)
	{
		SecurityElement securityElement = new SecurityElement("PolicyStatement");
		securityElement.AddAttribute("version", "1");
		if (m_attributes != PolicyStatementAttribute.Nothing)
		{
			securityElement.AddAttribute("Attributes", XMLUtil.BitFieldEnumToString(typeof(PolicyStatementAttribute), m_attributes));
		}
		lock (this)
		{
			if (m_permSet != null)
			{
				if (m_permSet is NamedPermissionSet)
				{
					NamedPermissionSet namedPermissionSet = (NamedPermissionSet)m_permSet;
					if (level != null && level.GetNamedPermissionSet(namedPermissionSet.Name) != null)
					{
						securityElement.AddAttribute("PermissionSetName", namedPermissionSet.Name);
					}
					else if (useInternal)
					{
						securityElement.AddChild(namedPermissionSet.InternalToXml());
					}
					else
					{
						securityElement.AddChild(namedPermissionSet.ToXml());
					}
				}
				else if (useInternal)
				{
					securityElement.AddChild(m_permSet.InternalToXml());
				}
				else
				{
					securityElement.AddChild(m_permSet.ToXml());
				}
			}
		}
		return securityElement;
	}

	[SecuritySafeCritical]
	public void FromXml(SecurityElement et, PolicyLevel level)
	{
		FromXml(et, level, allowInternalOnly: false);
	}

	[SecurityCritical]
	internal void FromXml(SecurityElement et, PolicyLevel level, bool allowInternalOnly)
	{
		if (et == null)
		{
			throw new ArgumentNullException("et");
		}
		if (!et.Tag.Equals("PolicyStatement"))
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Argument_InvalidXMLElement"), "PolicyStatement", GetType().FullName));
		}
		m_attributes = PolicyStatementAttribute.Nothing;
		string text = et.Attribute("Attributes");
		if (text != null)
		{
			m_attributes = (PolicyStatementAttribute)Enum.Parse(typeof(PolicyStatementAttribute), text);
		}
		lock (this)
		{
			m_permSet = null;
			if (level != null)
			{
				string text2 = et.Attribute("PermissionSetName");
				if (text2 != null)
				{
					m_permSet = level.GetNamedPermissionSetInternal(text2);
					if (m_permSet == null)
					{
						m_permSet = new PermissionSet(PermissionState.None);
					}
				}
			}
			if (m_permSet == null)
			{
				SecurityElement securityElement = et.SearchForChildByTag("PermissionSet");
				if (securityElement == null)
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_InvalidXML"));
				}
				string text3 = securityElement.Attribute("class");
				if (text3 != null && (text3.Equals("NamedPermissionSet") || text3.Equals("System.Security.NamedPermissionSet")))
				{
					m_permSet = new NamedPermissionSet("DefaultName", PermissionState.None);
				}
				else
				{
					m_permSet = new PermissionSet(PermissionState.None);
				}
				try
				{
					m_permSet.FromXml(securityElement, allowInternalOnly, ignoreTypeLoadFailures: true);
				}
				catch
				{
				}
			}
			if (m_permSet == null)
			{
				m_permSet = new PermissionSet(PermissionState.None);
			}
		}
	}

	[SecurityCritical]
	internal void FromXml(SecurityDocument doc, int position, PolicyLevel level, bool allowInternalOnly)
	{
		if (doc == null)
		{
			throw new ArgumentNullException("doc");
		}
		if (!doc.GetTagForElement(position).Equals("PolicyStatement"))
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Argument_InvalidXMLElement"), "PolicyStatement", GetType().FullName));
		}
		m_attributes = PolicyStatementAttribute.Nothing;
		string attributeForElement = doc.GetAttributeForElement(position, "Attributes");
		if (attributeForElement != null)
		{
			m_attributes = (PolicyStatementAttribute)Enum.Parse(typeof(PolicyStatementAttribute), attributeForElement);
		}
		lock (this)
		{
			m_permSet = null;
			if (level != null)
			{
				string attributeForElement2 = doc.GetAttributeForElement(position, "PermissionSetName");
				if (attributeForElement2 != null)
				{
					m_permSet = level.GetNamedPermissionSetInternal(attributeForElement2);
					if (m_permSet == null)
					{
						m_permSet = new PermissionSet(PermissionState.None);
					}
				}
			}
			if (m_permSet == null)
			{
				ArrayList childrenPositionForElement = doc.GetChildrenPositionForElement(position);
				int num = -1;
				for (int i = 0; i < childrenPositionForElement.Count; i++)
				{
					if (doc.GetTagForElement((int)childrenPositionForElement[i]).Equals("PermissionSet"))
					{
						num = (int)childrenPositionForElement[i];
					}
				}
				if (num == -1)
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_InvalidXML"));
				}
				string attributeForElement3 = doc.GetAttributeForElement(num, "class");
				if (attributeForElement3 != null && (attributeForElement3.Equals("NamedPermissionSet") || attributeForElement3.Equals("System.Security.NamedPermissionSet")))
				{
					m_permSet = new NamedPermissionSet("DefaultName", PermissionState.None);
				}
				else
				{
					m_permSet = new PermissionSet(PermissionState.None);
				}
				m_permSet.FromXml(doc, num, allowInternalOnly);
			}
			if (m_permSet == null)
			{
				m_permSet = new PermissionSet(PermissionState.None);
			}
		}
	}

	[ComVisible(false)]
	public override bool Equals(object obj)
	{
		if (!(obj is PolicyStatement policyStatement))
		{
			return false;
		}
		if (m_attributes != policyStatement.m_attributes)
		{
			return false;
		}
		if (!object.Equals(m_permSet, policyStatement.m_permSet))
		{
			return false;
		}
		return true;
	}

	[ComVisible(false)]
	public override int GetHashCode()
	{
		int num = (int)m_attributes;
		if (m_permSet != null)
		{
			num ^= m_permSet.GetHashCode();
		}
		return num;
	}
}

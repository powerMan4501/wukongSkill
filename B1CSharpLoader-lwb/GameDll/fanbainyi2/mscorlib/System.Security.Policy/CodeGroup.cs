using System.Collections;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Util;

namespace System.Security.Policy;

[Serializable]
[ComVisible(true)]
public abstract class CodeGroup
{
	private IMembershipCondition m_membershipCondition;

	private IList m_children;

	private PolicyStatement m_policy;

	private SecurityElement m_element;

	private PolicyLevel m_parentLevel;

	private string m_name;

	private string m_description;

	public IList Children
	{
		[SecuritySafeCritical]
		get
		{
			if (m_children == null)
			{
				ParseChildren();
			}
			lock (this)
			{
				IList list = new ArrayList(m_children.Count);
				IEnumerator enumerator = m_children.GetEnumerator();
				while (enumerator.MoveNext())
				{
					list.Add(((CodeGroup)enumerator.Current).Copy());
				}
				return list;
			}
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("Children");
			}
			ArrayList arrayList = ArrayList.Synchronized(new ArrayList(value.Count));
			IEnumerator enumerator = value.GetEnumerator();
			while (enumerator.MoveNext())
			{
				if (!(enumerator.Current is CodeGroup codeGroup))
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_CodeGroupChildrenMustBeCodeGroups"));
				}
				arrayList.Add(codeGroup.Copy());
			}
			m_children = arrayList;
		}
	}

	public IMembershipCondition MembershipCondition
	{
		[SecuritySafeCritical]
		get
		{
			if (m_membershipCondition == null && m_element != null)
			{
				ParseMembershipCondition();
			}
			return m_membershipCondition.Copy();
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("MembershipCondition");
			}
			m_membershipCondition = value.Copy();
		}
	}

	public PolicyStatement PolicyStatement
	{
		get
		{
			if (m_policy == null && m_element != null)
			{
				ParsePolicy();
			}
			if (m_policy != null)
			{
				return m_policy.Copy();
			}
			return null;
		}
		set
		{
			if (value != null)
			{
				m_policy = value.Copy();
			}
			else
			{
				m_policy = null;
			}
		}
	}

	public string Name
	{
		get
		{
			return m_name;
		}
		set
		{
			m_name = value;
		}
	}

	public string Description
	{
		get
		{
			return m_description;
		}
		set
		{
			m_description = value;
		}
	}

	public virtual string PermissionSetName
	{
		get
		{
			if (m_policy == null && m_element != null)
			{
				ParsePolicy();
			}
			if (m_policy == null)
			{
				return null;
			}
			if (m_policy.GetPermissionSetNoCopy() is NamedPermissionSet namedPermissionSet)
			{
				return namedPermissionSet.Name;
			}
			return null;
		}
	}

	public virtual string AttributeString
	{
		get
		{
			if (m_policy == null && m_element != null)
			{
				ParsePolicy();
			}
			if (m_policy != null)
			{
				return m_policy.AttributeString;
			}
			return null;
		}
	}

	public abstract string MergeLogic { get; }

	internal CodeGroup()
	{
	}

	internal CodeGroup(IMembershipCondition membershipCondition, PermissionSet permSet)
	{
		m_membershipCondition = membershipCondition;
		m_policy = new PolicyStatement();
		m_policy.SetPermissionSetNoCopy(permSet);
		m_children = ArrayList.Synchronized(new ArrayList());
		m_element = null;
		m_parentLevel = null;
	}

	protected CodeGroup(IMembershipCondition membershipCondition, PolicyStatement policy)
	{
		if (membershipCondition == null)
		{
			throw new ArgumentNullException("membershipCondition");
		}
		if (policy == null)
		{
			m_policy = null;
		}
		else
		{
			m_policy = policy.Copy();
		}
		m_membershipCondition = membershipCondition.Copy();
		m_children = ArrayList.Synchronized(new ArrayList());
		m_element = null;
		m_parentLevel = null;
	}

	[SecuritySafeCritical]
	public void AddChild(CodeGroup group)
	{
		if (group == null)
		{
			throw new ArgumentNullException("group");
		}
		if (m_children == null)
		{
			ParseChildren();
		}
		lock (this)
		{
			m_children.Add(group.Copy());
		}
	}

	[SecurityCritical]
	internal void AddChildInternal(CodeGroup group)
	{
		if (group == null)
		{
			throw new ArgumentNullException("group");
		}
		if (m_children == null)
		{
			ParseChildren();
		}
		lock (this)
		{
			m_children.Add(group);
		}
	}

	[SecuritySafeCritical]
	public void RemoveChild(CodeGroup group)
	{
		if (group == null)
		{
			return;
		}
		if (m_children == null)
		{
			ParseChildren();
		}
		lock (this)
		{
			int num = m_children.IndexOf(group);
			if (num != -1)
			{
				m_children.RemoveAt(num);
			}
		}
	}

	[SecurityCritical]
	internal IList GetChildrenInternal()
	{
		if (m_children == null)
		{
			ParseChildren();
		}
		return m_children;
	}

	public abstract PolicyStatement Resolve(Evidence evidence);

	public abstract CodeGroup ResolveMatchingCodeGroups(Evidence evidence);

	public abstract CodeGroup Copy();

	public SecurityElement ToXml()
	{
		return ToXml(null);
	}

	public void FromXml(SecurityElement e)
	{
		FromXml(e, null);
	}

	[SecuritySafeCritical]
	public SecurityElement ToXml(PolicyLevel level)
	{
		return ToXml(level, GetTypeName());
	}

	internal virtual string GetTypeName()
	{
		return GetType().FullName;
	}

	[SecurityCritical]
	internal SecurityElement ToXml(PolicyLevel level, string policyClassName)
	{
		if (m_membershipCondition == null && m_element != null)
		{
			ParseMembershipCondition();
		}
		if (m_children == null)
		{
			ParseChildren();
		}
		if (m_policy == null && m_element != null)
		{
			ParsePolicy();
		}
		SecurityElement securityElement = new SecurityElement("CodeGroup");
		XMLUtil.AddClassAttribute(securityElement, GetType(), policyClassName);
		securityElement.AddAttribute("version", "1");
		securityElement.AddChild(m_membershipCondition.ToXml(level));
		if (m_policy != null)
		{
			PermissionSet permissionSetNoCopy = m_policy.GetPermissionSetNoCopy();
			if (permissionSetNoCopy is NamedPermissionSet namedPermissionSet && level != null && level.GetNamedPermissionSetInternal(namedPermissionSet.Name) != null)
			{
				securityElement.AddAttribute("PermissionSetName", namedPermissionSet.Name);
			}
			else if (!permissionSetNoCopy.IsEmpty())
			{
				securityElement.AddChild(permissionSetNoCopy.ToXml());
			}
			if (m_policy.Attributes != PolicyStatementAttribute.Nothing)
			{
				securityElement.AddAttribute("Attributes", XMLUtil.BitFieldEnumToString(typeof(PolicyStatementAttribute), m_policy.Attributes));
			}
		}
		if (m_children.Count > 0)
		{
			lock (this)
			{
				IEnumerator enumerator = m_children.GetEnumerator();
				while (enumerator.MoveNext())
				{
					securityElement.AddChild(((CodeGroup)enumerator.Current).ToXml(level));
				}
			}
		}
		if (m_name != null)
		{
			securityElement.AddAttribute("Name", SecurityElement.Escape(m_name));
		}
		if (m_description != null)
		{
			securityElement.AddAttribute("Description", SecurityElement.Escape(m_description));
		}
		CreateXml(securityElement, level);
		return securityElement;
	}

	protected virtual void CreateXml(SecurityElement element, PolicyLevel level)
	{
	}

	public void FromXml(SecurityElement e, PolicyLevel level)
	{
		if (e == null)
		{
			throw new ArgumentNullException("e");
		}
		lock (this)
		{
			m_element = e;
			m_parentLevel = level;
			m_children = null;
			m_membershipCondition = null;
			m_policy = null;
			m_name = e.Attribute("Name");
			m_description = e.Attribute("Description");
			ParseXml(e, level);
		}
	}

	protected virtual void ParseXml(SecurityElement e, PolicyLevel level)
	{
	}

	[SecurityCritical]
	private bool ParseMembershipCondition(bool safeLoad)
	{
		lock (this)
		{
			IMembershipCondition membershipCondition = null;
			SecurityElement securityElement = m_element.SearchForChildByTag("IMembershipCondition");
			if (securityElement != null)
			{
				try
				{
					membershipCondition = XMLUtil.CreateMembershipCondition(securityElement);
					if (membershipCondition == null)
					{
						return false;
					}
				}
				catch (Exception innerException)
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_MembershipConditionElement"), innerException);
				}
				membershipCondition.FromXml(securityElement, m_parentLevel);
				m_membershipCondition = membershipCondition;
				return true;
			}
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Argument_InvalidXMLElement"), "IMembershipCondition", GetType().FullName));
		}
	}

	[SecurityCritical]
	private void ParseMembershipCondition()
	{
		ParseMembershipCondition(safeLoad: false);
	}

	[SecurityCritical]
	internal void ParseChildren()
	{
		lock (this)
		{
			ArrayList arrayList = ArrayList.Synchronized(new ArrayList());
			if (m_element != null && m_element.InternalChildren != null)
			{
				m_element.Children = (ArrayList)m_element.InternalChildren.Clone();
				ArrayList arrayList2 = ArrayList.Synchronized(new ArrayList());
				Evidence evidence = new Evidence();
				int count = m_element.InternalChildren.Count;
				int num = 0;
				while (num < count)
				{
					SecurityElement securityElement = (SecurityElement)m_element.Children[num];
					if (securityElement.Tag.Equals("CodeGroup"))
					{
						CodeGroup codeGroup = XMLUtil.CreateCodeGroup(securityElement);
						if (codeGroup != null)
						{
							codeGroup.FromXml(securityElement, m_parentLevel);
							if (ParseMembershipCondition(safeLoad: true))
							{
								codeGroup.Resolve(evidence);
								codeGroup.MembershipCondition.Check(evidence);
								arrayList.Add(codeGroup);
								num++;
							}
							else
							{
								m_element.InternalChildren.RemoveAt(num);
								count = m_element.InternalChildren.Count;
								arrayList2.Add(new CodeGroupPositionMarker(num, arrayList.Count, securityElement));
							}
						}
						else
						{
							m_element.InternalChildren.RemoveAt(num);
							count = m_element.InternalChildren.Count;
							arrayList2.Add(new CodeGroupPositionMarker(num, arrayList.Count, securityElement));
						}
					}
					else
					{
						num++;
					}
				}
				IEnumerator enumerator = arrayList2.GetEnumerator();
				while (enumerator.MoveNext())
				{
					CodeGroupPositionMarker codeGroupPositionMarker = (CodeGroupPositionMarker)enumerator.Current;
					CodeGroup codeGroup2 = XMLUtil.CreateCodeGroup(codeGroupPositionMarker.element);
					if (codeGroup2 != null)
					{
						codeGroup2.FromXml(codeGroupPositionMarker.element, m_parentLevel);
						codeGroup2.Resolve(evidence);
						codeGroup2.MembershipCondition.Check(evidence);
						arrayList.Insert(codeGroupPositionMarker.groupIndex, codeGroup2);
						m_element.InternalChildren.Insert(codeGroupPositionMarker.elementIndex, codeGroupPositionMarker.element);
						continue;
					}
					throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Argument_FailedCodeGroup"), codeGroupPositionMarker.element.Attribute("class")));
				}
			}
			m_children = arrayList;
		}
	}

	private void ParsePolicy()
	{
		while (true)
		{
			PolicyStatement policyStatement = new PolicyStatement();
			bool flag = false;
			SecurityElement securityElement = new SecurityElement("PolicyStatement");
			securityElement.AddAttribute("version", "1");
			SecurityElement element = m_element;
			lock (this)
			{
				if (m_element != null)
				{
					string text = m_element.Attribute("PermissionSetName");
					if (text != null)
					{
						securityElement.AddAttribute("PermissionSetName", text);
						flag = true;
					}
					else
					{
						SecurityElement securityElement2 = m_element.SearchForChildByTag("PermissionSet");
						if (securityElement2 != null)
						{
							securityElement.AddChild(securityElement2);
							flag = true;
						}
						else
						{
							securityElement.AddChild(new PermissionSet(fUnrestricted: false).ToXml());
							flag = true;
						}
					}
					string text2 = m_element.Attribute("Attributes");
					if (text2 != null)
					{
						securityElement.AddAttribute("Attributes", text2);
						flag = true;
					}
				}
			}
			if (flag)
			{
				policyStatement.FromXml(securityElement, m_parentLevel);
			}
			else
			{
				policyStatement.PermissionSet = null;
			}
			lock (this)
			{
				if (element == m_element && m_policy == null)
				{
					m_policy = policyStatement;
					break;
				}
				if (m_policy != null)
				{
					break;
				}
			}
		}
		if (m_policy != null && m_children != null)
		{
			_ = m_membershipCondition;
		}
	}

	[SecuritySafeCritical]
	public override bool Equals(object o)
	{
		if (o is CodeGroup codeGroup && GetType().Equals(codeGroup.GetType()) && object.Equals(m_name, codeGroup.m_name) && object.Equals(m_description, codeGroup.m_description))
		{
			if (m_membershipCondition == null && m_element != null)
			{
				ParseMembershipCondition();
			}
			if (codeGroup.m_membershipCondition == null && codeGroup.m_element != null)
			{
				codeGroup.ParseMembershipCondition();
			}
			if (object.Equals(m_membershipCondition, codeGroup.m_membershipCondition))
			{
				return true;
			}
		}
		return false;
	}

	[SecuritySafeCritical]
	public bool Equals(CodeGroup cg, bool compareChildren)
	{
		if (!Equals(cg))
		{
			return false;
		}
		if (compareChildren)
		{
			if (m_children == null)
			{
				ParseChildren();
			}
			if (cg.m_children == null)
			{
				cg.ParseChildren();
			}
			ArrayList arrayList = new ArrayList(m_children);
			ArrayList arrayList2 = new ArrayList(cg.m_children);
			if (arrayList.Count != arrayList2.Count)
			{
				return false;
			}
			for (int i = 0; i < arrayList.Count; i++)
			{
				if (!((CodeGroup)arrayList[i]).Equals((CodeGroup)arrayList2[i], compareChildren: true))
				{
					return false;
				}
			}
		}
		return true;
	}

	[SecuritySafeCritical]
	public override int GetHashCode()
	{
		if (m_membershipCondition == null && m_element != null)
		{
			ParseMembershipCondition();
		}
		if (m_name != null || m_membershipCondition != null)
		{
			return ((m_name != null) ? m_name.GetHashCode() : 0) + ((m_membershipCondition != null) ? m_membershipCondition.GetHashCode() : 0);
		}
		return GetType().GetHashCode();
	}
}

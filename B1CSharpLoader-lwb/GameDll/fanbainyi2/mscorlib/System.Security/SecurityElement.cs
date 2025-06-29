using System.Collections;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Security.Util;
using System.Text;

namespace System.Security;

[Serializable]
[ComVisible(true)]
public sealed class SecurityElement : ISecurityElementFactory
{
	private delegate void ToStringHelperFunc(object obj, string str);

	internal string m_strTag;

	internal string m_strText;

	private ArrayList m_lChildren;

	internal ArrayList m_lAttributes;

	internal SecurityElementType m_type;

	private static readonly char[] s_tagIllegalCharacters = new char[3] { ' ', '<', '>' };

	private static readonly char[] s_textIllegalCharacters = new char[2] { '<', '>' };

	private static readonly char[] s_valueIllegalCharacters = new char[3] { '<', '>', '"' };

	private const string s_strIndent = "   ";

	private const int c_AttributesTypical = 8;

	private const int c_ChildrenTypical = 1;

	private static readonly string[] s_escapeStringPairs = new string[10] { "<", "&lt;", ">", "&gt;", "\"", "&quot;", "'", "&apos;", "&", "&amp;" };

	private static readonly char[] s_escapeChars = new char[5] { '<', '>', '"', '\'', '&' };

	public string Tag
	{
		get
		{
			return m_strTag;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("Tag");
			}
			if (!IsValidTag(value))
			{
				throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Argument_InvalidElementTag"), value));
			}
			m_strTag = value;
		}
	}

	public Hashtable Attributes
	{
		get
		{
			if (m_lAttributes == null || m_lAttributes.Count == 0)
			{
				return null;
			}
			Hashtable hashtable = new Hashtable(m_lAttributes.Count / 2);
			int count = m_lAttributes.Count;
			for (int i = 0; i < count; i += 2)
			{
				hashtable.Add(m_lAttributes[i], m_lAttributes[i + 1]);
			}
			return hashtable;
		}
		set
		{
			if (value == null || value.Count == 0)
			{
				m_lAttributes = null;
				return;
			}
			ArrayList arrayList = new ArrayList(value.Count);
			IDictionaryEnumerator enumerator = value.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string text = (string)enumerator.Key;
				string value2 = (string)enumerator.Value;
				if (!IsValidAttributeName(text))
				{
					throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Argument_InvalidElementName"), (string)enumerator.Current));
				}
				if (!IsValidAttributeValue(value2))
				{
					throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Argument_InvalidElementValue"), (string)enumerator.Value));
				}
				arrayList.Add(text);
				arrayList.Add(value2);
			}
			m_lAttributes = arrayList;
		}
	}

	public string Text
	{
		get
		{
			return Unescape(m_strText);
		}
		set
		{
			if (value == null)
			{
				m_strText = null;
				return;
			}
			if (!IsValidText(value))
			{
				throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Argument_InvalidElementTag"), value));
			}
			m_strText = value;
		}
	}

	public ArrayList Children
	{
		get
		{
			ConvertSecurityElementFactories();
			return m_lChildren;
		}
		set
		{
			if (value != null)
			{
				IEnumerator enumerator = value.GetEnumerator();
				while (enumerator.MoveNext())
				{
					if (enumerator.Current == null)
					{
						throw new ArgumentException(Environment.GetResourceString("ArgumentNull_Child"));
					}
				}
			}
			m_lChildren = value;
		}
	}

	internal ArrayList InternalChildren => m_lChildren;

	internal SecurityElement()
	{
	}

	SecurityElement ISecurityElementFactory.CreateSecurityElement()
	{
		return this;
	}

	string ISecurityElementFactory.GetTag()
	{
		return Tag;
	}

	object ISecurityElementFactory.Copy()
	{
		return Copy();
	}

	string ISecurityElementFactory.Attribute(string attributeName)
	{
		return Attribute(attributeName);
	}

	public static SecurityElement FromString(string xml)
	{
		if (xml == null)
		{
			throw new ArgumentNullException("xml");
		}
		return new Parser(xml).GetTopElement();
	}

	public SecurityElement(string tag)
	{
		if (tag == null)
		{
			throw new ArgumentNullException("tag");
		}
		if (!IsValidTag(tag))
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Argument_InvalidElementTag"), tag));
		}
		m_strTag = tag;
		m_strText = null;
	}

	public SecurityElement(string tag, string text)
	{
		if (tag == null)
		{
			throw new ArgumentNullException("tag");
		}
		if (!IsValidTag(tag))
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Argument_InvalidElementTag"), tag));
		}
		if (text != null && !IsValidText(text))
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Argument_InvalidElementText"), text));
		}
		m_strTag = tag;
		m_strText = text;
	}

	internal void ConvertSecurityElementFactories()
	{
		if (m_lChildren == null)
		{
			return;
		}
		for (int i = 0; i < m_lChildren.Count; i++)
		{
			if (m_lChildren[i] is ISecurityElementFactory securityElementFactory && !(m_lChildren[i] is SecurityElement))
			{
				m_lChildren[i] = securityElementFactory.CreateSecurityElement();
			}
		}
	}

	internal void AddAttributeSafe(string name, string value)
	{
		if (m_lAttributes == null)
		{
			m_lAttributes = new ArrayList(8);
		}
		else
		{
			int count = m_lAttributes.Count;
			for (int i = 0; i < count; i += 2)
			{
				string a = (string)m_lAttributes[i];
				if (string.Equals(a, name))
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_AttributeNamesMustBeUnique"));
				}
			}
		}
		m_lAttributes.Add(name);
		m_lAttributes.Add(value);
	}

	public void AddAttribute(string name, string value)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (!IsValidAttributeName(name))
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Argument_InvalidElementName"), name));
		}
		if (!IsValidAttributeValue(value))
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Argument_InvalidElementValue"), value));
		}
		AddAttributeSafe(name, value);
	}

	public void AddChild(SecurityElement child)
	{
		if (child == null)
		{
			throw new ArgumentNullException("child");
		}
		if (m_lChildren == null)
		{
			m_lChildren = new ArrayList(1);
		}
		m_lChildren.Add(child);
	}

	internal void AddChild(ISecurityElementFactory child)
	{
		if (child == null)
		{
			throw new ArgumentNullException("child");
		}
		if (m_lChildren == null)
		{
			m_lChildren = new ArrayList(1);
		}
		m_lChildren.Add(child);
	}

	internal void AddChildNoDuplicates(ISecurityElementFactory child)
	{
		if (child == null)
		{
			throw new ArgumentNullException("child");
		}
		if (m_lChildren == null)
		{
			m_lChildren = new ArrayList(1);
			m_lChildren.Add(child);
			return;
		}
		for (int i = 0; i < m_lChildren.Count; i++)
		{
			if (m_lChildren[i] == child)
			{
				return;
			}
		}
		m_lChildren.Add(child);
	}

	public bool Equal(SecurityElement other)
	{
		if (other == null)
		{
			return false;
		}
		if (!string.Equals(m_strTag, other.m_strTag))
		{
			return false;
		}
		if (!string.Equals(m_strText, other.m_strText))
		{
			return false;
		}
		if (m_lAttributes == null || other.m_lAttributes == null)
		{
			if (m_lAttributes != other.m_lAttributes)
			{
				return false;
			}
		}
		else
		{
			int count = m_lAttributes.Count;
			if (count != other.m_lAttributes.Count)
			{
				return false;
			}
			for (int i = 0; i < count; i++)
			{
				string a = (string)m_lAttributes[i];
				string b = (string)other.m_lAttributes[i];
				if (!string.Equals(a, b))
				{
					return false;
				}
			}
		}
		if (m_lChildren == null || other.m_lChildren == null)
		{
			if (m_lChildren != other.m_lChildren)
			{
				return false;
			}
		}
		else
		{
			if (m_lChildren.Count != other.m_lChildren.Count)
			{
				return false;
			}
			ConvertSecurityElementFactories();
			other.ConvertSecurityElementFactories();
			IEnumerator enumerator = m_lChildren.GetEnumerator();
			IEnumerator enumerator2 = other.m_lChildren.GetEnumerator();
			while (enumerator.MoveNext())
			{
				enumerator2.MoveNext();
				SecurityElement securityElement = (SecurityElement)enumerator.Current;
				SecurityElement other2 = (SecurityElement)enumerator2.Current;
				if (securityElement == null || !securityElement.Equal(other2))
				{
					return false;
				}
			}
		}
		return true;
	}

	[ComVisible(false)]
	public SecurityElement Copy()
	{
		SecurityElement securityElement = new SecurityElement(m_strTag, m_strText);
		securityElement.m_lChildren = ((m_lChildren == null) ? null : new ArrayList(m_lChildren));
		securityElement.m_lAttributes = ((m_lAttributes == null) ? null : new ArrayList(m_lAttributes));
		return securityElement;
	}

	public static bool IsValidTag(string tag)
	{
		if (tag == null)
		{
			return false;
		}
		return tag.IndexOfAny(s_tagIllegalCharacters) == -1;
	}

	public static bool IsValidText(string text)
	{
		if (text == null)
		{
			return false;
		}
		return text.IndexOfAny(s_textIllegalCharacters) == -1;
	}

	public static bool IsValidAttributeName(string name)
	{
		return IsValidTag(name);
	}

	public static bool IsValidAttributeValue(string value)
	{
		if (value == null)
		{
			return false;
		}
		return value.IndexOfAny(s_valueIllegalCharacters) == -1;
	}

	private static string GetEscapeSequence(char c)
	{
		int num = s_escapeStringPairs.Length;
		for (int i = 0; i < num; i += 2)
		{
			string text = s_escapeStringPairs[i];
			string result = s_escapeStringPairs[i + 1];
			if (text[0] == c)
			{
				return result;
			}
		}
		return c.ToString();
	}

	public static string Escape(string str)
	{
		if (str == null)
		{
			return null;
		}
		StringBuilder stringBuilder = null;
		int length = str.Length;
		int num = 0;
		while (true)
		{
			int num2 = str.IndexOfAny(s_escapeChars, num);
			if (num2 == -1)
			{
				break;
			}
			if (stringBuilder == null)
			{
				stringBuilder = new StringBuilder();
			}
			stringBuilder.Append(str, num, num2 - num);
			stringBuilder.Append(GetEscapeSequence(str[num2]));
			num = num2 + 1;
		}
		if (stringBuilder == null)
		{
			return str;
		}
		stringBuilder.Append(str, num, length - num);
		return stringBuilder.ToString();
	}

	private static string GetUnescapeSequence(string str, int index, out int newIndex)
	{
		int num = str.Length - index;
		int num2 = s_escapeStringPairs.Length;
		for (int i = 0; i < num2; i += 2)
		{
			string result = s_escapeStringPairs[i];
			string text = s_escapeStringPairs[i + 1];
			int length = text.Length;
			if (length <= num && string.Compare(text, 0, str, index, length, StringComparison.Ordinal) == 0)
			{
				newIndex = index + text.Length;
				return result;
			}
		}
		newIndex = index + 1;
		return str[index].ToString();
	}

	private static string Unescape(string str)
	{
		if (str == null)
		{
			return null;
		}
		StringBuilder stringBuilder = null;
		int length = str.Length;
		int newIndex = 0;
		while (true)
		{
			int num = str.IndexOf('&', newIndex);
			if (num == -1)
			{
				break;
			}
			if (stringBuilder == null)
			{
				stringBuilder = new StringBuilder();
			}
			stringBuilder.Append(str, newIndex, num - newIndex);
			stringBuilder.Append(GetUnescapeSequence(str, num, out newIndex));
		}
		if (stringBuilder == null)
		{
			return str;
		}
		stringBuilder.Append(str, newIndex, length - newIndex);
		return stringBuilder.ToString();
	}

	private static void ToStringHelperStringBuilder(object obj, string str)
	{
		((StringBuilder)obj).Append(str);
	}

	private static void ToStringHelperStreamWriter(object obj, string str)
	{
		((StreamWriter)obj).Write(str);
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		ToString("", stringBuilder, ToStringHelperStringBuilder);
		return stringBuilder.ToString();
	}

	internal void ToWriter(StreamWriter writer)
	{
		ToString("", writer, ToStringHelperStreamWriter);
	}

	private void ToString(string indent, object obj, ToStringHelperFunc func)
	{
		func(obj, "<");
		switch (m_type)
		{
		case SecurityElementType.Format:
			func(obj, "?");
			break;
		case SecurityElementType.Comment:
			func(obj, "!");
			break;
		}
		func(obj, m_strTag);
		if (m_lAttributes != null && m_lAttributes.Count > 0)
		{
			func(obj, " ");
			int count = m_lAttributes.Count;
			for (int i = 0; i < count; i += 2)
			{
				string str = (string)m_lAttributes[i];
				string str2 = (string)m_lAttributes[i + 1];
				func(obj, str);
				func(obj, "=\"");
				func(obj, str2);
				func(obj, "\"");
				if (i != m_lAttributes.Count - 2)
				{
					if (m_type == SecurityElementType.Regular)
					{
						func(obj, Environment.NewLine);
					}
					else
					{
						func(obj, " ");
					}
				}
			}
		}
		if (m_strText == null && (m_lChildren == null || m_lChildren.Count == 0))
		{
			switch (m_type)
			{
			case SecurityElementType.Comment:
				func(obj, ">");
				break;
			case SecurityElementType.Format:
				func(obj, " ?>");
				break;
			default:
				func(obj, "/>");
				break;
			}
			func(obj, Environment.NewLine);
			return;
		}
		func(obj, ">");
		func(obj, m_strText);
		if (m_lChildren != null)
		{
			ConvertSecurityElementFactories();
			func(obj, Environment.NewLine);
			for (int j = 0; j < m_lChildren.Count; j++)
			{
				((SecurityElement)m_lChildren[j]).ToString("", obj, func);
			}
		}
		func(obj, "</");
		func(obj, m_strTag);
		func(obj, ">");
		func(obj, Environment.NewLine);
	}

	public string Attribute(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (m_lAttributes == null)
		{
			return null;
		}
		int count = m_lAttributes.Count;
		for (int i = 0; i < count; i += 2)
		{
			string a = (string)m_lAttributes[i];
			if (string.Equals(a, name))
			{
				string str = (string)m_lAttributes[i + 1];
				return Unescape(str);
			}
		}
		return null;
	}

	public SecurityElement SearchForChildByTag(string tag)
	{
		if (tag == null)
		{
			throw new ArgumentNullException("tag");
		}
		if (m_lChildren == null)
		{
			return null;
		}
		IEnumerator enumerator = m_lChildren.GetEnumerator();
		while (enumerator.MoveNext())
		{
			SecurityElement securityElement = (SecurityElement)enumerator.Current;
			if (securityElement != null && string.Equals(securityElement.Tag, tag))
			{
				return securityElement;
			}
		}
		return null;
	}

	internal IPermission ToPermission(bool ignoreTypeLoadFailures)
	{
		IPermission permission = XMLUtil.CreatePermission(this, PermissionState.None, ignoreTypeLoadFailures);
		if (permission == null)
		{
			return null;
		}
		permission.FromXml(this);
		PermissionToken token = PermissionToken.GetToken(permission);
		return permission;
	}

	[SecurityCritical]
	internal object ToSecurityObject()
	{
		string strTag = m_strTag;
		if (strTag == "PermissionSet")
		{
			PermissionSet permissionSet = new PermissionSet(PermissionState.None);
			permissionSet.FromXml(this);
			return permissionSet;
		}
		return ToPermission(ignoreTypeLoadFailures: false);
	}

	internal string SearchForTextOfLocalName(string strLocalName)
	{
		if (strLocalName == null)
		{
			throw new ArgumentNullException("strLocalName");
		}
		if (m_strTag == null)
		{
			return null;
		}
		if (m_strTag.Equals(strLocalName) || m_strTag.EndsWith(":" + strLocalName, StringComparison.Ordinal))
		{
			return Unescape(m_strText);
		}
		if (m_lChildren == null)
		{
			return null;
		}
		IEnumerator enumerator = m_lChildren.GetEnumerator();
		while (enumerator.MoveNext())
		{
			string text = ((SecurityElement)enumerator.Current).SearchForTextOfLocalName(strLocalName);
			if (text != null)
			{
				return text;
			}
		}
		return null;
	}

	public string SearchForTextOfTag(string tag)
	{
		if (tag == null)
		{
			throw new ArgumentNullException("tag");
		}
		if (string.Equals(m_strTag, tag))
		{
			return Unescape(m_strText);
		}
		if (m_lChildren == null)
		{
			return null;
		}
		IEnumerator enumerator = m_lChildren.GetEnumerator();
		ConvertSecurityElementFactories();
		while (enumerator.MoveNext())
		{
			string text = ((SecurityElement)enumerator.Current).SearchForTextOfTag(tag);
			if (text != null)
			{
				return text;
			}
		}
		return null;
	}
}

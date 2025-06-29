using System.Collections;
using System.Globalization;

namespace System.Security.Util;

[Serializable]
internal class SiteString
{
	protected string m_site;

	protected ArrayList m_separatedSite;

	protected static char[] m_separators = new char[1] { '.' };

	protected internal SiteString()
	{
	}

	public SiteString(string site)
	{
		m_separatedSite = CreateSeparatedSite(site);
		m_site = site;
	}

	private SiteString(string site, ArrayList separatedSite)
	{
		m_separatedSite = separatedSite;
		m_site = site;
	}

	private static ArrayList CreateSeparatedSite(string site)
	{
		if (site == null || site.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidSite"));
		}
		ArrayList arrayList = new ArrayList();
		int num = -1;
		int num2 = -1;
		num = site.IndexOf('[');
		if (num == 0)
		{
			num2 = site.IndexOf(']', num + 1);
		}
		if (num2 != -1)
		{
			string value = site.Substring(num + 1, num2 - num - 1);
			arrayList.Add(value);
			return arrayList;
		}
		string[] array = site.Split(m_separators);
		for (int num3 = array.Length - 1; num3 > -1; num3--)
		{
			if (array[num3] == null)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_InvalidSite"));
			}
			if (array[num3].Equals(""))
			{
				if (num3 != array.Length - 1)
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_InvalidSite"));
				}
			}
			else if (array[num3].Equals("*"))
			{
				if (num3 != 0)
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_InvalidSite"));
				}
				arrayList.Add(array[num3]);
			}
			else
			{
				if (!AllLegalCharacters(array[num3]))
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_InvalidSite"));
				}
				arrayList.Add(array[num3]);
			}
		}
		return arrayList;
	}

	private static bool AllLegalCharacters(string str)
	{
		foreach (char c in str)
		{
			if (!IsLegalDNSChar(c) && !IsNetbiosSplChar(c))
			{
				return false;
			}
		}
		return true;
	}

	private static bool IsLegalDNSChar(char c)
	{
		if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9') || c == '-')
		{
			return true;
		}
		return false;
	}

	private static bool IsNetbiosSplChar(char c)
	{
		switch (c)
		{
		case '!':
		case '#':
		case '$':
		case '%':
		case '&':
		case '\'':
		case '(':
		case ')':
		case '-':
		case '.':
		case '@':
		case '^':
		case '_':
		case '{':
		case '}':
		case '~':
			return true;
		default:
			return false;
		}
	}

	public override string ToString()
	{
		return m_site;
	}

	public override bool Equals(object o)
	{
		if (o == null || !(o is SiteString))
		{
			return false;
		}
		return Equals((SiteString)o, ignoreCase: true);
	}

	public override int GetHashCode()
	{
		TextInfo textInfo = CultureInfo.InvariantCulture.TextInfo;
		return textInfo.GetCaseInsensitiveHashCode(m_site);
	}

	internal bool Equals(SiteString ss, bool ignoreCase)
	{
		if (m_site == null)
		{
			return ss.m_site == null;
		}
		if (ss.m_site == null)
		{
			return false;
		}
		if (IsSubsetOf(ss, ignoreCase))
		{
			return ss.IsSubsetOf(this, ignoreCase);
		}
		return false;
	}

	public virtual SiteString Copy()
	{
		return new SiteString(m_site, m_separatedSite);
	}

	public virtual bool IsSubsetOf(SiteString operand)
	{
		return IsSubsetOf(operand, ignoreCase: true);
	}

	public virtual bool IsSubsetOf(SiteString operand, bool ignoreCase)
	{
		StringComparison comparisonType = (ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal);
		if (operand == null)
		{
			return false;
		}
		if (m_separatedSite.Count == operand.m_separatedSite.Count && m_separatedSite.Count == 0)
		{
			return true;
		}
		if (m_separatedSite.Count < operand.m_separatedSite.Count - 1)
		{
			return false;
		}
		if (m_separatedSite.Count > operand.m_separatedSite.Count && operand.m_separatedSite.Count > 0 && !operand.m_separatedSite[operand.m_separatedSite.Count - 1].Equals("*"))
		{
			return false;
		}
		if (string.Compare(m_site, operand.m_site, comparisonType) == 0)
		{
			return true;
		}
		for (int i = 0; i < operand.m_separatedSite.Count - 1; i++)
		{
			if (string.Compare((string)m_separatedSite[i], (string)operand.m_separatedSite[i], comparisonType) != 0)
			{
				return false;
			}
		}
		if (m_separatedSite.Count < operand.m_separatedSite.Count)
		{
			return operand.m_separatedSite[operand.m_separatedSite.Count - 1].Equals("*");
		}
		if (m_separatedSite.Count == operand.m_separatedSite.Count)
		{
			if (string.Compare((string)m_separatedSite[m_separatedSite.Count - 1], (string)operand.m_separatedSite[m_separatedSite.Count - 1], comparisonType) != 0)
			{
				return operand.m_separatedSite[operand.m_separatedSite.Count - 1].Equals("*");
			}
			return true;
		}
		return true;
	}

	public virtual SiteString Intersect(SiteString operand)
	{
		if (operand == null)
		{
			return null;
		}
		if (IsSubsetOf(operand))
		{
			return Copy();
		}
		if (operand.IsSubsetOf(this))
		{
			return operand.Copy();
		}
		return null;
	}

	public virtual SiteString Union(SiteString operand)
	{
		if (operand == null)
		{
			return this;
		}
		if (IsSubsetOf(operand))
		{
			return operand.Copy();
		}
		if (operand.IsSubsetOf(this))
		{
			return Copy();
		}
		return null;
	}
}

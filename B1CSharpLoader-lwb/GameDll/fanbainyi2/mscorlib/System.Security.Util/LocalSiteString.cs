using System.Collections;

namespace System.Security.Util;

[Serializable]
internal class LocalSiteString : SiteString
{
	private new static char[] m_separators = new char[1] { '/' };

	public LocalSiteString(string site)
	{
		m_site = site.Replace('|', ':');
		if (m_site.Length > 2 && m_site.IndexOf(':') != -1)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidDirectoryOnUrl"));
		}
		m_separatedSite = CreateSeparatedString(m_site);
	}

	private ArrayList CreateSeparatedString(string directory)
	{
		if (directory == null || directory.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidDirectoryOnUrl"));
		}
		ArrayList arrayList = new ArrayList();
		string[] array = directory.Split(m_separators);
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] == null || array[i].Equals(""))
			{
				if (i < 2 && directory[i] == '/')
				{
					arrayList.Add("//");
				}
				else if (i != array.Length - 1)
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_InvalidDirectoryOnUrl"));
				}
			}
			else if (array[i].Equals("*"))
			{
				if (i != array.Length - 1)
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_InvalidDirectoryOnUrl"));
				}
				arrayList.Add(array[i]);
			}
			else
			{
				arrayList.Add(array[i]);
			}
		}
		return arrayList;
	}

	public virtual bool IsSubsetOf(LocalSiteString operand)
	{
		return IsSubsetOf(operand, ignoreCase: true);
	}

	public virtual bool IsSubsetOf(LocalSiteString operand, bool ignoreCase)
	{
		if (operand == null)
		{
			return false;
		}
		if (operand.m_separatedSite.Count == 0)
		{
			if (m_separatedSite.Count != 0)
			{
				if (m_separatedSite.Count > 0)
				{
					return string.Compare((string)m_separatedSite[0], "*", StringComparison.Ordinal) == 0;
				}
				return false;
			}
			return true;
		}
		if (m_separatedSite.Count == 0)
		{
			return string.Compare((string)operand.m_separatedSite[0], "*", StringComparison.Ordinal) == 0;
		}
		return base.IsSubsetOf(operand, ignoreCase);
	}
}

using System.Collections;

namespace System.Security.Util;

[Serializable]
internal class DirectoryString : SiteString
{
	private bool m_checkForIllegalChars;

	private new static char[] m_separators = new char[1] { '/' };

	protected static char[] m_illegalDirectoryCharacters = new char[8] { '\\', ':', '*', '?', '"', '<', '>', '|' };

	public DirectoryString()
	{
		m_site = "";
		m_separatedSite = new ArrayList();
	}

	public DirectoryString(string directory, bool checkForIllegalChars)
	{
		m_site = directory;
		m_checkForIllegalChars = checkForIllegalChars;
		m_separatedSite = CreateSeparatedString(directory);
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
				continue;
			}
			if (array[i].Equals("*"))
			{
				if (i != array.Length - 1)
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_InvalidDirectoryOnUrl"));
				}
				arrayList.Add(array[i]);
			}
			else
			{
				if (m_checkForIllegalChars && array[i].IndexOfAny(m_illegalDirectoryCharacters) != -1)
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_InvalidDirectoryOnUrl"));
				}
				arrayList.Add(array[i]);
			}
		}
		return arrayList;
	}

	public virtual bool IsSubsetOf(DirectoryString operand)
	{
		return IsSubsetOf(operand, ignoreCase: true);
	}

	public virtual bool IsSubsetOf(DirectoryString operand, bool ignoreCase)
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

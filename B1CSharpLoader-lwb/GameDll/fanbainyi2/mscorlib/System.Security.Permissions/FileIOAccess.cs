using System.Collections;
using System.Runtime.InteropServices;
using System.Security.Util;

namespace System.Security.Permissions;

[Serializable]
internal sealed class FileIOAccess
{
	private bool m_ignoreCase = true;

	private StringExpressionSet m_set;

	private bool m_allFiles;

	private bool m_allLocalFiles;

	private bool m_pathDiscovery;

	private const string m_strAllFiles = "*AllFiles*";

	private const string m_strAllLocalFiles = "*AllLocalFiles*";

	public bool AllFiles
	{
		get
		{
			return m_allFiles;
		}
		set
		{
			m_allFiles = value;
		}
	}

	public bool AllLocalFiles
	{
		get
		{
			return m_allLocalFiles;
		}
		set
		{
			m_allLocalFiles = value;
		}
	}

	public bool PathDiscovery
	{
		set
		{
			m_pathDiscovery = value;
		}
	}

	public FileIOAccess()
	{
		m_set = new StringExpressionSet(m_ignoreCase, throwOnRelative: true);
		m_allFiles = false;
		m_allLocalFiles = false;
		m_pathDiscovery = false;
	}

	public FileIOAccess(bool pathDiscovery)
	{
		m_set = new StringExpressionSet(m_ignoreCase, throwOnRelative: true);
		m_allFiles = false;
		m_allLocalFiles = false;
		m_pathDiscovery = pathDiscovery;
	}

	[SecurityCritical]
	public FileIOAccess(string value)
	{
		if (value == null)
		{
			m_set = new StringExpressionSet(m_ignoreCase, throwOnRelative: true);
			m_allFiles = false;
			m_allLocalFiles = false;
		}
		else if (value.Length >= "*AllFiles*".Length && string.Compare("*AllFiles*", value, StringComparison.Ordinal) == 0)
		{
			m_set = new StringExpressionSet(m_ignoreCase, throwOnRelative: true);
			m_allFiles = true;
			m_allLocalFiles = false;
		}
		else if (value.Length >= "*AllLocalFiles*".Length && string.Compare("*AllLocalFiles*", 0, value, 0, "*AllLocalFiles*".Length, StringComparison.Ordinal) == 0)
		{
			m_set = new StringExpressionSet(m_ignoreCase, value.Substring("*AllLocalFiles*".Length), throwOnRelative: true);
			m_allFiles = false;
			m_allLocalFiles = true;
		}
		else
		{
			m_set = new StringExpressionSet(m_ignoreCase, value, throwOnRelative: true);
			m_allFiles = false;
			m_allLocalFiles = false;
		}
		m_pathDiscovery = false;
	}

	public FileIOAccess(bool allFiles, bool allLocalFiles, bool pathDiscovery)
	{
		m_set = new StringExpressionSet(m_ignoreCase, throwOnRelative: true);
		m_allFiles = allFiles;
		m_allLocalFiles = allLocalFiles;
		m_pathDiscovery = pathDiscovery;
	}

	public FileIOAccess(StringExpressionSet set, bool allFiles, bool allLocalFiles, bool pathDiscovery)
	{
		m_set = set;
		m_set.SetThrowOnRelative(throwOnRelative: true);
		m_allFiles = allFiles;
		m_allLocalFiles = allLocalFiles;
		m_pathDiscovery = pathDiscovery;
	}

	private FileIOAccess(FileIOAccess operand)
	{
		m_set = operand.m_set.Copy();
		m_allFiles = operand.m_allFiles;
		m_allLocalFiles = operand.m_allLocalFiles;
		m_pathDiscovery = operand.m_pathDiscovery;
	}

	[SecurityCritical]
	public void AddExpressions(ArrayList values, bool checkForDuplicates)
	{
		m_allFiles = false;
		m_set.AddExpressions(values, checkForDuplicates);
	}

	public bool IsEmpty()
	{
		if (!m_allFiles && !m_allLocalFiles)
		{
			if (m_set != null)
			{
				return m_set.IsEmpty();
			}
			return true;
		}
		return false;
	}

	public FileIOAccess Copy()
	{
		return new FileIOAccess(this);
	}

	[SecuritySafeCritical]
	public FileIOAccess Union(FileIOAccess operand)
	{
		if (operand == null)
		{
			if (!IsEmpty())
			{
				return Copy();
			}
			return null;
		}
		if (m_allFiles || operand.m_allFiles)
		{
			return new FileIOAccess(allFiles: true, allLocalFiles: false, m_pathDiscovery);
		}
		return new FileIOAccess(m_set.Union(operand.m_set), allFiles: false, m_allLocalFiles || operand.m_allLocalFiles, m_pathDiscovery);
	}

	[SecuritySafeCritical]
	public FileIOAccess Intersect(FileIOAccess operand)
	{
		if (operand == null)
		{
			return null;
		}
		if (m_allFiles)
		{
			if (operand.m_allFiles)
			{
				return new FileIOAccess(allFiles: true, allLocalFiles: false, m_pathDiscovery);
			}
			return new FileIOAccess(operand.m_set.Copy(), allFiles: false, operand.m_allLocalFiles, m_pathDiscovery);
		}
		if (operand.m_allFiles)
		{
			return new FileIOAccess(m_set.Copy(), allFiles: false, m_allLocalFiles, m_pathDiscovery);
		}
		StringExpressionSet stringExpressionSet = new StringExpressionSet(m_ignoreCase, throwOnRelative: true);
		if (m_allLocalFiles)
		{
			string[] array = operand.m_set.UnsafeToStringArray();
			if (array != null)
			{
				for (int i = 0; i < array.Length; i++)
				{
					string root = GetRoot(array[i]);
					if (root != null && IsLocalDrive(GetRoot(root)))
					{
						stringExpressionSet.AddExpressions(new string[1] { array[i] }, checkForDuplicates: true, needFullPath: false);
					}
				}
			}
		}
		if (operand.m_allLocalFiles)
		{
			string[] array2 = m_set.UnsafeToStringArray();
			if (array2 != null)
			{
				for (int j = 0; j < array2.Length; j++)
				{
					string root2 = GetRoot(array2[j]);
					if (root2 != null && IsLocalDrive(GetRoot(root2)))
					{
						stringExpressionSet.AddExpressions(new string[1] { array2[j] }, checkForDuplicates: true, needFullPath: false);
					}
				}
			}
		}
		string[] array3 = m_set.Intersect(operand.m_set).UnsafeToStringArray();
		if (array3 != null)
		{
			stringExpressionSet.AddExpressions(array3, !stringExpressionSet.IsEmpty(), needFullPath: false);
		}
		return new FileIOAccess(stringExpressionSet, allFiles: false, m_allLocalFiles && operand.m_allLocalFiles, m_pathDiscovery);
	}

	[SecuritySafeCritical]
	public bool IsSubsetOf(FileIOAccess operand)
	{
		if (operand == null)
		{
			return IsEmpty();
		}
		if (operand.m_allFiles)
		{
			return true;
		}
		if ((!m_pathDiscovery || !m_set.IsSubsetOfPathDiscovery(operand.m_set)) && !m_set.IsSubsetOf(operand.m_set))
		{
			if (!operand.m_allLocalFiles)
			{
				return false;
			}
			string[] array = m_set.UnsafeToStringArray();
			for (int i = 0; i < array.Length; i++)
			{
				string root = GetRoot(array[i]);
				if (root == null || !IsLocalDrive(GetRoot(root)))
				{
					return false;
				}
			}
		}
		return true;
	}

	private static string GetRoot(string path)
	{
		string text = path.Substring(0, 3);
		if (text.EndsWith(":\\", StringComparison.Ordinal))
		{
			return text;
		}
		return null;
	}

	[SecuritySafeCritical]
	public override string ToString()
	{
		if (m_allFiles)
		{
			return "*AllFiles*";
		}
		if (m_allLocalFiles)
		{
			string text = "*AllLocalFiles*";
			string text2 = m_set.UnsafeToString();
			if (text2 != null && text2.Length > 0)
			{
				text = text + ";" + text2;
			}
			return text;
		}
		return m_set.UnsafeToString();
	}

	[SecuritySafeCritical]
	public string[] ToStringArray()
	{
		return m_set.UnsafeToStringArray();
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern bool IsLocalDrive(string path);

	[SecuritySafeCritical]
	public override bool Equals(object obj)
	{
		if (!(obj is FileIOAccess fileIOAccess))
		{
			if (IsEmpty())
			{
				return obj == null;
			}
			return false;
		}
		if (m_pathDiscovery)
		{
			if (m_allFiles && fileIOAccess.m_allFiles)
			{
				return true;
			}
			if (m_allLocalFiles == fileIOAccess.m_allLocalFiles && m_set.IsSubsetOf(fileIOAccess.m_set) && fileIOAccess.m_set.IsSubsetOf(m_set))
			{
				return true;
			}
			return false;
		}
		if (!IsSubsetOf(fileIOAccess))
		{
			return false;
		}
		if (!fileIOAccess.IsSubsetOf(this))
		{
			return false;
		}
		return true;
	}

	public override int GetHashCode()
	{
		return base.GetHashCode();
	}
}

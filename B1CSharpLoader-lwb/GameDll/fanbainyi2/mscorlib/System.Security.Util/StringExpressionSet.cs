using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Security.Util;

[Serializable]
internal class StringExpressionSet
{
	[SecurityCritical]
	protected ArrayList m_list;

	protected bool m_ignoreCase;

	[SecurityCritical]
	protected string m_expressions;

	[SecurityCritical]
	protected string[] m_expressionsArray;

	protected bool m_throwOnRelative;

	protected static readonly char[] m_separators = new char[1] { ';' };

	protected static readonly char[] m_trimChars = new char[1] { ' ' };

	protected static readonly char m_directorySeparator = '\\';

	protected static readonly char m_alternateDirectorySeparator = '/';

	public StringExpressionSet()
		: this(ignoreCase: true, null, throwOnRelative: false)
	{
	}

	public StringExpressionSet(string str)
		: this(ignoreCase: true, str, throwOnRelative: false)
	{
	}

	public StringExpressionSet(bool ignoreCase, bool throwOnRelative)
		: this(ignoreCase, null, throwOnRelative)
	{
	}

	[SecuritySafeCritical]
	public StringExpressionSet(bool ignoreCase, string str, bool throwOnRelative)
	{
		m_list = null;
		m_ignoreCase = ignoreCase;
		m_throwOnRelative = throwOnRelative;
		if (str == null)
		{
			m_expressions = null;
		}
		else
		{
			AddExpressions(str);
		}
	}

	protected virtual StringExpressionSet CreateNewEmpty()
	{
		return new StringExpressionSet();
	}

	[SecuritySafeCritical]
	public virtual StringExpressionSet Copy()
	{
		StringExpressionSet stringExpressionSet = CreateNewEmpty();
		if (m_list != null)
		{
			stringExpressionSet.m_list = new ArrayList(m_list);
		}
		stringExpressionSet.m_expressions = m_expressions;
		stringExpressionSet.m_ignoreCase = m_ignoreCase;
		stringExpressionSet.m_throwOnRelative = m_throwOnRelative;
		return stringExpressionSet;
	}

	public void SetThrowOnRelative(bool throwOnRelative)
	{
		m_throwOnRelative = throwOnRelative;
	}

	private static string StaticProcessWholeString(string str)
	{
		return str.Replace(m_alternateDirectorySeparator, m_directorySeparator);
	}

	private static string StaticProcessSingleString(string str)
	{
		return str.Trim(m_trimChars);
	}

	protected virtual string ProcessWholeString(string str)
	{
		return StaticProcessWholeString(str);
	}

	protected virtual string ProcessSingleString(string str)
	{
		return StaticProcessSingleString(str);
	}

	[SecurityCritical]
	public void AddExpressions(string str)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		if (str.Length == 0)
		{
			return;
		}
		str = ProcessWholeString(str);
		if (m_expressions == null)
		{
			m_expressions = str;
		}
		else
		{
			m_expressions = m_expressions + m_separators[0] + str;
		}
		m_expressionsArray = null;
		string[] array = Split(str);
		if (m_list == null)
		{
			m_list = new ArrayList();
		}
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] == null || array[i].Equals(""))
			{
				continue;
			}
			string text = ProcessSingleString(array[i]);
			int num = text.IndexOf('\0');
			if (num != -1)
			{
				text = text.Substring(0, num);
			}
			if (text == null || text.Equals(""))
			{
				continue;
			}
			if (m_throwOnRelative)
			{
				if (Path.IsRelative(text))
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_AbsolutePathRequired"));
				}
				text = CanonicalizePath(text);
			}
			m_list.Add(text);
		}
		Reduce();
	}

	[SecurityCritical]
	public void AddExpressions(string[] str, bool checkForDuplicates, bool needFullPath)
	{
		AddExpressions(CreateListFromExpressions(str, needFullPath), checkForDuplicates);
	}

	[SecurityCritical]
	public void AddExpressions(ArrayList exprArrayList, bool checkForDuplicates)
	{
		m_expressionsArray = null;
		m_expressions = null;
		if (m_list != null)
		{
			m_list.AddRange(exprArrayList);
		}
		else
		{
			m_list = new ArrayList(exprArrayList);
		}
		if (checkForDuplicates)
		{
			Reduce();
		}
	}

	[SecurityCritical]
	internal static ArrayList CreateListFromExpressions(string[] str, bool needFullPath)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		ArrayList arrayList = new ArrayList();
		for (int i = 0; i < str.Length; i++)
		{
			if (str[i] == null)
			{
				throw new ArgumentNullException("str");
			}
			string text = StaticProcessWholeString(str[i]);
			if (text == null || text.Length == 0)
			{
				continue;
			}
			string text2 = StaticProcessSingleString(text);
			int num = text2.IndexOf('\0');
			if (num != -1)
			{
				text2 = text2.Substring(0, num);
			}
			if (text2 != null && text2.Length != 0)
			{
				if (PathInternal.IsPartiallyQualified(text2))
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_AbsolutePathRequired"));
				}
				text2 = CanonicalizePath(text2, needFullPath);
				arrayList.Add(text2);
			}
		}
		return arrayList;
	}

	[SecurityCritical]
	protected void CheckList()
	{
		if (m_list == null && m_expressions != null)
		{
			CreateList();
		}
	}

	protected string[] Split(string expressions)
	{
		if (m_throwOnRelative)
		{
			List<string> list = new List<string>();
			string[] array = expressions.Split('"');
			for (int i = 0; i < array.Length; i++)
			{
				if (i % 2 == 0)
				{
					string[] array2 = array[i].Split(';');
					for (int j = 0; j < array2.Length; j++)
					{
						if (array2[j] != null && !array2[j].Equals(""))
						{
							list.Add(array2[j]);
						}
					}
				}
				else
				{
					list.Add(array[i]);
				}
			}
			string[] array3 = new string[list.Count];
			IEnumerator enumerator = list.GetEnumerator();
			int num = 0;
			while (enumerator.MoveNext())
			{
				array3[num++] = (string)enumerator.Current;
			}
			return array3;
		}
		return expressions.Split(m_separators);
	}

	[SecurityCritical]
	protected void CreateList()
	{
		string[] array = Split(m_expressions);
		m_list = new ArrayList();
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] == null || array[i].Equals(""))
			{
				continue;
			}
			string text = ProcessSingleString(array[i]);
			int num = text.IndexOf('\0');
			if (num != -1)
			{
				text = text.Substring(0, num);
			}
			if (text == null || text.Equals(""))
			{
				continue;
			}
			if (m_throwOnRelative)
			{
				if (Path.IsRelative(text))
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_AbsolutePathRequired"));
				}
				text = CanonicalizePath(text);
			}
			m_list.Add(text);
		}
	}

	[SecuritySafeCritical]
	public bool IsEmpty()
	{
		if (m_list == null)
		{
			return m_expressions == null;
		}
		return m_list.Count == 0;
	}

	[SecurityCritical]
	public bool IsSubsetOf(StringExpressionSet ses)
	{
		if (IsEmpty())
		{
			return true;
		}
		if (ses == null || ses.IsEmpty())
		{
			return false;
		}
		CheckList();
		ses.CheckList();
		for (int i = 0; i < m_list.Count; i++)
		{
			if (!StringSubsetStringExpression((string)m_list[i], ses, m_ignoreCase))
			{
				return false;
			}
		}
		return true;
	}

	[SecurityCritical]
	public bool IsSubsetOfPathDiscovery(StringExpressionSet ses)
	{
		if (IsEmpty())
		{
			return true;
		}
		if (ses == null || ses.IsEmpty())
		{
			return false;
		}
		CheckList();
		ses.CheckList();
		for (int i = 0; i < m_list.Count; i++)
		{
			if (!StringSubsetStringExpressionPathDiscovery((string)m_list[i], ses, m_ignoreCase))
			{
				return false;
			}
		}
		return true;
	}

	[SecurityCritical]
	public StringExpressionSet Union(StringExpressionSet ses)
	{
		if (ses == null || ses.IsEmpty())
		{
			return Copy();
		}
		if (IsEmpty())
		{
			return ses.Copy();
		}
		CheckList();
		ses.CheckList();
		StringExpressionSet stringExpressionSet = ((ses.m_list.Count > m_list.Count) ? ses : this);
		StringExpressionSet stringExpressionSet2 = ((ses.m_list.Count <= m_list.Count) ? ses : this);
		StringExpressionSet stringExpressionSet3 = stringExpressionSet.Copy();
		stringExpressionSet3.Reduce();
		for (int i = 0; i < stringExpressionSet2.m_list.Count; i++)
		{
			stringExpressionSet3.AddSingleExpressionNoDuplicates((string)stringExpressionSet2.m_list[i]);
		}
		stringExpressionSet3.GenerateString();
		return stringExpressionSet3;
	}

	[SecurityCritical]
	public StringExpressionSet Intersect(StringExpressionSet ses)
	{
		if (IsEmpty() || ses == null || ses.IsEmpty())
		{
			return CreateNewEmpty();
		}
		CheckList();
		ses.CheckList();
		StringExpressionSet stringExpressionSet = CreateNewEmpty();
		for (int i = 0; i < m_list.Count; i++)
		{
			for (int j = 0; j < ses.m_list.Count; j++)
			{
				if (StringSubsetString((string)m_list[i], (string)ses.m_list[j], m_ignoreCase))
				{
					if (stringExpressionSet.m_list == null)
					{
						stringExpressionSet.m_list = new ArrayList();
					}
					stringExpressionSet.AddSingleExpressionNoDuplicates((string)m_list[i]);
				}
				else if (StringSubsetString((string)ses.m_list[j], (string)m_list[i], m_ignoreCase))
				{
					if (stringExpressionSet.m_list == null)
					{
						stringExpressionSet.m_list = new ArrayList();
					}
					stringExpressionSet.AddSingleExpressionNoDuplicates((string)ses.m_list[j]);
				}
			}
		}
		stringExpressionSet.GenerateString();
		return stringExpressionSet;
	}

	[SecuritySafeCritical]
	protected void GenerateString()
	{
		if (m_list != null)
		{
			StringBuilder stringBuilder = new StringBuilder();
			IEnumerator enumerator = m_list.GetEnumerator();
			bool flag = true;
			while (enumerator.MoveNext())
			{
				if (!flag)
				{
					stringBuilder.Append(m_separators[0]);
				}
				else
				{
					flag = false;
				}
				string text = (string)enumerator.Current;
				if (text != null)
				{
					int num = text.IndexOf(m_separators[0]);
					if (num != -1)
					{
						stringBuilder.Append('"');
					}
					stringBuilder.Append(text);
					if (num != -1)
					{
						stringBuilder.Append('"');
					}
				}
			}
			m_expressions = stringBuilder.ToString();
		}
		else
		{
			m_expressions = null;
		}
	}

	[SecurityCritical]
	public string UnsafeToString()
	{
		CheckList();
		Reduce();
		GenerateString();
		return m_expressions;
	}

	[SecurityCritical]
	public string[] UnsafeToStringArray()
	{
		if (m_expressionsArray == null && m_list != null)
		{
			m_expressionsArray = (string[])m_list.ToArray(typeof(string));
		}
		return m_expressionsArray;
	}

	[SecurityCritical]
	private bool StringSubsetStringExpression(string left, StringExpressionSet right, bool ignoreCase)
	{
		for (int i = 0; i < right.m_list.Count; i++)
		{
			if (StringSubsetString(left, (string)right.m_list[i], ignoreCase))
			{
				return true;
			}
		}
		return false;
	}

	[SecurityCritical]
	private static bool StringSubsetStringExpressionPathDiscovery(string left, StringExpressionSet right, bool ignoreCase)
	{
		for (int i = 0; i < right.m_list.Count; i++)
		{
			if (StringSubsetStringPathDiscovery(left, (string)right.m_list[i], ignoreCase))
			{
				return true;
			}
		}
		return false;
	}

	protected virtual bool StringSubsetString(string left, string right, bool ignoreCase)
	{
		StringComparison comparisonType = (ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal);
		if (right == null || left == null || right.Length == 0 || left.Length == 0 || right.Length > left.Length)
		{
			return false;
		}
		if (right.Length == left.Length)
		{
			return string.Compare(right, left, comparisonType) == 0;
		}
		if (left.Length - right.Length == 1 && left[left.Length - 1] == m_directorySeparator)
		{
			return string.Compare(left, 0, right, 0, right.Length, comparisonType) == 0;
		}
		if (right[right.Length - 1] == m_directorySeparator)
		{
			return string.Compare(right, 0, left, 0, right.Length, comparisonType) == 0;
		}
		if (left[right.Length] == m_directorySeparator)
		{
			return string.Compare(right, 0, left, 0, right.Length, comparisonType) == 0;
		}
		return false;
	}

	protected static bool StringSubsetStringPathDiscovery(string left, string right, bool ignoreCase)
	{
		StringComparison comparisonType = (ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal);
		if (right == null || left == null || right.Length == 0 || left.Length == 0)
		{
			return false;
		}
		if (right.Length == left.Length)
		{
			return string.Compare(right, left, comparisonType) == 0;
		}
		string text;
		string text2;
		if (right.Length < left.Length)
		{
			text = right;
			text2 = left;
		}
		else
		{
			text = left;
			text2 = right;
		}
		if (string.Compare(text, 0, text2, 0, text.Length, comparisonType) != 0)
		{
			return false;
		}
		if (text.Length == 3 && text.EndsWith(":\\", StringComparison.Ordinal) && ((text[0] >= 'A' && text[0] <= 'Z') || (text[0] >= 'a' && text[0] <= 'z')))
		{
			return true;
		}
		return text2[text.Length] == m_directorySeparator;
	}

	[SecuritySafeCritical]
	protected void AddSingleExpressionNoDuplicates(string expression)
	{
		int num = 0;
		m_expressionsArray = null;
		m_expressions = null;
		if (m_list == null)
		{
			m_list = new ArrayList();
		}
		while (num < m_list.Count)
		{
			if (StringSubsetString((string)m_list[num], expression, m_ignoreCase))
			{
				m_list.RemoveAt(num);
				continue;
			}
			if (StringSubsetString(expression, (string)m_list[num], m_ignoreCase))
			{
				return;
			}
			num++;
		}
		m_list.Add(expression);
	}

	[SecurityCritical]
	protected void Reduce()
	{
		CheckList();
		if (m_list == null)
		{
			return;
		}
		for (int i = 0; i < m_list.Count - 1; i++)
		{
			int num = i + 1;
			while (num < m_list.Count)
			{
				if (StringSubsetString((string)m_list[num], (string)m_list[i], m_ignoreCase))
				{
					m_list.RemoveAt(num);
				}
				else if (StringSubsetString((string)m_list[i], (string)m_list[num], m_ignoreCase))
				{
					m_list[i] = m_list[num];
					m_list.RemoveAt(num);
					num = i + 1;
				}
				else
				{
					num++;
				}
			}
		}
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern void GetLongPathName(string path, StringHandleOnStack retLongPath);

	[SecurityCritical]
	internal static string CanonicalizePath(string path)
	{
		return CanonicalizePath(path, needFullPath: true);
	}

	[SecurityCritical]
	internal static string CanonicalizePath(string path, bool needFullPath)
	{
		if (needFullPath)
		{
			string text = Path.GetFullPathInternal(path);
			if (path.EndsWith(m_directorySeparator + ".", StringComparison.Ordinal))
			{
				text = ((!text.EndsWith(m_directorySeparator)) ? (text + m_directorySeparator + ".") : (text + "."));
			}
			path = text;
		}
		else if (path.IndexOf('~') != -1)
		{
			string s = null;
			GetLongPathName(path, JitHelpers.GetStringHandleOnStack(ref s));
			path = ((s != null) ? s : path);
		}
		if (path.IndexOf(':', 2) != -1)
		{
			throw new NotSupportedException(Environment.GetResourceString("Argument_PathFormatNotSupported"));
		}
		return path;
	}
}

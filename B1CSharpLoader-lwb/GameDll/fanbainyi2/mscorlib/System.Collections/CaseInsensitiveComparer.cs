using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Collections;

[Serializable]
[ComVisible(true)]
public class CaseInsensitiveComparer : IComparer
{
	private CompareInfo m_compareInfo;

	private static volatile CaseInsensitiveComparer m_InvariantCaseInsensitiveComparer;

	public static CaseInsensitiveComparer Default => new CaseInsensitiveComparer(CultureInfo.CurrentCulture);

	public static CaseInsensitiveComparer DefaultInvariant
	{
		get
		{
			if (m_InvariantCaseInsensitiveComparer == null)
			{
				m_InvariantCaseInsensitiveComparer = new CaseInsensitiveComparer(CultureInfo.InvariantCulture);
			}
			return m_InvariantCaseInsensitiveComparer;
		}
	}

	public CaseInsensitiveComparer()
	{
		m_compareInfo = CultureInfo.CurrentCulture.CompareInfo;
	}

	public CaseInsensitiveComparer(CultureInfo culture)
	{
		if (culture == null)
		{
			throw new ArgumentNullException("culture");
		}
		m_compareInfo = culture.CompareInfo;
	}

	public int Compare(object a, object b)
	{
		string text = a as string;
		string text2 = b as string;
		if (text != null && text2 != null)
		{
			return m_compareInfo.Compare(text, text2, CompareOptions.IgnoreCase);
		}
		return Comparer.Default.Compare(a, b);
	}
}

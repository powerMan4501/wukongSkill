using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Collections;

[Serializable]
[Obsolete("Please use StringComparer instead.")]
[ComVisible(true)]
public class CaseInsensitiveHashCodeProvider : IHashCodeProvider
{
	private TextInfo m_text;

	private static volatile CaseInsensitiveHashCodeProvider m_InvariantCaseInsensitiveHashCodeProvider;

	public static CaseInsensitiveHashCodeProvider Default => new CaseInsensitiveHashCodeProvider(CultureInfo.CurrentCulture);

	public static CaseInsensitiveHashCodeProvider DefaultInvariant
	{
		get
		{
			if (m_InvariantCaseInsensitiveHashCodeProvider == null)
			{
				m_InvariantCaseInsensitiveHashCodeProvider = new CaseInsensitiveHashCodeProvider(CultureInfo.InvariantCulture);
			}
			return m_InvariantCaseInsensitiveHashCodeProvider;
		}
	}

	public CaseInsensitiveHashCodeProvider()
	{
		m_text = CultureInfo.CurrentCulture.TextInfo;
	}

	public CaseInsensitiveHashCodeProvider(CultureInfo culture)
	{
		if (culture == null)
		{
			throw new ArgumentNullException("culture");
		}
		m_text = culture.TextInfo;
	}

	public int GetHashCode(object obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (!(obj is string str))
		{
			return obj.GetHashCode();
		}
		return m_text.GetCaseInsensitiveHashCode(str);
	}
}

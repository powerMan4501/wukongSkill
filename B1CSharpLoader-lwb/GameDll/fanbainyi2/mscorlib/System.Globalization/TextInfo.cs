using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Text;

namespace System.Globalization;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class TextInfo : ICloneable, IDeserializationCallback
{
	private enum Tristate : byte
	{
		NotInitialized,
		True,
		False
	}

	[OptionalField(VersionAdded = 2)]
	private string m_listSeparator;

	[OptionalField(VersionAdded = 2)]
	private bool m_isReadOnly;

	[OptionalField(VersionAdded = 3)]
	private string m_cultureName;

	[NonSerialized]
	private CultureData m_cultureData;

	[NonSerialized]
	private string m_textInfoName;

	[NonSerialized]
	private IntPtr m_dataHandle;

	[NonSerialized]
	private IntPtr m_handleOrigin;

	[NonSerialized]
	private Tristate m_IsAsciiCasingSameAsInvariant;

	internal static volatile TextInfo s_Invariant;

	[OptionalField(VersionAdded = 2)]
	private string customCultureName;

	[OptionalField(VersionAdded = 1)]
	internal int m_nDataItem;

	[OptionalField(VersionAdded = 1)]
	internal bool m_useUserOverride;

	[OptionalField(VersionAdded = 1)]
	internal int m_win32LangID;

	private const int wordSeparatorMask = 536672256;

	internal static TextInfo Invariant
	{
		get
		{
			if (s_Invariant == null)
			{
				s_Invariant = new TextInfo(CultureData.Invariant);
			}
			return s_Invariant;
		}
	}

	public virtual int ANSICodePage => m_cultureData.IDEFAULTANSICODEPAGE;

	public virtual int OEMCodePage => m_cultureData.IDEFAULTOEMCODEPAGE;

	public virtual int MacCodePage => m_cultureData.IDEFAULTMACCODEPAGE;

	public virtual int EBCDICCodePage => m_cultureData.IDEFAULTEBCDICCODEPAGE;

	[ComVisible(false)]
	public int LCID => CultureInfo.GetCultureInfo(m_textInfoName).LCID;

	[ComVisible(false)]
	[__DynamicallyInvokable]
	public string CultureName
	{
		[__DynamicallyInvokable]
		get
		{
			return m_textInfoName;
		}
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	public bool IsReadOnly
	{
		[__DynamicallyInvokable]
		get
		{
			return m_isReadOnly;
		}
	}

	[__DynamicallyInvokable]
	public virtual string ListSeparator
	{
		[SecuritySafeCritical]
		[__DynamicallyInvokable]
		get
		{
			if (m_listSeparator == null)
			{
				m_listSeparator = m_cultureData.SLIST;
			}
			return m_listSeparator;
		}
		[ComVisible(false)]
		[__DynamicallyInvokable]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value", Environment.GetResourceString("ArgumentNull_String"));
			}
			VerifyWritable();
			m_listSeparator = value;
		}
	}

	private bool IsAsciiCasingSameAsInvariant
	{
		get
		{
			if (m_IsAsciiCasingSameAsInvariant == Tristate.NotInitialized)
			{
				m_IsAsciiCasingSameAsInvariant = ((CultureInfo.GetCultureInfo(m_textInfoName).CompareInfo.Compare("abcdefghijklmnopqrstuvwxyz", "ABCDEFGHIJKLMNOPQRSTUVWXYZ", CompareOptions.IgnoreCase) == 0) ? Tristate.True : Tristate.False);
			}
			return m_IsAsciiCasingSameAsInvariant == Tristate.True;
		}
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	public bool IsRightToLeft
	{
		[__DynamicallyInvokable]
		get
		{
			return m_cultureData.IsRightToLeft;
		}
	}

	internal TextInfo(CultureData cultureData)
	{
		m_cultureData = cultureData;
		m_cultureName = m_cultureData.CultureName;
		m_textInfoName = m_cultureData.STEXTINFO;
		m_dataHandle = CompareInfo.InternalInitSortHandle(m_textInfoName, out var handleOrigin);
		m_handleOrigin = handleOrigin;
	}

	[OnDeserializing]
	private void OnDeserializing(StreamingContext ctx)
	{
		m_cultureData = null;
		m_cultureName = null;
	}

	private void OnDeserialized()
	{
		if (m_cultureData != null)
		{
			return;
		}
		if (m_cultureName == null)
		{
			if (customCultureName != null)
			{
				m_cultureName = customCultureName;
			}
			else if (m_win32LangID == 0)
			{
				m_cultureName = "ar-SA";
			}
			else
			{
				m_cultureName = CultureInfo.GetCultureInfo(m_win32LangID).m_cultureData.CultureName;
			}
		}
		m_cultureData = CultureInfo.GetCultureInfo(m_cultureName).m_cultureData;
		m_textInfoName = m_cultureData.STEXTINFO;
		m_dataHandle = CompareInfo.InternalInitSortHandle(m_textInfoName, out var handleOrigin);
		m_handleOrigin = handleOrigin;
	}

	[OnDeserialized]
	private void OnDeserialized(StreamingContext ctx)
	{
		OnDeserialized();
	}

	[OnSerializing]
	private void OnSerializing(StreamingContext ctx)
	{
		m_useUserOverride = false;
		customCultureName = m_cultureName;
		m_win32LangID = CultureInfo.GetCultureInfo(m_cultureName).LCID;
	}

	internal static int GetHashCodeOrdinalIgnoreCase(string s)
	{
		return GetHashCodeOrdinalIgnoreCase(s, forceRandomizedHashing: false, 0L);
	}

	internal static int GetHashCodeOrdinalIgnoreCase(string s, bool forceRandomizedHashing, long additionalEntropy)
	{
		return Invariant.GetCaseInsensitiveHashCode(s, forceRandomizedHashing, additionalEntropy);
	}

	[SecuritySafeCritical]
	internal static bool TryFastFindStringOrdinalIgnoreCase(int searchFlags, string source, int startIndex, string value, int count, ref int foundIndex)
	{
		return InternalTryFindStringOrdinalIgnoreCase(searchFlags, source, count, startIndex, value, value.Length, ref foundIndex);
	}

	[SecuritySafeCritical]
	internal static int CompareOrdinalIgnoreCase(string str1, string str2)
	{
		return InternalCompareStringOrdinalIgnoreCase(str1, 0, str2, 0, str1.Length, str2.Length);
	}

	[SecuritySafeCritical]
	internal static int CompareOrdinalIgnoreCaseEx(string strA, int indexA, string strB, int indexB, int lengthA, int lengthB)
	{
		return InternalCompareStringOrdinalIgnoreCase(strA, indexA, strB, indexB, lengthA, lengthB);
	}

	internal static int IndexOfStringOrdinalIgnoreCase(string source, string value, int startIndex, int count)
	{
		if (source.Length == 0 && value.Length == 0)
		{
			return 0;
		}
		int foundIndex = -1;
		if (TryFastFindStringOrdinalIgnoreCase(4194304, source, startIndex, value, count, ref foundIndex))
		{
			return foundIndex;
		}
		int num = startIndex + count;
		int num2 = num - value.Length;
		while (startIndex <= num2)
		{
			if (CompareOrdinalIgnoreCaseEx(source, startIndex, value, 0, value.Length, value.Length) == 0)
			{
				return startIndex;
			}
			startIndex++;
		}
		return -1;
	}

	internal static int LastIndexOfStringOrdinalIgnoreCase(string source, string value, int startIndex, int count)
	{
		if (value.Length == 0)
		{
			return startIndex;
		}
		int foundIndex = -1;
		if (TryFastFindStringOrdinalIgnoreCase(8388608, source, startIndex, value, count, ref foundIndex))
		{
			return foundIndex;
		}
		int num = startIndex - count + 1;
		if (value.Length > 0)
		{
			startIndex -= value.Length - 1;
		}
		while (startIndex >= num)
		{
			if (CompareOrdinalIgnoreCaseEx(source, startIndex, value, 0, value.Length, value.Length) == 0)
			{
				return startIndex;
			}
			startIndex--;
		}
		return -1;
	}

	[ComVisible(false)]
	public virtual object Clone()
	{
		object obj = MemberwiseClone();
		((TextInfo)obj).SetReadOnlyState(readOnly: false);
		return obj;
	}

	[ComVisible(false)]
	public static TextInfo ReadOnly(TextInfo textInfo)
	{
		if (textInfo == null)
		{
			throw new ArgumentNullException("textInfo");
		}
		if (textInfo.IsReadOnly)
		{
			return textInfo;
		}
		TextInfo textInfo2 = (TextInfo)textInfo.MemberwiseClone();
		textInfo2.SetReadOnlyState(readOnly: true);
		return textInfo2;
	}

	private void VerifyWritable()
	{
		if (m_isReadOnly)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_ReadOnly"));
		}
	}

	internal void SetReadOnlyState(bool readOnly)
	{
		m_isReadOnly = readOnly;
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public virtual char ToLower(char c)
	{
		if (IsAscii(c) && IsAsciiCasingSameAsInvariant)
		{
			return ToLowerAsciiInvariant(c);
		}
		return InternalChangeCaseChar(m_dataHandle, m_handleOrigin, m_textInfoName, c, isToUpper: false);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public virtual string ToLower(string str)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		return InternalChangeCaseString(m_dataHandle, m_handleOrigin, m_textInfoName, str, isToUpper: false);
	}

	private static char ToLowerAsciiInvariant(char c)
	{
		if ('A' <= c && c <= 'Z')
		{
			c = (char)(c | 0x20);
		}
		return c;
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public virtual char ToUpper(char c)
	{
		if (IsAscii(c) && IsAsciiCasingSameAsInvariant)
		{
			return ToUpperAsciiInvariant(c);
		}
		return InternalChangeCaseChar(m_dataHandle, m_handleOrigin, m_textInfoName, c, isToUpper: true);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public virtual string ToUpper(string str)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		return InternalChangeCaseString(m_dataHandle, m_handleOrigin, m_textInfoName, str, isToUpper: true);
	}

	private static char ToUpperAsciiInvariant(char c)
	{
		if ('a' <= c && c <= 'z')
		{
			c = (char)(c & -33);
		}
		return c;
	}

	private static bool IsAscii(char c)
	{
		return c < '\u0080';
	}

	[__DynamicallyInvokable]
	public override bool Equals(object obj)
	{
		if (obj is TextInfo textInfo)
		{
			return CultureName.Equals(textInfo.CultureName);
		}
		return false;
	}

	[__DynamicallyInvokable]
	public override int GetHashCode()
	{
		return CultureName.GetHashCode();
	}

	[__DynamicallyInvokable]
	public override string ToString()
	{
		return "TextInfo - " + m_cultureData.CultureName;
	}

	public string ToTitleCase(string str)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		if (str.Length == 0)
		{
			return str;
		}
		StringBuilder result = new StringBuilder();
		string text = null;
		int num;
		for (num = 0; num < str.Length; num++)
		{
			UnicodeCategory unicodeCategory = CharUnicodeInfo.InternalGetUnicodeCategory(str, num, out var charLength);
			if (char.CheckLetter(unicodeCategory))
			{
				num = AddTitlecaseLetter(ref result, ref str, num, charLength) + 1;
				int num2 = num;
				bool flag = unicodeCategory == UnicodeCategory.LowercaseLetter;
				while (num < str.Length)
				{
					unicodeCategory = CharUnicodeInfo.InternalGetUnicodeCategory(str, num, out charLength);
					if (IsLetterCategory(unicodeCategory))
					{
						if (unicodeCategory == UnicodeCategory.LowercaseLetter)
						{
							flag = true;
						}
						num += charLength;
					}
					else if (str[num] == '\'')
					{
						num++;
						if (flag)
						{
							if (text == null)
							{
								text = ToLower(str);
							}
							result.Append(text, num2, num - num2);
						}
						else
						{
							result.Append(str, num2, num - num2);
						}
						num2 = num;
						flag = true;
					}
					else
					{
						if (IsWordSeparator(unicodeCategory))
						{
							break;
						}
						num += charLength;
					}
				}
				int num3 = num - num2;
				if (num3 > 0)
				{
					if (flag)
					{
						if (text == null)
						{
							text = ToLower(str);
						}
						result.Append(text, num2, num3);
					}
					else
					{
						result.Append(str, num2, num3);
					}
				}
				if (num < str.Length)
				{
					num = AddNonLetter(ref result, ref str, num, charLength);
				}
			}
			else
			{
				num = AddNonLetter(ref result, ref str, num, charLength);
			}
		}
		return result.ToString();
	}

	private static int AddNonLetter(ref StringBuilder result, ref string input, int inputIndex, int charLen)
	{
		if (charLen == 2)
		{
			result.Append(input[inputIndex++]);
			result.Append(input[inputIndex]);
		}
		else
		{
			result.Append(input[inputIndex]);
		}
		return inputIndex;
	}

	private int AddTitlecaseLetter(ref StringBuilder result, ref string input, int inputIndex, int charLen)
	{
		if (charLen == 2)
		{
			result.Append(ToUpper(input.Substring(inputIndex, charLen)));
			inputIndex++;
		}
		else
		{
			switch (input[inputIndex])
			{
			case 'Ǆ':
			case 'ǅ':
			case 'ǆ':
				result.Append('ǅ');
				break;
			case 'Ǉ':
			case 'ǈ':
			case 'ǉ':
				result.Append('ǈ');
				break;
			case 'Ǌ':
			case 'ǋ':
			case 'ǌ':
				result.Append('ǋ');
				break;
			case 'Ǳ':
			case 'ǲ':
			case 'ǳ':
				result.Append('ǲ');
				break;
			default:
				result.Append(ToUpper(input[inputIndex]));
				break;
			}
		}
		return inputIndex;
	}

	private static bool IsWordSeparator(UnicodeCategory category)
	{
		return (0x1FFCF800 & (1 << (int)category)) != 0;
	}

	private static bool IsLetterCategory(UnicodeCategory uc)
	{
		if (uc != UnicodeCategory.UppercaseLetter && uc != UnicodeCategory.LowercaseLetter && uc != UnicodeCategory.TitlecaseLetter && uc != UnicodeCategory.ModifierLetter)
		{
			return uc == UnicodeCategory.OtherLetter;
		}
		return true;
	}

	void IDeserializationCallback.OnDeserialization(object sender)
	{
		OnDeserialized();
	}

	[SecuritySafeCritical]
	internal int GetCaseInsensitiveHashCode(string str)
	{
		return GetCaseInsensitiveHashCode(str, forceRandomizedHashing: false, 0L);
	}

	[SecuritySafeCritical]
	internal int GetCaseInsensitiveHashCode(string str, bool forceRandomizedHashing, long additionalEntropy)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		return InternalGetCaseInsHash(m_dataHandle, m_handleOrigin, m_textInfoName, str, forceRandomizedHashing, additionalEntropy);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern char InternalChangeCaseChar(IntPtr handle, IntPtr handleOrigin, string localeName, char ch, bool isToUpper);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern string InternalChangeCaseString(IntPtr handle, IntPtr handleOrigin, string localeName, string str, bool isToUpper);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern int InternalGetCaseInsHash(IntPtr handle, IntPtr handleOrigin, string localeName, string str, bool forceRandomizedHashing, long additionalEntropy);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern int InternalCompareStringOrdinalIgnoreCase(string string1, int index1, string string2, int index2, int length1, int length2);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool InternalTryFindStringOrdinalIgnoreCase(int searchFlags, string source, int sourceCount, int startIndex, string target, int targetCount, ref int foundIndex);
}

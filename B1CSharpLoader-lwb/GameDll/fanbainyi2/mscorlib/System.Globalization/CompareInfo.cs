using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using Microsoft.Win32;

namespace System.Globalization;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class CompareInfo : IDeserializationCallback
{
	private const CompareOptions ValidIndexMaskOffFlags = ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth);

	private const CompareOptions ValidCompareMaskOffFlags = ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.StringSort);

	private const CompareOptions ValidHashCodeOfStringMaskOffFlags = ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth);

	[OptionalField(VersionAdded = 2)]
	private string m_name;

	[NonSerialized]
	private string m_sortName;

	[NonSerialized]
	private IntPtr m_dataHandle;

	[NonSerialized]
	private IntPtr m_handleOrigin;

	[OptionalField(VersionAdded = 1)]
	private int win32LCID;

	private int culture;

	private const int LINGUISTIC_IGNORECASE = 16;

	private const int NORM_IGNORECASE = 1;

	private const int NORM_IGNOREKANATYPE = 65536;

	private const int LINGUISTIC_IGNOREDIACRITIC = 32;

	private const int NORM_IGNORENONSPACE = 2;

	private const int NORM_IGNORESYMBOLS = 4;

	private const int NORM_IGNOREWIDTH = 131072;

	private const int SORT_STRINGSORT = 4096;

	private const int COMPARE_OPTIONS_ORDINAL = 1073741824;

	internal const int NORM_LINGUISTIC_CASING = 134217728;

	private const int RESERVED_FIND_ASCII_STRING = 536870912;

	private const int SORT_VERSION_WHIDBEY = 4096;

	private const int SORT_VERSION_V4 = 393473;

	[OptionalField(VersionAdded = 3)]
	private SortVersion m_SortVersion;

	[ComVisible(false)]
	[__DynamicallyInvokable]
	public virtual string Name
	{
		[__DynamicallyInvokable]
		get
		{
			if (m_name == "zh-CHT" || m_name == "zh-CHS")
			{
				return m_name;
			}
			return m_sortName;
		}
	}

	public int LCID => CultureInfo.GetCultureInfo(Name).LCID;

	internal static bool IsLegacy20SortingBehaviorRequested => InternalSortVersion == 4096;

	private static uint InternalSortVersion
	{
		[SecuritySafeCritical]
		get
		{
			return InternalGetSortVersion();
		}
	}

	public SortVersion Version
	{
		[SecuritySafeCritical]
		get
		{
			if (m_SortVersion == null)
			{
				Win32Native.NlsVersionInfoEx lpNlsVersionInformation = new Win32Native.NlsVersionInfoEx
				{
					dwNLSVersionInfoSize = Marshal.SizeOf(typeof(Win32Native.NlsVersionInfoEx))
				};
				InternalGetNlsVersionEx(m_dataHandle, m_handleOrigin, m_sortName, ref lpNlsVersionInformation);
				m_SortVersion = new SortVersion(lpNlsVersionInformation.dwNLSVersion, (lpNlsVersionInformation.dwEffectiveId != 0) ? lpNlsVersionInformation.dwEffectiveId : LCID, lpNlsVersionInformation.guidCustomVersion);
			}
			return m_SortVersion;
		}
	}

	internal CompareInfo(CultureInfo culture)
	{
		m_name = culture.m_name;
		m_sortName = culture.SortName;
		m_dataHandle = InternalInitSortHandle(m_sortName, out var handleOrigin);
		m_handleOrigin = handleOrigin;
	}

	public static CompareInfo GetCompareInfo(int culture, Assembly assembly)
	{
		if (assembly == null)
		{
			throw new ArgumentNullException("assembly");
		}
		if (assembly != typeof(object).Module.Assembly)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_OnlyMscorlib"));
		}
		return GetCompareInfo(culture);
	}

	public static CompareInfo GetCompareInfo(string name, Assembly assembly)
	{
		if (name == null || assembly == null)
		{
			throw new ArgumentNullException((name == null) ? "name" : "assembly");
		}
		if (assembly != typeof(object).Module.Assembly)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_OnlyMscorlib"));
		}
		return GetCompareInfo(name);
	}

	public static CompareInfo GetCompareInfo(int culture)
	{
		if (CultureData.IsCustomCultureId(culture))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_CustomCultureCannotBePassedByNumber", "culture"));
		}
		return CultureInfo.GetCultureInfo(culture).CompareInfo;
	}

	[__DynamicallyInvokable]
	public static CompareInfo GetCompareInfo(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		return CultureInfo.GetCultureInfo(name).CompareInfo;
	}

	[ComVisible(false)]
	public static bool IsSortable(char ch)
	{
		return IsSortable(ch.ToString());
	}

	[SecuritySafeCritical]
	[ComVisible(false)]
	public static bool IsSortable(string text)
	{
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		if (text.Length == 0)
		{
			return false;
		}
		CompareInfo compareInfo = CultureInfo.InvariantCulture.CompareInfo;
		return InternalIsSortable(compareInfo.m_dataHandle, compareInfo.m_handleOrigin, compareInfo.m_sortName, text, text.Length);
	}

	[OnDeserializing]
	private void OnDeserializing(StreamingContext ctx)
	{
		m_name = null;
	}

	private void OnDeserialized()
	{
		CultureInfo cultureInfo;
		if (m_name == null)
		{
			cultureInfo = CultureInfo.GetCultureInfo(culture);
			m_name = cultureInfo.m_name;
		}
		else
		{
			cultureInfo = CultureInfo.GetCultureInfo(m_name);
		}
		m_sortName = cultureInfo.SortName;
		m_dataHandle = InternalInitSortHandle(m_sortName, out var handleOrigin);
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
		culture = CultureInfo.GetCultureInfo(Name).LCID;
	}

	void IDeserializationCallback.OnDeserialization(object sender)
	{
		OnDeserialized();
	}

	internal static int GetNativeCompareFlags(CompareOptions options)
	{
		int num = 134217728;
		if ((options & CompareOptions.IgnoreCase) != CompareOptions.None)
		{
			num |= 1;
		}
		if ((options & CompareOptions.IgnoreKanaType) != CompareOptions.None)
		{
			num |= 0x10000;
		}
		if ((options & CompareOptions.IgnoreNonSpace) != CompareOptions.None)
		{
			num |= 2;
		}
		if ((options & CompareOptions.IgnoreSymbols) != CompareOptions.None)
		{
			num |= 4;
		}
		if ((options & CompareOptions.IgnoreWidth) != CompareOptions.None)
		{
			num |= 0x20000;
		}
		if ((options & CompareOptions.StringSort) != CompareOptions.None)
		{
			num |= 0x1000;
		}
		if (options == CompareOptions.Ordinal)
		{
			num = 1073741824;
		}
		return num;
	}

	[__DynamicallyInvokable]
	public virtual int Compare(string string1, string string2)
	{
		return Compare(string1, string2, CompareOptions.None);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public virtual int Compare(string string1, string string2, CompareOptions options)
	{
		if (options == CompareOptions.OrdinalIgnoreCase)
		{
			return string.Compare(string1, string2, StringComparison.OrdinalIgnoreCase);
		}
		if ((options & CompareOptions.Ordinal) != CompareOptions.None)
		{
			if (options != CompareOptions.Ordinal)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_CompareOptionOrdinal"), "options");
			}
			return string.CompareOrdinal(string1, string2);
		}
		if ((options & ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.StringSort)) != CompareOptions.None)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidFlag"), "options");
		}
		if (string1 == null)
		{
			if (string2 == null)
			{
				return 0;
			}
			return -1;
		}
		if (string2 == null)
		{
			return 1;
		}
		return InternalCompareString(m_dataHandle, m_handleOrigin, m_sortName, string1, 0, string1.Length, string2, 0, string2.Length, GetNativeCompareFlags(options));
	}

	[__DynamicallyInvokable]
	public virtual int Compare(string string1, int offset1, int length1, string string2, int offset2, int length2)
	{
		return Compare(string1, offset1, length1, string2, offset2, length2, CompareOptions.None);
	}

	[__DynamicallyInvokable]
	public virtual int Compare(string string1, int offset1, string string2, int offset2, CompareOptions options)
	{
		return Compare(string1, offset1, (string1 != null) ? (string1.Length - offset1) : 0, string2, offset2, (string2 != null) ? (string2.Length - offset2) : 0, options);
	}

	[__DynamicallyInvokable]
	public virtual int Compare(string string1, int offset1, string string2, int offset2)
	{
		return Compare(string1, offset1, string2, offset2, CompareOptions.None);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public virtual int Compare(string string1, int offset1, int length1, string string2, int offset2, int length2, CompareOptions options)
	{
		if (options == CompareOptions.OrdinalIgnoreCase)
		{
			int num = string.Compare(string1, offset1, string2, offset2, (length1 < length2) ? length1 : length2, StringComparison.OrdinalIgnoreCase);
			if (length1 != length2 && num == 0)
			{
				if (length1 <= length2)
				{
					return -1;
				}
				return 1;
			}
			return num;
		}
		if (length1 < 0 || length2 < 0)
		{
			throw new ArgumentOutOfRangeException((length1 < 0) ? "length1" : "length2", Environment.GetResourceString("ArgumentOutOfRange_NeedPosNum"));
		}
		if (offset1 < 0 || offset2 < 0)
		{
			throw new ArgumentOutOfRangeException((offset1 < 0) ? "offset1" : "offset2", Environment.GetResourceString("ArgumentOutOfRange_NeedPosNum"));
		}
		if (offset1 > (string1?.Length ?? 0) - length1)
		{
			throw new ArgumentOutOfRangeException("string1", Environment.GetResourceString("ArgumentOutOfRange_OffsetLength"));
		}
		if (offset2 > (string2?.Length ?? 0) - length2)
		{
			throw new ArgumentOutOfRangeException("string2", Environment.GetResourceString("ArgumentOutOfRange_OffsetLength"));
		}
		if ((options & CompareOptions.Ordinal) != CompareOptions.None)
		{
			if (options != CompareOptions.Ordinal)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_CompareOptionOrdinal"), "options");
			}
		}
		else if ((options & ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.StringSort)) != CompareOptions.None)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidFlag"), "options");
		}
		if (string1 == null)
		{
			if (string2 == null)
			{
				return 0;
			}
			return -1;
		}
		if (string2 == null)
		{
			return 1;
		}
		if (options == CompareOptions.Ordinal)
		{
			return CompareOrdinal(string1, offset1, length1, string2, offset2, length2);
		}
		return InternalCompareString(m_dataHandle, m_handleOrigin, m_sortName, string1, offset1, length1, string2, offset2, length2, GetNativeCompareFlags(options));
	}

	[SecurityCritical]
	private static int CompareOrdinal(string string1, int offset1, int length1, string string2, int offset2, int length2)
	{
		int num = string.nativeCompareOrdinalEx(string1, offset1, string2, offset2, (length1 < length2) ? length1 : length2);
		if (length1 != length2 && num == 0)
		{
			if (length1 <= length2)
			{
				return -1;
			}
			return 1;
		}
		return num;
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public virtual bool IsPrefix(string source, string prefix, CompareOptions options)
	{
		if (source == null || prefix == null)
		{
			throw new ArgumentNullException((source == null) ? "source" : "prefix", Environment.GetResourceString("ArgumentNull_String"));
		}
		if (prefix.Length == 0)
		{
			return true;
		}
		switch (options)
		{
		case CompareOptions.OrdinalIgnoreCase:
			return source.StartsWith(prefix, StringComparison.OrdinalIgnoreCase);
		case CompareOptions.Ordinal:
			return source.StartsWith(prefix, StringComparison.Ordinal);
		default:
			if ((options & ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth)) != CompareOptions.None)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_InvalidFlag"), "options");
			}
			return InternalFindNLSStringEx(m_dataHandle, m_handleOrigin, m_sortName, GetNativeCompareFlags(options) | 0x100000 | ((source.IsAscii() && prefix.IsAscii()) ? 536870912 : 0), source, source.Length, 0, prefix, prefix.Length) > -1;
		}
	}

	[__DynamicallyInvokable]
	public virtual bool IsPrefix(string source, string prefix)
	{
		return IsPrefix(source, prefix, CompareOptions.None);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public virtual bool IsSuffix(string source, string suffix, CompareOptions options)
	{
		if (source == null || suffix == null)
		{
			throw new ArgumentNullException((source == null) ? "source" : "suffix", Environment.GetResourceString("ArgumentNull_String"));
		}
		if (suffix.Length == 0)
		{
			return true;
		}
		switch (options)
		{
		case CompareOptions.OrdinalIgnoreCase:
			return source.EndsWith(suffix, StringComparison.OrdinalIgnoreCase);
		case CompareOptions.Ordinal:
			return source.EndsWith(suffix, StringComparison.Ordinal);
		default:
			if ((options & ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth)) != CompareOptions.None)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_InvalidFlag"), "options");
			}
			return InternalFindNLSStringEx(m_dataHandle, m_handleOrigin, m_sortName, GetNativeCompareFlags(options) | 0x200000 | ((source.IsAscii() && suffix.IsAscii()) ? 536870912 : 0), source, source.Length, source.Length - 1, suffix, suffix.Length) >= 0;
		}
	}

	[__DynamicallyInvokable]
	public virtual bool IsSuffix(string source, string suffix)
	{
		return IsSuffix(source, suffix, CompareOptions.None);
	}

	[__DynamicallyInvokable]
	public virtual int IndexOf(string source, char value)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		return IndexOf(source, value, 0, source.Length, CompareOptions.None);
	}

	[__DynamicallyInvokable]
	public virtual int IndexOf(string source, string value)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		return IndexOf(source, value, 0, source.Length, CompareOptions.None);
	}

	[__DynamicallyInvokable]
	public virtual int IndexOf(string source, char value, CompareOptions options)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		return IndexOf(source, value, 0, source.Length, options);
	}

	[__DynamicallyInvokable]
	public virtual int IndexOf(string source, string value, CompareOptions options)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		return IndexOf(source, value, 0, source.Length, options);
	}

	public virtual int IndexOf(string source, char value, int startIndex)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		return IndexOf(source, value, startIndex, source.Length - startIndex, CompareOptions.None);
	}

	public virtual int IndexOf(string source, string value, int startIndex)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		return IndexOf(source, value, startIndex, source.Length - startIndex, CompareOptions.None);
	}

	[__DynamicallyInvokable]
	public virtual int IndexOf(string source, char value, int startIndex, CompareOptions options)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		return IndexOf(source, value, startIndex, source.Length - startIndex, options);
	}

	[__DynamicallyInvokable]
	public virtual int IndexOf(string source, string value, int startIndex, CompareOptions options)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		return IndexOf(source, value, startIndex, source.Length - startIndex, options);
	}

	[__DynamicallyInvokable]
	public virtual int IndexOf(string source, char value, int startIndex, int count)
	{
		return IndexOf(source, value, startIndex, count, CompareOptions.None);
	}

	[__DynamicallyInvokable]
	public virtual int IndexOf(string source, string value, int startIndex, int count)
	{
		return IndexOf(source, value, startIndex, count, CompareOptions.None);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public virtual int IndexOf(string source, char value, int startIndex, int count, CompareOptions options)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (startIndex < 0 || startIndex > source.Length)
		{
			throw new ArgumentOutOfRangeException("startIndex", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		if (count < 0 || startIndex > source.Length - count)
		{
			throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("ArgumentOutOfRange_Count"));
		}
		if (options == CompareOptions.OrdinalIgnoreCase)
		{
			return source.IndexOf(value.ToString(), startIndex, count, StringComparison.OrdinalIgnoreCase);
		}
		if ((options & ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth)) != CompareOptions.None && options != CompareOptions.Ordinal)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidFlag"), "options");
		}
		return InternalFindNLSStringEx(m_dataHandle, m_handleOrigin, m_sortName, GetNativeCompareFlags(options) | 0x400000 | ((source.IsAscii() && value <= '\u007f') ? 536870912 : 0), source, count, startIndex, new string(value, 1), 1);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public virtual int IndexOf(string source, string value, int startIndex, int count, CompareOptions options)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (startIndex > source.Length)
		{
			throw new ArgumentOutOfRangeException("startIndex", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		if (source.Length == 0)
		{
			if (value.Length == 0)
			{
				return 0;
			}
			return -1;
		}
		if (startIndex < 0)
		{
			throw new ArgumentOutOfRangeException("startIndex", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		if (count < 0 || startIndex > source.Length - count)
		{
			throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("ArgumentOutOfRange_Count"));
		}
		if (options == CompareOptions.OrdinalIgnoreCase)
		{
			return source.IndexOf(value, startIndex, count, StringComparison.OrdinalIgnoreCase);
		}
		if ((options & ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth)) != CompareOptions.None && options != CompareOptions.Ordinal)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidFlag"), "options");
		}
		return InternalFindNLSStringEx(m_dataHandle, m_handleOrigin, m_sortName, GetNativeCompareFlags(options) | 0x400000 | ((source.IsAscii() && value.IsAscii()) ? 536870912 : 0), source, count, startIndex, value, value.Length);
	}

	[__DynamicallyInvokable]
	public virtual int LastIndexOf(string source, char value)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		return LastIndexOf(source, value, source.Length - 1, source.Length, CompareOptions.None);
	}

	[__DynamicallyInvokable]
	public virtual int LastIndexOf(string source, string value)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		return LastIndexOf(source, value, source.Length - 1, source.Length, CompareOptions.None);
	}

	[__DynamicallyInvokable]
	public virtual int LastIndexOf(string source, char value, CompareOptions options)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		return LastIndexOf(source, value, source.Length - 1, source.Length, options);
	}

	[__DynamicallyInvokable]
	public virtual int LastIndexOf(string source, string value, CompareOptions options)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		return LastIndexOf(source, value, source.Length - 1, source.Length, options);
	}

	public virtual int LastIndexOf(string source, char value, int startIndex)
	{
		return LastIndexOf(source, value, startIndex, startIndex + 1, CompareOptions.None);
	}

	public virtual int LastIndexOf(string source, string value, int startIndex)
	{
		return LastIndexOf(source, value, startIndex, startIndex + 1, CompareOptions.None);
	}

	[__DynamicallyInvokable]
	public virtual int LastIndexOf(string source, char value, int startIndex, CompareOptions options)
	{
		return LastIndexOf(source, value, startIndex, startIndex + 1, options);
	}

	[__DynamicallyInvokable]
	public virtual int LastIndexOf(string source, string value, int startIndex, CompareOptions options)
	{
		return LastIndexOf(source, value, startIndex, startIndex + 1, options);
	}

	[__DynamicallyInvokable]
	public virtual int LastIndexOf(string source, char value, int startIndex, int count)
	{
		return LastIndexOf(source, value, startIndex, count, CompareOptions.None);
	}

	[__DynamicallyInvokable]
	public virtual int LastIndexOf(string source, string value, int startIndex, int count)
	{
		return LastIndexOf(source, value, startIndex, count, CompareOptions.None);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public virtual int LastIndexOf(string source, char value, int startIndex, int count, CompareOptions options)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if ((options & ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth)) != CompareOptions.None && options != CompareOptions.Ordinal && options != CompareOptions.OrdinalIgnoreCase)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidFlag"), "options");
		}
		if (source.Length == 0 && (startIndex == -1 || startIndex == 0))
		{
			return -1;
		}
		if (startIndex < 0 || startIndex > source.Length)
		{
			throw new ArgumentOutOfRangeException("startIndex", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		if (startIndex == source.Length)
		{
			startIndex--;
			if (count > 0)
			{
				count--;
			}
		}
		if (count < 0 || startIndex - count + 1 < 0)
		{
			throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("ArgumentOutOfRange_Count"));
		}
		if (options == CompareOptions.OrdinalIgnoreCase)
		{
			return source.LastIndexOf(value.ToString(), startIndex, count, StringComparison.OrdinalIgnoreCase);
		}
		return InternalFindNLSStringEx(m_dataHandle, m_handleOrigin, m_sortName, GetNativeCompareFlags(options) | 0x800000 | ((source.IsAscii() && value <= '\u007f') ? 536870912 : 0), source, count, startIndex, new string(value, 1), 1);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public virtual int LastIndexOf(string source, string value, int startIndex, int count, CompareOptions options)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if ((options & ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth)) != CompareOptions.None && options != CompareOptions.Ordinal && options != CompareOptions.OrdinalIgnoreCase)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidFlag"), "options");
		}
		if (source.Length == 0 && (startIndex == -1 || startIndex == 0))
		{
			if (value.Length != 0)
			{
				return -1;
			}
			return 0;
		}
		if (startIndex < 0 || startIndex > source.Length)
		{
			throw new ArgumentOutOfRangeException("startIndex", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		if (startIndex == source.Length)
		{
			startIndex--;
			if (count > 0)
			{
				count--;
			}
			if (value.Length == 0 && count >= 0 && startIndex - count + 1 >= 0)
			{
				return startIndex;
			}
		}
		if (count < 0 || startIndex - count + 1 < 0)
		{
			throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("ArgumentOutOfRange_Count"));
		}
		if (options == CompareOptions.OrdinalIgnoreCase)
		{
			return source.LastIndexOf(value, startIndex, count, StringComparison.OrdinalIgnoreCase);
		}
		return InternalFindNLSStringEx(m_dataHandle, m_handleOrigin, m_sortName, GetNativeCompareFlags(options) | 0x800000 | ((source.IsAscii() && value.IsAscii()) ? 536870912 : 0), source, count, startIndex, value, value.Length);
	}

	public virtual SortKey GetSortKey(string source, CompareOptions options)
	{
		return CreateSortKey(source, options);
	}

	public virtual SortKey GetSortKey(string source)
	{
		return CreateSortKey(source, CompareOptions.None);
	}

	[SecuritySafeCritical]
	private SortKey CreateSortKey(string source, CompareOptions options)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if ((options & ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.StringSort)) != CompareOptions.None)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidFlag"), "options");
		}
		byte[] array = null;
		if (string.IsNullOrEmpty(source))
		{
			array = EmptyArray<byte>.Value;
			source = "\0";
		}
		int nativeCompareFlags = GetNativeCompareFlags(options);
		int num = InternalGetSortKey(m_dataHandle, m_handleOrigin, m_sortName, nativeCompareFlags, source, source.Length, null, 0);
		if (num == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidFlag"), "source");
		}
		if (array == null)
		{
			array = new byte[num];
			num = InternalGetSortKey(m_dataHandle, m_handleOrigin, m_sortName, nativeCompareFlags, source, source.Length, array, array.Length);
		}
		else
		{
			source = string.Empty;
		}
		return new SortKey(Name, source, options, array);
	}

	[__DynamicallyInvokable]
	public override bool Equals(object value)
	{
		if (value is CompareInfo compareInfo)
		{
			return Name == compareInfo.Name;
		}
		return false;
	}

	[__DynamicallyInvokable]
	public override int GetHashCode()
	{
		return Name.GetHashCode();
	}

	[__DynamicallyInvokable]
	public virtual int GetHashCode(string source, CompareOptions options)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		return options switch
		{
			CompareOptions.Ordinal => source.GetHashCode(), 
			CompareOptions.OrdinalIgnoreCase => TextInfo.GetHashCodeOrdinalIgnoreCase(source), 
			_ => GetHashCodeOfString(source, options, forceRandomizedHashing: false, 0L), 
		};
	}

	internal int GetHashCodeOfString(string source, CompareOptions options)
	{
		return GetHashCodeOfString(source, options, forceRandomizedHashing: false, 0L);
	}

	[SecuritySafeCritical]
	internal int GetHashCodeOfString(string source, CompareOptions options, bool forceRandomizedHashing, long additionalEntropy)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if ((options & ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth)) != CompareOptions.None)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidFlag"), "options");
		}
		if (source.Length == 0)
		{
			return 0;
		}
		return InternalGetGlobalizedHashCode(m_dataHandle, m_handleOrigin, m_sortName, source, source.Length, GetNativeCompareFlags(options), forceRandomizedHashing, additionalEntropy);
	}

	[__DynamicallyInvokable]
	public override string ToString()
	{
		return "CompareInfo - " + Name;
	}

	[SecuritySafeCritical]
	internal static IntPtr InternalInitSortHandle(string localeName, out IntPtr handleOrigin)
	{
		return NativeInternalInitSortHandle(localeName, out handleOrigin);
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool InternalGetNlsVersionEx(IntPtr handle, IntPtr handleOrigin, string localeName, ref Win32Native.NlsVersionInfoEx lpNlsVersionInformation);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern uint InternalGetSortVersion();

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern IntPtr NativeInternalInitSortHandle(string localeName, out IntPtr handleOrigin);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern int InternalGetGlobalizedHashCode(IntPtr handle, IntPtr handleOrigin, string localeName, string source, int length, int dwFlags, bool forceRandomizedHashing, long additionalEntropy);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool InternalIsSortable(IntPtr handle, IntPtr handleOrigin, string localeName, string source, int length);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern int InternalCompareString(IntPtr handle, IntPtr handleOrigin, string localeName, string string1, int offset1, int length1, string string2, int offset2, int length2, int flags);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern int InternalFindNLSStringEx(IntPtr handle, IntPtr handleOrigin, string localeName, int flags, string source, int sourceCount, int startIndex, string target, int targetCount);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern int InternalGetSortKey(IntPtr handle, IntPtr handleOrigin, string localeName, int flags, string source, int sourceCount, byte[] target, int targetCount);
}

using System.Runtime.InteropServices;
using System.Security;

namespace System.Globalization;

[__DynamicallyInvokable]
public static class CharUnicodeInfo
{
	[StructLayout(LayoutKind.Explicit)]
	internal struct UnicodeDataHeader
	{
		[FieldOffset(0)]
		internal char TableName;

		[FieldOffset(32)]
		internal ushort version;

		[FieldOffset(40)]
		internal uint OffsetToCategoriesIndex;

		[FieldOffset(44)]
		internal uint OffsetToCategoriesValue;

		[FieldOffset(48)]
		internal uint OffsetToNumbericIndex;

		[FieldOffset(52)]
		internal uint OffsetToDigitValue;

		[FieldOffset(56)]
		internal uint OffsetToNumbericValue;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	internal struct DigitValues
	{
		internal sbyte decimalDigit;

		internal sbyte digit;
	}

	internal const char HIGH_SURROGATE_START = '\ud800';

	internal const char HIGH_SURROGATE_END = '\udbff';

	internal const char LOW_SURROGATE_START = '\udc00';

	internal const char LOW_SURROGATE_END = '\udfff';

	internal const int UNICODE_CATEGORY_OFFSET = 0;

	internal const int BIDI_CATEGORY_OFFSET = 1;

	private static bool s_initialized = InitTable();

	[SecurityCritical]
	private unsafe static ushort* s_pCategoryLevel1Index;

	[SecurityCritical]
	private unsafe static byte* s_pCategoriesValue;

	[SecurityCritical]
	private unsafe static ushort* s_pNumericLevel1Index;

	[SecurityCritical]
	private unsafe static byte* s_pNumericValues;

	[SecurityCritical]
	private unsafe static DigitValues* s_pDigitValues;

	internal const string UNICODE_INFO_FILE_NAME = "charinfo.nlp";

	internal const int UNICODE_PLANE01_START = 65536;

	[SecuritySafeCritical]
	private unsafe static bool InitTable()
	{
		byte* globalizationResourceBytePtr = GlobalizationAssembly.GetGlobalizationResourceBytePtr(typeof(CharUnicodeInfo).Assembly, "charinfo.nlp");
		UnicodeDataHeader* ptr = (UnicodeDataHeader*)globalizationResourceBytePtr;
		s_pCategoryLevel1Index = (ushort*)(globalizationResourceBytePtr + ptr->OffsetToCategoriesIndex);
		s_pCategoriesValue = globalizationResourceBytePtr + ptr->OffsetToCategoriesValue;
		s_pNumericLevel1Index = (ushort*)(globalizationResourceBytePtr + ptr->OffsetToNumbericIndex);
		s_pNumericValues = globalizationResourceBytePtr + ptr->OffsetToNumbericValue;
		s_pDigitValues = (DigitValues*)(globalizationResourceBytePtr + ptr->OffsetToDigitValue);
		return true;
	}

	internal static int InternalConvertToUtf32(string s, int index)
	{
		if (index < s.Length - 1)
		{
			int num = s[index] - 55296;
			if (num >= 0 && num <= 1023)
			{
				int num2 = s[index + 1] - 56320;
				if (num2 >= 0 && num2 <= 1023)
				{
					return num * 1024 + num2 + 65536;
				}
			}
		}
		return s[index];
	}

	internal static int InternalConvertToUtf32(string s, int index, out int charLength)
	{
		charLength = 1;
		if (index < s.Length - 1)
		{
			int num = s[index] - 55296;
			if (num >= 0 && num <= 1023)
			{
				int num2 = s[index + 1] - 56320;
				if (num2 >= 0 && num2 <= 1023)
				{
					charLength++;
					return num * 1024 + num2 + 65536;
				}
			}
		}
		return s[index];
	}

	internal static bool IsWhiteSpace(string s, int index)
	{
		UnicodeCategory unicodeCategory = GetUnicodeCategory(s, index);
		if ((uint)(unicodeCategory - 11) <= 2u)
		{
			return true;
		}
		return false;
	}

	internal static bool IsWhiteSpace(char c)
	{
		UnicodeCategory unicodeCategory = GetUnicodeCategory(c);
		if ((uint)(unicodeCategory - 11) <= 2u)
		{
			return true;
		}
		return false;
	}

	[SecuritySafeCritical]
	internal unsafe static double InternalGetNumericValue(int ch)
	{
		ushort num = s_pNumericLevel1Index[ch >> 8];
		num = s_pNumericLevel1Index[num + ((ch >> 4) & 0xF)];
		byte* ptr = (byte*)(s_pNumericLevel1Index + (int)num);
		return ((double*)s_pNumericValues)[(int)ptr[ch & 0xF]];
	}

	[SecuritySafeCritical]
	internal unsafe static DigitValues* InternalGetDigitValues(int ch)
	{
		ushort num = s_pNumericLevel1Index[ch >> 8];
		num = s_pNumericLevel1Index[num + ((ch >> 4) & 0xF)];
		byte* ptr = (byte*)(s_pNumericLevel1Index + (int)num);
		return s_pDigitValues + (int)ptr[ch & 0xF];
	}

	[SecuritySafeCritical]
	internal unsafe static sbyte InternalGetDecimalDigitValue(int ch)
	{
		return InternalGetDigitValues(ch)->decimalDigit;
	}

	[SecuritySafeCritical]
	internal unsafe static sbyte InternalGetDigitValue(int ch)
	{
		return InternalGetDigitValues(ch)->digit;
	}

	[__DynamicallyInvokable]
	public static double GetNumericValue(char ch)
	{
		return InternalGetNumericValue(ch);
	}

	[__DynamicallyInvokable]
	public static double GetNumericValue(string s, int index)
	{
		if (s == null)
		{
			throw new ArgumentNullException("s");
		}
		if (index < 0 || index >= s.Length)
		{
			throw new ArgumentOutOfRangeException("index", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		return InternalGetNumericValue(InternalConvertToUtf32(s, index));
	}

	public static int GetDecimalDigitValue(char ch)
	{
		return InternalGetDecimalDigitValue(ch);
	}

	public static int GetDecimalDigitValue(string s, int index)
	{
		if (s == null)
		{
			throw new ArgumentNullException("s");
		}
		if (index < 0 || index >= s.Length)
		{
			throw new ArgumentOutOfRangeException("index", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		return InternalGetDecimalDigitValue(InternalConvertToUtf32(s, index));
	}

	public static int GetDigitValue(char ch)
	{
		return InternalGetDigitValue(ch);
	}

	public static int GetDigitValue(string s, int index)
	{
		if (s == null)
		{
			throw new ArgumentNullException("s");
		}
		if (index < 0 || index >= s.Length)
		{
			throw new ArgumentOutOfRangeException("index", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		return InternalGetDigitValue(InternalConvertToUtf32(s, index));
	}

	[__DynamicallyInvokable]
	public static UnicodeCategory GetUnicodeCategory(char ch)
	{
		return InternalGetUnicodeCategory(ch);
	}

	[__DynamicallyInvokable]
	public static UnicodeCategory GetUnicodeCategory(string s, int index)
	{
		if (s == null)
		{
			throw new ArgumentNullException("s");
		}
		if ((uint)index >= (uint)s.Length)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		return InternalGetUnicodeCategory(s, index);
	}

	internal static UnicodeCategory InternalGetUnicodeCategory(int ch)
	{
		return (UnicodeCategory)InternalGetCategoryValue(ch, 0);
	}

	[SecuritySafeCritical]
	internal unsafe static byte InternalGetCategoryValue(int ch, int offset)
	{
		ushort num = s_pCategoryLevel1Index[ch >> 8];
		num = s_pCategoryLevel1Index[num + ((ch >> 4) & 0xF)];
		byte* ptr = (byte*)(s_pCategoryLevel1Index + (int)num);
		byte b = ptr[ch & 0xF];
		return s_pCategoriesValue[b * 2 + offset];
	}

	internal static BidiCategory GetBidiCategory(string s, int index)
	{
		if (s == null)
		{
			throw new ArgumentNullException("s");
		}
		if ((uint)index >= (uint)s.Length)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		return (BidiCategory)InternalGetCategoryValue(InternalConvertToUtf32(s, index), 1);
	}

	internal static UnicodeCategory InternalGetUnicodeCategory(string value, int index)
	{
		return InternalGetUnicodeCategory(InternalConvertToUtf32(value, index));
	}

	internal static UnicodeCategory InternalGetUnicodeCategory(string str, int index, out int charLength)
	{
		return InternalGetUnicodeCategory(InternalConvertToUtf32(str, index, out charLength));
	}

	internal static bool IsCombiningCategory(UnicodeCategory uc)
	{
		if (uc != UnicodeCategory.NonSpacingMark && uc != UnicodeCategory.SpacingCombiningMark)
		{
			return uc == UnicodeCategory.EnclosingMark;
		}
		return true;
	}
}

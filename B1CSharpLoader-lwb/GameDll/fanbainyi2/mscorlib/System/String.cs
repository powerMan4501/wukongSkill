using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading;
using Microsoft.Win32;

namespace System;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class String : IComparable, ICloneable, IConvertible, IEnumerable, IComparable<string>, IEnumerable<char>, IEquatable<string>
{
	[NonSerialized]
	private int m_stringLength;

	[NonSerialized]
	private char m_firstChar;

	private const int TrimHead = 0;

	private const int TrimTail = 1;

	private const int TrimBoth = 2;

	[__DynamicallyInvokable]
	public static readonly string Empty;

	private const int charPtrAlignConst = 1;

	private const int alignConst = 3;

	internal char FirstChar => m_firstChar;

	[IndexerName("Chars")]
	[__DynamicallyInvokable]
	public extern char this[int index]
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[SecuritySafeCritical]
		[__DynamicallyInvokable]
		get;
	}

	[__DynamicallyInvokable]
	public extern int Length
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[SecuritySafeCritical]
		[__DynamicallyInvokable]
		get;
	}

	[__DynamicallyInvokable]
	public static string Join(string separator, params string[] value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		return Join(separator, value, 0, value.Length);
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	public static string Join(string separator, params object[] values)
	{
		if (values == null)
		{
			throw new ArgumentNullException("values");
		}
		if (values.Length == 0 || values[0] == null)
		{
			return Empty;
		}
		if ((object)separator == null)
		{
			separator = Empty;
		}
		StringBuilder stringBuilder = StringBuilderCache.Acquire();
		string text = values[0].ToString();
		if ((object)text != null)
		{
			stringBuilder.Append(text);
		}
		for (int i = 1; i < values.Length; i++)
		{
			stringBuilder.Append(separator);
			if (values[i] != null)
			{
				text = values[i].ToString();
				if ((object)text != null)
				{
					stringBuilder.Append(text);
				}
			}
		}
		return StringBuilderCache.GetStringAndRelease(stringBuilder);
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	public static string Join<T>(string separator, IEnumerable<T> values)
	{
		if (values == null)
		{
			throw new ArgumentNullException("values");
		}
		if ((object)separator == null)
		{
			separator = Empty;
		}
		using IEnumerator<T> enumerator = values.GetEnumerator();
		if (!enumerator.MoveNext())
		{
			return Empty;
		}
		StringBuilder stringBuilder = StringBuilderCache.Acquire();
		if (enumerator.Current != null)
		{
			string text = enumerator.Current.ToString();
			if ((object)text != null)
			{
				stringBuilder.Append(text);
			}
		}
		while (enumerator.MoveNext())
		{
			stringBuilder.Append(separator);
			if (enumerator.Current != null)
			{
				string text2 = enumerator.Current.ToString();
				if ((object)text2 != null)
				{
					stringBuilder.Append(text2);
				}
			}
		}
		return StringBuilderCache.GetStringAndRelease(stringBuilder);
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	public static string Join(string separator, IEnumerable<string> values)
	{
		if (values == null)
		{
			throw new ArgumentNullException("values");
		}
		if ((object)separator == null)
		{
			separator = Empty;
		}
		using IEnumerator<string> enumerator = values.GetEnumerator();
		if (!enumerator.MoveNext())
		{
			return Empty;
		}
		StringBuilder stringBuilder = StringBuilderCache.Acquire();
		if ((object)enumerator.Current != null)
		{
			stringBuilder.Append(enumerator.Current);
		}
		while (enumerator.MoveNext())
		{
			stringBuilder.Append(separator);
			if ((object)enumerator.Current != null)
			{
				stringBuilder.Append(enumerator.Current);
			}
		}
		return StringBuilderCache.GetStringAndRelease(stringBuilder);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe static string Join(string separator, string[] value, int startIndex, int count)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (startIndex < 0)
		{
			throw new ArgumentOutOfRangeException("startIndex", Environment.GetResourceString("ArgumentOutOfRange_StartIndex"));
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("ArgumentOutOfRange_NegativeCount"));
		}
		if (startIndex > value.Length - count)
		{
			throw new ArgumentOutOfRangeException("startIndex", Environment.GetResourceString("ArgumentOutOfRange_IndexCountBuffer"));
		}
		if ((object)separator == null)
		{
			separator = Empty;
		}
		if (count == 0)
		{
			return Empty;
		}
		int num = 0;
		int num2 = startIndex + count - 1;
		for (int i = startIndex; i <= num2; i++)
		{
			if ((object)value[i] != null)
			{
				num += value[i].Length;
			}
		}
		num += (count - 1) * separator.Length;
		if (num < 0 || num + 1 < 0)
		{
			throw new OutOfMemoryException();
		}
		if (num == 0)
		{
			return Empty;
		}
		string text = FastAllocateString(num);
		fixed (char* firstChar = &text.m_firstChar)
		{
			UnSafeCharBuffer unSafeCharBuffer = new UnSafeCharBuffer(firstChar, num);
			unSafeCharBuffer.AppendString(value[startIndex]);
			for (int j = startIndex + 1; j <= num2; j++)
			{
				unSafeCharBuffer.AppendString(separator);
				unSafeCharBuffer.AppendString(value[j]);
			}
		}
		return text;
	}

	[SecuritySafeCritical]
	private unsafe static int CompareOrdinalIgnoreCaseHelper(string strA, string strB)
	{
		int num = Math.Min(strA.Length, strB.Length);
		fixed (char* firstChar = &strA.m_firstChar)
		{
			fixed (char* firstChar2 = &strB.m_firstChar)
			{
				char* ptr = firstChar;
				char* ptr2 = firstChar2;
				while (num != 0)
				{
					int num2 = *ptr;
					int num3 = *ptr2;
					if ((uint)(num2 - 97) <= 25u)
					{
						num2 -= 32;
					}
					if ((uint)(num3 - 97) <= 25u)
					{
						num3 -= 32;
					}
					if (num2 != num3)
					{
						return num2 - num3;
					}
					ptr++;
					ptr2++;
					num--;
				}
				return strA.Length - strB.Length;
			}
		}
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern int nativeCompareOrdinalEx(string strA, int indexA, string strB, int indexB, int count);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal unsafe static extern int nativeCompareOrdinalIgnoreCaseWC(string strA, sbyte* strBBytes);

	[SecuritySafeCritical]
	internal unsafe static string SmallCharToUpper(string strIn)
	{
		int length = strIn.Length;
		string text = FastAllocateString(length);
		fixed (char* firstChar = &strIn.m_firstChar)
		{
			fixed (char* firstChar2 = &text.m_firstChar)
			{
				for (int i = 0; i < length; i++)
				{
					int num = firstChar[i];
					if ((uint)(num - 97) <= 25u)
					{
						num -= 32;
					}
					firstChar2[i] = (char)num;
				}
			}
		}
		return text;
	}

	[SecuritySafeCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	private unsafe static bool EqualsHelper(string strA, string strB)
	{
		int num = strA.Length;
		fixed (char* firstChar = &strA.m_firstChar)
		{
			fixed (char* firstChar2 = &strB.m_firstChar)
			{
				char* ptr = firstChar;
				char* ptr2 = firstChar2;
				while (num >= 10)
				{
					if (*(int*)ptr != *(int*)ptr2)
					{
						return false;
					}
					if (*(int*)(ptr + 2) != *(int*)(ptr2 + 2))
					{
						return false;
					}
					if (*(int*)(ptr + 4) != *(int*)(ptr2 + 4))
					{
						return false;
					}
					if (*(int*)(ptr + 6) != *(int*)(ptr2 + 6))
					{
						return false;
					}
					if (*(int*)(ptr + 8) != *(int*)(ptr2 + 8))
					{
						return false;
					}
					ptr += 10;
					ptr2 += 10;
					num -= 10;
				}
				while (num > 0 && *(int*)ptr == *(int*)ptr2)
				{
					ptr += 2;
					ptr2 += 2;
					num -= 2;
				}
				return num <= 0;
			}
		}
	}

	[SecuritySafeCritical]
	private unsafe static bool EqualsIgnoreCaseAsciiHelper(string strA, string strB)
	{
		int num = strA.Length;
		fixed (char* firstChar = &strA.m_firstChar)
		{
			fixed (char* firstChar2 = &strB.m_firstChar)
			{
				char* ptr = firstChar;
				char* ptr2 = firstChar2;
				while (true)
				{
					if (num != 0)
					{
						int num2 = *ptr;
						int num3 = *ptr2;
						if (num2 != num3 && ((num2 | 0x20) != (num3 | 0x20) || (uint)((num2 | 0x20) - 97) > 25u))
						{
							break;
						}
						ptr++;
						ptr2++;
						num--;
						continue;
					}
					return true;
				}
				return false;
			}
		}
	}

	[SecuritySafeCritical]
	private unsafe static int CompareOrdinalHelper(string strA, string strB)
	{
		int num = Math.Min(strA.Length, strB.Length);
		int num2 = -1;
		fixed (char* firstChar = &strA.m_firstChar)
		{
			fixed (char* firstChar2 = &strB.m_firstChar)
			{
				char* ptr = firstChar;
				char* ptr2 = firstChar2;
				while (num >= 10)
				{
					if (*(int*)ptr != *(int*)ptr2)
					{
						num2 = 0;
						break;
					}
					if (*(int*)(ptr + 2) != *(int*)(ptr2 + 2))
					{
						num2 = 2;
						break;
					}
					if (*(int*)(ptr + 4) != *(int*)(ptr2 + 4))
					{
						num2 = 4;
						break;
					}
					if (*(int*)(ptr + 6) != *(int*)(ptr2 + 6))
					{
						num2 = 6;
						break;
					}
					if (*(int*)(ptr + 8) != *(int*)(ptr2 + 8))
					{
						num2 = 8;
						break;
					}
					ptr += 10;
					ptr2 += 10;
					num -= 10;
				}
				if (num2 != -1)
				{
					ptr += num2;
					ptr2 += num2;
					int result;
					if ((result = *ptr - *ptr2) != 0)
					{
						return result;
					}
					return ptr[1] - ptr2[1];
				}
				while (num > 0 && *(int*)ptr == *(int*)ptr2)
				{
					ptr += 2;
					ptr2 += 2;
					num -= 2;
				}
				if (num > 0)
				{
					int result2;
					if ((result2 = *ptr - *ptr2) != 0)
					{
						return result2;
					}
					return ptr[1] - ptr2[1];
				}
				return strA.Length - strB.Length;
			}
		}
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	[__DynamicallyInvokable]
	public override bool Equals(object obj)
	{
		if ((object)this == null)
		{
			throw new NullReferenceException();
		}
		if (!(obj is string text))
		{
			return false;
		}
		if (this == obj)
		{
			return true;
		}
		if (Length != text.Length)
		{
			return false;
		}
		return EqualsHelper(this, text);
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	[__DynamicallyInvokable]
	public bool Equals(string value)
	{
		if ((object)this == null)
		{
			throw new NullReferenceException();
		}
		if ((object)value == null)
		{
			return false;
		}
		if ((object)this == value)
		{
			return true;
		}
		if (Length != value.Length)
		{
			return false;
		}
		return EqualsHelper(this, value);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public bool Equals(string value, StringComparison comparisonType)
	{
		if (comparisonType < StringComparison.CurrentCulture || comparisonType > StringComparison.OrdinalIgnoreCase)
		{
			throw new ArgumentException(Environment.GetResourceString("NotSupported_StringComparison"), "comparisonType");
		}
		if ((object)this == value)
		{
			return true;
		}
		if ((object)value == null)
		{
			return false;
		}
		switch (comparisonType)
		{
		case StringComparison.CurrentCulture:
			return CultureInfo.CurrentCulture.CompareInfo.Compare(this, value, CompareOptions.None) == 0;
		case StringComparison.CurrentCultureIgnoreCase:
			return CultureInfo.CurrentCulture.CompareInfo.Compare(this, value, CompareOptions.IgnoreCase) == 0;
		case StringComparison.InvariantCulture:
			return CultureInfo.InvariantCulture.CompareInfo.Compare(this, value, CompareOptions.None) == 0;
		case StringComparison.InvariantCultureIgnoreCase:
			return CultureInfo.InvariantCulture.CompareInfo.Compare(this, value, CompareOptions.IgnoreCase) == 0;
		case StringComparison.Ordinal:
			if (Length != value.Length)
			{
				return false;
			}
			return EqualsHelper(this, value);
		case StringComparison.OrdinalIgnoreCase:
			if (Length != value.Length)
			{
				return false;
			}
			if (IsAscii() && value.IsAscii())
			{
				return EqualsIgnoreCaseAsciiHelper(this, value);
			}
			return TextInfo.CompareOrdinalIgnoreCase(this, value) == 0;
		default:
			throw new ArgumentException(Environment.GetResourceString("NotSupported_StringComparison"), "comparisonType");
		}
	}

	[__DynamicallyInvokable]
	public static bool Equals(string a, string b)
	{
		if ((object)a == b)
		{
			return true;
		}
		if ((object)a == null || (object)b == null)
		{
			return false;
		}
		if (a.Length != b.Length)
		{
			return false;
		}
		return EqualsHelper(a, b);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static bool Equals(string a, string b, StringComparison comparisonType)
	{
		if (comparisonType < StringComparison.CurrentCulture || comparisonType > StringComparison.OrdinalIgnoreCase)
		{
			throw new ArgumentException(Environment.GetResourceString("NotSupported_StringComparison"), "comparisonType");
		}
		if ((object)a == b)
		{
			return true;
		}
		if ((object)a == null || (object)b == null)
		{
			return false;
		}
		switch (comparisonType)
		{
		case StringComparison.CurrentCulture:
			return CultureInfo.CurrentCulture.CompareInfo.Compare(a, b, CompareOptions.None) == 0;
		case StringComparison.CurrentCultureIgnoreCase:
			return CultureInfo.CurrentCulture.CompareInfo.Compare(a, b, CompareOptions.IgnoreCase) == 0;
		case StringComparison.InvariantCulture:
			return CultureInfo.InvariantCulture.CompareInfo.Compare(a, b, CompareOptions.None) == 0;
		case StringComparison.InvariantCultureIgnoreCase:
			return CultureInfo.InvariantCulture.CompareInfo.Compare(a, b, CompareOptions.IgnoreCase) == 0;
		case StringComparison.Ordinal:
			if (a.Length != b.Length)
			{
				return false;
			}
			return EqualsHelper(a, b);
		case StringComparison.OrdinalIgnoreCase:
			if (a.Length != b.Length)
			{
				return false;
			}
			if (a.IsAscii() && b.IsAscii())
			{
				return EqualsIgnoreCaseAsciiHelper(a, b);
			}
			return TextInfo.CompareOrdinalIgnoreCase(a, b) == 0;
		default:
			throw new ArgumentException(Environment.GetResourceString("NotSupported_StringComparison"), "comparisonType");
		}
	}

	[__DynamicallyInvokable]
	public static bool operator ==(string a, string b)
	{
		return Equals(a, b);
	}

	[__DynamicallyInvokable]
	public static bool operator !=(string a, string b)
	{
		return !Equals(a, b);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
	{
		if (destination == null)
		{
			throw new ArgumentNullException("destination");
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("ArgumentOutOfRange_NegativeCount"));
		}
		if (sourceIndex < 0)
		{
			throw new ArgumentOutOfRangeException("sourceIndex", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		if (count > Length - sourceIndex)
		{
			throw new ArgumentOutOfRangeException("sourceIndex", Environment.GetResourceString("ArgumentOutOfRange_IndexCount"));
		}
		if (destinationIndex > destination.Length - count || destinationIndex < 0)
		{
			throw new ArgumentOutOfRangeException("destinationIndex", Environment.GetResourceString("ArgumentOutOfRange_IndexCount"));
		}
		if (count <= 0)
		{
			return;
		}
		fixed (char* firstChar = &m_firstChar)
		{
			fixed (char* ptr = destination)
			{
				wstrcpy(ptr + destinationIndex, firstChar + sourceIndex, count);
			}
		}
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe char[] ToCharArray()
	{
		int length = Length;
		char[] array = new char[length];
		if (length > 0)
		{
			fixed (char* firstChar = &m_firstChar)
			{
				fixed (char* dmem = array)
				{
					wstrcpy(dmem, firstChar, length);
				}
			}
		}
		return array;
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe char[] ToCharArray(int startIndex, int length)
	{
		if (startIndex < 0 || startIndex > Length || startIndex > Length - length)
		{
			throw new ArgumentOutOfRangeException("startIndex", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		if (length < 0)
		{
			throw new ArgumentOutOfRangeException("length", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		char[] array = new char[length];
		if (length > 0)
		{
			fixed (char* firstChar = &m_firstChar)
			{
				fixed (char* dmem = array)
				{
					wstrcpy(dmem, firstChar + startIndex, length);
				}
			}
		}
		return array;
	}

	[__DynamicallyInvokable]
	public static bool IsNullOrEmpty(string value)
	{
		if ((object)value != null)
		{
			return value.Length == 0;
		}
		return true;
	}

	[__DynamicallyInvokable]
	public static bool IsNullOrWhiteSpace(string value)
	{
		if ((object)value == null)
		{
			return true;
		}
		for (int i = 0; i < value.Length; i++)
		{
			if (!char.IsWhiteSpace(value[i]))
			{
				return false;
			}
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern int InternalMarvin32HashString(string s, int strLen, long additionalEntropy);

	[SecuritySafeCritical]
	internal static bool UseRandomizedHashing()
	{
		return InternalUseRandomizedHashing();
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool InternalUseRandomizedHashing();

	[SecuritySafeCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	[__DynamicallyInvokable]
	public unsafe override int GetHashCode()
	{
		if (HashHelpers.s_UseRandomizedStringHashing)
		{
			return InternalMarvin32HashString(this, Length, 0L);
		}
		fixed (char* ptr = this)
		{
			int num = 352654597;
			int num2 = num;
			int* ptr2 = (int*)ptr;
			int num3;
			for (num3 = Length; num3 > 2; num3 -= 4)
			{
				num = ((num << 5) + num + (num >> 27)) ^ *ptr2;
				num2 = ((num2 << 5) + num2 + (num2 >> 27)) ^ ptr2[1];
				ptr2 += 2;
			}
			if (num3 > 0)
			{
				num = ((num << 5) + num + (num >> 27)) ^ *ptr2;
			}
			return num + num2 * 1566083941;
		}
	}

	[SecuritySafeCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	internal unsafe int GetLegacyNonRandomizedHashCode()
	{
		fixed (char* ptr = this)
		{
			int num = 352654597;
			int num2 = num;
			int* ptr2 = (int*)ptr;
			int num3;
			for (num3 = Length; num3 > 2; num3 -= 4)
			{
				num = ((num << 5) + num + (num >> 27)) ^ *ptr2;
				num2 = ((num2 << 5) + num2 + (num2 >> 27)) ^ ptr2[1];
				ptr2 += 2;
			}
			if (num3 > 0)
			{
				num = ((num << 5) + num + (num >> 27)) ^ *ptr2;
			}
			return num + num2 * 1566083941;
		}
	}

	[__DynamicallyInvokable]
	public string[] Split(params char[] separator)
	{
		return SplitInternal(separator, int.MaxValue, StringSplitOptions.None);
	}

	[__DynamicallyInvokable]
	public string[] Split(char[] separator, int count)
	{
		return SplitInternal(separator, count, StringSplitOptions.None);
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	public string[] Split(char[] separator, StringSplitOptions options)
	{
		return SplitInternal(separator, int.MaxValue, options);
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	public string[] Split(char[] separator, int count, StringSplitOptions options)
	{
		return SplitInternal(separator, count, options);
	}

	[ComVisible(false)]
	internal string[] SplitInternal(char[] separator, int count, StringSplitOptions options)
	{
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("ArgumentOutOfRange_NegativeCount"));
		}
		if (options < StringSplitOptions.None || options > StringSplitOptions.RemoveEmptyEntries)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_EnumIllegalVal", options));
		}
		bool flag = options == StringSplitOptions.RemoveEmptyEntries;
		if (count == 0 || (flag && Length == 0))
		{
			return new string[0];
		}
		int[] sepList = new int[Length];
		int num = MakeSeparatorList(separator, ref sepList);
		if (num == 0 || count == 1)
		{
			return new string[1] { this };
		}
		if (flag)
		{
			return InternalSplitOmitEmptyEntries(sepList, null, num, count);
		}
		return InternalSplitKeepEmptyEntries(sepList, null, num, count);
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	public string[] Split(string[] separator, StringSplitOptions options)
	{
		return Split(separator, int.MaxValue, options);
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	public string[] Split(string[] separator, int count, StringSplitOptions options)
	{
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("ArgumentOutOfRange_NegativeCount"));
		}
		if (options < StringSplitOptions.None || options > StringSplitOptions.RemoveEmptyEntries)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_EnumIllegalVal", (int)options));
		}
		bool flag = options == StringSplitOptions.RemoveEmptyEntries;
		if (separator == null || separator.Length == 0)
		{
			return SplitInternal(null, count, options);
		}
		if (count == 0 || (flag && Length == 0))
		{
			return new string[0];
		}
		int[] sepList = new int[Length];
		int[] lengthList = new int[Length];
		int num = MakeSeparatorList(separator, ref sepList, ref lengthList);
		if (num == 0 || count == 1)
		{
			return new string[1] { this };
		}
		if (flag)
		{
			return InternalSplitOmitEmptyEntries(sepList, lengthList, num, count);
		}
		return InternalSplitKeepEmptyEntries(sepList, lengthList, num, count);
	}

	private string[] InternalSplitKeepEmptyEntries(int[] sepList, int[] lengthList, int numReplaces, int count)
	{
		int num = 0;
		int num2 = 0;
		count--;
		int num3 = ((numReplaces < count) ? numReplaces : count);
		string[] array = new string[num3 + 1];
		for (int i = 0; i < num3; i++)
		{
			if (num >= Length)
			{
				break;
			}
			array[num2++] = Substring(num, sepList[i] - num);
			num = sepList[i] + ((lengthList == null) ? 1 : lengthList[i]);
		}
		if (num < Length && num3 >= 0)
		{
			array[num2] = Substring(num);
		}
		else if (num2 == num3)
		{
			array[num2] = Empty;
		}
		return array;
	}

	private string[] InternalSplitOmitEmptyEntries(int[] sepList, int[] lengthList, int numReplaces, int count)
	{
		int num = ((numReplaces < count) ? (numReplaces + 1) : count);
		string[] array = new string[num];
		int num2 = 0;
		int num3 = 0;
		for (int i = 0; i < numReplaces; i++)
		{
			if (num2 >= Length)
			{
				break;
			}
			if (sepList[i] - num2 > 0)
			{
				array[num3++] = Substring(num2, sepList[i] - num2);
			}
			num2 = sepList[i] + ((lengthList == null) ? 1 : lengthList[i]);
			if (num3 == count - 1)
			{
				while (i < numReplaces - 1 && num2 == sepList[++i])
				{
					num2 += ((lengthList == null) ? 1 : lengthList[i]);
				}
				break;
			}
		}
		if (num2 < Length)
		{
			array[num3++] = Substring(num2);
		}
		string[] array2 = array;
		if (num3 != num)
		{
			array2 = new string[num3];
			for (int j = 0; j < num3; j++)
			{
				array2[j] = array[j];
			}
		}
		return array2;
	}

	[SecuritySafeCritical]
	private unsafe int MakeSeparatorList(char[] separator, ref int[] sepList)
	{
		int num = 0;
		if (separator == null || separator.Length == 0)
		{
			fixed (char* firstChar = &m_firstChar)
			{
				for (int i = 0; i < Length; i++)
				{
					if (num >= sepList.Length)
					{
						break;
					}
					if (char.IsWhiteSpace(firstChar[i]))
					{
						sepList[num++] = i;
					}
				}
			}
		}
		else
		{
			int num2 = sepList.Length;
			int num3 = separator.Length;
			fixed (char* firstChar2 = &m_firstChar)
			{
				fixed (char* ptr = separator)
				{
					for (int j = 0; j < Length; j++)
					{
						if (num >= num2)
						{
							break;
						}
						char* ptr2 = ptr;
						int num4 = 0;
						while (num4 < num3)
						{
							if (firstChar2[j] == *ptr2)
							{
								sepList[num++] = j;
								break;
							}
							num4++;
							ptr2++;
						}
					}
				}
			}
		}
		return num;
	}

	[SecuritySafeCritical]
	private unsafe int MakeSeparatorList(string[] separators, ref int[] sepList, ref int[] lengthList)
	{
		int num = 0;
		int num2 = sepList.Length;
		int num3 = separators.Length;
		fixed (char* firstChar = &m_firstChar)
		{
			for (int i = 0; i < Length; i++)
			{
				if (num >= num2)
				{
					break;
				}
				foreach (string text in separators)
				{
					if (!IsNullOrEmpty(text))
					{
						int length = text.Length;
						if (firstChar[i] == text[0] && length <= Length - i && (length == 1 || CompareOrdinal(this, i, text, 0, length) == 0))
						{
							sepList[num] = i;
							lengthList[num] = length;
							num++;
							i += length - 1;
							break;
						}
					}
				}
			}
		}
		return num;
	}

	[__DynamicallyInvokable]
	public string Substring(int startIndex)
	{
		return Substring(startIndex, Length - startIndex);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public string Substring(int startIndex, int length)
	{
		if (startIndex < 0)
		{
			throw new ArgumentOutOfRangeException("startIndex", Environment.GetResourceString("ArgumentOutOfRange_StartIndex"));
		}
		if (startIndex > Length)
		{
			throw new ArgumentOutOfRangeException("startIndex", Environment.GetResourceString("ArgumentOutOfRange_StartIndexLargerThanLength"));
		}
		if (length < 0)
		{
			throw new ArgumentOutOfRangeException("length", Environment.GetResourceString("ArgumentOutOfRange_NegativeLength"));
		}
		if (startIndex > Length - length)
		{
			throw new ArgumentOutOfRangeException("length", Environment.GetResourceString("ArgumentOutOfRange_IndexLength"));
		}
		if (length == 0)
		{
			return Empty;
		}
		if (startIndex == 0 && length == Length)
		{
			return this;
		}
		return InternalSubString(startIndex, length);
	}

	[SecurityCritical]
	private unsafe string InternalSubString(int startIndex, int length)
	{
		string text = FastAllocateString(length);
		fixed (char* firstChar = &text.m_firstChar)
		{
			fixed (char* firstChar2 = &m_firstChar)
			{
				wstrcpy(firstChar, firstChar2 + startIndex, length);
			}
		}
		return text;
	}

	[__DynamicallyInvokable]
	public string Trim(params char[] trimChars)
	{
		if (trimChars == null || trimChars.Length == 0)
		{
			return TrimHelper(2);
		}
		return TrimHelper(trimChars, 2);
	}

	[__DynamicallyInvokable]
	public string TrimStart(params char[] trimChars)
	{
		if (trimChars == null || trimChars.Length == 0)
		{
			return TrimHelper(0);
		}
		return TrimHelper(trimChars, 0);
	}

	[__DynamicallyInvokable]
	public string TrimEnd(params char[] trimChars)
	{
		if (trimChars == null || trimChars.Length == 0)
		{
			return TrimHelper(1);
		}
		return TrimHelper(trimChars, 1);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	[CLSCompliant(false)]
	public unsafe extern String(char* value);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	[CLSCompliant(false)]
	public unsafe extern String(char* value, int startIndex, int length);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	[CLSCompliant(false)]
	public unsafe extern String(sbyte* value);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	[CLSCompliant(false)]
	public unsafe extern String(sbyte* value, int startIndex, int length);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	[CLSCompliant(false)]
	public unsafe extern String(sbyte* value, int startIndex, int length, Encoding enc);

	[SecurityCritical]
	private unsafe static string CreateString(sbyte* value, int startIndex, int length, Encoding enc)
	{
		if (enc == null)
		{
			return new string(value, startIndex, length);
		}
		if (length < 0)
		{
			throw new ArgumentOutOfRangeException("length", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (startIndex < 0)
		{
			throw new ArgumentOutOfRangeException("startIndex", Environment.GetResourceString("ArgumentOutOfRange_StartIndex"));
		}
		if (value + startIndex < value)
		{
			throw new ArgumentOutOfRangeException("startIndex", Environment.GetResourceString("ArgumentOutOfRange_PartialWCHAR"));
		}
		byte[] array = new byte[length];
		try
		{
			Buffer.Memcpy(array, 0, (byte*)value, startIndex, length);
		}
		catch (NullReferenceException)
		{
			throw new ArgumentOutOfRangeException("value", Environment.GetResourceString("ArgumentOutOfRange_PartialWCHAR"));
		}
		return enc.GetString(array);
	}

	[SecurityCritical]
	internal unsafe static string CreateStringFromEncoding(byte* bytes, int byteLength, Encoding encoding)
	{
		int charCount = encoding.GetCharCount(bytes, byteLength, null);
		if (charCount == 0)
		{
			return Empty;
		}
		string text = FastAllocateString(charCount);
		fixed (char* firstChar = &text.m_firstChar)
		{
			int chars = encoding.GetChars(bytes, byteLength, firstChar, charCount, null);
		}
		return text;
	}

	[SecuritySafeCritical]
	internal unsafe int GetBytesFromEncoding(byte* pbNativeBuffer, int cbNativeBuffer, Encoding encoding)
	{
		fixed (char* firstChar = &m_firstChar)
		{
			return encoding.GetBytes(firstChar, m_stringLength, pbNativeBuffer, cbNativeBuffer);
		}
	}

	[SecuritySafeCritical]
	internal unsafe int ConvertToAnsi(byte* pbNativeBuffer, int cbNativeBuffer, bool fBestFit, bool fThrowOnUnmappableChar)
	{
		uint flags = ((!fBestFit) ? 1024u : 0u);
		uint num = 0u;
		int num2;
		fixed (char* firstChar = &m_firstChar)
		{
			num2 = Win32Native.WideCharToMultiByte(0u, flags, firstChar, Length, pbNativeBuffer, cbNativeBuffer, IntPtr.Zero, fThrowOnUnmappableChar ? new IntPtr(&num) : IntPtr.Zero);
		}
		if (num != 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Interop_Marshal_Unmappable_Char"));
		}
		pbNativeBuffer[num2] = 0;
		return num2;
	}

	public bool IsNormalized()
	{
		return IsNormalized(NormalizationForm.FormC);
	}

	[SecuritySafeCritical]
	public bool IsNormalized(NormalizationForm normalizationForm)
	{
		if (IsFastSort() && (normalizationForm == NormalizationForm.FormC || normalizationForm == NormalizationForm.FormKC || normalizationForm == NormalizationForm.FormD || normalizationForm == NormalizationForm.FormKD))
		{
			return true;
		}
		return Normalization.IsNormalized(this, normalizationForm);
	}

	public string Normalize()
	{
		return Normalize(NormalizationForm.FormC);
	}

	[SecuritySafeCritical]
	public string Normalize(NormalizationForm normalizationForm)
	{
		if (IsAscii() && (normalizationForm == NormalizationForm.FormC || normalizationForm == NormalizationForm.FormKC || normalizationForm == NormalizationForm.FormD || normalizationForm == NormalizationForm.FormKD))
		{
			return this;
		}
		return Normalization.Normalize(this, normalizationForm);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern string FastAllocateString(int length);

	[SecuritySafeCritical]
	private unsafe static void FillStringChecked(string dest, int destPos, string src)
	{
		if (src.Length > dest.Length - destPos)
		{
			throw new IndexOutOfRangeException();
		}
		fixed (char* firstChar = &dest.m_firstChar)
		{
			fixed (char* firstChar2 = &src.m_firstChar)
			{
				wstrcpy(firstChar + destPos, firstChar2, src.Length);
			}
		}
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public extern String(char[] value, int startIndex, int length);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public extern String(char[] value);

	[SecurityCritical]
	internal unsafe static void wstrcpy(char* dmem, char* smem, int charCount)
	{
		Buffer.Memcpy((byte*)dmem, (byte*)smem, charCount * 2);
	}

	[SecuritySafeCritical]
	private unsafe string CtorCharArray(char[] value)
	{
		if (value != null && value.Length != 0)
		{
			string text = FastAllocateString(value.Length);
			fixed (char* dmem = text)
			{
				fixed (char* smem = value)
				{
					wstrcpy(dmem, smem, value.Length);
				}
			}
			return text;
		}
		return Empty;
	}

	[SecuritySafeCritical]
	private unsafe string CtorCharArrayStartLength(char[] value, int startIndex, int length)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (startIndex < 0)
		{
			throw new ArgumentOutOfRangeException("startIndex", Environment.GetResourceString("ArgumentOutOfRange_StartIndex"));
		}
		if (length < 0)
		{
			throw new ArgumentOutOfRangeException("length", Environment.GetResourceString("ArgumentOutOfRange_NegativeLength"));
		}
		if (startIndex > value.Length - length)
		{
			throw new ArgumentOutOfRangeException("startIndex", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		if (length > 0)
		{
			string text = FastAllocateString(length);
			fixed (char* dmem = text)
			{
				fixed (char* ptr = value)
				{
					wstrcpy(dmem, ptr + startIndex, length);
				}
			}
			return text;
		}
		return Empty;
	}

	[SecuritySafeCritical]
	private unsafe string CtorCharCount(char c, int count)
	{
		if (count > 0)
		{
			string text = FastAllocateString(count);
			if (c != 0)
			{
				fixed (char* ptr = text)
				{
					char* ptr2 = ptr;
					while (((int)ptr2 & 3) != 0 && count > 0)
					{
						*(ptr2++) = c;
						count--;
					}
					uint num = ((uint)c << 16) | c;
					if (count >= 4)
					{
						count -= 4;
						do
						{
							*(uint*)ptr2 = num;
							((int*)ptr2)[1] = (int)num;
							ptr2 += 4;
							count -= 4;
						}
						while (count >= 0);
					}
					if ((count & 2) != 0)
					{
						*(uint*)ptr2 = num;
						ptr2 += 2;
					}
					if ((count & 1) != 0)
					{
						*ptr2 = c;
					}
				}
			}
			return text;
		}
		if (count == 0)
		{
			return Empty;
		}
		throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("ArgumentOutOfRange_MustBeNonNegNum", "count"));
	}

	[SecurityCritical]
	private unsafe static int wcslen(char* ptr)
	{
		char* ptr2;
		for (ptr2 = ptr; ((int)ptr2 & 3) != 0 && *ptr2 != 0; ptr2++)
		{
		}
		if (*ptr2 != 0)
		{
			for (; (*ptr2 & ptr2[1]) != 0 || (*ptr2 != 0 && ptr2[1] != 0); ptr2 += 2)
			{
			}
		}
		for (; *ptr2 != 0; ptr2++)
		{
		}
		return (int)(ptr2 - ptr);
	}

	[SecurityCritical]
	private unsafe string CtorCharPtr(char* ptr)
	{
		if (ptr == null)
		{
			return Empty;
		}
		if ((nuint)ptr < (nuint)64000u)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeStringPtrNotAtom"));
		}
		try
		{
			int num = wcslen(ptr);
			if (num == 0)
			{
				return Empty;
			}
			string text = FastAllocateString(num);
			fixed (char* dmem = text)
			{
				wstrcpy(dmem, ptr, num);
			}
			return text;
		}
		catch (NullReferenceException)
		{
			throw new ArgumentOutOfRangeException("ptr", Environment.GetResourceString("ArgumentOutOfRange_PartialWCHAR"));
		}
	}

	[SecurityCritical]
	private unsafe string CtorCharPtrStartLength(char* ptr, int startIndex, int length)
	{
		if (length < 0)
		{
			throw new ArgumentOutOfRangeException("length", Environment.GetResourceString("ArgumentOutOfRange_NegativeLength"));
		}
		if (startIndex < 0)
		{
			throw new ArgumentOutOfRangeException("startIndex", Environment.GetResourceString("ArgumentOutOfRange_StartIndex"));
		}
		char* ptr2 = ptr + startIndex;
		if (ptr2 < ptr)
		{
			throw new ArgumentOutOfRangeException("startIndex", Environment.GetResourceString("ArgumentOutOfRange_PartialWCHAR"));
		}
		if (length == 0)
		{
			return Empty;
		}
		string text = FastAllocateString(length);
		try
		{
			fixed (char* dmem = text)
			{
				wstrcpy(dmem, ptr2, length);
			}
			return text;
		}
		catch (NullReferenceException)
		{
			throw new ArgumentOutOfRangeException("ptr", Environment.GetResourceString("ArgumentOutOfRange_PartialWCHAR"));
		}
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public extern String(char c, int count);

	[__DynamicallyInvokable]
	public static int Compare(string strA, string strB)
	{
		return CultureInfo.CurrentCulture.CompareInfo.Compare(strA, strB, CompareOptions.None);
	}

	[__DynamicallyInvokable]
	public static int Compare(string strA, string strB, bool ignoreCase)
	{
		if (ignoreCase)
		{
			return CultureInfo.CurrentCulture.CompareInfo.Compare(strA, strB, CompareOptions.IgnoreCase);
		}
		return CultureInfo.CurrentCulture.CompareInfo.Compare(strA, strB, CompareOptions.None);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static int Compare(string strA, string strB, StringComparison comparisonType)
	{
		if ((uint)(comparisonType - 0) > 5u)
		{
			throw new ArgumentException(Environment.GetResourceString("NotSupported_StringComparison"), "comparisonType");
		}
		if ((object)strA == strB)
		{
			return 0;
		}
		if ((object)strA == null)
		{
			return -1;
		}
		if ((object)strB == null)
		{
			return 1;
		}
		switch (comparisonType)
		{
		case StringComparison.CurrentCulture:
			return CultureInfo.CurrentCulture.CompareInfo.Compare(strA, strB, CompareOptions.None);
		case StringComparison.CurrentCultureIgnoreCase:
			return CultureInfo.CurrentCulture.CompareInfo.Compare(strA, strB, CompareOptions.IgnoreCase);
		case StringComparison.InvariantCulture:
			return CultureInfo.InvariantCulture.CompareInfo.Compare(strA, strB, CompareOptions.None);
		case StringComparison.InvariantCultureIgnoreCase:
			return CultureInfo.InvariantCulture.CompareInfo.Compare(strA, strB, CompareOptions.IgnoreCase);
		case StringComparison.Ordinal:
			if (strA.m_firstChar - strB.m_firstChar != 0)
			{
				return strA.m_firstChar - strB.m_firstChar;
			}
			return CompareOrdinalHelper(strA, strB);
		case StringComparison.OrdinalIgnoreCase:
			if (strA.IsAscii() && strB.IsAscii())
			{
				return CompareOrdinalIgnoreCaseHelper(strA, strB);
			}
			return TextInfo.CompareOrdinalIgnoreCase(strA, strB);
		default:
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_StringComparison"));
		}
	}

	[__DynamicallyInvokable]
	public static int Compare(string strA, string strB, CultureInfo culture, CompareOptions options)
	{
		if (culture == null)
		{
			throw new ArgumentNullException("culture");
		}
		return culture.CompareInfo.Compare(strA, strB, options);
	}

	public static int Compare(string strA, string strB, bool ignoreCase, CultureInfo culture)
	{
		if (culture == null)
		{
			throw new ArgumentNullException("culture");
		}
		if (ignoreCase)
		{
			return culture.CompareInfo.Compare(strA, strB, CompareOptions.IgnoreCase);
		}
		return culture.CompareInfo.Compare(strA, strB, CompareOptions.None);
	}

	[__DynamicallyInvokable]
	public static int Compare(string strA, int indexA, string strB, int indexB, int length)
	{
		int num = length;
		int num2 = length;
		if ((object)strA != null && strA.Length - indexA < num)
		{
			num = strA.Length - indexA;
		}
		if ((object)strB != null && strB.Length - indexB < num2)
		{
			num2 = strB.Length - indexB;
		}
		return CultureInfo.CurrentCulture.CompareInfo.Compare(strA, indexA, num, strB, indexB, num2, CompareOptions.None);
	}

	public static int Compare(string strA, int indexA, string strB, int indexB, int length, bool ignoreCase)
	{
		int num = length;
		int num2 = length;
		if ((object)strA != null && strA.Length - indexA < num)
		{
			num = strA.Length - indexA;
		}
		if ((object)strB != null && strB.Length - indexB < num2)
		{
			num2 = strB.Length - indexB;
		}
		if (ignoreCase)
		{
			return CultureInfo.CurrentCulture.CompareInfo.Compare(strA, indexA, num, strB, indexB, num2, CompareOptions.IgnoreCase);
		}
		return CultureInfo.CurrentCulture.CompareInfo.Compare(strA, indexA, num, strB, indexB, num2, CompareOptions.None);
	}

	public static int Compare(string strA, int indexA, string strB, int indexB, int length, bool ignoreCase, CultureInfo culture)
	{
		if (culture == null)
		{
			throw new ArgumentNullException("culture");
		}
		int num = length;
		int num2 = length;
		if ((object)strA != null && strA.Length - indexA < num)
		{
			num = strA.Length - indexA;
		}
		if ((object)strB != null && strB.Length - indexB < num2)
		{
			num2 = strB.Length - indexB;
		}
		if (ignoreCase)
		{
			return culture.CompareInfo.Compare(strA, indexA, num, strB, indexB, num2, CompareOptions.IgnoreCase);
		}
		return culture.CompareInfo.Compare(strA, indexA, num, strB, indexB, num2, CompareOptions.None);
	}

	public static int Compare(string strA, int indexA, string strB, int indexB, int length, CultureInfo culture, CompareOptions options)
	{
		if (culture == null)
		{
			throw new ArgumentNullException("culture");
		}
		int num = length;
		int num2 = length;
		if ((object)strA != null && strA.Length - indexA < num)
		{
			num = strA.Length - indexA;
		}
		if ((object)strB != null && strB.Length - indexB < num2)
		{
			num2 = strB.Length - indexB;
		}
		return culture.CompareInfo.Compare(strA, indexA, num, strB, indexB, num2, options);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static int Compare(string strA, int indexA, string strB, int indexB, int length, StringComparison comparisonType)
	{
		if (comparisonType < StringComparison.CurrentCulture || comparisonType > StringComparison.OrdinalIgnoreCase)
		{
			throw new ArgumentException(Environment.GetResourceString("NotSupported_StringComparison"), "comparisonType");
		}
		if ((object)strA == null || (object)strB == null)
		{
			if ((object)strA == strB)
			{
				return 0;
			}
			if ((object)strA != null)
			{
				return 1;
			}
			return -1;
		}
		if (length < 0)
		{
			throw new ArgumentOutOfRangeException("length", Environment.GetResourceString("ArgumentOutOfRange_NegativeLength"));
		}
		if (indexA < 0)
		{
			throw new ArgumentOutOfRangeException("indexA", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		if (indexB < 0)
		{
			throw new ArgumentOutOfRangeException("indexB", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		if (strA.Length - indexA < 0)
		{
			throw new ArgumentOutOfRangeException("indexA", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		if (strB.Length - indexB < 0)
		{
			throw new ArgumentOutOfRangeException("indexB", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		if (length == 0 || (strA == strB && indexA == indexB))
		{
			return 0;
		}
		int num = length;
		int num2 = length;
		if ((object)strA != null && strA.Length - indexA < num)
		{
			num = strA.Length - indexA;
		}
		if ((object)strB != null && strB.Length - indexB < num2)
		{
			num2 = strB.Length - indexB;
		}
		return comparisonType switch
		{
			StringComparison.CurrentCulture => CultureInfo.CurrentCulture.CompareInfo.Compare(strA, indexA, num, strB, indexB, num2, CompareOptions.None), 
			StringComparison.CurrentCultureIgnoreCase => CultureInfo.CurrentCulture.CompareInfo.Compare(strA, indexA, num, strB, indexB, num2, CompareOptions.IgnoreCase), 
			StringComparison.InvariantCulture => CultureInfo.InvariantCulture.CompareInfo.Compare(strA, indexA, num, strB, indexB, num2, CompareOptions.None), 
			StringComparison.InvariantCultureIgnoreCase => CultureInfo.InvariantCulture.CompareInfo.Compare(strA, indexA, num, strB, indexB, num2, CompareOptions.IgnoreCase), 
			StringComparison.Ordinal => nativeCompareOrdinalEx(strA, indexA, strB, indexB, length), 
			StringComparison.OrdinalIgnoreCase => TextInfo.CompareOrdinalIgnoreCaseEx(strA, indexA, strB, indexB, num, num2), 
			_ => throw new ArgumentException(Environment.GetResourceString("NotSupported_StringComparison")), 
		};
	}

	public int CompareTo(object value)
	{
		if (value == null)
		{
			return 1;
		}
		if (!(value is string))
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeString"));
		}
		return Compare(this, (string)value, StringComparison.CurrentCulture);
	}

	[__DynamicallyInvokable]
	public int CompareTo(string strB)
	{
		if ((object)strB == null)
		{
			return 1;
		}
		return CultureInfo.CurrentCulture.CompareInfo.Compare(this, strB, CompareOptions.None);
	}

	[__DynamicallyInvokable]
	public static int CompareOrdinal(string strA, string strB)
	{
		if ((object)strA == strB)
		{
			return 0;
		}
		if ((object)strA == null)
		{
			return -1;
		}
		if ((object)strB == null)
		{
			return 1;
		}
		if (strA.m_firstChar - strB.m_firstChar != 0)
		{
			return strA.m_firstChar - strB.m_firstChar;
		}
		return CompareOrdinalHelper(strA, strB);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static int CompareOrdinal(string strA, int indexA, string strB, int indexB, int length)
	{
		if ((object)strA == null || (object)strB == null)
		{
			if ((object)strA == strB)
			{
				return 0;
			}
			if ((object)strA != null)
			{
				return 1;
			}
			return -1;
		}
		return nativeCompareOrdinalEx(strA, indexA, strB, indexB, length);
	}

	[__DynamicallyInvokable]
	public bool Contains(string value)
	{
		return IndexOf(value, StringComparison.Ordinal) >= 0;
	}

	[__DynamicallyInvokable]
	public bool EndsWith(string value)
	{
		return EndsWith(value, StringComparison.CurrentCulture);
	}

	[SecuritySafeCritical]
	[ComVisible(false)]
	[__DynamicallyInvokable]
	public bool EndsWith(string value, StringComparison comparisonType)
	{
		if ((object)value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (comparisonType < StringComparison.CurrentCulture || comparisonType > StringComparison.OrdinalIgnoreCase)
		{
			throw new ArgumentException(Environment.GetResourceString("NotSupported_StringComparison"), "comparisonType");
		}
		if ((object)this == value)
		{
			return true;
		}
		if (value.Length == 0)
		{
			return true;
		}
		switch (comparisonType)
		{
		case StringComparison.CurrentCulture:
			return CultureInfo.CurrentCulture.CompareInfo.IsSuffix(this, value, CompareOptions.None);
		case StringComparison.CurrentCultureIgnoreCase:
			return CultureInfo.CurrentCulture.CompareInfo.IsSuffix(this, value, CompareOptions.IgnoreCase);
		case StringComparison.InvariantCulture:
			return CultureInfo.InvariantCulture.CompareInfo.IsSuffix(this, value, CompareOptions.None);
		case StringComparison.InvariantCultureIgnoreCase:
			return CultureInfo.InvariantCulture.CompareInfo.IsSuffix(this, value, CompareOptions.IgnoreCase);
		case StringComparison.Ordinal:
			if (Length >= value.Length)
			{
				return nativeCompareOrdinalEx(this, Length - value.Length, value, 0, value.Length) == 0;
			}
			return false;
		case StringComparison.OrdinalIgnoreCase:
			if (Length >= value.Length)
			{
				return TextInfo.CompareOrdinalIgnoreCaseEx(this, Length - value.Length, value, 0, value.Length, value.Length) == 0;
			}
			return false;
		default:
			throw new ArgumentException(Environment.GetResourceString("NotSupported_StringComparison"), "comparisonType");
		}
	}

	public bool EndsWith(string value, bool ignoreCase, CultureInfo culture)
	{
		if ((object)value == null)
		{
			throw new ArgumentNullException("value");
		}
		if ((object)this == value)
		{
			return true;
		}
		CultureInfo cultureInfo = ((culture != null) ? culture : CultureInfo.CurrentCulture);
		return cultureInfo.CompareInfo.IsSuffix(this, value, ignoreCase ? CompareOptions.IgnoreCase : CompareOptions.None);
	}

	internal bool EndsWith(char value)
	{
		int length = Length;
		if (length != 0 && this[length - 1] == value)
		{
			return true;
		}
		return false;
	}

	[__DynamicallyInvokable]
	public int IndexOf(char value)
	{
		return IndexOf(value, 0, Length);
	}

	[__DynamicallyInvokable]
	public int IndexOf(char value, int startIndex)
	{
		return IndexOf(value, startIndex, Length - startIndex);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public extern int IndexOf(char value, int startIndex, int count);

	[__DynamicallyInvokable]
	public int IndexOfAny(char[] anyOf)
	{
		return IndexOfAny(anyOf, 0, Length);
	}

	[__DynamicallyInvokable]
	public int IndexOfAny(char[] anyOf, int startIndex)
	{
		return IndexOfAny(anyOf, startIndex, Length - startIndex);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public extern int IndexOfAny(char[] anyOf, int startIndex, int count);

	[__DynamicallyInvokable]
	public int IndexOf(string value)
	{
		return IndexOf(value, StringComparison.CurrentCulture);
	}

	[__DynamicallyInvokable]
	public int IndexOf(string value, int startIndex)
	{
		return IndexOf(value, startIndex, StringComparison.CurrentCulture);
	}

	[__DynamicallyInvokable]
	public int IndexOf(string value, int startIndex, int count)
	{
		if (startIndex < 0 || startIndex > Length)
		{
			throw new ArgumentOutOfRangeException("startIndex", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		if (count < 0 || count > Length - startIndex)
		{
			throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("ArgumentOutOfRange_Count"));
		}
		return IndexOf(value, startIndex, count, StringComparison.CurrentCulture);
	}

	[__DynamicallyInvokable]
	public int IndexOf(string value, StringComparison comparisonType)
	{
		return IndexOf(value, 0, Length, comparisonType);
	}

	[__DynamicallyInvokable]
	public int IndexOf(string value, int startIndex, StringComparison comparisonType)
	{
		return IndexOf(value, startIndex, Length - startIndex, comparisonType);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public int IndexOf(string value, int startIndex, int count, StringComparison comparisonType)
	{
		if ((object)value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (startIndex < 0 || startIndex > Length)
		{
			throw new ArgumentOutOfRangeException("startIndex", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		if (count < 0 || startIndex > Length - count)
		{
			throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("ArgumentOutOfRange_Count"));
		}
		switch (comparisonType)
		{
		case StringComparison.CurrentCulture:
			return CultureInfo.CurrentCulture.CompareInfo.IndexOf(this, value, startIndex, count, CompareOptions.None);
		case StringComparison.CurrentCultureIgnoreCase:
			return CultureInfo.CurrentCulture.CompareInfo.IndexOf(this, value, startIndex, count, CompareOptions.IgnoreCase);
		case StringComparison.InvariantCulture:
			return CultureInfo.InvariantCulture.CompareInfo.IndexOf(this, value, startIndex, count, CompareOptions.None);
		case StringComparison.InvariantCultureIgnoreCase:
			return CultureInfo.InvariantCulture.CompareInfo.IndexOf(this, value, startIndex, count, CompareOptions.IgnoreCase);
		case StringComparison.Ordinal:
			return CultureInfo.InvariantCulture.CompareInfo.IndexOf(this, value, startIndex, count, CompareOptions.Ordinal);
		case StringComparison.OrdinalIgnoreCase:
			if (value.IsAscii() && IsAscii())
			{
				return CultureInfo.InvariantCulture.CompareInfo.IndexOf(this, value, startIndex, count, CompareOptions.IgnoreCase);
			}
			return TextInfo.IndexOfStringOrdinalIgnoreCase(this, value, startIndex, count);
		default:
			throw new ArgumentException(Environment.GetResourceString("NotSupported_StringComparison"), "comparisonType");
		}
	}

	[__DynamicallyInvokable]
	public int LastIndexOf(char value)
	{
		return LastIndexOf(value, Length - 1, Length);
	}

	[__DynamicallyInvokable]
	public int LastIndexOf(char value, int startIndex)
	{
		return LastIndexOf(value, startIndex, startIndex + 1);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public extern int LastIndexOf(char value, int startIndex, int count);

	[__DynamicallyInvokable]
	public int LastIndexOfAny(char[] anyOf)
	{
		return LastIndexOfAny(anyOf, Length - 1, Length);
	}

	[__DynamicallyInvokable]
	public int LastIndexOfAny(char[] anyOf, int startIndex)
	{
		return LastIndexOfAny(anyOf, startIndex, startIndex + 1);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public extern int LastIndexOfAny(char[] anyOf, int startIndex, int count);

	[__DynamicallyInvokable]
	public int LastIndexOf(string value)
	{
		return LastIndexOf(value, Length - 1, Length, StringComparison.CurrentCulture);
	}

	[__DynamicallyInvokable]
	public int LastIndexOf(string value, int startIndex)
	{
		return LastIndexOf(value, startIndex, startIndex + 1, StringComparison.CurrentCulture);
	}

	[__DynamicallyInvokable]
	public int LastIndexOf(string value, int startIndex, int count)
	{
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("ArgumentOutOfRange_Count"));
		}
		return LastIndexOf(value, startIndex, count, StringComparison.CurrentCulture);
	}

	[__DynamicallyInvokable]
	public int LastIndexOf(string value, StringComparison comparisonType)
	{
		return LastIndexOf(value, Length - 1, Length, comparisonType);
	}

	[__DynamicallyInvokable]
	public int LastIndexOf(string value, int startIndex, StringComparison comparisonType)
	{
		return LastIndexOf(value, startIndex, startIndex + 1, comparisonType);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public int LastIndexOf(string value, int startIndex, int count, StringComparison comparisonType)
	{
		if ((object)value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (Length == 0 && (startIndex == -1 || startIndex == 0))
		{
			if (value.Length != 0)
			{
				return -1;
			}
			return 0;
		}
		if (startIndex < 0 || startIndex > Length)
		{
			throw new ArgumentOutOfRangeException("startIndex", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		if (startIndex == Length)
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
		switch (comparisonType)
		{
		case StringComparison.CurrentCulture:
			return CultureInfo.CurrentCulture.CompareInfo.LastIndexOf(this, value, startIndex, count, CompareOptions.None);
		case StringComparison.CurrentCultureIgnoreCase:
			return CultureInfo.CurrentCulture.CompareInfo.LastIndexOf(this, value, startIndex, count, CompareOptions.IgnoreCase);
		case StringComparison.InvariantCulture:
			return CultureInfo.InvariantCulture.CompareInfo.LastIndexOf(this, value, startIndex, count, CompareOptions.None);
		case StringComparison.InvariantCultureIgnoreCase:
			return CultureInfo.InvariantCulture.CompareInfo.LastIndexOf(this, value, startIndex, count, CompareOptions.IgnoreCase);
		case StringComparison.Ordinal:
			return CultureInfo.InvariantCulture.CompareInfo.LastIndexOf(this, value, startIndex, count, CompareOptions.Ordinal);
		case StringComparison.OrdinalIgnoreCase:
			if (value.IsAscii() && IsAscii())
			{
				return CultureInfo.InvariantCulture.CompareInfo.LastIndexOf(this, value, startIndex, count, CompareOptions.IgnoreCase);
			}
			return TextInfo.LastIndexOfStringOrdinalIgnoreCase(this, value, startIndex, count);
		default:
			throw new ArgumentException(Environment.GetResourceString("NotSupported_StringComparison"), "comparisonType");
		}
	}

	[__DynamicallyInvokable]
	public string PadLeft(int totalWidth)
	{
		return PadHelper(totalWidth, ' ', isRightPadded: false);
	}

	[__DynamicallyInvokable]
	public string PadLeft(int totalWidth, char paddingChar)
	{
		return PadHelper(totalWidth, paddingChar, isRightPadded: false);
	}

	[__DynamicallyInvokable]
	public string PadRight(int totalWidth)
	{
		return PadHelper(totalWidth, ' ', isRightPadded: true);
	}

	[__DynamicallyInvokable]
	public string PadRight(int totalWidth, char paddingChar)
	{
		return PadHelper(totalWidth, paddingChar, isRightPadded: true);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	private extern string PadHelper(int totalWidth, char paddingChar, bool isRightPadded);

	[__DynamicallyInvokable]
	public bool StartsWith(string value)
	{
		if ((object)value == null)
		{
			throw new ArgumentNullException("value");
		}
		return StartsWith(value, StringComparison.CurrentCulture);
	}

	[SecuritySafeCritical]
	[ComVisible(false)]
	[__DynamicallyInvokable]
	public bool StartsWith(string value, StringComparison comparisonType)
	{
		if ((object)value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (comparisonType < StringComparison.CurrentCulture || comparisonType > StringComparison.OrdinalIgnoreCase)
		{
			throw new ArgumentException(Environment.GetResourceString("NotSupported_StringComparison"), "comparisonType");
		}
		if ((object)this == value)
		{
			return true;
		}
		if (value.Length == 0)
		{
			return true;
		}
		switch (comparisonType)
		{
		case StringComparison.CurrentCulture:
			return CultureInfo.CurrentCulture.CompareInfo.IsPrefix(this, value, CompareOptions.None);
		case StringComparison.CurrentCultureIgnoreCase:
			return CultureInfo.CurrentCulture.CompareInfo.IsPrefix(this, value, CompareOptions.IgnoreCase);
		case StringComparison.InvariantCulture:
			return CultureInfo.InvariantCulture.CompareInfo.IsPrefix(this, value, CompareOptions.None);
		case StringComparison.InvariantCultureIgnoreCase:
			return CultureInfo.InvariantCulture.CompareInfo.IsPrefix(this, value, CompareOptions.IgnoreCase);
		case StringComparison.Ordinal:
			if (Length < value.Length)
			{
				return false;
			}
			return nativeCompareOrdinalEx(this, 0, value, 0, value.Length) == 0;
		case StringComparison.OrdinalIgnoreCase:
			if (Length < value.Length)
			{
				return false;
			}
			return TextInfo.CompareOrdinalIgnoreCaseEx(this, 0, value, 0, value.Length, value.Length) == 0;
		default:
			throw new ArgumentException(Environment.GetResourceString("NotSupported_StringComparison"), "comparisonType");
		}
	}

	public bool StartsWith(string value, bool ignoreCase, CultureInfo culture)
	{
		if ((object)value == null)
		{
			throw new ArgumentNullException("value");
		}
		if ((object)this == value)
		{
			return true;
		}
		CultureInfo cultureInfo = ((culture != null) ? culture : CultureInfo.CurrentCulture);
		return cultureInfo.CompareInfo.IsPrefix(this, value, ignoreCase ? CompareOptions.IgnoreCase : CompareOptions.None);
	}

	[__DynamicallyInvokable]
	public string ToLower()
	{
		return ToLower(CultureInfo.CurrentCulture);
	}

	public string ToLower(CultureInfo culture)
	{
		if (culture == null)
		{
			throw new ArgumentNullException("culture");
		}
		return culture.TextInfo.ToLower(this);
	}

	[__DynamicallyInvokable]
	public string ToLowerInvariant()
	{
		return ToLower(CultureInfo.InvariantCulture);
	}

	[__DynamicallyInvokable]
	public string ToUpper()
	{
		return ToUpper(CultureInfo.CurrentCulture);
	}

	public string ToUpper(CultureInfo culture)
	{
		if (culture == null)
		{
			throw new ArgumentNullException("culture");
		}
		return culture.TextInfo.ToUpper(this);
	}

	[__DynamicallyInvokable]
	public string ToUpperInvariant()
	{
		return ToUpper(CultureInfo.InvariantCulture);
	}

	[__DynamicallyInvokable]
	public override string ToString()
	{
		return this;
	}

	public string ToString(IFormatProvider provider)
	{
		return this;
	}

	public object Clone()
	{
		return this;
	}

	private static bool IsBOMWhitespace(char c)
	{
		return false;
	}

	[__DynamicallyInvokable]
	public string Trim()
	{
		return TrimHelper(2);
	}

	[SecuritySafeCritical]
	private string TrimHelper(int trimType)
	{
		int num = Length - 1;
		int i = 0;
		if (trimType != 1)
		{
			for (i = 0; i < Length && (char.IsWhiteSpace(this[i]) || IsBOMWhitespace(this[i])); i++)
			{
			}
		}
		if (trimType != 0)
		{
			num = Length - 1;
			while (num >= i && (char.IsWhiteSpace(this[num]) || IsBOMWhitespace(this[i])))
			{
				num--;
			}
		}
		return CreateTrimmedString(i, num);
	}

	[SecuritySafeCritical]
	private string TrimHelper(char[] trimChars, int trimType)
	{
		int num = Length - 1;
		int i = 0;
		if (trimType != 1)
		{
			for (i = 0; i < Length; i++)
			{
				int num2 = 0;
				char c = this[i];
				for (num2 = 0; num2 < trimChars.Length && trimChars[num2] != c; num2++)
				{
				}
				if (num2 == trimChars.Length)
				{
					break;
				}
			}
		}
		if (trimType != 0)
		{
			for (num = Length - 1; num >= i; num--)
			{
				int num3 = 0;
				char c2 = this[num];
				for (num3 = 0; num3 < trimChars.Length && trimChars[num3] != c2; num3++)
				{
				}
				if (num3 == trimChars.Length)
				{
					break;
				}
			}
		}
		return CreateTrimmedString(i, num);
	}

	[SecurityCritical]
	private string CreateTrimmedString(int start, int end)
	{
		int num = end - start + 1;
		if (num == Length)
		{
			return this;
		}
		if (num == 0)
		{
			return Empty;
		}
		return InternalSubString(start, num);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe string Insert(int startIndex, string value)
	{
		if ((object)value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (startIndex < 0 || startIndex > Length)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		int length = Length;
		int length2 = value.Length;
		int num = length + length2;
		if (num == 0)
		{
			return Empty;
		}
		string text = FastAllocateString(num);
		fixed (char* firstChar = &m_firstChar)
		{
			fixed (char* firstChar2 = &value.m_firstChar)
			{
				fixed (char* firstChar3 = &text.m_firstChar)
				{
					wstrcpy(firstChar3, firstChar, startIndex);
					wstrcpy(firstChar3 + startIndex, firstChar2, length2);
					wstrcpy(firstChar3 + startIndex + length2, firstChar + startIndex, length - startIndex);
				}
			}
		}
		return text;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	private extern string ReplaceInternal(char oldChar, char newChar);

	[__DynamicallyInvokable]
	public string Replace(char oldChar, char newChar)
	{
		return ReplaceInternal(oldChar, newChar);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	private extern string ReplaceInternal(string oldValue, string newValue);

	[__DynamicallyInvokable]
	public string Replace(string oldValue, string newValue)
	{
		if ((object)oldValue == null)
		{
			throw new ArgumentNullException("oldValue");
		}
		return ReplaceInternal(oldValue, newValue);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe string Remove(int startIndex, int count)
	{
		if (startIndex < 0)
		{
			throw new ArgumentOutOfRangeException("startIndex", Environment.GetResourceString("ArgumentOutOfRange_StartIndex"));
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("ArgumentOutOfRange_NegativeCount"));
		}
		if (count > Length - startIndex)
		{
			throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("ArgumentOutOfRange_IndexCount"));
		}
		int num = Length - count;
		if (num == 0)
		{
			return Empty;
		}
		string text = FastAllocateString(num);
		fixed (char* firstChar = &m_firstChar)
		{
			fixed (char* firstChar2 = &text.m_firstChar)
			{
				wstrcpy(firstChar2, firstChar, startIndex);
				wstrcpy(firstChar2 + startIndex, firstChar + startIndex + count, num - startIndex);
			}
		}
		return text;
	}

	[__DynamicallyInvokable]
	public string Remove(int startIndex)
	{
		if (startIndex < 0)
		{
			throw new ArgumentOutOfRangeException("startIndex", Environment.GetResourceString("ArgumentOutOfRange_StartIndex"));
		}
		if (startIndex >= Length)
		{
			throw new ArgumentOutOfRangeException("startIndex", Environment.GetResourceString("ArgumentOutOfRange_StartIndexLessThanLength"));
		}
		return Substring(0, startIndex);
	}

	[__DynamicallyInvokable]
	public static string Format(string format, object arg0)
	{
		return FormatHelper(null, format, new ParamsArray(arg0));
	}

	[__DynamicallyInvokable]
	public static string Format(string format, object arg0, object arg1)
	{
		return FormatHelper(null, format, new ParamsArray(arg0, arg1));
	}

	[__DynamicallyInvokable]
	public static string Format(string format, object arg0, object arg1, object arg2)
	{
		return FormatHelper(null, format, new ParamsArray(arg0, arg1, arg2));
	}

	[__DynamicallyInvokable]
	public static string Format(string format, params object[] args)
	{
		if (args == null)
		{
			throw new ArgumentNullException(((object)format == null) ? "format" : "args");
		}
		return FormatHelper(null, format, new ParamsArray(args));
	}

	[__DynamicallyInvokable]
	public static string Format(IFormatProvider provider, string format, object arg0)
	{
		return FormatHelper(provider, format, new ParamsArray(arg0));
	}

	[__DynamicallyInvokable]
	public static string Format(IFormatProvider provider, string format, object arg0, object arg1)
	{
		return FormatHelper(provider, format, new ParamsArray(arg0, arg1));
	}

	[__DynamicallyInvokable]
	public static string Format(IFormatProvider provider, string format, object arg0, object arg1, object arg2)
	{
		return FormatHelper(provider, format, new ParamsArray(arg0, arg1, arg2));
	}

	[__DynamicallyInvokable]
	public static string Format(IFormatProvider provider, string format, params object[] args)
	{
		if (args == null)
		{
			throw new ArgumentNullException(((object)format == null) ? "format" : "args");
		}
		return FormatHelper(provider, format, new ParamsArray(args));
	}

	private static string FormatHelper(IFormatProvider provider, string format, ParamsArray args)
	{
		if ((object)format == null)
		{
			throw new ArgumentNullException("format");
		}
		return StringBuilderCache.GetStringAndRelease(StringBuilderCache.Acquire(format.Length + args.Length * 8).AppendFormatHelper(provider, format, args));
	}

	[SecuritySafeCritical]
	public unsafe static string Copy(string str)
	{
		if ((object)str == null)
		{
			throw new ArgumentNullException("str");
		}
		int length = str.Length;
		string text = FastAllocateString(length);
		fixed (char* firstChar = &text.m_firstChar)
		{
			fixed (char* firstChar2 = &str.m_firstChar)
			{
				wstrcpy(firstChar, firstChar2, length);
			}
		}
		return text;
	}

	[__DynamicallyInvokable]
	public static string Concat(object arg0)
	{
		if (arg0 == null)
		{
			return Empty;
		}
		return arg0.ToString();
	}

	[__DynamicallyInvokable]
	public static string Concat(object arg0, object arg1)
	{
		if (arg0 == null)
		{
			arg0 = Empty;
		}
		if (arg1 == null)
		{
			arg1 = Empty;
		}
		return arg0.ToString() + arg1.ToString();
	}

	[__DynamicallyInvokable]
	public static string Concat(object arg0, object arg1, object arg2)
	{
		if (arg0 == null)
		{
			arg0 = Empty;
		}
		if (arg1 == null)
		{
			arg1 = Empty;
		}
		if (arg2 == null)
		{
			arg2 = Empty;
		}
		return arg0.ToString() + arg1.ToString() + arg2.ToString();
	}

	[CLSCompliant(false)]
	public static string Concat(object arg0, object arg1, object arg2, object arg3, __arglist)
	{
		ArgIterator argIterator = new ArgIterator(__arglist);
		int num = argIterator.GetRemainingCount() + 4;
		object[] array = new object[num];
		array[0] = arg0;
		array[1] = arg1;
		array[2] = arg2;
		array[3] = arg3;
		for (int i = 4; i < num; i++)
		{
			array[i] = TypedReference.ToObject(argIterator.GetNextArg());
		}
		return Concat(array);
	}

	[__DynamicallyInvokable]
	public static string Concat(params object[] args)
	{
		if (args == null)
		{
			throw new ArgumentNullException("args");
		}
		string[] array = new string[args.Length];
		int num = 0;
		for (int i = 0; i < args.Length; i++)
		{
			object obj = args[i];
			array[i] = ((obj == null) ? Empty : obj.ToString());
			if ((object)array[i] == null)
			{
				array[i] = Empty;
			}
			num += array[i].Length;
			if (num < 0)
			{
				throw new OutOfMemoryException();
			}
		}
		return ConcatArray(array, num);
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	public static string Concat<T>(IEnumerable<T> values)
	{
		if (values == null)
		{
			throw new ArgumentNullException("values");
		}
		StringBuilder stringBuilder = StringBuilderCache.Acquire();
		using (IEnumerator<T> enumerator = values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current != null)
				{
					string text = enumerator.Current.ToString();
					if ((object)text != null)
					{
						stringBuilder.Append(text);
					}
				}
			}
		}
		return StringBuilderCache.GetStringAndRelease(stringBuilder);
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	public static string Concat(IEnumerable<string> values)
	{
		if (values == null)
		{
			throw new ArgumentNullException("values");
		}
		StringBuilder stringBuilder = StringBuilderCache.Acquire();
		using (IEnumerator<string> enumerator = values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if ((object)enumerator.Current != null)
				{
					stringBuilder.Append(enumerator.Current);
				}
			}
		}
		return StringBuilderCache.GetStringAndRelease(stringBuilder);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static string Concat(string str0, string str1)
	{
		if (IsNullOrEmpty(str0))
		{
			if (IsNullOrEmpty(str1))
			{
				return Empty;
			}
			return str1;
		}
		if (IsNullOrEmpty(str1))
		{
			return str0;
		}
		int length = str0.Length;
		string text = FastAllocateString(length + str1.Length);
		FillStringChecked(text, 0, str0);
		FillStringChecked(text, length, str1);
		return text;
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static string Concat(string str0, string str1, string str2)
	{
		if ((object)str0 == null && (object)str1 == null && (object)str2 == null)
		{
			return Empty;
		}
		if ((object)str0 == null)
		{
			str0 = Empty;
		}
		if ((object)str1 == null)
		{
			str1 = Empty;
		}
		if ((object)str2 == null)
		{
			str2 = Empty;
		}
		int length = str0.Length + str1.Length + str2.Length;
		string text = FastAllocateString(length);
		FillStringChecked(text, 0, str0);
		FillStringChecked(text, str0.Length, str1);
		FillStringChecked(text, str0.Length + str1.Length, str2);
		return text;
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static string Concat(string str0, string str1, string str2, string str3)
	{
		if ((object)str0 == null && (object)str1 == null && (object)str2 == null && (object)str3 == null)
		{
			return Empty;
		}
		if ((object)str0 == null)
		{
			str0 = Empty;
		}
		if ((object)str1 == null)
		{
			str1 = Empty;
		}
		if ((object)str2 == null)
		{
			str2 = Empty;
		}
		if ((object)str3 == null)
		{
			str3 = Empty;
		}
		int length = str0.Length + str1.Length + str2.Length + str3.Length;
		string text = FastAllocateString(length);
		FillStringChecked(text, 0, str0);
		FillStringChecked(text, str0.Length, str1);
		FillStringChecked(text, str0.Length + str1.Length, str2);
		FillStringChecked(text, str0.Length + str1.Length + str2.Length, str3);
		return text;
	}

	[SecuritySafeCritical]
	private static string ConcatArray(string[] values, int totalLength)
	{
		string text = FastAllocateString(totalLength);
		int num = 0;
		for (int i = 0; i < values.Length; i++)
		{
			FillStringChecked(text, num, values[i]);
			num += values[i].Length;
		}
		return text;
	}

	[__DynamicallyInvokable]
	public static string Concat(params string[] values)
	{
		if (values == null)
		{
			throw new ArgumentNullException("values");
		}
		int num = 0;
		string[] array = new string[values.Length];
		for (int i = 0; i < values.Length; i++)
		{
			string text = values[i];
			array[i] = (((object)text == null) ? Empty : text);
			num += array[i].Length;
			if (num < 0)
			{
				throw new OutOfMemoryException();
			}
		}
		return ConcatArray(array, num);
	}

	[SecuritySafeCritical]
	public static string Intern(string str)
	{
		if ((object)str == null)
		{
			throw new ArgumentNullException("str");
		}
		return Thread.GetDomain().GetOrInternString(str);
	}

	[SecuritySafeCritical]
	public static string IsInterned(string str)
	{
		if ((object)str == null)
		{
			throw new ArgumentNullException("str");
		}
		return Thread.GetDomain().IsStringInterned(str);
	}

	public TypeCode GetTypeCode()
	{
		return TypeCode.String;
	}

	[__DynamicallyInvokable]
	bool IConvertible.ToBoolean(IFormatProvider provider)
	{
		return Convert.ToBoolean(this, provider);
	}

	[__DynamicallyInvokable]
	char IConvertible.ToChar(IFormatProvider provider)
	{
		return Convert.ToChar(this, provider);
	}

	[__DynamicallyInvokable]
	sbyte IConvertible.ToSByte(IFormatProvider provider)
	{
		return Convert.ToSByte(this, provider);
	}

	[__DynamicallyInvokable]
	byte IConvertible.ToByte(IFormatProvider provider)
	{
		return Convert.ToByte(this, provider);
	}

	[__DynamicallyInvokable]
	short IConvertible.ToInt16(IFormatProvider provider)
	{
		return Convert.ToInt16(this, provider);
	}

	[__DynamicallyInvokable]
	ushort IConvertible.ToUInt16(IFormatProvider provider)
	{
		return Convert.ToUInt16(this, provider);
	}

	[__DynamicallyInvokable]
	int IConvertible.ToInt32(IFormatProvider provider)
	{
		return Convert.ToInt32(this, provider);
	}

	[__DynamicallyInvokable]
	uint IConvertible.ToUInt32(IFormatProvider provider)
	{
		return Convert.ToUInt32(this, provider);
	}

	[__DynamicallyInvokable]
	long IConvertible.ToInt64(IFormatProvider provider)
	{
		return Convert.ToInt64(this, provider);
	}

	[__DynamicallyInvokable]
	ulong IConvertible.ToUInt64(IFormatProvider provider)
	{
		return Convert.ToUInt64(this, provider);
	}

	[__DynamicallyInvokable]
	float IConvertible.ToSingle(IFormatProvider provider)
	{
		return Convert.ToSingle(this, provider);
	}

	[__DynamicallyInvokable]
	double IConvertible.ToDouble(IFormatProvider provider)
	{
		return Convert.ToDouble(this, provider);
	}

	[__DynamicallyInvokable]
	decimal IConvertible.ToDecimal(IFormatProvider provider)
	{
		return Convert.ToDecimal(this, provider);
	}

	[__DynamicallyInvokable]
	DateTime IConvertible.ToDateTime(IFormatProvider provider)
	{
		return Convert.ToDateTime(this, provider);
	}

	[__DynamicallyInvokable]
	object IConvertible.ToType(Type type, IFormatProvider provider)
	{
		return Convert.DefaultToType(this, type, provider);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal extern bool IsFastSort();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal extern bool IsAscii();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal extern void SetTrailByte(byte data);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal extern bool TryGetTrailByte(out byte data);

	public CharEnumerator GetEnumerator()
	{
		return new CharEnumerator(this);
	}

	[__DynamicallyInvokable]
	IEnumerator<char> IEnumerable<char>.GetEnumerator()
	{
		return new CharEnumerator(this);
	}

	[__DynamicallyInvokable]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return new CharEnumerator(this);
	}

	[SecurityCritical]
	internal unsafe static void InternalCopy(string src, IntPtr dest, int len)
	{
		if (len != 0)
		{
			fixed (char* firstChar = &src.m_firstChar)
			{
				byte* src2 = (byte*)firstChar;
				byte* dest2 = (byte*)(void*)dest;
				Buffer.Memcpy(dest2, src2, len);
			}
		}
	}
}

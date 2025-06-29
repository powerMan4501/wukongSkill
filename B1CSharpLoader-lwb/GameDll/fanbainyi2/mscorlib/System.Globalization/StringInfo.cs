using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Globalization;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class StringInfo
{
	[OptionalField(VersionAdded = 2)]
	private string m_str;

	[NonSerialized]
	private int[] m_indexes;

	private int[] Indexes
	{
		get
		{
			if (m_indexes == null && 0 < String.Length)
			{
				m_indexes = ParseCombiningCharacters(String);
			}
			return m_indexes;
		}
	}

	[__DynamicallyInvokable]
	public string String
	{
		[__DynamicallyInvokable]
		get
		{
			return m_str;
		}
		[__DynamicallyInvokable]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("String", Environment.GetResourceString("ArgumentNull_String"));
			}
			m_str = value;
			m_indexes = null;
		}
	}

	[__DynamicallyInvokable]
	public int LengthInTextElements
	{
		[__DynamicallyInvokable]
		get
		{
			if (Indexes == null)
			{
				return 0;
			}
			return Indexes.Length;
		}
	}

	[__DynamicallyInvokable]
	public StringInfo()
		: this("")
	{
	}

	[__DynamicallyInvokable]
	public StringInfo(string value)
	{
		String = value;
	}

	[OnDeserializing]
	private void OnDeserializing(StreamingContext ctx)
	{
		m_str = string.Empty;
	}

	[OnDeserialized]
	private void OnDeserialized(StreamingContext ctx)
	{
		if (m_str.Length == 0)
		{
			m_indexes = null;
		}
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	public override bool Equals(object value)
	{
		if (value is StringInfo stringInfo)
		{
			return m_str.Equals(stringInfo.m_str);
		}
		return false;
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	public override int GetHashCode()
	{
		return m_str.GetHashCode();
	}

	public string SubstringByTextElements(int startingTextElement)
	{
		if (Indexes == null)
		{
			if (startingTextElement < 0)
			{
				throw new ArgumentOutOfRangeException("startingTextElement", Environment.GetResourceString("ArgumentOutOfRange_NeedPosNum"));
			}
			throw new ArgumentOutOfRangeException("startingTextElement", Environment.GetResourceString("Arg_ArgumentOutOfRangeException"));
		}
		return SubstringByTextElements(startingTextElement, Indexes.Length - startingTextElement);
	}

	public string SubstringByTextElements(int startingTextElement, int lengthInTextElements)
	{
		if (startingTextElement < 0)
		{
			throw new ArgumentOutOfRangeException("startingTextElement", Environment.GetResourceString("ArgumentOutOfRange_NeedPosNum"));
		}
		if (String.Length == 0 || startingTextElement >= Indexes.Length)
		{
			throw new ArgumentOutOfRangeException("startingTextElement", Environment.GetResourceString("Arg_ArgumentOutOfRangeException"));
		}
		if (lengthInTextElements < 0)
		{
			throw new ArgumentOutOfRangeException("lengthInTextElements", Environment.GetResourceString("ArgumentOutOfRange_NeedPosNum"));
		}
		if (startingTextElement > Indexes.Length - lengthInTextElements)
		{
			throw new ArgumentOutOfRangeException("lengthInTextElements", Environment.GetResourceString("Arg_ArgumentOutOfRangeException"));
		}
		int num = Indexes[startingTextElement];
		if (startingTextElement + lengthInTextElements == Indexes.Length)
		{
			return String.Substring(num);
		}
		return String.Substring(num, Indexes[lengthInTextElements + startingTextElement] - num);
	}

	[__DynamicallyInvokable]
	public static string GetNextTextElement(string str)
	{
		return GetNextTextElement(str, 0);
	}

	internal static int GetCurrentTextElementLen(string str, int index, int len, ref UnicodeCategory ucCurrent, ref int currentCharCount)
	{
		if (index + currentCharCount == len)
		{
			return currentCharCount;
		}
		UnicodeCategory unicodeCategory = CharUnicodeInfo.InternalGetUnicodeCategory(str, index + currentCharCount, out var charLength);
		if (CharUnicodeInfo.IsCombiningCategory(unicodeCategory) && !CharUnicodeInfo.IsCombiningCategory(ucCurrent) && ucCurrent != UnicodeCategory.Format && ucCurrent != UnicodeCategory.Control && ucCurrent != UnicodeCategory.OtherNotAssigned && ucCurrent != UnicodeCategory.Surrogate)
		{
			int num = index;
			for (index += currentCharCount + charLength; index < len; index += charLength)
			{
				unicodeCategory = CharUnicodeInfo.InternalGetUnicodeCategory(str, index, out charLength);
				if (!CharUnicodeInfo.IsCombiningCategory(unicodeCategory))
				{
					ucCurrent = unicodeCategory;
					currentCharCount = charLength;
					break;
				}
			}
			return index - num;
		}
		int result = currentCharCount;
		ucCurrent = unicodeCategory;
		currentCharCount = charLength;
		return result;
	}

	[__DynamicallyInvokable]
	public static string GetNextTextElement(string str, int index)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		int length = str.Length;
		if (index < 0 || index >= length)
		{
			if (index == length)
			{
				return string.Empty;
			}
			throw new ArgumentOutOfRangeException("index", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		int charLength;
		UnicodeCategory ucCurrent = CharUnicodeInfo.InternalGetUnicodeCategory(str, index, out charLength);
		return str.Substring(index, GetCurrentTextElementLen(str, index, length, ref ucCurrent, ref charLength));
	}

	[__DynamicallyInvokable]
	public static TextElementEnumerator GetTextElementEnumerator(string str)
	{
		return GetTextElementEnumerator(str, 0);
	}

	[__DynamicallyInvokable]
	public static TextElementEnumerator GetTextElementEnumerator(string str, int index)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		int length = str.Length;
		if (index < 0 || index > length)
		{
			throw new ArgumentOutOfRangeException("index", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		return new TextElementEnumerator(str, index, length);
	}

	[__DynamicallyInvokable]
	public static int[] ParseCombiningCharacters(string str)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		int length = str.Length;
		int[] array = new int[length];
		if (length == 0)
		{
			return array;
		}
		int num = 0;
		int i = 0;
		int charLength;
		for (UnicodeCategory ucCurrent = CharUnicodeInfo.InternalGetUnicodeCategory(str, 0, out charLength); i < length; i += GetCurrentTextElementLen(str, i, length, ref ucCurrent, ref charLength))
		{
			array[num++] = i;
		}
		if (num < length)
		{
			int[] array2 = new int[num];
			Array.Copy(array, array2, num);
			return array2;
		}
		return array;
	}
}

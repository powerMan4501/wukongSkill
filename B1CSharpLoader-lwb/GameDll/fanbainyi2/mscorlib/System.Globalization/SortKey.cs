using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Globalization;

[Serializable]
[ComVisible(true)]
public class SortKey
{
	[OptionalField(VersionAdded = 3)]
	internal string localeName;

	[OptionalField(VersionAdded = 1)]
	internal int win32LCID;

	internal CompareOptions options;

	internal string m_String;

	internal byte[] m_KeyData;

	public virtual string OriginalString => m_String;

	public virtual byte[] KeyData => (byte[])m_KeyData.Clone();

	internal SortKey(string localeName, string str, CompareOptions options, byte[] keyData)
	{
		m_KeyData = keyData;
		this.localeName = localeName;
		this.options = options;
		m_String = str;
	}

	[OnSerializing]
	private void OnSerializing(StreamingContext context)
	{
		if (win32LCID == 0)
		{
			win32LCID = CultureInfo.GetCultureInfo(localeName).LCID;
		}
	}

	[OnDeserialized]
	private void OnDeserialized(StreamingContext context)
	{
		if (string.IsNullOrEmpty(localeName) && win32LCID != 0)
		{
			localeName = CultureInfo.GetCultureInfo(win32LCID).Name;
		}
	}

	public static int Compare(SortKey sortkey1, SortKey sortkey2)
	{
		if (sortkey1 == null || sortkey2 == null)
		{
			throw new ArgumentNullException((sortkey1 == null) ? "sortkey1" : "sortkey2");
		}
		byte[] keyData = sortkey1.m_KeyData;
		byte[] keyData2 = sortkey2.m_KeyData;
		if (keyData.Length == 0)
		{
			if (keyData2.Length == 0)
			{
				return 0;
			}
			return -1;
		}
		if (keyData2.Length == 0)
		{
			return 1;
		}
		int num = ((keyData.Length < keyData2.Length) ? keyData.Length : keyData2.Length);
		for (int i = 0; i < num; i++)
		{
			if (keyData[i] > keyData2[i])
			{
				return 1;
			}
			if (keyData[i] < keyData2[i])
			{
				return -1;
			}
		}
		return 0;
	}

	public override bool Equals(object value)
	{
		if (value is SortKey sortkey)
		{
			return Compare(this, sortkey) == 0;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return CompareInfo.GetCompareInfo(localeName).GetHashCodeOfString(m_String, options);
	}

	public override string ToString()
	{
		return "SortKey - " + localeName + ", " + options.ToString() + ", " + m_String;
	}
}

using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace System.Collections;

[Serializable]
[ComVisible(true)]
public sealed class Comparer : IComparer, ISerializable
{
	private CompareInfo m_compareInfo;

	public static readonly Comparer Default = new Comparer(CultureInfo.CurrentCulture);

	public static readonly Comparer DefaultInvariant = new Comparer(CultureInfo.InvariantCulture);

	private const string CompareInfoName = "CompareInfo";

	private Comparer()
	{
		m_compareInfo = null;
	}

	public Comparer(CultureInfo culture)
	{
		if (culture == null)
		{
			throw new ArgumentNullException("culture");
		}
		m_compareInfo = culture.CompareInfo;
	}

	private Comparer(SerializationInfo info, StreamingContext context)
	{
		m_compareInfo = null;
		SerializationInfoEnumerator enumerator = info.GetEnumerator();
		while (enumerator.MoveNext())
		{
			string name = enumerator.Name;
			if (name == "CompareInfo")
			{
				m_compareInfo = (CompareInfo)info.GetValue("CompareInfo", typeof(CompareInfo));
			}
		}
	}

	public int Compare(object a, object b)
	{
		if (a == b)
		{
			return 0;
		}
		if (a == null)
		{
			return -1;
		}
		if (b == null)
		{
			return 1;
		}
		if (m_compareInfo != null)
		{
			string text = a as string;
			string text2 = b as string;
			if (text != null && text2 != null)
			{
				return m_compareInfo.Compare(text, text2);
			}
		}
		if (a is IComparable comparable)
		{
			return comparable.CompareTo(b);
		}
		if (b is IComparable comparable2)
		{
			return -comparable2.CompareTo(a);
		}
		throw new ArgumentException(Environment.GetResourceString("Argument_ImplementIComparable"));
	}

	[SecurityCritical]
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		if (m_compareInfo != null)
		{
			info.AddValue("CompareInfo", m_compareInfo);
		}
	}
}

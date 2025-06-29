using System.Runtime.InteropServices;

namespace System.Reflection.Emit;

[Serializable]
[ComVisible(true)]
public struct Label
{
	internal int m_label;

	internal Label(int label)
	{
		m_label = label;
	}

	internal int GetLabelValue()
	{
		return m_label;
	}

	public override int GetHashCode()
	{
		return m_label;
	}

	public override bool Equals(object obj)
	{
		if (obj is Label)
		{
			return Equals((Label)obj);
		}
		return false;
	}

	public bool Equals(Label obj)
	{
		return obj.m_label == m_label;
	}

	public static bool operator ==(Label a, Label b)
	{
		return a.Equals(b);
	}

	public static bool operator !=(Label a, Label b)
	{
		return !(a == b);
	}
}

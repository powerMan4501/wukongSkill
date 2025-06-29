using System.Runtime.InteropServices;

namespace System.Reflection.Emit;

[Serializable]
[ComVisible(true)]
public struct PropertyToken
{
	public static readonly PropertyToken Empty;

	internal int m_property;

	public int Token => m_property;

	internal PropertyToken(int str)
	{
		m_property = str;
	}

	public override int GetHashCode()
	{
		return m_property;
	}

	public override bool Equals(object obj)
	{
		if (obj is PropertyToken)
		{
			return Equals((PropertyToken)obj);
		}
		return false;
	}

	public bool Equals(PropertyToken obj)
	{
		return obj.m_property == m_property;
	}

	public static bool operator ==(PropertyToken a, PropertyToken b)
	{
		return a.Equals(b);
	}

	public static bool operator !=(PropertyToken a, PropertyToken b)
	{
		return !(a == b);
	}
}

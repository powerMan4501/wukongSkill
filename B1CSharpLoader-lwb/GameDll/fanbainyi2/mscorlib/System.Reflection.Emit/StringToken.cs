using System.Runtime.InteropServices;

namespace System.Reflection.Emit;

[Serializable]
[ComVisible(true)]
public struct StringToken
{
	internal int m_string;

	public int Token => m_string;

	internal StringToken(int str)
	{
		m_string = str;
	}

	public override int GetHashCode()
	{
		return m_string;
	}

	public override bool Equals(object obj)
	{
		if (obj is StringToken)
		{
			return Equals((StringToken)obj);
		}
		return false;
	}

	public bool Equals(StringToken obj)
	{
		return obj.m_string == m_string;
	}

	public static bool operator ==(StringToken a, StringToken b)
	{
		return a.Equals(b);
	}

	public static bool operator !=(StringToken a, StringToken b)
	{
		return !(a == b);
	}
}

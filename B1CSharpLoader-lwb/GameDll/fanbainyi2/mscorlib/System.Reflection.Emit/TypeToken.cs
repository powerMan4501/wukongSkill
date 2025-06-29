using System.Runtime.InteropServices;

namespace System.Reflection.Emit;

[Serializable]
[ComVisible(true)]
public struct TypeToken
{
	public static readonly TypeToken Empty;

	internal int m_class;

	public int Token => m_class;

	internal TypeToken(int str)
	{
		m_class = str;
	}

	public override int GetHashCode()
	{
		return m_class;
	}

	public override bool Equals(object obj)
	{
		if (obj is TypeToken)
		{
			return Equals((TypeToken)obj);
		}
		return false;
	}

	public bool Equals(TypeToken obj)
	{
		return obj.m_class == m_class;
	}

	public static bool operator ==(TypeToken a, TypeToken b)
	{
		return a.Equals(b);
	}

	public static bool operator !=(TypeToken a, TypeToken b)
	{
		return !(a == b);
	}
}

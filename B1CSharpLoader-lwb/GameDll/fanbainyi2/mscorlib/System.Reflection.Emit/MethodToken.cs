using System.Runtime.InteropServices;

namespace System.Reflection.Emit;

[Serializable]
[ComVisible(true)]
public struct MethodToken
{
	public static readonly MethodToken Empty;

	internal int m_method;

	public int Token => m_method;

	internal MethodToken(int str)
	{
		m_method = str;
	}

	public override int GetHashCode()
	{
		return m_method;
	}

	public override bool Equals(object obj)
	{
		if (obj is MethodToken)
		{
			return Equals((MethodToken)obj);
		}
		return false;
	}

	public bool Equals(MethodToken obj)
	{
		return obj.m_method == m_method;
	}

	public static bool operator ==(MethodToken a, MethodToken b)
	{
		return a.Equals(b);
	}

	public static bool operator !=(MethodToken a, MethodToken b)
	{
		return !(a == b);
	}
}

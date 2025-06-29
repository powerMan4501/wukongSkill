using System.Runtime.InteropServices;

namespace System.Reflection.Emit;

[Serializable]
[ComVisible(true)]
public struct ParameterToken
{
	public static readonly ParameterToken Empty;

	internal int m_tkParameter;

	public int Token => m_tkParameter;

	internal ParameterToken(int tkParam)
	{
		m_tkParameter = tkParam;
	}

	public override int GetHashCode()
	{
		return m_tkParameter;
	}

	public override bool Equals(object obj)
	{
		if (obj is ParameterToken)
		{
			return Equals((ParameterToken)obj);
		}
		return false;
	}

	public bool Equals(ParameterToken obj)
	{
		return obj.m_tkParameter == m_tkParameter;
	}

	public static bool operator ==(ParameterToken a, ParameterToken b)
	{
		return a.Equals(b);
	}

	public static bool operator !=(ParameterToken a, ParameterToken b)
	{
		return !(a == b);
	}
}

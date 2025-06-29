using System.Runtime.InteropServices;

namespace System.Diagnostics.SymbolStore;

[ComVisible(true)]
public struct SymbolToken
{
	internal int m_token;

	public SymbolToken(int val)
	{
		m_token = val;
	}

	public int GetToken()
	{
		return m_token;
	}

	public override int GetHashCode()
	{
		return m_token;
	}

	public override bool Equals(object obj)
	{
		if (obj is SymbolToken)
		{
			return Equals((SymbolToken)obj);
		}
		return false;
	}

	public bool Equals(SymbolToken obj)
	{
		return obj.m_token == m_token;
	}

	public static bool operator ==(SymbolToken a, SymbolToken b)
	{
		return a.Equals(b);
	}

	public static bool operator !=(SymbolToken a, SymbolToken b)
	{
		return !(a == b);
	}
}

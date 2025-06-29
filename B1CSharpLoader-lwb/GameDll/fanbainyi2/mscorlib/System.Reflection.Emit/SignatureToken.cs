using System.Runtime.InteropServices;

namespace System.Reflection.Emit;

[ComVisible(true)]
public struct SignatureToken
{
	public static readonly SignatureToken Empty;

	internal int m_signature;

	internal ModuleBuilder m_moduleBuilder;

	public int Token => m_signature;

	internal SignatureToken(int str, ModuleBuilder mod)
	{
		m_signature = str;
		m_moduleBuilder = mod;
	}

	public override int GetHashCode()
	{
		return m_signature;
	}

	public override bool Equals(object obj)
	{
		if (obj is SignatureToken)
		{
			return Equals((SignatureToken)obj);
		}
		return false;
	}

	public bool Equals(SignatureToken obj)
	{
		return obj.m_signature == m_signature;
	}

	public static bool operator ==(SignatureToken a, SignatureToken b)
	{
		return a.Equals(b);
	}

	public static bool operator !=(SignatureToken a, SignatureToken b)
	{
		return !(a == b);
	}
}

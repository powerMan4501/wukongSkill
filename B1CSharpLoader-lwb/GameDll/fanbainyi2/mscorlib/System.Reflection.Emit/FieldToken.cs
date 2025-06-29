using System.Runtime.InteropServices;

namespace System.Reflection.Emit;

[Serializable]
[ComVisible(true)]
public struct FieldToken
{
	public static readonly FieldToken Empty;

	internal int m_fieldTok;

	internal object m_class;

	public int Token => m_fieldTok;

	internal FieldToken(int field, Type fieldClass)
	{
		m_fieldTok = field;
		m_class = fieldClass;
	}

	public override int GetHashCode()
	{
		return m_fieldTok;
	}

	public override bool Equals(object obj)
	{
		if (obj is FieldToken)
		{
			return Equals((FieldToken)obj);
		}
		return false;
	}

	public bool Equals(FieldToken obj)
	{
		if (obj.m_fieldTok == m_fieldTok)
		{
			return obj.m_class == m_class;
		}
		return false;
	}

	public static bool operator ==(FieldToken a, FieldToken b)
	{
		return a.Equals(b);
	}

	public static bool operator !=(FieldToken a, FieldToken b)
	{
		return !(a == b);
	}
}

using System.Runtime.CompilerServices;
using System.Security;

namespace System.Runtime.InteropServices;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public struct ArrayWithOffset
{
	private object m_array;

	private int m_offset;

	private int m_count;

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public ArrayWithOffset(object array, int offset)
	{
		m_array = array;
		m_offset = offset;
		m_count = 0;
		m_count = CalculateCount();
	}

	[__DynamicallyInvokable]
	public object GetArray()
	{
		return m_array;
	}

	[__DynamicallyInvokable]
	public int GetOffset()
	{
		return m_offset;
	}

	[__DynamicallyInvokable]
	public override int GetHashCode()
	{
		return m_count + m_offset;
	}

	[__DynamicallyInvokable]
	public override bool Equals(object obj)
	{
		if (obj is ArrayWithOffset)
		{
			return Equals((ArrayWithOffset)obj);
		}
		return false;
	}

	[__DynamicallyInvokable]
	public bool Equals(ArrayWithOffset obj)
	{
		if (obj.m_array == m_array && obj.m_offset == m_offset)
		{
			return obj.m_count == m_count;
		}
		return false;
	}

	[__DynamicallyInvokable]
	public static bool operator ==(ArrayWithOffset a, ArrayWithOffset b)
	{
		return a.Equals(b);
	}

	[__DynamicallyInvokable]
	public static bool operator !=(ArrayWithOffset a, ArrayWithOffset b)
	{
		return !(a == b);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private extern int CalculateCount();
}

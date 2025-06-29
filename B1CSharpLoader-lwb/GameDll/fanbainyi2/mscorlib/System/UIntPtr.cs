using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Versioning;
using System.Security;

namespace System;

[Serializable]
[CLSCompliant(false)]
[ComVisible(true)]
[__DynamicallyInvokable]
public struct UIntPtr : ISerializable
{
	[SecurityCritical]
	private unsafe void* m_value;

	public static readonly UIntPtr Zero;

	[__DynamicallyInvokable]
	public static int Size
	{
		[NonVersionable]
		[__DynamicallyInvokable]
		get
		{
			return 4;
		}
	}

	[SecuritySafeCritical]
	[NonVersionable]
	[__DynamicallyInvokable]
	public unsafe UIntPtr(uint value)
	{
		m_value = (void*)value;
	}

	[SecuritySafeCritical]
	[NonVersionable]
	[__DynamicallyInvokable]
	public unsafe UIntPtr(ulong value)
	{
		m_value = (void*)checked((uint)value);
	}

	[SecurityCritical]
	[CLSCompliant(false)]
	[NonVersionable]
	public unsafe UIntPtr(void* value)
	{
		m_value = value;
	}

	[SecurityCritical]
	private unsafe UIntPtr(SerializationInfo info, StreamingContext context)
	{
		ulong uInt = info.GetUInt64("value");
		if (Size == 4 && uInt > uint.MaxValue)
		{
			throw new ArgumentException(Environment.GetResourceString("Serialization_InvalidPtrValue"));
		}
		m_value = (void*)uInt;
	}

	[SecurityCritical]
	unsafe void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		info.AddValue("value", (ulong)m_value);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe override bool Equals(object obj)
	{
		if (obj is UIntPtr)
		{
			return m_value == ((UIntPtr)obj).m_value;
		}
		return false;
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe override int GetHashCode()
	{
		return (int)m_value & 0x7FFFFFFF;
	}

	[SecuritySafeCritical]
	[NonVersionable]
	[__DynamicallyInvokable]
	public unsafe uint ToUInt32()
	{
		return (uint)m_value;
	}

	[SecuritySafeCritical]
	[NonVersionable]
	[__DynamicallyInvokable]
	public unsafe ulong ToUInt64()
	{
		return (ulong)m_value;
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe override string ToString()
	{
		return ((uint)m_value).ToString(CultureInfo.InvariantCulture);
	}

	[NonVersionable]
	public static explicit operator UIntPtr(uint value)
	{
		return new UIntPtr(value);
	}

	[NonVersionable]
	public static explicit operator UIntPtr(ulong value)
	{
		return new UIntPtr(value);
	}

	[SecuritySafeCritical]
	[NonVersionable]
	public unsafe static explicit operator uint(UIntPtr value)
	{
		return (uint)value.m_value;
	}

	[SecuritySafeCritical]
	[NonVersionable]
	public unsafe static explicit operator ulong(UIntPtr value)
	{
		return (ulong)value.m_value;
	}

	[SecurityCritical]
	[CLSCompliant(false)]
	[NonVersionable]
	public unsafe static explicit operator UIntPtr(void* value)
	{
		return new UIntPtr(value);
	}

	[SecurityCritical]
	[CLSCompliant(false)]
	[NonVersionable]
	public unsafe static explicit operator void*(UIntPtr value)
	{
		return value.m_value;
	}

	[SecuritySafeCritical]
	[NonVersionable]
	[__DynamicallyInvokable]
	public unsafe static bool operator ==(UIntPtr value1, UIntPtr value2)
	{
		return value1.m_value == value2.m_value;
	}

	[SecuritySafeCritical]
	[NonVersionable]
	[__DynamicallyInvokable]
	public unsafe static bool operator !=(UIntPtr value1, UIntPtr value2)
	{
		return value1.m_value != value2.m_value;
	}

	[NonVersionable]
	public static UIntPtr Add(UIntPtr pointer, int offset)
	{
		return pointer + offset;
	}

	[NonVersionable]
	public static UIntPtr operator +(UIntPtr pointer, int offset)
	{
		return new UIntPtr(pointer.ToUInt32() + (uint)offset);
	}

	[NonVersionable]
	public static UIntPtr Subtract(UIntPtr pointer, int offset)
	{
		return pointer - offset;
	}

	[NonVersionable]
	public static UIntPtr operator -(UIntPtr pointer, int offset)
	{
		return new UIntPtr(pointer.ToUInt32() - (uint)offset);
	}

	[SecuritySafeCritical]
	[CLSCompliant(false)]
	[NonVersionable]
	public unsafe void* ToPointer()
	{
		return m_value;
	}
}

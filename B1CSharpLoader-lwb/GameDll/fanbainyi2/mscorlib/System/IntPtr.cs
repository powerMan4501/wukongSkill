using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Versioning;
using System.Security;

namespace System;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public struct IntPtr : ISerializable
{
	[SecurityCritical]
	private unsafe void* m_value;

	public static readonly IntPtr Zero;

	[__DynamicallyInvokable]
	public static int Size
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[NonVersionable]
		[__DynamicallyInvokable]
		get
		{
			return 4;
		}
	}

	[SecuritySafeCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal unsafe bool IsNull()
	{
		return m_value == null;
	}

	[SecuritySafeCritical]
	[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
	[NonVersionable]
	[__DynamicallyInvokable]
	public unsafe IntPtr(int value)
	{
		m_value = (void*)value;
	}

	[SecuritySafeCritical]
	[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
	[NonVersionable]
	[__DynamicallyInvokable]
	public unsafe IntPtr(long value)
	{
		m_value = (void*)checked((int)value);
	}

	[SecurityCritical]
	[CLSCompliant(false)]
	[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
	[NonVersionable]
	public unsafe IntPtr(void* value)
	{
		m_value = value;
	}

	[SecurityCritical]
	private unsafe IntPtr(SerializationInfo info, StreamingContext context)
	{
		long @int = info.GetInt64("value");
		if (Size == 4 && (@int > int.MaxValue || @int < int.MinValue))
		{
			throw new ArgumentException(Environment.GetResourceString("Serialization_InvalidPtrValue"));
		}
		m_value = (void*)@int;
	}

	[SecurityCritical]
	unsafe void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		info.AddValue("value", (long)(int)m_value);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe override bool Equals(object obj)
	{
		if (obj is IntPtr)
		{
			return m_value == ((IntPtr)obj).m_value;
		}
		return false;
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe override int GetHashCode()
	{
		return (int)m_value;
	}

	[SecuritySafeCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[NonVersionable]
	[__DynamicallyInvokable]
	public unsafe int ToInt32()
	{
		return (int)m_value;
	}

	[SecuritySafeCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[NonVersionable]
	[__DynamicallyInvokable]
	public unsafe long ToInt64()
	{
		return (int)m_value;
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe override string ToString()
	{
		return ((int)m_value).ToString(CultureInfo.InvariantCulture);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe string ToString(string format)
	{
		return ((int)m_value).ToString(format, CultureInfo.InvariantCulture);
	}

	[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
	[NonVersionable]
	public static explicit operator IntPtr(int value)
	{
		return new IntPtr(value);
	}

	[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
	[NonVersionable]
	public static explicit operator IntPtr(long value)
	{
		return new IntPtr(value);
	}

	[SecurityCritical]
	[CLSCompliant(false)]
	[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
	[NonVersionable]
	public unsafe static explicit operator IntPtr(void* value)
	{
		return new IntPtr(value);
	}

	[SecuritySafeCritical]
	[CLSCompliant(false)]
	[NonVersionable]
	public unsafe static explicit operator void*(IntPtr value)
	{
		return value.m_value;
	}

	[SecuritySafeCritical]
	[NonVersionable]
	public unsafe static explicit operator int(IntPtr value)
	{
		return (int)value.m_value;
	}

	[SecuritySafeCritical]
	[NonVersionable]
	public unsafe static explicit operator long(IntPtr value)
	{
		return (int)value.m_value;
	}

	[SecuritySafeCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[NonVersionable]
	[__DynamicallyInvokable]
	public unsafe static bool operator ==(IntPtr value1, IntPtr value2)
	{
		return value1.m_value == value2.m_value;
	}

	[SecuritySafeCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[NonVersionable]
	[__DynamicallyInvokable]
	public unsafe static bool operator !=(IntPtr value1, IntPtr value2)
	{
		return value1.m_value != value2.m_value;
	}

	[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
	[NonVersionable]
	public static IntPtr Add(IntPtr pointer, int offset)
	{
		return pointer + offset;
	}

	[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
	[NonVersionable]
	public static IntPtr operator +(IntPtr pointer, int offset)
	{
		return new IntPtr(pointer.ToInt32() + offset);
	}

	[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
	[NonVersionable]
	public static IntPtr Subtract(IntPtr pointer, int offset)
	{
		return pointer - offset;
	}

	[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
	[NonVersionable]
	public static IntPtr operator -(IntPtr pointer, int offset)
	{
		return new IntPtr(pointer.ToInt32() - offset);
	}

	[SecuritySafeCritical]
	[CLSCompliant(false)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[NonVersionable]
	public unsafe void* ToPointer()
	{
		return m_value;
	}
}

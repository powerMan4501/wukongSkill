using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace System;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public struct RuntimeFieldHandle : ISerializable
{
	private IRuntimeFieldInfo m_ptr;

	public IntPtr Value
	{
		[SecurityCritical]
		get
		{
			if (m_ptr == null)
			{
				return IntPtr.Zero;
			}
			return m_ptr.Value.Value;
		}
	}

	internal RuntimeFieldHandle GetNativeHandle()
	{
		IRuntimeFieldInfo ptr = m_ptr;
		if (ptr == null)
		{
			throw new ArgumentNullException(null, Environment.GetResourceString("Arg_InvalidHandle"));
		}
		return new RuntimeFieldHandle(ptr);
	}

	internal RuntimeFieldHandle(IRuntimeFieldInfo fieldInfo)
	{
		m_ptr = fieldInfo;
	}

	internal IRuntimeFieldInfo GetRuntimeFieldInfo()
	{
		return m_ptr;
	}

	internal bool IsNullHandle()
	{
		return m_ptr == null;
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public override int GetHashCode()
	{
		return ValueType.GetHashCodeOfPtr(Value);
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public override bool Equals(object obj)
	{
		if (!(obj is RuntimeFieldHandle runtimeFieldHandle))
		{
			return false;
		}
		return runtimeFieldHandle.Value == Value;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public bool Equals(RuntimeFieldHandle handle)
	{
		return handle.Value == Value;
	}

	[__DynamicallyInvokable]
	public static bool operator ==(RuntimeFieldHandle left, RuntimeFieldHandle right)
	{
		return left.Equals(right);
	}

	[__DynamicallyInvokable]
	public static bool operator !=(RuntimeFieldHandle left, RuntimeFieldHandle right)
	{
		return !left.Equals(right);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern string GetName(RtFieldInfo field);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private unsafe static extern void* _GetUtf8Name(RuntimeFieldHandleInternal field);

	[SecuritySafeCritical]
	internal unsafe static Utf8String GetUtf8Name(RuntimeFieldHandleInternal field)
	{
		return new Utf8String(_GetUtf8Name(field));
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern bool MatchesNameHash(RuntimeFieldHandleInternal handle, uint hash);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern FieldAttributes GetAttributes(RuntimeFieldHandleInternal field);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern RuntimeType GetApproxDeclaringType(RuntimeFieldHandleInternal field);

	[SecurityCritical]
	internal static RuntimeType GetApproxDeclaringType(IRuntimeFieldInfo field)
	{
		RuntimeType approxDeclaringType = GetApproxDeclaringType(field.Value);
		GC.KeepAlive(field);
		return approxDeclaringType;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern int GetToken(RtFieldInfo field);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern object GetValue(RtFieldInfo field, object instance, RuntimeType fieldType, RuntimeType declaringType, ref bool domainInitialized);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal unsafe static extern object GetValueDirect(RtFieldInfo field, RuntimeType fieldType, void* pTypedRef, RuntimeType contextType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern void SetValue(RtFieldInfo field, object obj, object value, RuntimeType fieldType, FieldAttributes fieldAttr, RuntimeType declaringType, ref bool domainInitialized);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal unsafe static extern void SetValueDirect(RtFieldInfo field, RuntimeType fieldType, void* pTypedRef, object value, RuntimeType contextType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern RuntimeFieldHandleInternal GetStaticFieldForGenericType(RuntimeFieldHandleInternal field, RuntimeType declaringType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern bool AcquiresContextFromThis(RuntimeFieldHandleInternal field);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool IsSecurityCritical(RuntimeFieldHandle fieldHandle);

	[SecuritySafeCritical]
	internal bool IsSecurityCritical()
	{
		return IsSecurityCritical(GetNativeHandle());
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool IsSecuritySafeCritical(RuntimeFieldHandle fieldHandle);

	[SecuritySafeCritical]
	internal bool IsSecuritySafeCritical()
	{
		return IsSecuritySafeCritical(GetNativeHandle());
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool IsSecurityTransparent(RuntimeFieldHandle fieldHandle);

	[SecuritySafeCritical]
	internal bool IsSecurityTransparent()
	{
		return IsSecurityTransparent(GetNativeHandle());
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern void CheckAttributeAccess(RuntimeFieldHandle fieldHandle, RuntimeModule decoratedTarget);

	[SecurityCritical]
	private RuntimeFieldHandle(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		FieldInfo fieldInfo = (RuntimeFieldInfo)info.GetValue("FieldObj", typeof(RuntimeFieldInfo));
		if (fieldInfo == null)
		{
			throw new SerializationException(Environment.GetResourceString("Serialization_InsufficientState"));
		}
		m_ptr = fieldInfo.FieldHandle.m_ptr;
		if (m_ptr == null)
		{
			throw new SerializationException(Environment.GetResourceString("Serialization_InsufficientState"));
		}
	}

	[SecurityCritical]
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		if (m_ptr == null)
		{
			throw new SerializationException(Environment.GetResourceString("Serialization_InvalidFieldState"));
		}
		RuntimeFieldInfo value = (RuntimeFieldInfo)RuntimeType.GetFieldInfo(GetRuntimeFieldInfo());
		info.AddValue("FieldObj", value, typeof(RuntimeFieldInfo));
	}
}

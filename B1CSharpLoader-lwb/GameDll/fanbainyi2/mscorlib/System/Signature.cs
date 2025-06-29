using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

namespace System;

internal class Signature
{
	internal enum MdSigCallingConvention : byte
	{
		Generics = 16,
		HasThis = 32,
		ExplicitThis = 64,
		CallConvMask = 15,
		Default = 0,
		C = 1,
		StdCall = 2,
		ThisCall = 3,
		FastCall = 4,
		Vararg = 5,
		Field = 6,
		LocalSig = 7,
		Property = 8,
		Unmgd = 9,
		GenericInst = 10,
		Max = 11
	}

	internal RuntimeType[] m_arguments;

	internal RuntimeType m_declaringType;

	internal RuntimeType m_returnTypeORfieldType;

	internal object m_keepalive;

	[SecurityCritical]
	internal unsafe void* m_sig;

	internal int m_managedCallingConventionAndArgIteratorFlags;

	internal int m_nSizeOfArgStack;

	internal int m_csig;

	internal RuntimeMethodHandleInternal m_pMethod;

	internal CallingConventions CallingConvention => (CallingConventions)(byte)m_managedCallingConventionAndArgIteratorFlags;

	internal RuntimeType[] Arguments => m_arguments;

	internal RuntimeType ReturnType => m_returnTypeORfieldType;

	internal RuntimeType FieldType => m_returnTypeORfieldType;

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private unsafe extern void GetSignature(void* pCorSig, int cCorSig, RuntimeFieldHandleInternal fieldHandle, IRuntimeMethodInfo methodHandle, RuntimeType declaringType);

	[SecuritySafeCritical]
	public unsafe Signature(IRuntimeMethodInfo method, RuntimeType[] arguments, RuntimeType returnType, CallingConventions callingConvention)
	{
		m_pMethod = method.Value;
		m_arguments = arguments;
		m_returnTypeORfieldType = returnType;
		m_managedCallingConventionAndArgIteratorFlags = (byte)callingConvention;
		GetSignature(null, 0, default(RuntimeFieldHandleInternal), method, null);
	}

	[SecuritySafeCritical]
	public unsafe Signature(IRuntimeMethodInfo methodHandle, RuntimeType declaringType)
	{
		GetSignature(null, 0, default(RuntimeFieldHandleInternal), methodHandle, declaringType);
	}

	[SecurityCritical]
	public unsafe Signature(IRuntimeFieldInfo fieldHandle, RuntimeType declaringType)
	{
		GetSignature(null, 0, fieldHandle.Value, null, declaringType);
		GC.KeepAlive(fieldHandle);
	}

	[SecurityCritical]
	public unsafe Signature(void* pCorSig, int cCorSig, RuntimeType declaringType)
	{
		GetSignature(pCorSig, cCorSig, default(RuntimeFieldHandleInternal), null, declaringType);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	internal static extern bool CompareSig(Signature sig1, Signature sig2);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	internal extern Type[] GetCustomModifiers(int position, bool required);
}

using System.Runtime.CompilerServices;
using System.Security;

namespace System;

public struct ArgIterator
{
	private IntPtr ArgCookie;

	private IntPtr sigPtr;

	private IntPtr sigPtrLen;

	private IntPtr ArgPtr;

	private int RemainingArgs;

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private extern ArgIterator(IntPtr arglist);

	[SecuritySafeCritical]
	public ArgIterator(RuntimeArgumentHandle arglist)
		: this(arglist.Value)
	{
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private unsafe extern ArgIterator(IntPtr arglist, void* ptr);

	[SecurityCritical]
	[CLSCompliant(false)]
	public unsafe ArgIterator(RuntimeArgumentHandle arglist, void* ptr)
		: this(arglist.Value, ptr)
	{
	}

	[SecuritySafeCritical]
	[CLSCompliant(false)]
	public unsafe TypedReference GetNextArg()
	{
		TypedReference result = default(TypedReference);
		FCallGetNextArg(&result);
		return result;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private unsafe extern void FCallGetNextArg(void* result);

	[SecuritySafeCritical]
	[CLSCompliant(false)]
	public unsafe TypedReference GetNextArg(RuntimeTypeHandle rth)
	{
		if (sigPtr != IntPtr.Zero)
		{
			return GetNextArg();
		}
		if (ArgPtr == IntPtr.Zero)
		{
			throw new ArgumentNullException();
		}
		TypedReference result = default(TypedReference);
		InternalGetNextArg(&result, rth.GetRuntimeType());
		return result;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private unsafe extern void InternalGetNextArg(void* result, RuntimeType rt);

	public void End()
	{
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	public extern int GetRemainingCount();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private unsafe extern void* _GetNextArgType();

	[SecuritySafeCritical]
	public unsafe RuntimeTypeHandle GetNextArgType()
	{
		return new RuntimeTypeHandle(Type.GetTypeFromHandleUnsafe((IntPtr)_GetNextArgType()));
	}

	public override int GetHashCode()
	{
		return ValueType.GetHashCodeOfPtr(ArgCookie);
	}

	public override bool Equals(object o)
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_NYI"));
	}
}

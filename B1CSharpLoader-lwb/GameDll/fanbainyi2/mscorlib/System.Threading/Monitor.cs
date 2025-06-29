using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;

namespace System.Threading;

[ComVisible(true)]
[__DynamicallyInvokable]
[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
public static class Monitor
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static extern void Enter(object obj);

	[__DynamicallyInvokable]
	public static void Enter(object obj, ref bool lockTaken)
	{
		if (lockTaken)
		{
			ThrowLockTakenException();
		}
		ReliableEnter(obj, ref lockTaken);
	}

	private static void ThrowLockTakenException()
	{
		throw new ArgumentException(Environment.GetResourceString("Argument_MustBeFalse"), "lockTaken");
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	private static extern void ReliableEnter(object obj, ref bool lockTaken);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[__DynamicallyInvokable]
	public static extern void Exit(object obj);

	[__DynamicallyInvokable]
	public static bool TryEnter(object obj)
	{
		bool lockTaken = false;
		TryEnter(obj, 0, ref lockTaken);
		return lockTaken;
	}

	[__DynamicallyInvokable]
	public static void TryEnter(object obj, ref bool lockTaken)
	{
		if (lockTaken)
		{
			ThrowLockTakenException();
		}
		ReliableEnterTimeout(obj, 0, ref lockTaken);
	}

	[__DynamicallyInvokable]
	public static bool TryEnter(object obj, int millisecondsTimeout)
	{
		bool lockTaken = false;
		TryEnter(obj, millisecondsTimeout, ref lockTaken);
		return lockTaken;
	}

	private static int MillisecondsTimeoutFromTimeSpan(TimeSpan timeout)
	{
		long num = (long)timeout.TotalMilliseconds;
		if (num < -1 || num > int.MaxValue)
		{
			throw new ArgumentOutOfRangeException("timeout", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegOrNegative1"));
		}
		return (int)num;
	}

	[__DynamicallyInvokable]
	public static bool TryEnter(object obj, TimeSpan timeout)
	{
		return TryEnter(obj, MillisecondsTimeoutFromTimeSpan(timeout));
	}

	[__DynamicallyInvokable]
	public static void TryEnter(object obj, int millisecondsTimeout, ref bool lockTaken)
	{
		if (lockTaken)
		{
			ThrowLockTakenException();
		}
		ReliableEnterTimeout(obj, millisecondsTimeout, ref lockTaken);
	}

	[__DynamicallyInvokable]
	public static void TryEnter(object obj, TimeSpan timeout, ref bool lockTaken)
	{
		if (lockTaken)
		{
			ThrowLockTakenException();
		}
		ReliableEnterTimeout(obj, MillisecondsTimeoutFromTimeSpan(timeout), ref lockTaken);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	private static extern void ReliableEnterTimeout(object obj, int timeout, ref bool lockTaken);

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static bool IsEntered(object obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		return IsEnteredNative(obj);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern bool IsEnteredNative(object obj);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern bool ObjWait(bool exitContext, int millisecondsTimeout, object obj);

	[SecuritySafeCritical]
	public static bool Wait(object obj, int millisecondsTimeout, bool exitContext)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		return ObjWait(exitContext, millisecondsTimeout, obj);
	}

	public static bool Wait(object obj, TimeSpan timeout, bool exitContext)
	{
		return Wait(obj, MillisecondsTimeoutFromTimeSpan(timeout), exitContext);
	}

	[__DynamicallyInvokable]
	public static bool Wait(object obj, int millisecondsTimeout)
	{
		return Wait(obj, millisecondsTimeout, exitContext: false);
	}

	[__DynamicallyInvokable]
	public static bool Wait(object obj, TimeSpan timeout)
	{
		return Wait(obj, MillisecondsTimeoutFromTimeSpan(timeout), exitContext: false);
	}

	[__DynamicallyInvokable]
	public static bool Wait(object obj)
	{
		return Wait(obj, -1, exitContext: false);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern void ObjPulse(object obj);

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static void Pulse(object obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		ObjPulse(obj);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern void ObjPulseAll(object obj);

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static void PulseAll(object obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		ObjPulseAll(obj);
	}
}

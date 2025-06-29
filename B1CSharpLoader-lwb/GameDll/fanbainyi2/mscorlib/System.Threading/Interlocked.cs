using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Threading;

[__DynamicallyInvokable]
public static class Interlocked
{
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[__DynamicallyInvokable]
	public static int Increment(ref int location)
	{
		return Add(ref location, 1);
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[__DynamicallyInvokable]
	public static long Increment(ref long location)
	{
		return Add(ref location, 1L);
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[__DynamicallyInvokable]
	public static int Decrement(ref int location)
	{
		return Add(ref location, -1);
	}

	[__DynamicallyInvokable]
	public static long Decrement(ref long location)
	{
		return Add(ref location, -1L);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static extern int Exchange(ref int location1, int value);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static extern long Exchange(ref long location1, long value);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static extern float Exchange(ref float location1, float value);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static extern double Exchange(ref double location1, double value);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static extern object Exchange(ref object location1, object value);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SecuritySafeCritical]
	public static extern IntPtr Exchange(ref IntPtr location1, IntPtr value);

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[ComVisible(false)]
	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static T Exchange<T>(ref T location1, T value) where T : class
	{
		_Exchange(__makeref(location1), __makeref(value));
		return value;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SecuritySafeCritical]
	private static extern void _Exchange(TypedReference location1, TypedReference value);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static extern int CompareExchange(ref int location1, int value, int comparand);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static extern long CompareExchange(ref long location1, long value, long comparand);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static extern float CompareExchange(ref float location1, float value, float comparand);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static extern double CompareExchange(ref double location1, double value, double comparand);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static extern object CompareExchange(ref object location1, object value, object comparand);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SecuritySafeCritical]
	public static extern IntPtr CompareExchange(ref IntPtr location1, IntPtr value, IntPtr comparand);

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[ComVisible(false)]
	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static T CompareExchange<T>(ref T location1, T value, T comparand) where T : class
	{
		_CompareExchange(__makeref(location1), __makeref(value), comparand);
		return value;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SecuritySafeCritical]
	private static extern void _CompareExchange(TypedReference location1, TypedReference value, object comparand);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SecuritySafeCritical]
	internal static extern int CompareExchange(ref int location1, int value, int comparand, ref bool succeeded);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal static extern int ExchangeAdd(ref int location1, int value);

	[MethodImpl(MethodImplOptions.InternalCall)]
	internal static extern long ExchangeAdd(ref long location1, long value);

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[__DynamicallyInvokable]
	public static int Add(ref int location1, int value)
	{
		return ExchangeAdd(ref location1, value) + value;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[__DynamicallyInvokable]
	public static long Add(ref long location1, long value)
	{
		return ExchangeAdd(ref location1, value) + value;
	}

	[__DynamicallyInvokable]
	public static long Read(ref long location)
	{
		return CompareExchange(ref location, 0L, 0L);
	}

	[__DynamicallyInvokable]
	public static void MemoryBarrier()
	{
		Thread.MemoryBarrier();
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SecuritySafeCritical]
	public static extern void SpeculationBarrier();
}

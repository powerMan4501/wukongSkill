using System.Runtime.InteropServices;
using System.Threading;

namespace System.Net;

internal class SafeNativeOverlapped : SafeHandle
{
	internal static readonly SafeNativeOverlapped Zero = new SafeNativeOverlapped();

	public override bool IsInvalid => handle == IntPtr.Zero;

	internal SafeNativeOverlapped()
		: this(IntPtr.Zero)
	{
	}

	internal unsafe SafeNativeOverlapped(NativeOverlapped* handle)
		: this((IntPtr)handle)
	{
	}

	internal SafeNativeOverlapped(IntPtr handle)
		: base(IntPtr.Zero, ownsHandle: true)
	{
		SetHandle(handle);
	}

	public unsafe void ReinitializeNativeOverlapped()
	{
		IntPtr intPtr = handle;
		if (intPtr != IntPtr.Zero)
		{
			((NativeOverlapped*)(void*)intPtr)->InternalHigh = IntPtr.Zero;
			((NativeOverlapped*)(void*)intPtr)->InternalLow = IntPtr.Zero;
			((NativeOverlapped*)(void*)intPtr)->EventHandle = IntPtr.Zero;
		}
	}

	protected unsafe override bool ReleaseHandle()
	{
		IntPtr intPtr = Interlocked.Exchange(ref handle, IntPtr.Zero);
		if (intPtr != IntPtr.Zero && !NclUtilities.HasShutdownStarted)
		{
			Overlapped.Free((NativeOverlapped*)(void*)intPtr);
		}
		return true;
	}
}

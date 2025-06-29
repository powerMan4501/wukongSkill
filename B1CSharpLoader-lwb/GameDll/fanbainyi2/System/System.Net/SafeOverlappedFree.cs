using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace System.Net;

[ComVisible(false)]
internal sealed class SafeOverlappedFree : SafeHandleZeroOrMinusOneIsInvalid
{
	private const int LPTR = 64;

	internal static readonly SafeOverlappedFree Zero = new SafeOverlappedFree(ownsHandle: false);

	private SafeCloseSocket _socketHandle;

	private SafeOverlappedFree()
		: base(ownsHandle: true)
	{
	}

	private SafeOverlappedFree(bool ownsHandle)
		: base(ownsHandle)
	{
	}

	public static SafeOverlappedFree Alloc()
	{
		SafeOverlappedFree safeOverlappedFree = UnsafeNclNativeMethods.SafeNetHandlesSafeOverlappedFree.LocalAlloc(64, (UIntPtr)(ulong)Win32.OverlappedSize);
		if (safeOverlappedFree.IsInvalid)
		{
			safeOverlappedFree.SetHandleAsInvalid();
			throw new OutOfMemoryException();
		}
		return safeOverlappedFree;
	}

	public static SafeOverlappedFree Alloc(SafeCloseSocket socketHandle)
	{
		SafeOverlappedFree safeOverlappedFree = Alloc();
		safeOverlappedFree._socketHandle = socketHandle;
		return safeOverlappedFree;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public void Close(bool resetOwner)
	{
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
		}
		finally
		{
			if (resetOwner)
			{
				_socketHandle = null;
			}
			Close();
		}
	}

	protected override bool ReleaseHandle()
	{
		SafeCloseSocket socketHandle = _socketHandle;
		if (socketHandle != null && !socketHandle.IsInvalid)
		{
			socketHandle.Dispose();
		}
		return UnsafeNclNativeMethods.SafeNetHandles.LocalFree(handle) == IntPtr.Zero;
	}
}

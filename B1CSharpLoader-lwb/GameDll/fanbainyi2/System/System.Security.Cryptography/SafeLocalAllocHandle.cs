using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography;

internal sealed class SafeLocalAllocHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	internal static SafeLocalAllocHandle InvalidHandle
	{
		get
		{
			SafeLocalAllocHandle safeLocalAllocHandle = new SafeLocalAllocHandle(IntPtr.Zero);
			GC.SuppressFinalize(safeLocalAllocHandle);
			return safeLocalAllocHandle;
		}
	}

	private SafeLocalAllocHandle()
		: base(ownsHandle: true)
	{
	}

	internal SafeLocalAllocHandle(IntPtr handle)
		: base(ownsHandle: true)
	{
		SetHandle(handle);
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private static extern IntPtr LocalFree(IntPtr handle);

	protected override bool ReleaseHandle()
	{
		return LocalFree(handle) == IntPtr.Zero;
	}
}

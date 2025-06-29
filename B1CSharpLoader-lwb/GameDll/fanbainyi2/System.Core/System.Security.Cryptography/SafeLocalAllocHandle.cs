using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography;

internal sealed class SafeLocalAllocHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	internal static System.Security.Cryptography.SafeLocalAllocHandle InvalidHandle
	{
		[SecuritySafeCritical]
		get
		{
			return new System.Security.Cryptography.SafeLocalAllocHandle(IntPtr.Zero);
		}
	}

	[SecuritySafeCritical]
	private SafeLocalAllocHandle()
		: base(ownsHandle: true)
	{
	}

	[DllImport("kernel32.dll")]
	[SuppressUnmanagedCodeSecurity]
	[SecurityCritical]
	private static extern IntPtr LocalFree(IntPtr hMem);

	[SecuritySafeCritical]
	internal unsafe T Read<T>(int offset) where T : struct
	{
		bool success = false;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			DangerousAddRef(ref success);
			IntPtr ptr = new IntPtr((byte*)handle.ToPointer() + offset);
			return (T)Marshal.PtrToStructure(ptr, typeof(T));
		}
		finally
		{
			if (success)
			{
				DangerousRelease();
			}
		}
	}

	[SecuritySafeCritical]
	protected override bool ReleaseHandle()
	{
		return LocalFree(handle) == IntPtr.Zero;
	}

	[SecuritySafeCritical]
	internal SafeLocalAllocHandle(IntPtr handle)
		: base(ownsHandle: true)
	{
		SetHandle(handle);
	}
}

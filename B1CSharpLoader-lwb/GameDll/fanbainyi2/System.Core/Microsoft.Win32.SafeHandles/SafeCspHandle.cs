using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;

namespace Microsoft.Win32.SafeHandles;

[SecurityCritical(SecurityCriticalScope.Everything)]
internal sealed class SafeCspHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	private SafeCspHandle()
		: base(ownsHandle: true)
	{
	}

	[DllImport("advapi32", SetLastError = true)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool CryptContextAddRef(SafeCspHandle hProv, IntPtr pdwReserved, int dwFlags);

	[DllImport("advapi32")]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool CryptReleaseContext(IntPtr hProv, int dwFlags);

	public SafeCspHandle Duplicate()
	{
		bool success = false;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			DangerousAddRef(ref success);
			IntPtr intPtr = DangerousGetHandle();
			int num = 0;
			SafeCspHandle safeCspHandle = new SafeCspHandle();
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
			}
			finally
			{
				if (!CryptContextAddRef(this, IntPtr.Zero, 0))
				{
					num = Marshal.GetLastWin32Error();
				}
				else
				{
					safeCspHandle.SetHandle(intPtr);
				}
			}
			if (num != 0)
			{
				safeCspHandle.Dispose();
				throw new CryptographicException(num);
			}
			return safeCspHandle;
		}
		finally
		{
			if (success)
			{
				DangerousRelease();
			}
		}
	}

	protected override bool ReleaseHandle()
	{
		return CryptReleaseContext(handle, 0);
	}
}

using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography;

internal sealed class SafeCryptProvHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	internal static SafeCryptProvHandle InvalidHandle
	{
		get
		{
			SafeCryptProvHandle safeCryptProvHandle = new SafeCryptProvHandle(IntPtr.Zero);
			GC.SuppressFinalize(safeCryptProvHandle);
			return safeCryptProvHandle;
		}
	}

	private SafeCryptProvHandle()
		: base(ownsHandle: true)
	{
	}

	internal SafeCryptProvHandle(IntPtr handle)
		: base(ownsHandle: true)
	{
		SetHandle(handle);
	}

	[DllImport("advapi32.dll", SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private static extern bool CryptReleaseContext(IntPtr hCryptProv, uint dwFlags);

	protected override bool ReleaseHandle()
	{
		return CryptReleaseContext(handle, 0u);
	}
}

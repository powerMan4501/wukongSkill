using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography;

internal sealed class SafeLibraryHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	private SafeLibraryHandle()
		: base(ownsHandle: true)
	{
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool FreeLibrary([In] IntPtr hModule);

	protected override bool ReleaseHandle()
	{
		return FreeLibrary(handle);
	}
}

using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;

namespace Microsoft.Win32.SafeHandles;

[SuppressUnmanagedCodeSecurity]
[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
internal sealed class SafeUserTokenHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	internal SafeUserTokenHandle()
		: base(ownsHandle: true)
	{
	}

	internal SafeUserTokenHandle(IntPtr existingHandle, bool ownsHandle)
		: base(ownsHandle)
	{
		SetHandle(existingHandle);
	}

	[DllImport("advapi32.dll", BestFitMapping = false, CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern bool DuplicateTokenEx(SafeHandle hToken, int access, NativeMethods.SECURITY_ATTRIBUTES tokenAttributes, int impersonationLevel, int tokenType, out SafeUserTokenHandle hNewToken);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private static extern bool CloseHandle(IntPtr handle);

	protected override bool ReleaseHandle()
	{
		return CloseHandle(handle);
	}
}

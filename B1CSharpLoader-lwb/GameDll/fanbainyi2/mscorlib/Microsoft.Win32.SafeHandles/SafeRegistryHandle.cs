using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Win32.SafeHandles;

[SecurityCritical]
public sealed class SafeRegistryHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	[SecurityCritical]
	internal SafeRegistryHandle()
		: base(ownsHandle: true)
	{
	}

	[SecurityCritical]
	public SafeRegistryHandle(IntPtr preexistingHandle, bool ownsHandle)
		: base(ownsHandle)
	{
		SetHandle(preexistingHandle);
	}

	[SecurityCritical]
	protected override bool ReleaseHandle()
	{
		return RegCloseKey(handle) == 0;
	}

	[DllImport("advapi32.dll")]
	[SuppressUnmanagedCodeSecurity]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal static extern int RegCloseKey(IntPtr hKey);
}

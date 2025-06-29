using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;

namespace Microsoft.Win32.SafeHandles;

[SuppressUnmanagedCodeSecurity]
[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
internal sealed class SafeLocalMemHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	internal SafeLocalMemHandle()
		: base(ownsHandle: true)
	{
	}

	[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
	internal SafeLocalMemHandle(IntPtr existingHandle, bool ownsHandle)
		: base(ownsHandle)
	{
		SetHandle(existingHandle);
	}

	[DllImport("advapi32.dll", BestFitMapping = false, CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern bool ConvertStringSecurityDescriptorToSecurityDescriptor(string StringSecurityDescriptor, int StringSDRevision, out SafeLocalMemHandle pSecurityDescriptor, IntPtr SecurityDescriptorSize);

	[DllImport("kernel32.dll")]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private static extern IntPtr LocalFree(IntPtr hMem);

	protected override bool ReleaseHandle()
	{
		return LocalFree(handle) == IntPtr.Zero;
	}
}

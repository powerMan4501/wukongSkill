using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;

namespace Microsoft.Win32.SafeHandles;

[SuppressUnmanagedCodeSecurity]
[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
internal sealed class SafeEventLogWriteHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	internal SafeEventLogWriteHandle()
		: base(ownsHandle: true)
	{
	}

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern SafeEventLogWriteHandle RegisterEventSource(string uncServerName, string sourceName);

	[DllImport("advapi32.dll", SetLastError = true)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private static extern bool DeregisterEventSource(IntPtr hEventLog);

	protected override bool ReleaseHandle()
	{
		return DeregisterEventSource(handle);
	}
}

using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;

namespace Microsoft.Win32.SafeHandles;

[SuppressUnmanagedCodeSecurity]
[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
internal sealed class SafeEventLogReadHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	internal SafeEventLogReadHandle()
		: base(ownsHandle: true)
	{
	}

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern SafeEventLogReadHandle OpenEventLog(string UNCServerName, string sourceName);

	[DllImport("advapi32.dll", SetLastError = true)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private static extern bool CloseEventLog(IntPtr hEventLog);

	protected override bool ReleaseHandle()
	{
		return CloseEventLog(handle);
	}
}

using System;
using System.Security;
using System.Threading;

namespace Microsoft.Win32.SafeHandles;

[SecurityCritical(SecurityCriticalScope.Everything)]
internal sealed class SafePerfProviderHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	private SafePerfProviderHandle()
		: base(ownsHandle: true)
	{
	}

	protected override bool ReleaseHandle()
	{
		IntPtr hProvider = handle;
		if (Interlocked.Exchange(ref handle, IntPtr.Zero) != IntPtr.Zero)
		{
			uint num = Microsoft.Win32.UnsafeNativeMethods.PerfStopProvider(hProvider);
		}
		return true;
	}
}

using System.Security;
using Microsoft.Win32.SafeHandles;

namespace System.Net.NetworkInformation;

[SuppressUnmanagedCodeSecurity]
internal class SafeCancelMibChangeNotify : SafeHandleZeroOrMinusOneIsInvalid
{
	public SafeCancelMibChangeNotify()
		: base(ownsHandle: true)
	{
	}

	protected override bool ReleaseHandle()
	{
		uint num = UnsafeNetInfoNativeMethods.CancelMibChangeNotify2(handle);
		handle = IntPtr.Zero;
		return num == 0;
	}
}

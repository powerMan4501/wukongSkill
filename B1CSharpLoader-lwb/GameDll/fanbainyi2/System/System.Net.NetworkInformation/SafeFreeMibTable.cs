using System.Security;
using Microsoft.Win32.SafeHandles;

namespace System.Net.NetworkInformation;

[SuppressUnmanagedCodeSecurity]
internal class SafeFreeMibTable : SafeHandleZeroOrMinusOneIsInvalid
{
	public SafeFreeMibTable()
		: base(ownsHandle: true)
	{
	}

	protected override bool ReleaseHandle()
	{
		UnsafeNetInfoNativeMethods.FreeMibTable(handle);
		handle = IntPtr.Zero;
		return true;
	}
}

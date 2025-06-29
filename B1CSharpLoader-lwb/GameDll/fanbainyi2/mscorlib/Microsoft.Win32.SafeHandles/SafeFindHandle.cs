using System.Security;

namespace Microsoft.Win32.SafeHandles;

[SecurityCritical]
internal sealed class SafeFindHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	[SecurityCritical]
	internal SafeFindHandle()
		: base(ownsHandle: true)
	{
	}

	[SecurityCritical]
	protected override bool ReleaseHandle()
	{
		return Win32Native.FindClose(handle);
	}
}

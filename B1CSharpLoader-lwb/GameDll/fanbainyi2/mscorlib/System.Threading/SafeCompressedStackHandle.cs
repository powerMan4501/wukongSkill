using System.Runtime.InteropServices;
using System.Security;

namespace System.Threading;

[SecurityCritical]
internal class SafeCompressedStackHandle : SafeHandle
{
	public override bool IsInvalid
	{
		[SecurityCritical]
		get
		{
			return handle == IntPtr.Zero;
		}
	}

	public SafeCompressedStackHandle()
		: base(IntPtr.Zero, ownsHandle: true)
	{
	}

	[SecurityCritical]
	protected override bool ReleaseHandle()
	{
		CompressedStack.DestroyDelayedCompressedStack(handle);
		handle = IntPtr.Zero;
		return true;
	}
}

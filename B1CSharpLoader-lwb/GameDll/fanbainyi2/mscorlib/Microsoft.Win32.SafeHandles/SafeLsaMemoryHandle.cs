using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Win32.SafeHandles;

[SecurityCritical]
internal sealed class SafeLsaMemoryHandle : SafeBuffer
{
	internal static SafeLsaMemoryHandle InvalidHandle => new SafeLsaMemoryHandle(IntPtr.Zero);

	private SafeLsaMemoryHandle()
		: base(ownsHandle: true)
	{
	}

	internal SafeLsaMemoryHandle(IntPtr handle)
		: base(ownsHandle: true)
	{
		SetHandle(handle);
	}

	[SecurityCritical]
	protected override bool ReleaseHandle()
	{
		return Win32Native.LsaFreeMemory(handle) == 0;
	}
}

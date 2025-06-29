using System.Runtime.InteropServices;
using System.Security;

namespace System.Diagnostics.Eventing.Reader;

[SecurityCritical(SecurityCriticalScope.Everything)]
internal sealed class CoTaskMemUnicodeSafeHandle : SafeHandle
{
	public override bool IsInvalid
	{
		get
		{
			if (!base.IsClosed)
			{
				return handle == IntPtr.Zero;
			}
			return true;
		}
	}

	public static CoTaskMemUnicodeSafeHandle Zero => new CoTaskMemUnicodeSafeHandle();

	internal CoTaskMemUnicodeSafeHandle()
		: base(IntPtr.Zero, ownsHandle: true)
	{
	}

	internal CoTaskMemUnicodeSafeHandle(IntPtr handle, bool ownsHandle)
		: base(IntPtr.Zero, ownsHandle)
	{
		SetHandle(handle);
	}

	internal void SetMemory(IntPtr handle)
	{
		SetHandle(handle);
	}

	internal IntPtr GetMemory()
	{
		return handle;
	}

	protected override bool ReleaseHandle()
	{
		Marshal.ZeroFreeCoTaskMemUnicode(handle);
		handle = IntPtr.Zero;
		return true;
	}
}

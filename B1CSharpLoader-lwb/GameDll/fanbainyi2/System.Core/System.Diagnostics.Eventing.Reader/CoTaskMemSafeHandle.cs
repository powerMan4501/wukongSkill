using System.Runtime.InteropServices;
using System.Security;

namespace System.Diagnostics.Eventing.Reader;

[SecurityCritical(SecurityCriticalScope.Everything)]
internal sealed class CoTaskMemSafeHandle : SafeHandle
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

	public static CoTaskMemSafeHandle Zero => new CoTaskMemSafeHandle();

	internal CoTaskMemSafeHandle()
		: base(IntPtr.Zero, ownsHandle: true)
	{
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
		Marshal.FreeCoTaskMem(handle);
		handle = IntPtr.Zero;
		return true;
	}
}

using System.Runtime.InteropServices;
using System.Security;

namespace System.Diagnostics.Eventing.Reader;

[SecuritySafeCritical]
internal sealed class EventLogHandle : SafeHandle
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

	public static EventLogHandle Zero => new EventLogHandle();

	private EventLogHandle()
		: base(IntPtr.Zero, ownsHandle: true)
	{
	}

	internal EventLogHandle(IntPtr handle, bool ownsHandle)
		: base(IntPtr.Zero, ownsHandle)
	{
		SetHandle(handle);
	}

	protected override bool ReleaseHandle()
	{
		NativeWrapper.EvtClose(handle);
		handle = IntPtr.Zero;
		return true;
	}
}

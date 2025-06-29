using System.Security;

namespace System.Runtime.InteropServices;

[SecurityCritical]
internal sealed class SafeHeapHandle : SafeBuffer
{
	public override bool IsInvalid
	{
		[SecurityCritical]
		get
		{
			return handle == IntPtr.Zero;
		}
	}

	public SafeHeapHandle(ulong byteLength)
		: base(ownsHandle: true)
	{
		Resize(byteLength);
	}

	public void Resize(ulong byteLength)
	{
		if (base.IsClosed)
		{
			throw new ObjectDisposedException("SafeHeapHandle");
		}
		ulong num = 0uL;
		if (handle == IntPtr.Zero)
		{
			handle = Marshal.AllocHGlobal((IntPtr)(long)byteLength);
		}
		else
		{
			num = base.ByteLength;
			handle = Marshal.ReAllocHGlobal(handle, (IntPtr)(long)byteLength);
		}
		if (handle == IntPtr.Zero)
		{
			throw new OutOfMemoryException();
		}
		if (byteLength > num)
		{
			ulong num2 = byteLength - num;
			if (num2 > long.MaxValue)
			{
				GC.AddMemoryPressure(long.MaxValue);
				GC.AddMemoryPressure((long)(num2 - long.MaxValue));
			}
			else
			{
				GC.AddMemoryPressure((long)num2);
			}
		}
		else
		{
			RemoveMemoryPressure(num - byteLength);
		}
		Initialize(byteLength);
	}

	private void RemoveMemoryPressure(ulong removedBytes)
	{
		if (removedBytes != 0L)
		{
			if (removedBytes > long.MaxValue)
			{
				GC.RemoveMemoryPressure(long.MaxValue);
				GC.RemoveMemoryPressure((long)(removedBytes - long.MaxValue));
			}
			else
			{
				GC.RemoveMemoryPressure((long)removedBytes);
			}
		}
	}

	[SecurityCritical]
	protected override bool ReleaseHandle()
	{
		IntPtr intPtr = handle;
		handle = IntPtr.Zero;
		if (intPtr != IntPtr.Zero)
		{
			RemoveMemoryPressure(base.ByteLength);
			Marshal.FreeHGlobal(intPtr);
		}
		return true;
	}
}

using System.Runtime.InteropServices;

namespace System.Deployment.Internal.Isolation;

internal struct StoreOperationScavenge
{
	[Flags]
	public enum OpFlags
	{
		Nothing = 0,
		Light = 1,
		LimitSize = 2,
		LimitTime = 4,
		LimitCount = 8
	}

	[MarshalAs(UnmanagedType.U4)]
	public uint Size;

	[MarshalAs(UnmanagedType.U4)]
	public OpFlags Flags;

	[MarshalAs(UnmanagedType.U8)]
	public ulong SizeReclaimationLimit;

	[MarshalAs(UnmanagedType.U8)]
	public ulong RuntimeLimit;

	[MarshalAs(UnmanagedType.U4)]
	public uint ComponentCountLimit;

	public StoreOperationScavenge(bool Light, ulong SizeLimit, ulong RunLimit, uint ComponentLimit)
	{
		Size = (uint)Marshal.SizeOf(typeof(StoreOperationScavenge));
		Flags = OpFlags.Nothing;
		if (Light)
		{
			Flags |= OpFlags.Light;
		}
		SizeReclaimationLimit = SizeLimit;
		if (SizeLimit != 0L)
		{
			Flags |= OpFlags.LimitSize;
		}
		RuntimeLimit = RunLimit;
		if (RunLimit != 0L)
		{
			Flags |= OpFlags.LimitTime;
		}
		ComponentCountLimit = ComponentLimit;
		if (ComponentLimit != 0)
		{
			Flags |= OpFlags.LimitCount;
		}
	}

	public StoreOperationScavenge(bool Light)
		: this(Light, 0uL, 0uL, 0u)
	{
	}

	public void Destroy()
	{
	}
}

using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public struct FSharedMemoryRegion
{
	public IntPtr StructAddress { get; private set; }

	public string Name
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FSharedMemoryRegion.GetName(StructAddress, ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public IntPtr Address => Native_FSharedMemoryRegion.GetAddress(StructAddress);

	public IntPtr Size => Native_FSharedMemoryRegion.GetSize(StructAddress);

	public FSharedMemoryRegion(IntPtr structAddress)
	{
		StructAddress = structAddress;
	}
}

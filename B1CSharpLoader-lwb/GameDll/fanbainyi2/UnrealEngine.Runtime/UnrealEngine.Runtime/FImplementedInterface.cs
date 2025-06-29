using System;

namespace UnrealEngine.Runtime;

public struct FImplementedInterface
{
	public IntPtr InterfaceClassAddress;

	public int PointerOffset;

	public csbool ImplementedByK2;

	public UClass InterfaceClass
	{
		get
		{
			return GCHelper.Find<UClass>(InterfaceClassAddress);
		}
		set
		{
			InterfaceClassAddress = ((value == null) ? IntPtr.Zero : value.Address);
		}
	}

	public FImplementedInterface(IntPtr interfaceClass, int pointerOffset, bool implementedByK2)
	{
		InterfaceClassAddress = interfaceClass;
		PointerOffset = pointerOffset;
		ImplementedByK2 = implementedByK2;
	}
}

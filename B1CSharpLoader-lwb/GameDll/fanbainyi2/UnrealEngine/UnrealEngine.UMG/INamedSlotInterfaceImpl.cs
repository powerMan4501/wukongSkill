using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

public sealed class INamedSlotInterfaceImpl : IInterfaceImpl, INamedSlotInterface, IInterface
{
	static INamedSlotInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(INamedSlotInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(INamedSlotInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UMG.NamedSlotInterface");
	}
}

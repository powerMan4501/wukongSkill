using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Water;

public sealed class IWaterBrushActorInterfaceImpl : IInterfaceImpl, IWaterBrushActorInterface, IInterface
{
	static IWaterBrushActorInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IWaterBrushActorInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IWaterBrushActorInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Water.WaterBrushActorInterface");
	}
}

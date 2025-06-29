using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_DestructibleActorDataComp")]
public class BUS_DestructibleActorDataComp : BUS_ActorBaseDataComp
{
	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_DestructibleActorDataComp");
	}

	static BUS_DestructibleActorDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_DestructibleActorDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_DestructibleActorDataComp));
	}
}

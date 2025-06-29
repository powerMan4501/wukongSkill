using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_BattleSCDataComp")]
public class BUS_BattleSCDataComp : BUS_ActorBaseDataComp
{
	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_BattleSCDataComp");
	}

	static BUS_BattleSCDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_BattleSCDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_BattleSCDataComp));
	}
}

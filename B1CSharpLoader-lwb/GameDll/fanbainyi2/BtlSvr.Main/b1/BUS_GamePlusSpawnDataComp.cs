using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_GamePlusSpawnDataComp")]
internal class BUS_GamePlusSpawnDataComp : BUS_FlowDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BUC_GamePlusSpawnData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_GamePlusSpawnDataComp");
	}

	static BUS_GamePlusSpawnDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_GamePlusSpawnDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_GamePlusSpawnDataComp));
	}
}

using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_DynamicObstacleDataComp")]
internal class BUS_DynamicObstacleDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<b1.BUC_DynamicObstacleConfigData>();
		CreateDataClass<BUC_FlowGeneralData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_DynamicObstacleDataComp");
	}

	static BUS_DynamicObstacleDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_DynamicObstacleDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_DynamicObstacleDataComp));
	}
}

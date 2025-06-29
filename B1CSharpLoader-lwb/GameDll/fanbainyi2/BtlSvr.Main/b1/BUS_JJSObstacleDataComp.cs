using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_JJSObstacleDataComp")]
internal class BUS_JJSObstacleDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BUC_JJSObstacleData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_JJSObstacleDataComp");
	}

	static BUS_JJSObstacleDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_JJSObstacleDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_JJSObstacleDataComp));
	}
}

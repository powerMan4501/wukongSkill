using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_SplineFlyMoveTriggerDataComp")]
public class BUS_SplineFlyMoveTriggerDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BUC_SplineFlyMoveTriggerData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_SplineFlyMoveTriggerDataComp");
	}

	static BUS_SplineFlyMoveTriggerDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_SplineFlyMoveTriggerDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_SplineFlyMoveTriggerDataComp));
	}
}

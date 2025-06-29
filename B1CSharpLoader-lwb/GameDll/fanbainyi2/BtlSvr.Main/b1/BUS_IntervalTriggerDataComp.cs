using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_IntervalTriggerDataComp")]
public class BUS_IntervalTriggerDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BUC_IntervalTriggerData>();
		CreateDataClass<b1.BUC_GateStateMachineData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_IntervalTriggerDataComp");
	}

	static BUS_IntervalTriggerDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_IntervalTriggerDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_IntervalTriggerDataComp));
	}
}

using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_IntervalTriggerAreaDataComp")]
public class BUS_IntervalTriggerAreaDataComp : BUS_AreaBaseDataContainer
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BUC_IntervalTriggerLogicData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_IntervalTriggerAreaDataComp");
	}

	static BUS_IntervalTriggerAreaDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_IntervalTriggerAreaDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_IntervalTriggerAreaDataComp));
	}
}

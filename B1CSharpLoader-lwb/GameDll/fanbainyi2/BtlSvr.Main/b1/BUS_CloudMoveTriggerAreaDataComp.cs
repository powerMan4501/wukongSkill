using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_CloudMoveTriggerAreaDataComp")]
public class BUS_CloudMoveTriggerAreaDataComp : BUS_AreaBaseDataContainer
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BUC_CloudMoveTriggerAreaData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_CloudMoveTriggerAreaDataComp");
	}

	static BUS_CloudMoveTriggerAreaDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_CloudMoveTriggerAreaDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_CloudMoveTriggerAreaDataComp));
	}
}

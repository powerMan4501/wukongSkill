using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_BGMAreaDataComp")]
public class BUS_BGMAreaDataComp : BUS_AreaBaseDataContainer
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<b1.BUC_BGMAreaData>();
		CreateDataClass<BUC_IntervalTriggerData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_BGMAreaDataComp");
	}

	static BUS_BGMAreaDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_BGMAreaDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_BGMAreaDataComp));
	}
}

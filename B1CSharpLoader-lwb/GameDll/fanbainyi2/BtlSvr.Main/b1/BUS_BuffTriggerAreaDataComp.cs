using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_BuffTriggerAreaDataComp")]
public class BUS_BuffTriggerAreaDataComp : BUS_AreaBaseDataContainer
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<b1.BUC_BuffTriggerLogicData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_BuffTriggerAreaDataComp");
	}

	static BUS_BuffTriggerAreaDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_BuffTriggerAreaDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_BuffTriggerAreaDataComp));
	}
}

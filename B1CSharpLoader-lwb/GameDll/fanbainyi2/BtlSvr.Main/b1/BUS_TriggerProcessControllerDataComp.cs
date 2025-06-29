using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_TriggerProcessControllerDataComp")]
internal class BUS_TriggerProcessControllerDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<b1.BUC_TriggerProcessControllerData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_TriggerProcessControllerDataComp");
	}

	static BUS_TriggerProcessControllerDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_TriggerProcessControllerDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_TriggerProcessControllerDataComp));
	}
}

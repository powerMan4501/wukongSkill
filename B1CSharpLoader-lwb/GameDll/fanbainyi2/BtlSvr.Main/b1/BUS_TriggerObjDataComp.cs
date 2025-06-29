using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_TriggerObjDataComp")]
internal class BUS_TriggerObjDataComp : BUS_InteractiveActorDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<b1.BUC_TriggerData>();
		CreateDataClass<BUC_FlowGeneralData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_TriggerObjDataComp");
	}

	static BUS_TriggerObjDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_TriggerObjDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_TriggerObjDataComp));
	}
}

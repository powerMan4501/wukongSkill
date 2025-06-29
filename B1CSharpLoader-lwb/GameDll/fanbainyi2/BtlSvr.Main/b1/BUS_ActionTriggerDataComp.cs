using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_ActionTriggerDataComp")]
internal class BUS_ActionTriggerDataComp : b1.BUS_TriggerBoxDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<b1.BUC_ActionTriggerData>();
		CreateDataClass<b1.BUC_ActionTriggerConfigData>();
		CreateDataClass<BUC_FlowGeneralData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_ActionTriggerDataComp");
	}

	static BUS_ActionTriggerDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_ActionTriggerDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_ActionTriggerDataComp));
	}
}

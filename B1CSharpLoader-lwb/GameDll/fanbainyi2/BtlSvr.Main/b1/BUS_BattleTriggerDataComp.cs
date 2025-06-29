using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_BattleTriggerDataComp")]
public class BUS_BattleTriggerDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<b1.BUC_BattleTriggerData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_BattleTriggerDataComp");
	}

	static BUS_BattleTriggerDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_BattleTriggerDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_BattleTriggerDataComp));
	}
}

using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_RideControlTriggerDataComp")]
public class BUS_RideControlTriggerDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<b1.BUC_RideControlTriggerData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_RideControlTriggerDataComp");
	}

	static BUS_RideControlTriggerDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_RideControlTriggerDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_RideControlTriggerDataComp));
	}
}

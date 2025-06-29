using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_RebirthPointDataComp")]
internal class BUS_RebirthPointDataComp : BUS_InteractiveActorDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BUC_RebirthPointData>();
		CreateDataClass<BUC_FlowGeneralData>();
		if (BasicData != null)
		{
			BasicData.ActorType = BGU_ActorType.RebirthPoint;
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_RebirthPointDataComp");
	}

	static BUS_RebirthPointDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_RebirthPointDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_RebirthPointDataComp));
	}
}

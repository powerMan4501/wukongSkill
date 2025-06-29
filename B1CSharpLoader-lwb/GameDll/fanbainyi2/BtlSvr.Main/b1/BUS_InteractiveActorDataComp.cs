using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_InteractiveActorDataComp")]
public class BUS_InteractiveActorDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BUC_InteractData>();
		CreateDataClass<BUC_FlowGeneralData>();
		CreateDataClass<BUC_AnimationSyncHostData>();
		CreateDataClass<BUC_AnimationSyncGuestData>();
		CreateDataClass<BUC_AKMgrData>();
		CreateDataClass<BUC_TickRateData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_InteractiveActorDataComp");
	}

	static BUS_InteractiveActorDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_InteractiveActorDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_InteractiveActorDataComp));
	}
}

using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_DroppableDestructionDataComp")]
public class BUS_DroppableDestructionDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BUC_InteractData>();
		CreateDataClass<BUC_FlowGeneralData>();
		CreateDataClass<BUC_AnimationSyncHostData>();
		CreateDataClass<BUC_AnimationSyncGuestData>();
		CreateDataClass<BUC_AKMgrData>();
		CreateDataClass<b1.BUC_DestructibleData>();
		CreateDataClass<BUC_FXActorAudioData>();
		CreateDataClass<BUC_TickRateData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_DroppableDestructionDataComp");
	}

	static BUS_DroppableDestructionDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_DroppableDestructionDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_DroppableDestructionDataComp));
	}
}

using System;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_CloudMoveRestrictAreaLogicComp")]
public class BUS_CloudMoveRestrictAreaLogicComp : UActorCompBaseUObj
{
	private BUC_CloudMoveRestrictAreaData CloudMoveRestrictAreaData;

	public override void OnAttach()
	{
		CloudMoveRestrictAreaData = RequireWritableData<BUC_CloudMoveRestrictAreaData>();
		base.BUSEventCollection.Evt_OnActorEnterArea += new Del_Void_Actor(OnActorEnter);
		base.BUSEventCollection.Evt_OnActorLeaveArea += new Del_Void_Actor(OnActorLeave);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
	}

	private void OnActorEnter(AActor OtherActor)
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(OtherActor);
		if (!(bUS_GSEventCollection == null))
		{
			switch (CloudMoveRestrictAreaData.CloudMoveRestrictType)
			{
			case EGSCloudMoveRestrictType.ForbidEnableCloudMove:
				bUS_GSEventCollection.Evt_SetForbidEnableCloudMove.Invoke(P1: true);
				break;
			case EGSCloudMoveRestrictType.ForbidDisableCloudMove:
				bUS_GSEventCollection.Evt_SetForbidDisableCloudMove.Invoke(P1: true);
				break;
			}
		}
	}

	private void OnActorLeave(AActor OtherActor)
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(OtherActor);
		if (!(bUS_GSEventCollection == null))
		{
			switch (CloudMoveRestrictAreaData.CloudMoveRestrictType)
			{
			case EGSCloudMoveRestrictType.ForbidEnableCloudMove:
				bUS_GSEventCollection.Evt_SetForbidEnableCloudMove.Invoke(P1: false);
				break;
			case EGSCloudMoveRestrictType.ForbidDisableCloudMove:
				bUS_GSEventCollection.Evt_SetForbidDisableCloudMove.Invoke(P1: false);
				break;
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_CloudMoveRestrictAreaLogicComp");
	}

	static BUS_CloudMoveRestrictAreaLogicComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_CloudMoveRestrictAreaLogicComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_CloudMoveRestrictAreaLogicComp));
	}
}

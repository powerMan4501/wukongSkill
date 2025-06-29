using System;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_CloudMoveTriggerAreaLogicComp")]
public class BUS_CloudMoveTriggerAreaLogicComp : UActorCompBaseUObj
{
	private BUC_CloudMoveTriggerAreaData CloudMoveTriggerAreaData;

	private IBUC_GuidData GuidData;

	private b1.IBUC_AreaBasicData AreaBasicData;

	public override void OnAttach()
	{
		CloudMoveTriggerAreaData = RequireWritableData<BUC_CloudMoveTriggerAreaData>();
		GuidData = RequireReadOnlyData<IBUC_GuidData, BUC_GuidData>();
		AreaBasicData = RequireReadOnlyData<b1.IBUC_AreaBasicData, BUC_AreaBasicData>();
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		UpdateAreaTriggerEvent();
		UpdateDelayTriggerEnterEvent(DeltaTime);
	}

	private void HandleTriggerLogic(bool bEnter)
	{
		if (bEnter)
		{
			if (CloudMoveTriggerAreaData.PreCoolDown <= 1E-08f)
			{
				base.BGWEventCollection.Evt_BGS_PlayerEnterOverlap(GuidData.GetFinalGuid());
				return;
			}
			CloudMoveTriggerAreaData.bIsInPendingTrigger = true;
			CloudMoveTriggerAreaData.DelayTriggerTimer = 0f;
		}
		else
		{
			base.BGWEventCollection.Evt_BGS_PlayerLeaveOverlap(GuidData.GetFinalGuid());
			CloudMoveTriggerAreaData.bIsInPendingTrigger = false;
		}
	}

	private void UpdateDelayTriggerEnterEvent(float DeltaTime)
	{
		if (CloudMoveTriggerAreaData.bIsInPendingTrigger)
		{
			CloudMoveTriggerAreaData.DelayTriggerTimer += DeltaTime;
			if (CloudMoveTriggerAreaData.DelayTriggerTimer >= CloudMoveTriggerAreaData.PreCoolDown)
			{
				CloudMoveTriggerAreaData.bIsInPendingTrigger = false;
				base.BGWEventCollection.Evt_BGS_PlayerEnterOverlap(GuidData.GetFinalGuid());
			}
		}
	}

	private void UpdateInnerActorState()
	{
		CloudMoveTriggerAreaData.InCloudMove_PlayerCount = 0;
		foreach (Entity innerEntity in AreaBasicData.InnerEntityList)
		{
			BUC_SimpleStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_SimpleStateData>(innerEntity);
			if (readOnlyData != null && readOnlyData.HasSimpleState(EBGUSimpleState.CloudMove))
			{
				CloudMoveTriggerAreaData.InCloudMove_PlayerCount++;
			}
		}
	}

	private void UpdateAreaTriggerEvent()
	{
		if (!CloudMoveTriggerAreaData.bActive)
		{
			if (AreaBasicData.InnerEntityList.Count > 0)
			{
				UpdateInnerActorState();
				if (CloudMoveTriggerAreaData.InCloudMove_PlayerCount == 0)
				{
					CloudMoveTriggerAreaData.bActive = true;
					HandleTriggerLogic(bEnter: true);
				}
			}
		}
		else
		{
			UpdateInnerActorState();
			if ((AreaBasicData.InnerEntityList.Count > 0 && AreaBasicData.InnerEntityList.Count == CloudMoveTriggerAreaData.InCloudMove_PlayerCount) || AreaBasicData.InnerEntityList.Count < 1)
			{
				CloudMoveTriggerAreaData.bActive = false;
				HandleTriggerLogic(bEnter: false);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_CloudMoveTriggerAreaLogicComp");
	}

	static BUS_CloudMoveTriggerAreaLogicComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_CloudMoveTriggerAreaLogicComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_CloudMoveTriggerAreaLogicComp));
	}
}

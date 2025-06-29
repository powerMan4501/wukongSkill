using System;
using b1.EventDelDefine;
using UnrealEngine.Engine;

namespace b1;

public class BUS_TimeScaleComp : UActorCompBaseCS
{
	private BUC_TimeScaleData TimeScaleData;

	private IBUC_PropMgrData PropMgrData;

	private IBIC_BossRushBattleData BossRushBattleData;

	public override void OnAttach()
	{
		TimeScaleData = RequireWritableData<BUC_TimeScaleData>();
		PropMgrData = RequireReadOnlyData<IBUC_PropMgrData, BUC_PropMgrData>();
		BossRushBattleData = RequireReadonlyGameInstanceData<IBIC_BossRushBattleData, BIC_BossRushBattleData>();
		base.BUSEventCollection.Evt_TriggerScaleTime += new Del_ScaleTime(OnTriggerScaleTime);
		base.BUSEventCollection.Evt_NotifyTransitFromUnit += new Del_Void_Actor(OnTransitFromUnit);
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_StopAllTimeDilation = (Del_Void)Delegate.Combine(bGWEventCollection.Evt_StopAllTimeDilation, new Del_Void(StopAllTimeDilation));
	}

	public override int GetTickGroupMask()
	{
		return 1;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		TickForScaleTime(DeltaTime);
	}

	private void TickForScaleTime(float DeltaTime)
	{
		if (!TimeScaleData.IsDuringTimeScale)
		{
			return;
		}
		float realTimeSeconds = UGameplayStatics.GetRealTimeSeconds(Owner);
		TimeScaleData.PassedDuration += DeltaTime;
		float num = 0f;
		float num2 = TimeScaleData.TimeScaleSetting.TimeScale;
		float num3 = realTimeSeconds - TimeScaleData.RealTimeStart;
		if (TimeScaleData.PassedDuration >= TimeScaleData.TotalDuration)
		{
			if (TimeScaleData.RealTimeOutStart == 0f)
			{
				TimeScaleData.RealTimeOutStart = realTimeSeconds;
			}
			num = ((TimeScaleData.TimeScaleSetting.BlendOutRealTime != 0f) ? ((realTimeSeconds - TimeScaleData.RealTimeOutStart) / TimeScaleData.TimeScaleSetting.BlendOutRealTime) : 1f);
			if (num >= 1f)
			{
				FinishLastTimeScaleTask();
				return;
			}
			num2 = UBUS_UtilComm.GSEase(TimeScaleData.GlobalNormalScale, TimeScaleData.TimeScaleSetting.TimeScale, num, TimeScaleData.TimeScaleSetting.BlendOutType, TimeScaleData.TimeScaleSetting.BlendOutExp);
		}
		else if (num3 <= TimeScaleData.TimeScaleSetting.BlendInRealTime)
		{
			num2 = UBUS_UtilComm.GSEase(Alpha: (TimeScaleData.TimeScaleSetting.BlendInRealTime != 0f) ? (num3 / TimeScaleData.TimeScaleSetting.BlendInRealTime) : 1f, Start: TimeScaleData.GlobalNormalScale, End: TimeScaleData.TimeScaleSetting.TimeScale, GSBlendTypeG: TimeScaleData.TimeScaleSetting.BlendInType, EaseExp: TimeScaleData.TimeScaleSetting.BlendInExp);
		}
		UGameplayStatics.SetGlobalTimeDilation(Owner, num2);
		if (TimeScaleData.TimeScaleSetting.ExceptSelf && num2 > 0f)
		{
			float value = 1f / num2;
			if (TimeScaleData.LastLocalTimeScaleHandleID == 0)
			{
				base.BUSEventCollection.Evt_SetFloatProperty.Invoke(EPropType.Actor_CustomTimeDilation, value);
				TimeScaleData.LastLocalTimeScaleHandleID = PropMgrData.GetLastHandleID();
			}
			else
			{
				base.BUSEventCollection.Evt_SetFloatProperty.Invoke(EPropType.Actor_CustomTimeDilation, value, TimeScaleData.LastLocalTimeScaleHandleID);
			}
		}
	}

	private void OnTriggerScaleTime(FGSTimeScaleSetting TimeScaleSetting, float Duration)
	{
		if (UGSE_EngineFuncLib.IsStandAlone(Owner.World) && (!B1Global.GIsBossRushMode || !BossRushBattleData.IsInSlowTime()))
		{
			FinishLastTimeScaleTask();
			if (!TimeScaleData.IsDuringTimeScale)
			{
				TimeScaleData.GlobalNormalScale = UGameplayStatics.GetGlobalTimeDilation(Owner);
			}
			TimeScaleData.TimeScaleSetting = TimeScaleSetting;
			TimeScaleData.PassedDuration = 0f;
			TimeScaleData.TotalDuration = Duration;
			TimeScaleData.IsDuringTimeScale = true;
			TimeScaleData.RealTimeStart = UGameplayStatics.GetRealTimeSeconds(Owner);
		}
	}

	private void OnTransitFromUnit(AActor FromUnit)
	{
		IBUC_TimeScaleData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_TimeScaleData, BUC_TimeScaleData>(FromUnit);
		TimeScaleData.CopyData(unPersistentReadOnlyData);
	}

	private void FinishLastTimeScaleTask()
	{
		if (TimeScaleData.IsDuringTimeScale)
		{
			UGameplayStatics.SetGlobalTimeDilation(Owner, TimeScaleData.GlobalNormalScale);
			if (TimeScaleData.TimeScaleSetting.ExceptSelf)
			{
				base.BUSEventCollection.Evt_ResetProperty.Invoke(TimeScaleData.LastLocalTimeScaleHandleID);
			}
			TimeScaleData.Reset();
		}
	}

	private void StopAllTimeDilation()
	{
		FinishLastTimeScaleTask();
	}
}

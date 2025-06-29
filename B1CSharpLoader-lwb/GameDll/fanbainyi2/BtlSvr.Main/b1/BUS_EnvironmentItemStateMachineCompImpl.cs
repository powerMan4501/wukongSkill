using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
public class BUS_EnvironmentItemStateMachineCompImpl : BUS_QuestOverlapComponent
{
	private b1.BUC_EnvironmentItemStateMachineData EnvironmentItemStateMachineData;

	private bool bStartTick;

	public override void OnAttach()
	{
		base.OnAttach();
		EnvironmentItemStateMachineData = RequireWritableData<b1.BUC_EnvironmentItemStateMachineData>();
		base.BGSEventCollection.Evt_BGS_NotifySwitchTarget += new Del_BGS_NotifySwitchTarget(OnNotifySwitchTarget);
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		base.BGSEventCollection.Evt_BGS_NotifySwitchTarget -= new Del_BGS_NotifySwitchTarget(OnNotifySwitchTarget);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		base.OnTickWithGroup(DeltaTime, TickGroup);
		BGUEnvironmentItemStateMachineActor bGUEnvironmentItemStateMachineActor = base.Owner as BGUEnvironmentItemStateMachineActor;
		if (!(bGUEnvironmentItemStateMachineActor == null) && bStartTick && (!UGSE_OverlapFuncLib.BoxOverlapActorsByProfile(base.Owner, BGUFuncLibActorTransformCS.BGUGetActorLocation(base.Owner), bGUEnvironmentItemStateMachineActor.TriggerBox.GetScaledBoxExtent() + new FVector(EnvironmentItemStateMachineData.TriggerRange), bGUEnvironmentItemStateMachineActor.TriggerBox.GetCollisionProfileName(), null, null, out var OutActors) || !OutActors.Contains(EnvironmentItemStateMachineData.RealEndOverlapActor)))
		{
			bGUEnvironmentItemStateMachineActor.OnCollisionEndOverlap(EnvironmentItemStateMachineData.RealEndOverlapActor);
			bStartTick = false;
			if (EnvironmentItemStateMachineData.bCanTriggerRepeatedly)
			{
				EnvironmentItemStateMachineData.bHasTriggered = false;
			}
		}
	}

	protected override void OnReset()
	{
		base.OnReset();
		EnvironmentItemStateMachineData.bHasTriggered = false;
		bStartTick = false;
		EnvironmentItemStateMachineData.BeginOverlapActor = null;
		EnvironmentItemStateMachineData.RealEndOverlapActor = null;
		EnvironmentItemStateMachineData.SwitchFromActor = null;
		EnvironmentItemStateMachineData.SwitchToActor = null;
		BGUEnvironmentItemStateMachineActor bGUEnvironmentItemStateMachineActor = base.Owner as BGUEnvironmentItemStateMachineActor;
		if (!(bGUEnvironmentItemStateMachineActor == null))
		{
			bGUEnvironmentItemStateMachineActor.OnGSReset();
		}
	}

	protected override void OnResetToOverlapEnable()
	{
		base.OnResetToOverlapEnable();
		BGUEnvironmentItemStateMachineActor bGUEnvironmentItemStateMachineActor = base.Owner as BGUEnvironmentItemStateMachineActor;
		if (!(bGUEnvironmentItemStateMachineActor == null))
		{
			bGUEnvironmentItemStateMachineActor.OnResetToOverlapEnable();
		}
	}

	protected override void OnResetToOverlapDisable()
	{
		base.OnResetToOverlapEnable();
		BGUEnvironmentItemStateMachineActor bGUEnvironmentItemStateMachineActor = base.Owner as BGUEnvironmentItemStateMachineActor;
		if (!(bGUEnvironmentItemStateMachineActor == null))
		{
			bGUEnvironmentItemStateMachineActor.OnResetToOverlapDisable();
		}
	}

	protected override void OnEnableOverlap()
	{
		base.OnEnableOverlap();
		BGUEnvironmentItemStateMachineActor bGUEnvironmentItemStateMachineActor = base.Owner as BGUEnvironmentItemStateMachineActor;
		if (!(bGUEnvironmentItemStateMachineActor == null))
		{
			bGUEnvironmentItemStateMachineActor.OnEnableOverlap();
		}
	}

	protected override void OnDisableOverlap()
	{
		base.OnDisableOverlap();
		BGUEnvironmentItemStateMachineActor bGUEnvironmentItemStateMachineActor = base.Owner as BGUEnvironmentItemStateMachineActor;
		if (!(bGUEnvironmentItemStateMachineActor == null))
		{
			bGUEnvironmentItemStateMachineActor.OnDisableOverlap();
		}
	}

	private void OnNotifySwitchTarget(AActor Old, AActor New, bool TriggerTaunt, ETargetSourceType TargetSourceType)
	{
		EnvironmentItemStateMachineData.SwitchFromActor = Old;
		EnvironmentItemStateMachineData.SwitchToActor = New;
	}

	protected override void OnCollisionBeginOverlap(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, FHitResult SweepResult)
	{
		if (!(OtherActor == null))
		{
			EnvironmentItemStateMachineData.BeginOverlapActor = OtherActor;
			WriteLog("OnCollisionBeginOverlap");
			NotifyGraph(BGW_FlowUtils.CommonTag.OverlapBegin);
			base.BGWEventCollection.Evt_BGS_PlayerEnterOverlap(base.GuidData.GetFinalGuid());
			OnCollisionBeginOverlapImpl(OverlappedComponent, OtherActor, OtherComp, OtherBodyIndex, bFromSweep, SweepResult);
			base.OverlapData.BeginOverlapAction?.Invoke(OverlappedComponent, OtherActor, OtherComp, OtherBodyIndex, bFromSweep, SweepResult);
		}
	}

	protected override void OnCollisionEndOverlap(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
	{
		if (!(OtherActor == null) && (!(EnvironmentItemStateMachineData.BeginOverlapActor == EnvironmentItemStateMachineData.SwitchToActor) || !(OtherActor == EnvironmentItemStateMachineData.SwitchFromActor)))
		{
			WriteLog("OnCollisionEndOverlap");
			NotifyGraph(BGW_FlowUtils.CommonTag.OverlapEnd);
			base.BGWEventCollection.Evt_BGS_PlayerLeaveOverlap(base.GuidData.GetFinalGuid());
			OnCollisionEndOverlapImpl(OverlappedComponent, OtherActor, OtherComp, OtherBodyIndex);
			base.OverlapData.EndOverlapAction?.Invoke(OverlappedComponent, OtherActor, OtherComp, OtherBodyIndex);
		}
	}

	protected override void OnCollisionBeginOverlapImpl(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, FHitResult SweepResult)
	{
		BGUEnvironmentItemStateMachineActor bGUEnvironmentItemStateMachineActor = base.Owner as BGUEnvironmentItemStateMachineActor;
		if (!(bGUEnvironmentItemStateMachineActor == null) && CanTriggerOverlap(OtherActor) && !EnvironmentItemStateMachineData.bHasTriggered)
		{
			bGUEnvironmentItemStateMachineActor.OnCollisionBeginOverlap(OtherActor);
			EnvironmentItemStateMachineData.bHasTriggered = true;
			bStartTick = false;
		}
	}

	protected override void OnCollisionEndOverlapImpl(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
	{
		if (!(base.Owner as BGUEnvironmentItemStateMachineActor == null) && CanTriggerOverlap(OtherActor))
		{
			bStartTick = true;
			EnvironmentItemStateMachineData.RealEndOverlapActor = OtherActor;
		}
	}

	private bool CanTriggerOverlap(AActor OtherActor)
	{
		if (!EnvironmentItemStateMachineData.bEnableBoxOverlapping)
		{
			return false;
		}
		switch (EnvironmentItemStateMachineData.TriggerUnitFilter)
		{
		case ETriggerUnitFilter.WuKongOnly:
			if (BGU_DataUtil.GetActorResID(OtherActor) != 10)
			{
				return false;
			}
			break;
		case ETriggerUnitFilter.WuKongTeam:
			if (BGU_DataUtil.GetActorTeamID(OtherActor) != 1)
			{
				return false;
			}
			if (IsActorInBlackList(OtherActor))
			{
				return false;
			}
			break;
		case ETriggerUnitFilter.SpecifiedResID:
			if (BGU_DataUtil.GetActorResID(OtherActor) != EnvironmentItemStateMachineData.SpecifiedResID)
			{
				return false;
			}
			break;
		case ETriggerUnitFilter.All:
			if (IsActorInBlackList(OtherActor))
			{
				return false;
			}
			break;
		}
		return true;
	}

	private bool IsActorInBlackList(AActor OtherActor)
	{
		int actorResID = BGU_DataUtil.GetActorResID(OtherActor);
		if (EnvironmentItemStateMachineData.ResIDBlackList.Contains(actorResID))
		{
			return true;
		}
		return false;
	}
}

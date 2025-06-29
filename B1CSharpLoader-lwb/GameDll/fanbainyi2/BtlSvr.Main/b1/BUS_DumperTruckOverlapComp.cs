using UnrealEngine.Engine;

namespace b1;

public class BUS_DumperTruckOverlapComp : BUS_QuestOverlapComponent
{
	private IBIC_StateMachineData StateMachineData { get; set; }

	private BUC_DumperTruckTriggerData DumperTruckTriggerData { get; set; }

	public override void OnAttach()
	{
		base.OnAttach();
		StateMachineData = RequireReadonlyGameInstanceData<IBIC_StateMachineData, BIC_StateMachineData>();
		DumperTruckTriggerData = RequireWritableData<BUC_DumperTruckTriggerData>();
	}

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
		RequireWritableData<BUC_QuestOverlapData>().bAutoEnableOverlap = true;
	}

	protected override void OnCollisionBeginOverlap(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, FHitResult SweepResult)
	{
		if (OtherActor == null)
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = OtherActor as BGUCharacterCS;
		if (bGUCharacterCS != null && bGUCharacterCS.IsPlayerControlled())
		{
			AActor actorByGuid = BGU_DataUtil.GetActorByGuid(base.Owner, DumperTruckTriggerData.UnitGuid);
			StateMachineData.GetCurrentSceneObjState(base.GuidData.GetFinalGuid(), out var GameplayTagContainerRef);
			if (actorByGuid != null && !GameplayTagContainerRef.HasTag(BGW_FlowUtils.DumperTruckTag.State_Activating) && !GameplayTagContainerRef.HasTag(BGW_FlowUtils.DumperTruckTag.State_Actived) && !GameplayTagContainerRef.HasTag(BGW_FlowUtils.DumperTruckTag.State_WaitWakeUp))
			{
				DumperTruckTriggerData.ControlledUnit = actorByGuid as ACharacter;
				BUS_EventCollectionCS.Get(actorByGuid).Evt_AICatchTarget.Invoke(OtherActor, ETargetSourceType.Target_AssignPlayerAsTarget);
				BUS_EventCollectionCS.Get(base.Owner).Evt_SceneObjTransitByEventNoSaveState.Invoke(BGW_FlowUtils.DumperTruckTag.Event_JumpToWakeUp);
				StateMachineData.GetCurrentSceneObjState(base.GuidData.GetFinalGuid(), out var _);
			}
			else if (actorByGuid != null && OverlappedComponent.GetName() == "EndBox" && !GameplayTagContainerRef.HasTag(BGW_FlowUtils.DumperTruckTag.State_Actived) && !GameplayTagContainerRef.HasTag(BGW_FlowUtils.DumperTruckTag.State_InActived) && !GameplayTagContainerRef.HasTag(BGW_FlowUtils.DumperTruckTag.State_WaitWakeUp))
			{
				BUS_EventCollectionCS.Get(base.Owner).Evt_SceneObjDirectJumpToState.Invoke(BGW_FlowUtils.DumperTruckTag.State_Actived);
			}
		}
	}
}

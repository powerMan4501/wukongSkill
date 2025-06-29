using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_PerformerControlComp : BUS_StateMachineCompBase
{
	public class EnableState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.DynamicObstacleTag.State_Enabled;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.DynamicObstacleTag.Event_Disable, BGW_FlowUtils.DynamicObstacleTag.State_Disabled);
			base.EventTransitDictionary.Add(BGW_FlowUtils.SceneObjCommonEventTag.Next, BGW_FlowUtils.DynamicObstacleTag.State_Disabled);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is BUS_PerformerControlComp bUS_PerformerControlComp)
			{
				bUS_PerformerControlComp.ClosePerformerControl();
			}
		}
	}

	public class DisableState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.DynamicObstacleTag.State_Disabled;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.DynamicObstacleTag.Event_Enable, BGW_FlowUtils.DynamicObstacleTag.State_Enabled);
			base.EventTransitDictionary.Add(BGW_FlowUtils.SceneObjCommonEventTag.Next, BGW_FlowUtils.DynamicObstacleTag.State_Enabled);
			base.ReactionDictionary.Add(BGW_FlowUtils.DynamicObstacleTag.Event_Disable, OnEnterAction);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is BUS_PerformerControlComp bUS_PerformerControlComp)
			{
				bUS_PerformerControlComp.OpenPerformerControl();
			}
		}
	}

	private BUC_PerformerControlData ControlData { get; set; }

	private IBIC_TaskData TaskData { get; set; }

	public override void OnAttach()
	{
		base.OnAttach();
		base.SceneObjTag = BGW_FlowUtils.SceneObjTag.DynamicObstacle;
		GSStateBase initialState = AddState(typeof(EnableState), 1);
		AddState(typeof(DisableState), 0);
		base.InitialState = initialState;
		ControlData = RequireWritableData<BUC_PerformerControlData>();
		TaskData = RequireReadonlyGameInstanceData<IBIC_TaskData, BIC_TaskData>();
	}

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
		TryBeginPerformerControl();
	}

	private void TryBeginPerformerControl()
	{
		bool flag = true;
		foreach (UPerformerParamBase item in ControlData.Params)
		{
			if (item.ParamType == EPerformerParamType.Performer && item is UPerformerParam_Performer uPerformerParam_Performer && BGU_DataUtil.GetActorByGuid(base.Owner, uPerformerParam_Performer.PerformerGuid) as BGUPerformerActorCS == null)
			{
				flag = false;
			}
		}
		ControlData.bAllPerformerReady = flag;
		if (!flag)
		{
			return;
		}
		ControlData.ParamGuidDictionary.Clear();
		foreach (UPerformerParamBase item2 in ControlData.Params)
		{
			if (item2 == null)
			{
				continue;
			}
			if (item2.ParamType == EPerformerParamType.Performer && item2 is UPerformerParam_Performer uPerformerParam_Performer2)
			{
				BGUPerformerActorCS bGUPerformerActorCS = BGU_DataUtil.GetActorByGuid(base.Owner, uPerformerParam_Performer2.PerformerGuid) as BGUPerformerActorCS;
				if (bGUPerformerActorCS != null)
				{
					bGUPerformerActorCS.SetOptimizeEnabled(bEnable: false);
					if (!bGUPerformerActorCS.ActorHasTag(B1GlobalFNames.SkipSeqControl))
					{
						bGUPerformerActorCS.Tags.Add(B1GlobalFNames.SkipSeqControl);
					}
					UAnimInstance uAnimInstance = bGUPerformerActorCS.Mesh?.GetAnimInstance();
					if (uAnimInstance != null)
					{
						uAnimInstance.Montage_Stop(0f, null);
					}
				}
			}
			ControlData.ParamGuidDictionary[GameplayTagExtension.ConvertToGuid(item2.ConfigGuid)] = item2.GetActorGuid();
		}
		foreach (UPerformerPhase phase in ControlData.Phases)
		{
			phase.SetOwnerComp(this);
		}
		TriggerEnterPhase(0);
	}

	private void TryEndPerformerControl()
	{
		bool flag = true;
		foreach (UPerformerParamBase item in ControlData.Params)
		{
			if (item.ParamType == EPerformerParamType.Performer && item is UPerformerParam_Performer uPerformerParam_Performer && BGU_DataUtil.GetActorByGuid(base.Owner, uPerformerParam_Performer.PerformerGuid) as BGUPerformerActorCS == null)
			{
				flag = false;
			}
		}
		ControlData.bAllPerformerReady = flag;
		if (!flag)
		{
			return;
		}
		foreach (UPerformerParamBase item2 in ControlData.Params)
		{
			if (item2 == null || item2.ParamType != EPerformerParamType.Performer || !(item2 is UPerformerParam_Performer uPerformerParam_Performer2))
			{
				continue;
			}
			BGUPerformerActorCS bGUPerformerActorCS = BGU_DataUtil.GetActorByGuid(base.Owner, uPerformerParam_Performer2.PerformerGuid) as BGUPerformerActorCS;
			if (bGUPerformerActorCS != null)
			{
				if (bGUPerformerActorCS.ActorHasTag(B1GlobalFNames.SkipSeqControl))
				{
					bGUPerformerActorCS.Tags.Remove(B1GlobalFNames.SkipSeqControl);
				}
				bGUPerformerActorCS.SetOptimizeEnabled(bEnable: true);
				bGUPerformerActorCS.SetActorHiddenInGame(bNewHidden: true);
			}
		}
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (ControlData.bEnableControlPhase)
		{
			if (!ControlData.bAllPerformerReady)
			{
				TryBeginPerformerControl();
				return;
			}
			int num = ControlData.Phases.Count - 1;
			int currentPhaseIndex = ControlData.CurrentPhaseIndex;
			if (currentPhaseIndex >= 0 && currentPhaseIndex <= num)
			{
				UPerformerPhase uPerformerPhase = ControlData.Phases[currentPhaseIndex];
				uPerformerPhase.Tick(DeltaTime);
				if (currentPhaseIndex < num && uPerformerPhase.CanTriggerNext())
				{
					uPerformerPhase.ExitPhase();
					TriggerEnterPhase(currentPhaseIndex + 1);
				}
			}
		}
		else if (!ControlData.bAllPerformerReady)
		{
			TryEndPerformerControl();
		}
	}

	private void TriggerEnterPhase(int Index)
	{
		if (ControlData.Phases.Count > Index)
		{
			ControlData.Phases[Index].EnterPhase();
			ControlData.CurrentPhaseIndex = Index;
		}
	}

	private void OpenPerformerControl()
	{
		ControlData.bEnableControlPhase = true;
		ControlData.bAllPerformerReady = false;
	}

	private void ClosePerformerControl()
	{
		ControlData.bEnableControlPhase = false;
		ControlData.bAllPerformerReady = false;
	}

	public bool IsInnerOverlap(Guid InConfigGuid, out bool bInnerOverlap)
	{
		bInnerOverlap = false;
		if (ControlData.ParamGuidDictionary.TryGetValue(InConfigGuid, out var value))
		{
			return TaskData.IsPlayerInOverlap(value, out bInnerOverlap);
		}
		return false;
	}

	public bool GetParamActorGuid(Guid InConfigGuid, out string OutActorGuid)
	{
		if (ControlData.ParamGuidDictionary.TryGetValue(InConfigGuid, out OutActorGuid))
		{
			return true;
		}
		return false;
	}
}

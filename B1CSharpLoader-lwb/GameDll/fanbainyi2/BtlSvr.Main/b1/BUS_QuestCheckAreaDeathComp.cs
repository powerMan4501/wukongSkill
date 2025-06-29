using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_QuestCheckAreaDeathComp : BUS_StateMachineCompBase
{
	public class EnableState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.CheckerTag.State_Enabled;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.CheckerTag.Event_Disable, BGW_FlowUtils.CheckerTag.State_Disabled);
			base.EventTransitDictionary.Add(BGW_FlowUtils.SceneObjCommonEventTag.Next, BGW_FlowUtils.CheckerTag.State_Disabled);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is BUS_QuestCheckAreaDeathComp bUS_QuestCheckAreaDeathComp)
			{
				bUS_QuestCheckAreaDeathComp.EnableChecker();
			}
		}
	}

	public class DisableState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.CheckerTag.State_Disabled;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.CheckerTag.Event_Enable, BGW_FlowUtils.CheckerTag.State_Enabled);
			base.EventTransitDictionary.Add(BGW_FlowUtils.SceneObjCommonEventTag.Next, BGW_FlowUtils.CheckerTag.State_Enabled);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is BUS_QuestCheckAreaDeathComp bUS_QuestCheckAreaDeathComp)
			{
				bUS_QuestCheckAreaDeathComp.DisableChecker();
			}
		}
	}

	private UShapeComponent AreaShapeComponent { get; set; }

	private BUC_QuestCheckerData QuestCheckerData { get; set; }

	private IBIC_GlobalActorData GlobalActorData { get; set; }

	public override void OnAttach()
	{
		base.OnAttach();
		QuestCheckerData = RequireWritableData<BUC_QuestCheckerData>();
		QuestCheckerData.CheckedActors.Clear();
		base.SceneObjTag = BGW_FlowUtils.SceneObjTag.Checker;
		AddState(typeof(EnableState), 1);
		GSStateBase initialState = AddState(typeof(DisableState), 0);
		base.InitialState = initialState;
	}

	public override void OnBeginPlay()
	{
		AreaShapeComponent = base.Owner.GetComponentByClass<UShapeComponent>();
		base.OnBeginPlay();
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		base.OnTickWithGroup(DeltaTime, TickGroup);
		if (QuestCheckerData.CheckedActors.Count == 0)
		{
			RefreshCheckedActors();
			if (QuestCheckerData.CheckedActors.Count == 0)
			{
				DisableChecker();
				return;
			}
		}
		bool flag = true;
		foreach (AActor checkedActor in QuestCheckerData.CheckedActors)
		{
			string actorGuid = BGU_DataUtil.GetActorGuid(checkedActor);
			if (!GlobalActorData.HasActorAliveState(actorGuid) || GlobalActorData.GetActorAliveState(actorGuid))
			{
				flag = false;
				break;
			}
		}
		if (flag)
		{
			NotifyGraph(BGW_FlowUtils.CommonTag.AllDead);
			DisableChecker();
		}
	}

	private void EnableChecker()
	{
		QuestCheckerData.bEnableCheck = true;
		SetCanTick(Val: true);
	}

	private void RefreshCheckedActors()
	{
		BGUFuncLibActorTransformCS.BGUGetActorLocation(GetOwner());
		USphereComponent uSphereComponent = AreaShapeComponent as USphereComponent;
		UBoxComponent uBoxComponent = AreaShapeComponent as UBoxComponent;
		List<UPrimitiveComponent> OutOverlappingComponents = null;
		if (uSphereComponent != null)
		{
			uSphereComponent.GetOverlappingComponents(out OutOverlappingComponents);
		}
		else
		{
			if (!(uBoxComponent != null))
			{
				return;
			}
			uBoxComponent.GetOverlappingComponents(out OutOverlappingComponents);
		}
		foreach (UPrimitiveComponent item in OutOverlappingComponents)
		{
			BGUCharacterCS bGUCharacterCS = item.GetOwner() as BGUCharacterCS;
			if (!(bGUCharacterCS == null))
			{
				IBUC_ActorBasicData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_ActorBasicData>(bGUCharacterCS);
				if (readOnlyData != null && readOnlyData.ActorType == BGU_ActorType.CharacterAI)
				{
					QuestCheckerData.CheckedActors.Add(bGUCharacterCS);
				}
			}
		}
	}

	private void DisableChecker()
	{
		QuestCheckerData.CheckedActors.Clear();
		QuestCheckerData.bEnableCheck = false;
		SetCanTick(Val: false);
	}
}

using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_QuestCheckOnlinePlayerComp : BUS_StateMachineCompBase
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
			if (InOwner is BUS_QuestCheckOnlinePlayerComp bUS_QuestCheckOnlinePlayerComp)
			{
				bUS_QuestCheckOnlinePlayerComp.EnableChecker();
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
			if (InOwner is BUS_QuestCheckOnlinePlayerComp bUS_QuestCheckOnlinePlayerComp)
			{
				bUS_QuestCheckOnlinePlayerComp.DisableChecker();
			}
		}
	}

	private UShapeComponent AreaShapeComponent { get; set; }

	private BUC_QuestPlayerCheckerData QuestCheckerData { get; set; }

	public override void OnAttach()
	{
		base.OnAttach();
		QuestCheckerData = RequireWritableData<BUC_QuestPlayerCheckerData>();
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
		RefreshCheckedActors();
	}

	public override bool AllowTRO()
	{
		return false;
	}

	public override float GetAccumulatedDeltaTime()
	{
		if (!HasBegunPlay())
		{
			return -1f;
		}
		return 0f;
	}

	private void EnableChecker()
	{
		QuestCheckerData.bEnableCheck = true;
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
		QuestCheckerData.CheckedActors.Clear();
		foreach (UPrimitiveComponent item in OutOverlappingComponents)
		{
			BGUCharacterCS bGUCharacterCS = item.GetOwner() as BGUCharacterCS;
			if (!(bGUCharacterCS == null) && bGUCharacterCS.IsPlayerControlled())
			{
				QuestCheckerData.CheckedActors.Add(bGUCharacterCS);
			}
		}
	}

	private void DisableChecker()
	{
		QuestCheckerData.CheckedActors.Clear();
		QuestCheckerData.bEnableCheck = false;
	}
}

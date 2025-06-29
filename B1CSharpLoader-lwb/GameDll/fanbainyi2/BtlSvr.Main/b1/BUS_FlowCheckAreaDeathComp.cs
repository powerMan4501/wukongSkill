using System;
using b1.CppExport;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_FlowCheckAreaDeathComp : BUS_QuestCompBase
{
	private UShapeComponent AreaShapeComponent { get; set; }

	private BUC_FlowCheckerData FlowCheckerData { get; set; }

	private IBIC_GlobalActorData GlobalActorData { get; set; }

	public override void OnAttach()
	{
		base.OnAttach();
		FlowCheckerData = RequireWritableData<BUC_FlowCheckerData>();
		GlobalActorData = RequireReadonlyGameInstanceData<IBIC_GlobalActorData, BIC_GlobalActorData>();
	}

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
		AreaShapeComponent = base.Owner.GetComponentByClass<UShapeComponent>();
		FlowCheckerData.CheckedActors.Clear();
	}

	protected override void NotifyFromGraph(GameplayTagContainerRef NotifyTags)
	{
		base.NotifyFromGraph(NotifyTags);
		if (NotifyTags.HasTag(BGW_FlowUtils.CommonTag.Enable) || NotifyTags.HasTag(BGW_FlowUtils.CheckerTag.Event_Enable))
		{
			EnableChecker();
		}
		if (NotifyTags.HasTag(BGW_FlowUtils.CommonTag.Disable) || NotifyTags.HasTag(BGW_FlowUtils.CheckerTag.Event_Disable))
		{
			DisableChecker();
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		base.OnTickWithGroup(DeltaTime, TickGroup);
		bool flag = true;
		foreach (AActor checkedActor in FlowCheckerData.CheckedActors)
		{
			string actorGuid = BGU_DataUtil.GetActorGuid(checkedActor);
			if (GlobalActorData.GetActorAliveState(actorGuid))
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
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(GetOwner());
		USphereComponent uSphereComponent = AreaShapeComponent as USphereComponent;
		UBoxComponent uBoxComponent = AreaShapeComponent as UBoxComponent;
		foreach (string actorDataKey in GlobalActorData.GetActorDataKeys())
		{
			AActor actorByGuid = BGU_DataUtil.GetActorByGuid(base.Owner, actorDataKey);
			if (actorByGuid == null || ((IBUC_ActorBasicData)BGU_DataUtil.GetReadOnlyData<BUC_ActorBasicData>(actorByGuid)).ActorType != BGU_ActorType.CharacterAI)
			{
				continue;
			}
			if (uSphereComponent != null)
			{
				float scaledSphereRadius = uSphereComponent.GetScaledSphereRadius();
				if (!(FVector.Dist(fVector, BGUFuncLibActorTransformCS.BGUGetActorLocation(actorByGuid)) > scaledSphereRadius))
				{
					FlowCheckerData.CheckedActors.Add(actorByGuid);
				}
			}
			else if (uBoxComponent != null)
			{
				FVector scaledBoxExtent = uBoxComponent.GetScaledBoxExtent();
				FVector fVector2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(actorByGuid) - fVector;
				if (!(Math.Abs(fVector2.X) > scaledBoxExtent.X) && !(Math.Abs(fVector2.Y) > scaledBoxExtent.Y))
				{
					FlowCheckerData.CheckedActors.Add(actorByGuid);
				}
			}
		}
		if (FlowCheckerData.CheckedActors.Count > 0)
		{
			FlowCheckerData.bEnableCheck = true;
			SetCanTick(Val: true);
		}
	}

	private void DisableChecker()
	{
		FlowCheckerData.CheckedActors.Clear();
		FlowCheckerData.bEnableCheck = false;
		SetCanTick(Val: false);
	}
}

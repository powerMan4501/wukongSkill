using CommB1;
using UnrealEngine.Engine;

namespace b1;

public class FGuardCondition_NPCReach : FGuardConditionBase
{
	public string NPCGuid { get; set; }

	public string ActorGuid { get; set; }

	private ENpcMoveType NpcMoveType { get; set; }

	private float MoveAcceptableRadius { get; set; }

	private IBIC_GlobalActorData GlobalActorData { get; set; }

	public override EGuardConditionType ConditionType => EGuardConditionType.NPCReach;

	protected override void Clean()
	{
		NPCGuid = "";
		ActorGuid = "";
		NpcMoveType = ENpcMoveType.Navigation;
		MoveAcceptableRadius = 0f;
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_Idle IdleCondition, PsmNodeInstance InPsmNodeInstance)
	{
		NPCGuid = InPsmNodeInstance.ParentInstance.ConvertParamID2StringParam(IdleCondition.NpcGuid);
		NpcMoveType = (ENpcMoveType)IdleCondition.NpcMoveType;
		ActorGuid = IdleCondition.ActorGuid;
		MoveAcceptableRadius = IdleCondition.MoveAcceptableRadius;
		return true;
	}

	protected override void Start()
	{
		GlobalActorData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_GlobalActorData, BIC_GlobalActorData>(base.Owner);
	}

	protected override void OnTick(float DeltaTime)
	{
		if (NpcMoveType == ENpcMoveType.Navigation)
		{
			if (GlobalActorData.GetActorEntity(NPCGuid, out var Entity) && GlobalActorData.GetActorEntity(ActorGuid, out var Entity2) && ECSExtension.ToActor(Entity).GetDistanceTo(ECSExtension.ToActor(Entity2)) <= MoveAcceptableRadius)
			{
				base.QueryState = EQueryState.QuerySuccess;
			}
		}
		else
		{
			if (!GlobalActorData.GetActorEntity(NPCGuid, out var Entity3) || !GlobalActorData.GetActorEntity(ActorGuid, out var Entity4))
			{
				return;
			}
			AActor aActor = ECSExtension.ToActor(Entity4);
			AActor aActor2 = ECSExtension.ToActor(Entity3);
			if (aActor2 != null || aActor != null)
			{
				USplineComponent componentByClass = aActor.GetComponentByClass<USplineComponent>();
				componentByClass.FindInputKeyClosestToWorldLocation(BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor2));
				componentByClass.GetNumberOfSplinePoints();
				if (componentByClass != null && componentByClass.FindInputKeyClosestToWorldLocation(BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor2)) >= (float)(componentByClass.GetNumberOfSplinePoints() - 1))
				{
					base.QueryState = EQueryState.QuerySuccess;
				}
			}
		}
	}
}

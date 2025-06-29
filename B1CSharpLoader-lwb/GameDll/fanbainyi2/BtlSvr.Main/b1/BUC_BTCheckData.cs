using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.NavigationSystem;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_BTCheckData : IBUC_BTCheckData, IPersistentECSData
{
	public bool HasInit;

	public PathLengthCache LengthCache = new PathLengthCache(100);

	public TWeakObject<BGUCharacterCS> Owner { get; set; }

	public IBUC_TargetInfoData TargetInfoData { get; set; }

	public IBUC_AttrContainer AttrContainer { get; set; }

	public IBUC_SimpleStateData SimpleStateData { get; set; }

	public IBUC_UnitStateData UnitStateData { get; set; }

	public IBUC_BuffData BuffData { get; set; }

	public IBUC_FsmData FsmData { get; set; }

	public IBUC_BeAttackData BeAttackData { get; set; }

	public IBUC_MasterData MasterData { get; set; }

	public IBUC_GuidData GuidData { get; set; }

	public IBUC_SkillInstsData SkillInstsData { get; set; }

	public IBUC_ActorTransformInfoData TransformInfoData { get; set; }

	public IBUC_SceneItemData SceneItemData { get; set; }

	public IBUC_AIData AIData { get; set; }

	public IBIC_GlobalActorData GlobalActorData { get; set; }

	public IBGC_CircusControlData TamerFamilyTreeData { get; set; }

	public IBGC_LocalPlayerSharedData LocalPlayerSharedData { get; set; }

	private static float ComputePathLength(AActor Owner, FVector StartPos, FVector EndPos)
	{
		if (UNavigationSystemV1.GetPathLength(Owner, StartPos, EndPos, out var PathLength, null, null) == ENavigationQueryResult.Success)
		{
			return PathLength;
		}
		return 0f;
	}

	public bool CheckForBTCondition(EBTConditionCheckType CheckType, IBTConditionCheck ICheckInfo)
	{
		if (!HasInit)
		{
			return false;
		}
		if (CheckType == EBTConditionCheckType.CheckDistance)
		{
			if (!TransformInfoData.GetNextUpdateLocation(out var OutLocation))
			{
				return false;
			}
			if (!(ICheckInfo is BTCondition_Distance bTCondition_Distance))
			{
				return false;
			}
			BGUCharacterCS bGUCharacterCS = Owner.Get();
			if (bGUCharacterCS == null)
			{
				return false;
			}
			AActor aActor = null;
			bool flag = false;
			bool flag2 = true;
			FVector fVector = OutLocation;
			switch (bTCondition_Distance.CheckTarget)
			{
			case EAICheckTarget.CurLockTarget:
				aActor = TargetInfoData.GetTargetInfo()?.LockTargetActor;
				break;
			case EAICheckTarget.CachedScencItem:
				aActor = SceneItemData.SceneItemCatch;
				break;
			case EAICheckTarget.FirstLocalPlayer:
				aActor = LocalPlayerSharedData.FirstLocalPlayerPawn;
				break;
			case EAICheckTarget.EQSTarget:
				aActor = AIData?.GetCurEQSTarget(bGUCharacterCS);
				break;
			}
			if (aActor != null)
			{
				float num = 0f;
				FVector fVector2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor);
				switch (bTCondition_Distance.CheckDistanceType)
				{
				case EAICheckDistanceType.LocationDistance:
					num = (fVector - fVector2).Size();
					break;
				case EAICheckDistanceType.ZDistance:
					num = fVector.Z - fVector2.Z;
					break;
				case EAICheckDistanceType.LocationDistanceXY:
					num = (fVector - fVector2).Size2D();
					break;
				case EAICheckDistanceType.NavigationDistance:
				{
					if (UNavigationSystemV1.GetPathLength(bGUCharacterCS, fVector2, fVector, out var PathLength, null, null) == ENavigationQueryResult.Success)
					{
						num = PathLength;
					}
					else
					{
						flag2 = false;
					}
					break;
				}
				}
				flag = ((!bTCondition_Distance.PreferCloser) ? (num >= bTCondition_Distance.Distance) : (num <= bTCondition_Distance.Distance));
			}
			return flag && flag2;
		}
		return false;
	}
}

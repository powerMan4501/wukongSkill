using CommB1;
using UnrealEngine.Engine;

namespace b1;

public class FGuardCondition_NpcActionFinished : FGuardConditionBase
{
	private string NPCGuid { get; set; }

	private int SkillId { get; set; }

	private bool IsSkillCasted { get; set; }

	private IBIC_GlobalActorData GlobalActorData { get; set; }

	public override EGuardConditionType ConditionType => EGuardConditionType.NpcActionFinished;

	protected override void Clean()
	{
		NPCGuid = "";
		SkillId = 0;
		IsSkillCasted = false;
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_Idle IdleCondition, PsmNodeInstance InPsmNodeInstance)
	{
		NPCGuid = InPsmNodeInstance.ParentInstance.ConvertParamID2StringParam(IdleCondition.NpcGuid);
		SkillId = IdleCondition.SkillId;
		IsSkillCasted = false;
		return true;
	}

	protected override void Start()
	{
		GlobalActorData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_GlobalActorData, BIC_GlobalActorData>(base.Owner);
	}

	protected override void OnTick(float DeltaTime)
	{
		if (!GlobalActorData.GetActorEntity(NPCGuid, out var Entity))
		{
			return;
		}
		AActor aActor = ECSExtension.ToActor(Entity);
		if (BGU_DataUtil.GetReadOnlyData<BUC_SkillInstsData>(aActor).CurrentCastingSkillID == SkillId)
		{
			if (!BGUFunctionLibraryCS.BGUHasUnitState(aActor, EBGUUnitState.Attacking))
			{
				base.QueryState = EQueryState.QuerySuccess;
			}
			else
			{
				IsSkillCasted = true;
			}
		}
		else if (IsSkillCasted)
		{
			base.QueryState = EQueryState.QuerySuccess;
		}
	}
}

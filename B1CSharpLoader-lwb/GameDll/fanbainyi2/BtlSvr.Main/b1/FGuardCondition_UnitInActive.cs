using b1.ECS;
using CommB1;

namespace b1;

public class FGuardCondition_UnitInActive : FGuardConditionBase
{
	private string UnitGuid { get; set; }

	private IBIC_GlobalActorData GlobalActorData { get; set; }

	public override EGuardConditionType ConditionType => EGuardConditionType.UnitInActive;

	protected override void Clean()
	{
		UnitGuid = "";
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_Idle IdleCondition, PsmNodeInstance InPsmNodeInstance)
	{
		UnitGuid = InPsmNodeInstance.ParentInstance.ConvertParamID2StringParam(IdleCondition.UnitGuid);
		return true;
	}

	protected override void Start()
	{
		GlobalActorData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_GlobalActorData, BIC_GlobalActorData>(base.Owner);
	}

	protected override void OnTick(float DeltaTime)
	{
		if (GlobalActorData.GetActorEntity(UnitGuid, out var Entity) && BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(ECSExtension.ToActor(Entity)).GetTargetInfo().LockTargetEntity == Entity.Null)
		{
			base.QueryState = EQueryState.QuerySuccess;
		}
	}
}

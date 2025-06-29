using CommB1;

namespace b1;

public class FGuardCondition_SequencePlayed : FGuardConditionBase
{
	private int SequenceId { get; set; }

	private IBIC_MovieData MovieData { get; set; }

	public override EGuardConditionType ConditionType => EGuardConditionType.SequencePlayed;

	protected override void Clean()
	{
		SequenceId = 0;
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_Group GroupCondition, PsmNodeInstance InPsmNodeInstance)
	{
		SequenceId = InPsmNodeInstance.ParentInstance.ConvertParamID2IntParam(GroupCondition.SequenceId);
		return true;
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_State StateCondition)
	{
		SequenceId = StateCondition.SequenceId;
		return true;
	}

	protected override void Start()
	{
		MovieData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_MovieData, BIC_MovieData>(base.Owner);
	}

	protected override void OnTick(float DeltaTime)
	{
		if (MovieData != null && MovieData.IsSequencePlayed(SequenceId))
		{
			base.QueryState = EQueryState.QuerySuccess;
		}
	}
}

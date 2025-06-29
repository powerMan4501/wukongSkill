using System.Collections.Generic;
using CommB1;

namespace b1;

public class FGuardCondition_UnitsDead : FGuardConditionBase
{
	private List<string> Units { get; } = new List<string>();

	private IBIC_GlobalActorData GlobalActorData { get; set; }

	public override EGuardConditionType ConditionType => EGuardConditionType.UnitsDead;

	protected override void Clean()
	{
		Units.Clear();
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_Battle BattleCondition, PsmNodeInstance InPsmNodeInstance)
	{
		foreach (string unit in BattleCondition.Units)
		{
			Units.Add(InPsmNodeInstance.ParentInstance.ConvertParamID2StringParam(unit));
		}
		return true;
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_Group GroupCondition, PsmNodeInstance InPsmNodeInstance)
	{
		foreach (string unit in GroupCondition.Units)
		{
			Units.Add(InPsmNodeInstance.ParentInstance.ConvertParamID2StringParam(unit));
		}
		return true;
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_State StateCondition)
	{
		foreach (string unit in StateCondition.Units)
		{
			Units.Add(unit);
		}
		return true;
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_Guide GuideCondition, PsmNodeInstance InPsmNodeInstance)
	{
		Units.Add(InPsmNodeInstance.ParentInstance.ConvertParamID2StringParam(GuideCondition.UnitGuid));
		return true;
	}

	protected override void Start()
	{
		GlobalActorData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_GlobalActorData, BIC_GlobalActorData>(base.Owner);
	}

	protected override void OnTick(float DeltaTime)
	{
		if (GlobalActorData == null)
		{
			return;
		}
		bool flag = true;
		foreach (string unit in Units)
		{
			if (GlobalActorData.GetActorAliveState(unit))
			{
				flag = false;
				break;
			}
		}
		if (flag)
		{
			base.QueryState = EQueryState.QuerySuccess;
		}
	}
}

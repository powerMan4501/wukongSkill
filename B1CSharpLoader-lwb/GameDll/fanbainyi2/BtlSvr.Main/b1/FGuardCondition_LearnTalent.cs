using System.Collections.Generic;
using b1.EventDelDefine;
using CommB1;
using UnrealEngine.Engine;

namespace b1;

public class FGuardCondition_LearnTalent : FGuardConditionBase
{
	private int TalentId;

	public override EGuardConditionType ConditionType => EGuardConditionType.LearnTalent;

	public override bool Initial(CalliopeCustom_TransitionCondition_Guide GuideCondition, PsmNodeInstance InPsmNodeInstance)
	{
		TalentId = GuideCondition.TalentId;
		return true;
	}

	protected override void Clean()
	{
	}

	protected override void Start()
	{
		BPS_EventCollectionCS.GetLocal(GetOwner()).Evt_Close_RoleMain += new Del_Void(OnCloseRoleMain);
	}

	protected override void OnPlayerControllerAttach()
	{
		BPS_EventCollectionCS.GetLocal(GetOwner()).Evt_Close_RoleMain += new Del_Void(OnCloseRoleMain);
	}

	protected override void Stop()
	{
		BPS_EventCollectionCS.GetLocal(GetOwner()).Evt_Close_RoleMain -= new Del_Void(OnCloseRoleMain);
	}

	private void OnCloseRoleMain()
	{
		IBPC_RoleBaseData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_RoleBaseData, BPC_RoleBaseData>(UGameplayStatics.GetPlayerState(GetOwner(), 0));
		if (readOnlyData == null || readOnlyData.TalenList == null)
		{
			return;
		}
		foreach (KeyValuePair<int, int> talen in readOnlyData.TalenList)
		{
			if (talen.Key == TalentId)
			{
				base.QueryState = EQueryState.QuerySuccess;
			}
		}
	}
}

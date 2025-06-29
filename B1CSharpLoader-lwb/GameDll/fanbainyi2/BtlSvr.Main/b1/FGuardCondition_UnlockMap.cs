using System.Linq;
using CommB1;
using ResB1;

namespace b1;

public class FGuardCondition_UnlockMap : FGuardConditionBase
{
	public override EGuardConditionType ConditionType => EGuardConditionType.UnlockMap;

	private ETransitionConditionType_Guide GuideType { get; set; }

	private BGW_GameLifeTimeMgr GameLifeTimeMgr { get; set; }

	public override bool Initial(CalliopeCustom_TransitionCondition_Guide GuideCondition, PsmNodeInstance InPsmNodeInstance)
	{
		GuideType = (ETransitionConditionType_Guide)GuideCondition.ConditionType;
		return true;
	}

	protected override void Start()
	{
		base.Start();
		if (GameLifeTimeMgr == null)
		{
			GameLifeTimeMgr = BGW_GameLifeTimeMgr.Get(base.Owner);
		}
	}

	protected override void OnTick(float DeltaTime)
	{
		if (!CheckNeedQuery())
		{
			return;
		}
		int? num = FGuardConditionBase.CommonData?.PlayerRoleData?.RoleData?.RoleCs?.Actor?.NewGamePlusCount;
		ReadOnlyQuestStageOneList readOnlyQuestStageOneList = FGuardConditionBase.CommonData?.PlayerRoleData?.RoleData?.RoleCs?.Task?.QuestList;
		if (!num.HasValue || readOnlyQuestStageOneList == null)
		{
			return;
		}
		bool flag = num.Value >= 2 || readOnlyQuestStageOneList.Any((ReadOnlyQuestStageOne Quest) => Quest.Id == 20101 && Quest.Stage == QuestStage.Finished);
		switch (GuideType)
		{
		case ETransitionConditionType_Guide.OldPlayerForUnlockMap:
			if (!flag)
			{
				break;
			}
			goto IL_0116;
		case ETransitionConditionType_Guide.NewPlayerForUnlockMap:
			{
				if (flag)
				{
					break;
				}
				goto IL_0116;
			}
			IL_0116:
			base.QueryState = EQueryState.QuerySuccess;
			break;
		}
		bool CheckNeedQuery()
		{
			if (base.QueryState == EQueryState.QueryFailure)
			{
				return false;
			}
			if (!GameLifeTimeMgr.IsInFSMState(SGI_Global.InBattleStandAlone))
			{
				return false;
			}
			if (FGuardConditionBase.CommonData.PlayerGuideData.IsGroupGuideCompleted(5001))
			{
				base.QueryState = EQueryState.QueryFailure;
				return false;
			}
			return true;
		}
	}

	protected override void Clean()
	{
	}
}

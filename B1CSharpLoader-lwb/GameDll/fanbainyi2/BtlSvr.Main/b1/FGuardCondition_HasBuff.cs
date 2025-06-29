using b1.ECS;
using CommB1;
using GurCalliopeState;
using UnrealEngine.Engine;

namespace b1;

public class FGuardCondition_HasBuff : FGuardConditionBase
{
	private string UnitGuid { get; set; }

	private int BuffId { get; set; }

	private IBIC_GlobalActorData GlobalActorData { get; set; }

	private CalliopeCustom_DetectCondition DetectConditionForHasBuff { get; set; }

	public override EGuardConditionType ConditionType => EGuardConditionType.HasBuff;

	protected override void Clean()
	{
		UnitGuid = "";
		BuffId = 0;
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_Battle BattleCondition, PsmNodeInstance InPsmNodeInstance)
	{
		BuffId = InPsmNodeInstance.ParentInstance.ConvertParamID2IntParam(BattleCondition.BuffId);
		if (BattleCondition.UnitGuid == B1GlobalFNames.Player_Wukong_String)
		{
			UnitGuid = B1GlobalFNames.Player_Wukong_String;
		}
		else
		{
			UnitGuid = InPsmNodeInstance.ParentInstance.ConvertParamID2StringParam(BattleCondition.UnitGuid);
		}
		return true;
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_Group GroupCondition, PsmNodeInstance InPsmNodeInstance)
	{
		BuffId = InPsmNodeInstance.ParentInstance.ConvertParamID2IntParam(GroupCondition.BuffId);
		if (GroupCondition.UnitGuid == B1GlobalFNames.Player_Wukong_String)
		{
			UnitGuid = B1GlobalFNames.Player_Wukong_String;
		}
		else
		{
			UnitGuid = InPsmNodeInstance.ParentInstance.ConvertParamID2StringParam(GroupCondition.UnitGuid);
		}
		return true;
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_State StateCondition)
	{
		BuffId = StateCondition.BuffId;
		if (StateCondition.UnitGuid == B1GlobalFNames.Player_Wukong.PlainName)
		{
			UnitGuid = B1GlobalFNames.Player_Wukong.PlainName;
		}
		else
		{
			UnitGuid = StateCondition.UnitGuid;
		}
		return true;
	}

	protected override void Start()
	{
		GlobalActorData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_GlobalActorData, BIC_GlobalActorData>(base.Owner);
		DetectConditionForHasBuff = new CalliopeCustom_DetectCondition
		{
			DetectedElementType = 3,
			HasBuff = new CalliopeCustom_DetectCondition_HasBuff
			{
				BuffId = BuffId
			}
		};
	}

	protected override void OnTick(float DeltaTime)
	{
		if (DetectConditionForHasBuff != null && GlobalActorData != null)
		{
			AActor actor = null;
			Entity Entity;
			if (UnitGuid == B1GlobalFNames.Player_Wukong_String)
			{
				actor = UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner).GetControlledPawn();
			}
			else if (GlobalActorData.GetActorEntity(UnitGuid, out Entity))
			{
				actor = ECSExtension.ToActor(Entity);
			}
			bool? flag = ((IBUC_CheckData)BGU_DataUtil.GetReadOnlyData<BUC_CheckData>(actor))?.CheckDetectCondition(DetectConditionForHasBuff);
			if (flag.HasValue && flag.Value)
			{
				base.QueryState = EQueryState.QuerySuccess;
			}
		}
	}
}

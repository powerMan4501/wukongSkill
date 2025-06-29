using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using UnrealEngine.AIModule;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_PriorityActionInitiatorComp : UActorCompBaseCS
{
	private class ActionChainInfo
	{
		public int ActionQueID;

		public int ResID;

		public int ExecutorNum;

		public FPAQI_SelectUnitTypeInfo SelectUnitTypeInfo;

		public EPriorityActionUnitType UnitType;

		public List<OneActionWarpInfo> ActionQueInfoList;

		public bool NeedWaitEQSFinish;

		public List<FVector> EQSGoalPos;

		public ActionChainInfo(int _ActionQueID, int _ResID, int _ExecutorNum, FPAQI_SelectUnitTypeInfo _SelectUnitTypeInfo, EPriorityActionUnitType _UnitType, List<OneActionWarpInfo> _ActionQueInfoList)
		{
			ActionQueID = _ActionQueID;
			ResID = _ResID;
			ExecutorNum = _ExecutorNum;
			SelectUnitTypeInfo = _SelectUnitTypeInfo;
			UnitType = _UnitType;
			ActionQueInfoList = _ActionQueInfoList;
			NeedWaitEQSFinish = false;
			EQSGoalPos = new List<FVector>();
		}
	}

	private List<ActionChainInfo> ActionChainInfoList;

	public override void OnAttach()
	{
		base.BUSEventCollection.Evt_InitiatePriorityAction += new Del_Void_StringInt(OnInitiatePriorityAction);
	}

	public override void PreBeginPlay()
	{
		ActionChainInfoList = new List<ActionChainInfo>();
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		TickForSendOut();
	}

	private void TickForSendOut()
	{
		if (ActionChainInfoList.Count <= 0)
		{
			return;
		}
		List<int> list = new List<int>();
		for (int i = 0; i < ActionChainInfoList.Count; i++)
		{
			ActionChainInfo actionChainInfo = ActionChainInfoList[i];
			if (!actionChainInfo.NeedWaitEQSFinish)
			{
				list.Add(i);
				base.BGSEventCollection.Evt_BGS_InitiatePriorityActionQue.Invoke(new ActionWarpInfo(actionChainInfo.ResID, actionChainInfo.ExecutorNum, actionChainInfo.SelectUnitTypeInfo, actionChainInfo.UnitType, actionChainInfo.ActionQueInfoList, actionChainInfo.EQSGoalPos));
			}
		}
		for (int num = ActionChainInfoList.Count - 1; num >= 0; num--)
		{
			if (list.Contains(num))
			{
				ActionChainInfoList.Remove(ActionChainInfoList[num]);
			}
		}
	}

	private void OnInitiatePriorityAction(string PriorityActionDataAssetPath, int ActionQueID)
	{
		if (GetOwner() == null)
		{
			return;
		}
		BGWPriorityActionQueDataAsset bGWPriorityActionQueDataAsset = PreloadAssetMgr.TryGetCachedResourceObj<BGWPriorityActionQueDataAsset>(PriorityActionDataAssetPath, ELoadResourceType.SyncLoadAndCache);
		if (bGWPriorityActionQueDataAsset == null || !bGWPriorityActionQueDataAsset.PriorityActionMap.TryGetValue(ActionQueID, out var value))
		{
			return;
		}
		ActionChainInfo actionChainInfo = new ActionChainInfo(ActionQueID, value.ResID, value.ExecutorNum, value.SelectUnitTypeInfo, value.UnitType, new List<OneActionWarpInfo>());
		for (int i = 0; i < value.Actions.Count; i++)
		{
			FOnePriorityActionInfo fOnePriorityActionInfo = value.Actions[i];
			int exParam_Int = i;
			float waitForBeginTime = fOnePriorityActionInfo.WaitForBeginTime;
			float beginNoiseTime = fOnePriorityActionInfo.BeginNoiseTime;
			switch (fOnePriorityActionInfo.ActionType)
			{
			case EGroupPriorityActionType.MoveToPos:
			{
				float waitTime = fOnePriorityActionInfo.PAI_MoveToPos.WaitTime;
				UEnvQuery moveActionEnvQueryTemplate = fOnePriorityActionInfo.PAI_MoveToPos.MoveActionEnvQueryTemplate;
				EAIMoveSpeedType speedType = fOnePriorityActionInfo.PAI_MoveToPos.SpeedType;
				EBGUMoveAIType moveAIType = fOnePriorityActionInfo.PAI_MoveToPos.MoveAIType;
				if (moveActionEnvQueryTemplate != null)
				{
					GAAI_PRIO_ACT_MoveToPos groupAIActionInfo3 = new GAAI_PRIO_ACT_MoveToPos(FVector.ZeroVector, waitTime, speedType, moveAIType);
					actionChainInfo.ActionQueInfoList.Add(new OneActionWarpInfo(EGroupPriorityActionType.MoveToPos, groupAIActionInfo3, waitForBeginTime, beginNoiseTime));
					base.BGSEventCollection.Evt_BGS_EQSObjRun.Invoke(moveActionEnvQueryTemplate, Owner, EBGURunEQSObjReason.None, new FGSEQSExParam
					{
						ExParam_Int = ActionQueID,
						ExParam_Int2 = exParam_Int
					}, OnEQSFinish);
					actionChainInfo.NeedWaitEQSFinish = true;
				}
				break;
			}
			case EGroupPriorityActionType.CastSkill:
			{
				GAAI_PRIO_ACT_CastSkill groupAIActionInfo2 = new GAAI_PRIO_ACT_CastSkill(fOnePriorityActionInfo.PAI_CastSkill.SkillID);
				actionChainInfo.ActionQueInfoList.Add(new OneActionWarpInfo(EGroupPriorityActionType.CastSkill, groupAIActionInfo2, waitForBeginTime, beginNoiseTime));
				break;
			}
			case EGroupPriorityActionType.AddBuff:
			{
				GAAI_PRIO_ACT_AddBuff groupAIActionInfo = new GAAI_PRIO_ACT_AddBuff(fOnePriorityActionInfo.PAI_AddBuff.BuffIDList);
				actionChainInfo.ActionQueInfoList.Add(new OneActionWarpInfo(EGroupPriorityActionType.AddBuff, groupAIActionInfo, waitForBeginTime, beginNoiseTime));
				break;
			}
			}
		}
		ActionChainInfoList.Add(actionChainInfo);
		TickForSendOut();
	}

	private void OnEQSFinish(List<FVector> Result, List<float> Scores, FGSEQSExParam ExParam, int QueryID)
	{
		if (GetOwner() == null)
		{
			return;
		}
		int exParam_Int = ExParam.ExParam_Int;
		int exParam_Int2 = ExParam.ExParam_Int2;
		for (int i = 0; i < ActionChainInfoList.Count; i++)
		{
			if (exParam_Int != ActionChainInfoList[i].ActionQueID)
			{
				continue;
			}
			for (int j = 0; j <= ActionChainInfoList[i].ActionQueInfoList.Count; j++)
			{
				if (exParam_Int2 == j)
				{
					List<FVector> list = new List<FVector>();
					for (int k = 0; k < ActionChainInfoList[i].ExecutorNum && k < Result.Count; k++)
					{
						list.Add(Result[k]);
					}
					if (ActionChainInfoList[i].EQSGoalPos == null)
					{
						ActionChainInfoList[i].EQSGoalPos = new List<FVector>();
					}
					ActionChainInfoList[i].EQSGoalPos = list;
					ActionChainInfoList[i].NeedWaitEQSFinish = false;
					break;
				}
			}
		}
	}
}

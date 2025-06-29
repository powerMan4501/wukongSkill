using System.Collections.Generic;
using System.Linq;
using b1.EventDelDefine;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_GOAPSystem : UActorCompBaseCS
{
	private BUC_GOAPData GOAPData;

	private float TickInterval = 0.1f;

	private float CurInterval;

	public override void OnAttach()
	{
		GOAPData = RequireWritableData<BUC_GOAPData>();
		base.BUSEventCollection.Evt_RegisterAIElem += new Del_RegisterAIElem(RegisterAIElem);
		base.BUSEventCollection.Evt_OnActionExeFinish += new Del_OnActionExeFinish(OnActionExeFinish);
		base.BUSEventCollection.Evt_OnThinkFinish += new Del_OnThinkFinish(OnThinkFinish);
		base.BUSEventCollection.Evt_OnGenerateSkillFeature += new Del_OnGenerateSkillFeature(OnGenerateSkillFeature);
	}

	public override void PreBeginPlay()
	{
		GOAPData.Init(Owner);
	}

	public override void OnBeginPlay()
	{
		LoadAISkillTagsDesc();
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		TickAllActionProcess(DeltaTime);
		CurInterval += DeltaTime;
		if (!(CurInterval < TickInterval))
		{
			CurInterval %= TickInterval;
			UpdateSkillInfo();
			UpdateSkillAreaInfo();
			UpdateAllMainTree();
			UpdateAllExecutingAction();
			ProcessAbort();
			ActionExecuteDecision();
		}
	}

	private void TickAllActionProcess(float DeltaTime)
	{
		foreach (ActionProcessBase actionProcess in GOAPData.ActionProcessList)
		{
			actionProcess.ExecuteTick(DeltaTime);
		}
	}

	private void UpdateAllExecutingAction()
	{
		foreach (AIActionElem executingAction in GOAPData.ExecutingActionList)
		{
			if (!CheckExecutingAction(executingAction))
			{
				MarkAbortAction(executingAction);
			}
		}
	}

	private bool CheckExecutingAction(AIActionElem ActionElem)
	{
		if (ActionElem.State != AIActionState.Executing)
		{
			return false;
		}
		if (ActionElem.ParentElem is AIFeatureElem { State: AIFeatureState.Valid })
		{
			return false;
		}
		if (!AIGOAPFuncLibCS.CheckElemInTree(ActionElem))
		{
			return false;
		}
		if (BGUFunctionLibraryCS.BGUHasUnitState(GetOwner(), EBGUUnitState.Dead) || BGUFunctionLibraryCS.BGUHasUnitSimpleState(GetOwner(), EBGUSimpleState.PendingDeathInAnimationSyncing))
		{
			return false;
		}
		return true;
	}

	private void UpdateAllMainTree()
	{
		GOAPData.ResetSingleFrameData();
		foreach (AIElement rootAIElem in GOAPData.RootAIElemList)
		{
			UpdateTree(rootAIElem);
		}
	}

	private void UpdateSkillInfo()
	{
		GOAPData.ValidSkillInfoList.Clear();
		foreach (AISkillInfo oriSkillInfo in GOAPData.OriSkillInfoList)
		{
			if (oriSkillInfo.IsMappedSkill)
			{
				continue;
			}
			base.BUSEventCollection.Evt_OnSkillMappingStart.Invoke(oriSkillInfo.SkillID);
			BUC_SkillMappingData bUC_SkillMappingData = RequireWritableData<BUC_SkillMappingData>();
			int num = oriSkillInfo.SkillID;
			if (bUC_SkillMappingData != null)
			{
				num = bUC_SkillMappingData.GetCurResultSkillID(oriSkillInfo.SkillID);
			}
			if (num == -1)
			{
				num = oriSkillInfo.SkillID;
			}
			if (BGU_CommonUtil.CheckSkillCanCast(GetOwner(), oriSkillInfo.SkillID, num) != ECanCastSkillResult.CCSR_OK)
			{
				continue;
			}
			foreach (AISkillInfo oriSkillInfo2 in GOAPData.OriSkillInfoList)
			{
				if (oriSkillInfo2.SkillID == num)
				{
					GOAPData.ValidSkillInfoList.Add(oriSkillInfo2);
				}
			}
		}
	}

	private void LoadAISkillTagsDesc()
	{
		int actorResID = BGU_DataUtil.GetActorResID(GetOwner());
		foreach (KeyValuePair<int, FUStAISkillTagsDesc> item in BGW_GameDB.GetAllAISkillTagsDesc())
		{
			if (item.Key.ToString().StartsWith(actorResID.ToString()))
			{
				AISkillInfo aISkillInfo = new AISkillInfo();
				FUStAISkillTagsDesc value = item.Value;
				aISkillInfo.SkillID = item.Key;
				aISkillInfo.MinRange = value.MinRange;
				aISkillInfo.MaxRange = value.MaxRange;
				aISkillInfo.Tags = new List<EActionTagType>();
				aISkillInfo.Tags.AddRange(value.ActionTags);
				if (value.IsMappedSkill == EGSYesNo.Yes)
				{
					aISkillInfo.IsMappedSkill = true;
				}
				else
				{
					aISkillInfo.IsMappedSkill = false;
				}
				GOAPData.OriSkillInfoList.Add(aISkillInfo);
			}
		}
	}

	private void UpdateSkillAreaInfo()
	{
		foreach (TStrongObjectPtr<AFSkillArea> skillAreaFeature in GOAPData.SkillAreaFeatureList)
		{
			AFSkillArea aFSkillArea = skillAreaFeature.Get();
			if (aFSkillArea.ExecuteTime + aFSkillArea.DurationTime < GetOwner().World.GetTimeSeconds())
			{
				GOAPData.SkillAreaFeatureList.Remove(skillAreaFeature);
				break;
			}
		}
	}

	private void OnGenerateSkillFeature(AFSkillArea SkillAreaFeature)
	{
		GOAPData.SkillAreaFeatureList.Add(new TStrongObjectPtr<AFSkillArea>(SkillAreaFeature));
	}

	private void RegisterAIElem(int ElemID, EAIElemType ElemType, float Score)
	{
		AIElement aIElement = AIGOAPFuncLibCS.CreateAIElem(ElemID, ElemType);
		aIElement.OriScore = Score;
		CreateTree(aIElement);
		GOAPData.RootAIElemList.Add(aIElement);
	}

	private bool IsActionExecuting(AIActionElem ActionElem)
	{
		if (GOAPData.ExecutingActionList.Contains(ActionElem))
		{
			return true;
		}
		return false;
	}

	private void OnActionExeFinish(AIActionElem ActionElem)
	{
		ActionElem.State = AIActionState.NotVertify;
		GOAPData.ExecutingActionList.Remove(ActionElem);
		if (ActionElem.ParentElem is AIThinkElem thinkElem)
		{
			ThinkNextPhase(thinkElem);
		}
	}

	private void OnThinkFinish(AIThinkElem ThinkElem)
	{
		if (ThinkElem.ParentElem is AIThinkElem thinkElem)
		{
			ThinkNextPhase(thinkElem);
		}
	}

	private void ThinkNextPhase(AIThinkElem ThinkElem)
	{
		switch (ThinkElem.ThinkType)
		{
		case EThinkType.CircleThink:
			CircleThinkNextPhase(ThinkElem);
			break;
		case EThinkType.OneDirThink:
			OneDirThinkNextPhase(ThinkElem);
			break;
		}
	}

	private void CircleThinkNextPhase(AIThinkElem ThinkElem)
	{
		for (int i = 0; i < ThinkElem.ChildElems.Count; i++)
		{
			if (ThinkElem.ChildElems[i] == ThinkElem.CurElem)
			{
				if (i == ThinkElem.ChildElems.Count - 1)
				{
					ThinkElem.CurElem = ThinkElem.ChildElems[0];
					OnThinkFinish(ThinkElem);
				}
				else
				{
					ThinkElem.CurElem = ThinkElem.ChildElems[i + 1];
				}
				break;
			}
		}
	}

	private void OneDirThinkNextPhase(AIThinkElem ThinkElem)
	{
		for (int i = 0; i < ThinkElem.ChildElems.Count; i++)
		{
			if (ThinkElem.ChildElems[i] == ThinkElem.CurElem)
			{
				if (i != ThinkElem.ChildElems.Count - 1)
				{
					ThinkElem.CurElem = ThinkElem.ChildElems[i + 1];
				}
				break;
			}
		}
	}

	private void ProcessAbort()
	{
		int num = 0;
		while (num < GOAPData.ActionsWaitAbort.Count)
		{
			AIActionElem aIActionElem = GOAPData.ActionsWaitAbort[num];
			if (aIActionElem.State == AIActionState.NotVertify)
			{
				GOAPData.ActionsWaitAbort.RemoveAt(num);
			}
			else if (AbortActionElem(aIActionElem))
			{
				GOAPData.ActionsWaitAbort.RemoveAt(num);
			}
			else
			{
				num++;
			}
		}
	}

	private bool AbortActionElem(AIActionElem ActionElem)
	{
		if (ActionElem.Process.Abort(ActionElem))
		{
			ActionElem.State = AIActionState.NotVertify;
			GOAPData.ExecutingActionList.Remove(ActionElem);
			return true;
		}
		return false;
	}

	private void MarkAbortAction(AIActionElem Elem)
	{
		if (!GOAPData.ActionsWaitAbort.Contains(Elem))
		{
			GOAPData.ActionsWaitAbort.Add(Elem);
		}
	}

	private void ActionExecuteDecision()
	{
		if (GOAPData.ExecutableActionList.Count == 0)
		{
			return;
		}
		foreach (AIActionElem item in GOAPData.ExecutableActionList.OrderByDescending((AIActionElem Item) => Item.CurScore).ToList())
		{
			if (ExecuteActionElem(item))
			{
				break;
			}
		}
	}

	private bool ExecuteActionElem(AIActionElem ActionElem)
	{
		if (!CheckExeNeed(ActionElem))
		{
			return false;
		}
		ActionElem.Process.StartExecute(ActionElem);
		ActionElem.State = AIActionState.Executing;
		GOAPData.ExecutingActionList.Add(ActionElem);
		return true;
	}

	private bool CheckExeNeed(AIActionElem ActionElem)
	{
		ActionProcessBase process = ActionElem.Process;
		List<ActionProcessBase> processListWillAbort = GetProcessListWillAbort(process);
		if (processListWillAbort.Count == 0)
		{
			return true;
		}
		foreach (ActionProcessBase item in processListWillAbort)
		{
			if (ActionElem.CurScore <= item.GetCurAction().CurScore)
			{
				return false;
			}
		}
		foreach (ActionProcessBase item2 in processListWillAbort)
		{
			MarkAbortAction(item2.GetCurAction());
		}
		return false;
	}

	private List<ActionProcessBase> GetProcessListWillAbort(ActionProcessBase CurProcess)
	{
		List<ActionProcessBase> list = new List<ActionProcessBase>();
		foreach (ActionProcessBase actionProcess in GOAPData.ActionProcessList)
		{
			if (actionProcess.CheckAbortByProcess(CurProcess))
			{
				list.Add(actionProcess);
			}
		}
		return list;
	}

	public void UpdateTree(AIElement RootElem)
	{
		CalcElemScore(RootElem);
		AIThinkElem aIThinkElem = RootElem as AIThinkElem;
		AIActionElem aIActionElem = RootElem as AIActionElem;
		AIFeatureElem aIFeatureElem = RootElem as AIFeatureElem;
		if (aIThinkElem != null)
		{
			UpdateThinkElem(aIThinkElem);
		}
		if (aIActionElem != null)
		{
			UpdateActionElem(aIActionElem);
		}
		if (aIFeatureElem != null)
		{
			UpdateFeatureElem(aIFeatureElem);
		}
	}

	private void CalcElemScore(AIElement Elem)
	{
		if (Elem.ParentElem == null)
		{
			Elem.CurScore = Elem.OriScore;
		}
		else
		{
			Elem.CurScore = Elem.OriScore + Elem.ParentElem.CurScore;
		}
	}

	public void UpdateThinkElem(AIThinkElem ThinkElem)
	{
		UpdateTree(ThinkElem.CurElem);
		if (ThinkElem.CurElem is AIFeatureElem { State: AIFeatureState.Valid })
		{
			ThinkNextPhase(ThinkElem);
		}
	}

	public void UpdateActionElem(AIActionElem ActionElem)
	{
		GOAPData.AllUpdateActionList.Add(ActionElem);
		foreach (AIElement childElem in ActionElem.ChildElems)
		{
			UpdateTree(childElem);
		}
		ActionElem.ClearData();
		foreach (AIElement childElem2 in ActionElem.ChildElems)
		{
			if ((childElem2 as AIFeatureElem).State != AIFeatureState.Valid)
			{
				if (IsActionExecuting(ActionElem))
				{
					ActionElem.State = AIActionState.ExeInputInvalid;
				}
				else
				{
					ActionElem.State = AIActionState.InputInvalid;
				}
				return;
			}
			if (IsActionExecuting(ActionElem))
			{
				ActionElem.State = AIActionState.Executing;
			}
		}
		foreach (AIElement childElem3 in ActionElem.ChildElems)
		{
			AIFeatureElem aIFeatureElem = childElem3 as AIFeatureElem;
			ActionElem.InputDataList.Add(aIFeatureElem.OutputData);
		}
		if (ActionElem.State != AIActionState.Executing && ActionElem.State != AIActionState.ExeInputInvalid && ActionElem.State == AIActionState.NotVertify)
		{
			switch (VertifyAction(ActionElem))
			{
			case AIActionVertifyResult.Invalid:
				ActionElem.State = AIActionState.CantProcess;
				break;
			case AIActionVertifyResult.Valid:
				ActionElem.State = AIActionState.Executable;
				GOAPData.ExecutableActionList.Add(ActionElem);
				break;
			}
		}
	}

	public void UpdateFeatureElem(AIFeatureElem FeatureElem)
	{
		FeatureElem.ClearData();
		foreach (AIFeatureElem validFeatureElem in GOAPData.GetValidFeatureElemList())
		{
			if (validFeatureElem.FeatureID == FeatureElem.FeatureID)
			{
				FeatureElem.State = AIFeatureState.Valid;
				FeatureElem.OutputData = validFeatureElem.OutputData;
				return;
			}
		}
		if (AIGOAPFuncLibCS.OriFeatureInputDic.TryGetValue(FeatureElem.FeatureID, out var value))
		{
			AIDataPkg aIDataPkg = new AIDataPkg();
			switch (value)
			{
			case EFeatureInputType.AllCharacters:
			{
				ACharacter[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<ACharacter>(GetOwner());
				foreach (ACharacter character in allActorsOfClass)
				{
					aIDataPkg.AddData(new AICharacterData(character));
				}
				break;
			}
			case EFeatureInputType.OwnCharacter:
				aIDataPkg.AddData(new AICharacterData(GetOwner() as ACharacter));
				break;
			case EFeatureInputType.CenterCharacter:
			{
				ACharacter aCharacter = BGU_UnrealWorldUtil.GetNearestPlayerActor(GetOwner()) as ACharacter;
				if (aCharacter.IsNullOrDestroyed())
				{
					aCharacter = GetOwner() as ACharacter;
				}
				aIDataPkg.AddData(new AICharacterData(aCharacter));
				break;
			}
			}
			FeatureElem.OutputData = aIDataPkg;
			FeatureElem.State = AIFeatureState.Valid;
		}
		else
		{
			VertifyFeature(FeatureElem);
		}
		if (FeatureElem.State == AIFeatureState.Valid)
		{
			GOAPData.ValidFeatureElemList.Add(FeatureElem);
		}
		if (FeatureElem.State == AIFeatureState.Valid)
		{
			return;
		}
		foreach (AIElement childElem in FeatureElem.ChildElems)
		{
			if (childElem is AIActionElem rootElem)
			{
				UpdateTree(rootElem);
			}
		}
	}

	public void VertifyFeature(AIFeatureElem FeatureElem)
	{
		foreach (AIElement childElem in FeatureElem.ChildElems)
		{
			if (childElem is AIFeatureElem rootElem)
			{
				UpdateTree(rootElem);
			}
		}
		foreach (AIElement childElem2 in FeatureElem.ChildElems)
		{
			if (childElem2 is AIFeatureElem aIFeatureElem)
			{
				if (aIFeatureElem.State != AIFeatureState.Valid)
				{
					FeatureElem.State = AIFeatureState.InputInvalid;
					break;
				}
				FeatureElem.InputDataList.Add(aIFeatureElem.OutputData);
			}
		}
		if (FeatureElem.State == AIFeatureState.NotVertify && GOAPData.FilterProcess.ExecuteFilter(FeatureElem) == AIFilterResult.Failed)
		{
			FeatureElem.State = AIFeatureState.FilterFailed;
		}
		if (FeatureElem.State == AIFeatureState.NotVertify)
		{
			FeatureElem.State = AIFeatureState.Valid;
		}
	}

	public AIActionVertifyResult VertifyAction(AIActionElem ActionElem)
	{
		FUStAIActionDesc aIActionDesc = BGW_GameDB.GetAIActionDesc(ActionElem.ActionID);
		ActionProcessBase actionProcessBase = null;
		foreach (FUStAIActionFilter filter in aIActionDesc.Filters)
		{
			ActionElem.PreExeCache.Clear();
			ActionProcessBase actionProcessBase2 = null;
			foreach (KeyValuePair<ActionProcessBase, EActionTagType> item in GOAPData.ProcessKeyTagDic)
			{
				if (filter.Tags.Contains(item.Value))
				{
					actionProcessBase2 = item.Key;
					break;
				}
			}
			if (actionProcessBase2 != null && actionProcessBase2.CheckExecutable(filter, ActionElem.PreExeCache))
			{
				ActionElem.PreExeCache.FilterDesc = filter;
				actionProcessBase = actionProcessBase2;
				break;
			}
		}
		if (actionProcessBase == null)
		{
			return AIActionVertifyResult.Invalid;
		}
		ActionElem.Process = actionProcessBase;
		return AIActionVertifyResult.Valid;
	}

	public void CreateTree(AIElement Elem)
	{
		AIThinkElem aIThinkElem = Elem as AIThinkElem;
		AIActionElem aIActionElem = Elem as AIActionElem;
		AIFeatureElem aIFeatureElem = Elem as AIFeatureElem;
		if (aIThinkElem != null)
		{
			InitThinkElem(aIThinkElem);
		}
		if (aIActionElem != null)
		{
			InitActionElem(aIActionElem);
		}
		if (aIFeatureElem != null)
		{
			InitFeatureElem(aIFeatureElem);
		}
	}

	public void InitFeatureElem(AIFeatureElem FeatureElem)
	{
		FUStAIFeatureDesc aIFeatureDesc = BGW_GameDB.GetAIFeatureDesc(FeatureElem.FeatureID);
		if (aIFeatureDesc == null)
		{
			AIGOAPFuncLibCS.OriFeatureInputDic.TryGetValue(FeatureElem.FeatureID, out var _);
			return;
		}
		CheckFeatureConfig(aIFeatureDesc);
		foreach (int item in AIGOAPFuncLibCS.GetInputIDListByFeatureDesc(aIFeatureDesc))
		{
			AIElement aIElement = AIGOAPFuncLibCS.CreateAIElem(item, EAIElemType.Feature);
			FeatureElem.ChildElems.Add(aIElement);
			aIElement.ParentElem = FeatureElem;
			CreateTree(aIElement);
		}
		foreach (KeyValuePair<int, FUStAIActionDesc> item2 in BGW_GameDB.GetAllAIActionDesc())
		{
			if (item2.Value.Effect.Contains(FeatureElem.FeatureID))
			{
				AIElement aIElement2 = AIGOAPFuncLibCS.CreateAIElem(item2.Key, EAIElemType.Action);
				FeatureElem.ChildElems.Add(aIElement2);
				aIElement2.ParentElem = FeatureElem;
				CreateTree(aIElement2);
			}
		}
	}

	public void InitActionElem(AIActionElem ActionElem)
	{
		FUStAIActionDesc aIActionDesc = BGW_GameDB.GetAIActionDesc(ActionElem.ActionID);
		if (aIActionDesc == null)
		{
			return;
		}
		foreach (int item in aIActionDesc.PreCondition)
		{
			AIElement aIElement = AIGOAPFuncLibCS.CreateAIElem(item, EAIElemType.Feature);
			ActionElem.ChildElems.Add(aIElement);
			aIElement.ParentElem = ActionElem;
			CreateTree(aIElement);
		}
	}

	public void InitThinkElem(AIThinkElem ThinkElem)
	{
		FUStAIThinkDesc aIThinkDesc = BGW_GameDB.GetAIThinkDesc(ThinkElem.ThinkID);
		if (aIThinkDesc == null)
		{
			return;
		}
		foreach (FUStThinkElem thinkElem in aIThinkDesc.ThinkElems)
		{
			AIElement aIElement = AIGOAPFuncLibCS.CreateAIElem(thinkElem.ElemID, thinkElem.ElemType);
			ThinkElem.ChildElems.Add(aIElement);
			aIElement.ParentElem = ThinkElem;
			CreateTree(aIElement);
		}
		ThinkElem.CurElem = ThinkElem.ChildElems[0];
		ThinkElem.ThinkType = aIThinkDesc.ThinkType;
	}

	public bool CheckFeatureConfig(FUStAIFeatureDesc FeatureDesc)
	{
		if (!AIGOAPFuncLibCS.OriFeatureInputDic.TryGetValue(FeatureDesc.ID, out var _) && FeatureDesc.MainInputID == 0)
		{
			return false;
		}
		return true;
	}
}

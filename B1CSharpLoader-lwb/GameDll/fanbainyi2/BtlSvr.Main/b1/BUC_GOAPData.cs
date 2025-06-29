using System.Collections.Generic;
using b1.ECS;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_GOAPData : IBUC_GOAPData, IPersistentECSData
{
	public Dictionary<ActionProcessBase, EActionTagType> ProcessKeyTagDic;

	public List<AISkillInfo> OriSkillInfoList;

	public NormalMoveAction NormalMove;

	public NormalSkillCastAction NormalSkillCast;

	public List<ActionProcessBase> ActionProcessList;

	public AIFilterProcess FilterProcess;

	public List<AIElement> RootAIElemList;

	public List<AIActionElem> ExecutingActionList;

	public List<AIActionElem> ActionsWaitAbort;

	public List<AIFeatureElem> ValidFeatureElemList;

	public List<AIActionElem> ExecutableActionList;

	public List<AIActionElem> AllUpdateActionList;

	public List<AISkillInfo> ValidSkillInfoList;

	public List<TStrongObjectPtr<AFSkillArea>> SkillAreaFeatureList = new List<TStrongObjectPtr<AFSkillArea>>();

	public void Init(AActor Own)
	{
		OriSkillInfoList = new List<AISkillInfo>();
		ValidSkillInfoList = new List<AISkillInfo>();
		RootAIElemList = new List<AIElement>();
		ValidFeatureElemList = new List<AIFeatureElem>();
		ProcessKeyTagDic = new Dictionary<ActionProcessBase, EActionTagType>();
		ExecutableActionList = new List<AIActionElem>();
		ExecutingActionList = new List<AIActionElem>();
		ActionProcessList = new List<ActionProcessBase>();
		FilterProcess = new AIFilterProcess(Own);
		ActionsWaitAbort = new List<AIActionElem>();
		AllUpdateActionList = new List<AIActionElem>();
		NormalSkillCast = new NormalSkillCastAction(Own);
		NormalMove = new NormalMoveAction(Own);
		ActionProcessList.Add(NormalSkillCast);
		ActionProcessList.Add(NormalMove);
		ProcessKeyTagDic.Add(NormalMove, EActionTagType.NormalMove);
		ProcessKeyTagDic.Add(NormalSkillCast, EActionTagType.NormalSkillCast);
	}

	public void ResetSingleFrameData()
	{
		ValidFeatureElemList.Clear();
		ExecutableActionList.Clear();
		AllUpdateActionList.Clear();
	}

	public List<AISkillInfo> GetValidSkillInfoList()
	{
		return ValidSkillInfoList;
	}

	public List<AIActionElem> GetExecutableActionElemList()
	{
		return ExecutableActionList;
	}

	public List<AIActionElem> GetExecutingActionElemList()
	{
		return ExecutingActionList;
	}

	public List<AIFeatureElem> GetValidFeatureElemList()
	{
		return ValidFeatureElemList;
	}

	public List<TStrongObjectPtr<AFSkillArea>> GetSkillAreaFeatureList()
	{
		return SkillAreaFeatureList;
	}

	public List<AIElement> GetAllRootElemList()
	{
		return RootAIElemList;
	}

	public List<AIActionElem> GetAllUpdateActionList()
	{
		return AllUpdateActionList;
	}

	public List<ActionProcessBase> GetActionProcessList()
	{
		return ActionProcessList;
	}
}

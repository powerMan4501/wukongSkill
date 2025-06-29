using BtlB1;
using BtlShare;
using UnrealEngine.Engine;

namespace b1;

public abstract class BUInteractActionTemplate
{
	protected int ParamIntNum;

	protected int ParamStringNum;

	protected AActor Player;

	public virtual bool DoInteractAction(int InteractiveActorID, AActor User, AActor InteractiveActor, FUStInteractionMappingDesc Action)
	{
		if (CheckParamNum(Action))
		{
			BGW_LogUtil.LogError($"[interactComp] 交互动作模板参数数量不匹配 {Action.InteractAction} int:{Action.ParamsInt.Count}/{ParamIntNum} string:{Action.ParamsString.Count}/{ParamStringNum}");
		}
		return true;
	}

	public virtual void OnBreakInteractAction(int InteractiveActorID, AActor User, AActor InteractiveActor, FUStInteractionMappingDesc Action)
	{
	}

	public virtual void OnFinishInteractAction(int InteractiveActorID, AActor User, AActor InteractiveActor, FUStInteractionMappingDesc Action)
	{
	}

	public virtual void OnEnd(AActor User)
	{
	}

	public virtual bool IsSupportSkip(int InteractiveActorID, AActor User, AActor InteractiveActor, FUStInteractionMappingDesc Action)
	{
		return false;
	}

	public virtual void OnSkipInteractAction(int InteractiveActorID, AActor User, AActor InteractiveActor, FUStInteractionMappingDesc Action)
	{
	}

	private bool CheckParamNum(FUStInteractionMappingDesc Action)
	{
		return true;
	}

	public virtual void UpdateIdle(AActor InteractiveActor, FUStInteractionMappingDesc Action, EBGUInteractUnitState State)
	{
	}
}

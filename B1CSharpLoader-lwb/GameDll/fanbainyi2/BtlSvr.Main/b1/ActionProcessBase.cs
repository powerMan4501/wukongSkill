using System.Collections.Generic;
using BtlShare;
using UnrealEngine.Engine;

namespace b1;

public class ActionProcessBase
{
	public AActor Own;

	protected List<AIActionElem> ActionElemList;

	protected AIActionProcessState State;

	public ActionProcessBase(AActor Own)
	{
		this.Own = Own;
		State = AIActionProcessState.Available;
		ActionElemList = new List<AIActionElem>();
	}

	public virtual void StartExecute(AIActionElem ActionElem)
	{
		ActionElemList.Add(ActionElem);
	}

	public virtual void ExecuteTick(float DeltaTime)
	{
	}

	public virtual bool CheckExecutable(FUStAIActionFilter Filter, ActionPreExeCache PreExeCache)
	{
		return false;
	}

	public virtual bool Abort(AIActionElem ActionElem)
	{
		return false;
	}

	public virtual bool CheckAbortByProcess(ActionProcessBase OtherProcess)
	{
		return false;
	}

	public virtual AIActionElem GetCurAction()
	{
		return null;
	}

	public bool IsProcessing()
	{
		return ActionElemList.Count != 0;
	}
}

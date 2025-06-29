using CommB1;
using GUR.Runtime;
using UnrealEngine.Runtime;

namespace b1;

[TypeFactory]
public abstract class FIdleProcessExecutorBase
{
	[FactoryKey]
	public abstract EIdleProcessActionType ActionType { get; }

	public abstract void Initial(CalliopeCustom_IdleProcessAction InIdleProcessAction, PsmNodeInstance InPsmNodeInstance);

	public abstract void Run(UObject InWorldContext);

	public virtual void ResetRun(UObject InWorldContext)
	{
	}

	public virtual void RecoverRun(UObject InWorldContext)
	{
	}

	public bool CanTick()
	{
		return !IsFinished();
	}

	public virtual void OnTick(UObject InWorldContext, float InDeltaTime)
	{
	}

	public virtual bool IsFinished()
	{
		return true;
	}

	public virtual bool IsAiConversationChainEnd()
	{
		return true;
	}

	public virtual void Shutdown(UObject InWorldContext)
	{
	}
}

using CommB1;
using UnrealEngine.Runtime;

namespace b1;

public class FIdleProcessExecutor_GameLevelPass : FIdleProcessExecutorBase
{
	public override EIdleProcessActionType ActionType => EIdleProcessActionType.GameLevelPass;

	public override void Initial(CalliopeCustom_IdleProcessAction InIdleProcessAction, PsmNodeInstance InPsmNodeInstance)
	{
	}

	public override void Run(UObject InWorldContext)
	{
		BGW_EventCollection.Get(InWorldContext).Evt_BGW_TriggerGlobalFSMEvent(EGI_Global.GameLevelPass);
	}

	public override void RecoverRun(UObject InWorldContext)
	{
		Run(InWorldContext);
	}
}

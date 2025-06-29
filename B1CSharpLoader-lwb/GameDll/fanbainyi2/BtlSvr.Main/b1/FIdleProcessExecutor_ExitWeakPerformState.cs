using CommB1;
using UnrealEngine.Runtime;

namespace b1;

public class FIdleProcessExecutor_ExitWeakPerformState : FIdleProcessExecutorBase
{
	public override EIdleProcessActionType ActionType => EIdleProcessActionType.ExitWeakPerformState;

	public override void Initial(CalliopeCustom_IdleProcessAction InIdleProcessAction, PsmNodeInstance InPsmNodeInstance)
	{
	}

	public override void Run(UObject InWorldContext)
	{
		BPS_GSEventCollection bPS_GSEventCollection = BPS_EventCollectionCS.Get(UGSE_EngineFuncLib.GetFirstLocalPlayerController(InWorldContext));
		if (!(bPS_GSEventCollection == null))
		{
			bPS_GSEventCollection.Evt_ExitWeakPerformState.Invoke();
		}
	}
}

using CommB1;
using UnrealEngine.Runtime;

namespace b1;

public class FIdleProcessExecutor_EnterWeakPerformState : FIdleProcessExecutorBase
{
	public override EIdleProcessActionType ActionType => EIdleProcessActionType.EnterWeakPerformState;

	private int WeakPerformStateConfigID { get; set; }

	public override void Initial(CalliopeCustom_IdleProcessAction InIdleProcessAction, PsmNodeInstance InPsmNodeInstance)
	{
		WeakPerformStateConfigID = InIdleProcessAction.WeakPerformConfigId;
	}

	public override void Run(UObject InWorldContext)
	{
		BPS_GSEventCollection bPS_GSEventCollection = BPS_EventCollectionCS.Get(UGSE_EngineFuncLib.GetFirstLocalPlayerController(InWorldContext));
		if (!(bPS_GSEventCollection == null) && bPS_GSEventCollection.HasBeginPlay)
		{
			bPS_GSEventCollection.Evt_EnterWeakPerformState.Invoke(WeakPerformStateConfigID);
		}
	}
}

using b1.EventDelDefine;
using BtlB1;
using CommB1;
using UnrealEngine.Runtime;

namespace b1;

public class FIdleProcessExecutor_PlayDefeatUI : FIdleProcessExecutorBase
{
	public override EIdleProcessActionType ActionType => EIdleProcessActionType.PlayDefeatUI;

	private int ExtendID { get; set; }

	private bool bPlayingDefeatUI { get; set; }

	private BGS_GSEventCollection BGSEventCollection { get; set; }

	public override void Initial(CalliopeCustom_IdleProcessAction InIdleProcessAction, PsmNodeInstance InPsmNodeInstance)
	{
		ExtendID = InIdleProcessAction.ExtendId;
		bPlayingDefeatUI = false;
	}

	public override void Run(UObject InWorldContext)
	{
		FUStDefeatSlowTimeConfigDesc slowTimeConfigDescByExtendID = BGW_GameDB.GetSlowTimeConfigDescByExtendID(ExtendID);
		if (slowTimeConfigDescByExtendID != null && slowTimeConfigDescByExtendID.TriggerType == EDefeatUITriggerType.Cpg)
		{
			bPlayingDefeatUI = true;
			BGSEventCollection = BGS_EventCollectionCS.Get(InWorldContext);
			BGSEventCollection.Evt_BeginDefeatSlowTime.Invoke(ExtendID, EDefeatUITriggerType.Cpg);
			BGSEventCollection.Evt_EndDefeatSlowTime += new Del_Void_Int(OnEndDefeatSlowTime);
		}
	}

	public override bool IsFinished()
	{
		return !bPlayingDefeatUI;
	}

	public override void Shutdown(UObject InWorldContext)
	{
		OnEndDefeatSlowTime(ExtendID);
	}

	private void OnEndDefeatSlowTime(int InExtendID)
	{
		if (bPlayingDefeatUI && !(BGSEventCollection == null) && ExtendID == InExtendID)
		{
			bPlayingDefeatUI = false;
			BGSEventCollection.Evt_EndDefeatSlowTime -= new Del_Void_Int(OnEndDefeatSlowTime);
		}
	}
}

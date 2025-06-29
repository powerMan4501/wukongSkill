using b1.Plugins.AsyncLoadingScreen;

namespace b1;

public class FSMState_GI_Loading_CloseLoadingScreen : FSMState_GI_LoadingBase
{
	private const float ProtectDuration = 1.5f;

	private float _timer;

	public override void Init(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
	{
		base.Init(RuntimeInstance, Node, InputParams);
	}

	public override void OnEnter()
	{
		_timer = 1.5f;
		if (Context.GameInst.GetCurLoadingScreenState() == EGSLoadingScreenState.Idle)
		{
			TriggerFinishEvent();
		}
	}

	private void TriggerFinishEvent()
	{
		BGW_EventCollection.Get(Context.GameInst).Evt_BlockInput(EBlockType.Loading, IsBlock: false);
		base.OwningInstance.TriggerEvent(EGI_Loading.Finish);
	}

	public override int OnTick(float Delta)
	{
		if (Context.GameInst.IsLoadingScreenFadeAwayFinish())
		{
			CloseLoadingScreen();
			return 0;
		}
		_timer -= Delta;
		if (_timer < 0f)
		{
			CloseLoadingScreen();
		}
		return 100;
		void CloseLoadingScreen()
		{
			BGW_DebugMgr.Get(Context.GameInst).UpdateUserConfigToSentry();
			BGW_EventCollection.Get(Context.GameInst).Evt_BGW_PostFecthLoadingTipsFinish();
			Context.GameInst.SwitchLoadingScreenThread(UseSlateThread: false);
			Context.GameInst.CloseLoadingScreen();
			BGW_EventCollection.Get(Context.OwnerUObj).Evt_PostLoadingScreenClose();
			TriggerFinishEvent();
		}
	}

	public override void OnExit()
	{
		BGW_LoadingTipsMgr.Get(Context.GameInst).LoadingColorAlphaTracker.Close();
	}
}

using b1.Plugins.AsyncLoadingScreen;

namespace b1;

public class FSMState_GI_Loading_PrepareFadeAway : FSMState_GI_LoadingBase
{
	private const float ProtectDuration = 10f;

	private float _timer;

	public override void Init(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
	{
		base.Init(RuntimeInstance, Node, InputParams);
	}

	public override void OnEnter()
	{
		BGWGameInstanceCS gameInst = Context.GameInst;
		if (gameInst.GetCurLoadingScreenState() != EGSLoadingScreenState.Idle)
		{
			_timer = 10f;
			gameInst.PrepareFadeAway();
		}
		else
		{
			base.OwningInstance.TriggerEvent(EGI_Loading.Finish);
		}
	}

	public override int OnTick(float Delta)
	{
		if (Context.GameInst.CanFadeAway())
		{
			base.OwningInstance.TriggerEvent(EGI_Loading.Finish);
			return 100;
		}
		_timer -= Delta;
		if (_timer < 0f)
		{
			base.OwningInstance.TriggerEvent(EGI_Loading.Finish);
		}
		return 0;
	}

	public override void OnExit()
	{
	}
}

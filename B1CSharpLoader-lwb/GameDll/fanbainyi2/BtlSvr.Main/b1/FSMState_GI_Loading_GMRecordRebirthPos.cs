namespace b1;

public class FSMState_GI_Loading_GMRecordRebirthPos : FSMState_GI_LoadingBase
{
	public override void Init(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
	{
		base.Init(RuntimeInstance, Node, InputParams);
	}

	public override void OnEnter()
	{
		BUS_EventCollectionCS.Get(UGSE_EngineFuncLib.GetFirstLocalPlayerController(Context.GameInst).GetControlledPawn())?.Evt_GMRecordRebirthPos.Invoke();
		base.OwningInstance.TriggerEvent(EGI_Loading.Finish);
	}

	public override int OnTick(float Delta)
	{
		return 100;
	}

	public override void OnExit()
	{
	}
}

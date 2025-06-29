namespace b1;

public class FSMState_GI_Global_MainMenu : FSMState_GI_GlobalBase
{
	public override void Init(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
	{
		base.Init(RuntimeInstance, Node, InputParams);
	}

	public override void OnEnter()
	{
		if (UGSE_EngineFuncLib.IsCommandLineHasParam("benchmark"))
		{
			BGW_EventCollection.Get(base.OwningInstance.OwnerUObj).Evt_BGW_TriggerGlobalFSMEvent(EGI_Global.BenchMark);
		}
	}

	public override int OnTick(float Delta)
	{
		return 100;
	}

	public override void OnExit()
	{
	}
}

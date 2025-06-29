using UnrealEngine.Engine;

namespace b1;

public class FSMState_GI_Loading_WaitUntilGameStateInit : FSMState_GI_LoadingBase
{
	public override void Init(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
	{
		base.Init(RuntimeInstance, Node, InputParams);
	}

	public override void OnEnter()
	{
	}

	public override int OnTick(float Delta)
	{
		if (UGameplayStatics.GetGameState(Context.GameInst) != null)
		{
			base.OwningInstance.TriggerEvent(EGI_Loading.Finish);
			return 100;
		}
		return 0;
	}

	public override void OnExit()
	{
	}
}

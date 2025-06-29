using UnrealEngine.Engine;

namespace b1;

public class BPS_LiftTimeSystem : PlayerControllerSystemBase
{
	public override void OnAttach()
	{
		BGW_EventCollection.Get(Owner).Evt_PostPlayerControllerAttach();
	}

	public override void OnBeginPlay()
	{
		BGW_EventCollection.Get(Owner).Evt_PostPlayerControllerBeginPlay();
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		BGW_EventCollection.Get(Owner).Evt_PostPlayerControllerEndPlay();
	}
}

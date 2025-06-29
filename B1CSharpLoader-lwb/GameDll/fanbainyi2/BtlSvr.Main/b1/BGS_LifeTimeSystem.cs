using UnrealEngine.Engine;

namespace b1;

public class BGS_LifeTimeSystem : GameStateSystemBase
{
	public override void OnAttach()
	{
		BGW_EventCollection.Get(Owner).Evt_PostGameStateAttach();
	}

	public override void OnBeginPlay()
	{
		BGW_EventCollection.Get(Owner).Evt_PostGameStateBeginPlay();
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		BGW_EventCollection.Get(Owner).Evt_PostGameStateEndPlay();
	}
}

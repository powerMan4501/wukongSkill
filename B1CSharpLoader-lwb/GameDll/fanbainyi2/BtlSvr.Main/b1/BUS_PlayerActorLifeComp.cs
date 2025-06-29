using UnrealEngine.Engine;

namespace b1;

public class BUS_PlayerActorLifeComp : UActorCompBaseCS
{
	private BUC_UIControlData UIControlData;

	private BGS_GSEventCollection GameEventCollection;

	public override void OnAttach()
	{
		UIControlData = RequireWritableData<BUC_UIControlData>();
		AGameStateBase gameState = UGameplayStatics.GetGameState(Owner);
		GameEventCollection = (gameState as BGGGameStateCS)?.GameEventCollection;
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (!UIControlData.HasCacheActor)
		{
			BGUPlayerCharacterCS bGUPlayerCharacterCS = Owner as BGUPlayerCharacterCS;
			if (bGUPlayerCharacterCS.ActorCompContainerCS.HasLateBeginPlay)
			{
				GameEventCollection?.Evt_PlayerActorLateBeginPlayFinish.Invoke(bGUPlayerCharacterCS.PlayerState);
				UIControlData.HasCacheActor = true;
			}
		}
	}
}

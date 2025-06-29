using UnrealEngine.Engine;

namespace b1;

public class GameModeSystemBase : UActorCompBaseCS
{
	protected T RequireWritableGameStateData<T>() where T : class, new()
	{
		return BGU_DataUtil.GetUnPersistentReadOnlyData<T>(UGameplayStatics.GetGameState(Owner.World));
	}

	protected BGS_GSEventCollection GetGameEventCollection()
	{
		return (UGameplayStatics.GetGameState(GetOwner().World) as BGGGameStateCS)?.GameEventCollection;
	}
}

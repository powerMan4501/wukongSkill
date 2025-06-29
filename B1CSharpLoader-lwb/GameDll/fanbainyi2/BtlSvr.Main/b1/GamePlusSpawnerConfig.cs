using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public struct GamePlusSpawnerConfig
{
	public int Rate;

	public TSubclassOf<AActor> ActorClass;
}

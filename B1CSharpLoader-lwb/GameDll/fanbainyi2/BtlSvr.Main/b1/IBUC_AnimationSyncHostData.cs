using UnrealEngine.Engine;

namespace b1;

public interface IBUC_AnimationSyncHostData
{
	AActor Guest { get; }

	AActor GetSpawnedSyncAnimActor(uint NotifyUniqueID);
}

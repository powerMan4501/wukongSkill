using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public interface IBGC_AnimationSyncData
{
	bool IsAnyUnitInAnimationSyncing(bool bIncludeInteractAnimationSyncing = false);

	bool IsPlayerInAnimationSyncing(UObject Context);

	bool IsActorInAnimationSyncing(AActor Actor);
}

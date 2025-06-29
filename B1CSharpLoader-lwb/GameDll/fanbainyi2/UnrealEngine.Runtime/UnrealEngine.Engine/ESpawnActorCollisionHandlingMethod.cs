using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.ESpawnActorCollisionHandlingMethod", "Engine", UnrealModuleType.Engine)]
public enum ESpawnActorCollisionHandlingMethod : byte
{
	Undefined,
	AlwaysSpawn,
	AdjustIfPossibleButAlwaysSpawn,
	AdjustIfPossibleButDontSpawnIfColliding,
	DontSpawnIfColliding
}

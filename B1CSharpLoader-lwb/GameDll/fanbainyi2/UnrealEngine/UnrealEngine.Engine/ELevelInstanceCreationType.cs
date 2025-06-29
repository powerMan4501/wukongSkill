using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ELevelInstanceCreationType", "Engine", UnrealModuleType.Engine)]
public enum ELevelInstanceCreationType
{
	LevelInstance,
	PackedLevelActor
}

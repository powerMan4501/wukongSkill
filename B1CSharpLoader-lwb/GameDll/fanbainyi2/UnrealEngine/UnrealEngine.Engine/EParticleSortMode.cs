using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EParticleSortMode", "Engine", UnrealModuleType.Engine)]
public enum EParticleSortMode
{
	PSORTMODE_None,
	PSORTMODE_ViewProjDepth,
	PSORTMODE_DistanceToView,
	PSORTMODE_Age_OldestFirst,
	PSORTMODE_Age_NewestFirst
}

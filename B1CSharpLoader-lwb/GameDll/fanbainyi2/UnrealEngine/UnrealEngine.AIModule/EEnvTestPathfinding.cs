using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UEnum]
[UMetaPath("/Script/AIModule.EEnvTestPathfinding", "AIModule", UnrealModuleType.Engine)]
public enum EEnvTestPathfinding
{
	PathExist,
	PathCost,
	PathLength
}

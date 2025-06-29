using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ENetworkLagState", "Engine", UnrealModuleType.Engine)]
public enum ENetworkLagState
{
	NotLagging,
	Lagging
}

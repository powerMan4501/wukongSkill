using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.ENetworkSmoothingMode", "Engine", UnrealModuleType.Engine)]
public enum ENetworkSmoothingMode : byte
{
	Disabled,
	Linear,
	Exponential,
	Replay
}

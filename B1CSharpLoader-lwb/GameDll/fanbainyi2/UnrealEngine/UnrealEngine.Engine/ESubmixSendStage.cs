using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.ESubmixSendStage", "Engine", UnrealModuleType.Engine)]
public enum ESubmixSendStage : byte
{
	PostDistanceAttenuation,
	PreDistanceAttenuation
}

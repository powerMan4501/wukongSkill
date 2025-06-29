using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.ESendLevelControlMethod", "Engine", UnrealModuleType.Engine)]
public enum ESendLevelControlMethod : byte
{
	Linear,
	CustomCurve,
	Manual
}

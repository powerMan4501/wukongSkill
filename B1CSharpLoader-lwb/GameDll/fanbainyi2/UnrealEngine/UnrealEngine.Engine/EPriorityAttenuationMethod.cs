using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EPriorityAttenuationMethod", "Engine", UnrealModuleType.Engine)]
public enum EPriorityAttenuationMethod : byte
{
	Linear,
	CustomCurve,
	Manual
}

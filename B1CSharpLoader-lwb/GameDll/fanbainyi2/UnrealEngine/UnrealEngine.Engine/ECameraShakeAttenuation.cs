using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.ECameraShakeAttenuation", "Engine", UnrealModuleType.Engine)]
public enum ECameraShakeAttenuation : byte
{
	Linear,
	Quadratic
}

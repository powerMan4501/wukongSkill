using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EAttenuationDistanceModel", "Engine", UnrealModuleType.Engine)]
public enum EAttenuationDistanceModel : byte
{
	Linear,
	Logarithmic,
	Inverse,
	LogReverse,
	NaturalSound,
	Custom
}

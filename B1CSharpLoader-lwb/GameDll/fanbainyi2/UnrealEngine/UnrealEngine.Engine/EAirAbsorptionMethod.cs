using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EAirAbsorptionMethod", "Engine", UnrealModuleType.Engine)]
public enum EAirAbsorptionMethod : byte
{
	Linear,
	CustomCurve
}

using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EQuarztQuantizationReference", "Engine", UnrealModuleType.Engine)]
public enum EQuarztQuantizationReference : byte
{
	BarRelative,
	TransportRelative,
	CurrentTimeRelative,
	Count
}

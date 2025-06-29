using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.ETemperatureSeverityType", "Engine", UnrealModuleType.Engine)]
public enum ETemperatureSeverityType : byte
{
	Unknown,
	Good,
	Bad,
	Serious,
	Critical,
	NumSeverities
}

using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EAnimNodeReferenceConversionResult", "Engine", UnrealModuleType.Engine)]
public enum EAnimNodeReferenceConversionResult : byte
{
	Succeeded = 1,
	Failed = 0
}

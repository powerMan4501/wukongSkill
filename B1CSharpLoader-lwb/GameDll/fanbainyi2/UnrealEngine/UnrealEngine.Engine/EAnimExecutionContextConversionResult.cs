using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EAnimExecutionContextConversionResult", "Engine", UnrealModuleType.Engine)]
public enum EAnimExecutionContextConversionResult : byte
{
	Succeeded = 1,
	Failed = 0
}

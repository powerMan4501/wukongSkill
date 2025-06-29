using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/b1.EGSEnvTraceMode", "b1", UnrealModuleType.Game)]
public enum EGSEnvTraceMode : byte
{
	None,
	Navigation,
	CapsuleTraceByPawn
}

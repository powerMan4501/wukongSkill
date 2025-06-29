using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AIModule.EEnvQueryStatus", "AIModule", UnrealModuleType.Engine)]
public enum EEnvQueryStatus : byte
{
	Processing,
	Success,
	Failed,
	Aborted,
	OwnerLost,
	MissingParam
}

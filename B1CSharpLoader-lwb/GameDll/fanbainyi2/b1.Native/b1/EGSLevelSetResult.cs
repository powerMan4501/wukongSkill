using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/b1.EGSLevelSetResult", "b1", UnrealModuleType.Game)]
public enum EGSLevelSetResult : byte
{
	Success,
	RefusedByVolume,
	LevelNotFound,
	NullPtrParam,
	WorldTypeError,
	UnnecessaryUnload,
	BlockedByHotLevelStreaming,
	UnknownError
}

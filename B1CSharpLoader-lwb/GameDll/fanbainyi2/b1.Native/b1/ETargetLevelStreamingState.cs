using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/b1.ETargetLevelStreamingState", "b1", UnrealModuleType.Game)]
public enum ETargetLevelStreamingState : byte
{
	RemainCurrent,
	HideOnly,
	Unloaded
}

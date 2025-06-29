using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Calliope.EGsStreamingLevelManagePolice", "Calliope", UnrealModuleType.GamePlugin)]
public enum EGsStreamingLevelManagePolice : byte
{
	SameAsPrevious,
	DefaultLoadAndShow,
	DefaultUnload
}

using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Calliope.EGsOverlapManagePolice", "Calliope", UnrealModuleType.GamePlugin)]
public enum EGsOverlapManagePolice : byte
{
	SameAsPrevious,
	KeepEnable,
	KeepDisable
}

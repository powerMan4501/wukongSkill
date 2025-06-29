using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Calliope.EGsUnitManagePolice", "Calliope", UnrealModuleType.GamePlugin)]
public enum EGsUnitManagePolice : byte
{
	SameAsPrevious,
	Status,
	StatusWithoutHP,
	Spawn,
	Destroy
}

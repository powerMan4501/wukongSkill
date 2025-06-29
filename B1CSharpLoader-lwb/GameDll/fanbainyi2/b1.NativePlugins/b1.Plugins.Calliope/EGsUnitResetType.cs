using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Calliope.EGsUnitResetType", "Calliope", UnrealModuleType.GamePlugin)]
public enum EGsUnitResetType : byte
{
	No,
	Destroy,
	Status,
	Spawn,
	StatusWithoutHp,
	None
}

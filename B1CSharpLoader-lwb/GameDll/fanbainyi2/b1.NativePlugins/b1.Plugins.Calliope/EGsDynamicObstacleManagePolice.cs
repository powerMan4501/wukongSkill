using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Calliope.EGsDynamicObstacleManagePolice", "Calliope", UnrealModuleType.GamePlugin)]
public enum EGsDynamicObstacleManagePolice : byte
{
	SameAsPrevious,
	KeepOpen,
	KeepClose,
	AsBattleInDoor,
	AsBattleOutDoor
}

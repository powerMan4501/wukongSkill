using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Calliope.EGsSpawnerManagePolice", "Calliope", UnrealModuleType.GamePlugin)]
public enum EGsSpawnerManagePolice : byte
{
	SameAsPrevious,
	Auto,
	SameAsBattle,
	OnlyBeginSameAsBattle,
	OnlyEndSameAsBattle,
	Disable,
	BeginLikeStateEndLikeBattle
}

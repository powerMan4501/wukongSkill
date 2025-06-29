using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/b1.ESweepCheckHitFilterType", "b1", UnrealModuleType.Game)]
public enum ESweepCheckHitFilterType : byte
{
	Zero,
	NotInSameTeam,
	FilterMaster
}

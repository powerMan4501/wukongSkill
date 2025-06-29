using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/b1.ESweepCheckType", "b1", UnrealModuleType.Game)]
public enum ESweepCheckType : byte
{
	SweepCheck,
	AttackWarning,
	Max
}

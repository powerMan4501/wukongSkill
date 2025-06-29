using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/b1.EBGURunEQSObjReason", "b1", UnrealModuleType.Game)]
public enum EBGURunEQSObjReason : byte
{
	None,
	Teleport,
	Summon,
	RandomPatrol,
	GenPointSet
}

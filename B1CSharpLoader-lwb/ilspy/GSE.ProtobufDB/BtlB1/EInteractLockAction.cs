using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.InteractLockAction")]
public enum EInteractLockAction : byte
{
	None,
	LockSkill,
	OnlyWalk,
	LockAllInput
}

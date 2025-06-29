using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.NpcSubInteractType")]
public enum ENpcSubInteractType : byte
{
	None,
	NpcSkill,
	PlayerSkill,
	ComplexSkill,
	Seq,
	Dialogue,
	NpcMontage,
	PlayerMontage,
	ComplexMontage,
	EnumMax
}

using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.UnitAIAttackType")]
public enum EUnitAIAttackType : byte
{
	ActiveAttack = 0,
	PassiveAttack = 1,
	EnumMax = byte.MaxValue
}

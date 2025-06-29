using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.SpellTargetBaseType")]
public enum ESpellTargetBaseType : byte
{
	None,
	Victim,
	Caster,
	Attacker
}

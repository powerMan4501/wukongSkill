using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.SpellTriggerEffectType")]
public enum ESpellTriggerEffectType : byte
{
	None,
	SkillEffect,
	AddBuff,
	RemoveBuff
}

using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.SkillDamageType")]
public enum ESkillDamageType : byte
{
	NoneEffectAtk,
	BluntAtk,
	SharpAtk,
	BurnAtk,
	ExplosionAtk,
	FreezeAtk,
	LightningAtk,
	PoisonAtk,
	EnumMax
}

using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.MagicSkillMapping")]
public enum EMagicSkillMapping : byte
{
	MagicBodyMove,
	MagicRareSkill,
	MagicChangeSkill,
	MagicMonkeyFurSkill,
	MagicRemoteAtk,
	MagicArtifact,
	MagicEliteChange,
	ChangeSpecialAtkMode,
	DrinkBloodBottom,
	MagicMonkeyFurSkillExtend
}

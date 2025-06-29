using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.MobStrengthLevel")]
public enum EMobStrengthLevel : byte
{
	LevelWeak,
	LevelModerate,
	LevelStrong,
	LevelSpecial
}

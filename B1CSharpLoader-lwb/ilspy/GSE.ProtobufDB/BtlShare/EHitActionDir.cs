using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.HitActionDir")]
public enum EHitActionDir : byte
{
	Default,
	Up,
	Down,
	Left,
	Right,
	Front,
	Back,
	EnumMax
}

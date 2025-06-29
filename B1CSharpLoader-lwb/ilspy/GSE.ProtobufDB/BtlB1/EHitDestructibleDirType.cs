using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.HitDestructibleDirType")]
public enum EHitDestructibleDirType : byte
{
	DestructibleDirection,
	AttackerSpeedDirection,
	AttackerRelativeDirection
}

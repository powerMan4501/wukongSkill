using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.CollectionPortraitStage")]
public enum ECollectionPortraitStage : byte
{
	FirstSight,
	Completed,
	EnumMax
}

using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.CollectionStageRemove")]
public enum ECollectionStageRemove : byte
{
	Min,
	FirstSight,
	End
}

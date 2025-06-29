using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.CollectionInteractType")]
public enum ECollectionInteractType : byte
{
	Item,
	Normal,
	Plus,
	Chief
}

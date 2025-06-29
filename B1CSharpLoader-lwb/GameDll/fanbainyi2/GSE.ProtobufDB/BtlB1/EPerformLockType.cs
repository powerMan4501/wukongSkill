using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.PerformLockType")]
public enum EPerformLockType : byte
{
	None,
	Unit,
	SceneItem
}

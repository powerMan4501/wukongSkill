using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.BulletWindFieldActionType")]
public enum EBulletWindFieldActionType : byte
{
	None,
	Explode,
	AutoRelease
}

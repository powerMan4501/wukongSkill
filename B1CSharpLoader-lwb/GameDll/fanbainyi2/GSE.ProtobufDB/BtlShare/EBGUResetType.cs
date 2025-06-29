using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.EBGUResetType")]
public enum EBGUResetType : byte
{
	No,
	Destroy,
	Status,
	Spawn,
	StatusWithoutHp,
	None,
	EnumMax
}

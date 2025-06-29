using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.AbnormalDispModifyType")]
public enum EAbnormalDispModifyType : byte
{
	None,
	Override,
	Modify
}

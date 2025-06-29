using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.EBGUBloodBarShowType")]
public enum EBGUBloodBarShowType : byte
{
	Hide,
	Always,
	Change
}

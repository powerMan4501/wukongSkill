using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.EAIElemType")]
public enum EAIElemType : byte
{
	Think,
	Action,
	Feature
}

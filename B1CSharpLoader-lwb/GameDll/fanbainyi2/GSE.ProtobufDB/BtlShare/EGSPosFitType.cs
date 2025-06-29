using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.EGSPosFitType")]
public enum EGSPosFitType : byte
{
	FitBegin = 0,
	FitEnd = 1,
	FitBothWithScale = 2,
	EnumMax = 7
}

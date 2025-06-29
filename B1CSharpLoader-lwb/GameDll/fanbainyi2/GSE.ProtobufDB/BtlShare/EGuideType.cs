using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.GuideType")]
public enum EGuideType : byte
{
	Battle,
	Adventure,
	EnumMax
}

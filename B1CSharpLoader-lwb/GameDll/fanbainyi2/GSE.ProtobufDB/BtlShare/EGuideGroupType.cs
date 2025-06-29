using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.GuideGroupType")]
public enum EGuideGroupType : byte
{
	Normal,
	Task,
	Pause,
	Always
}

using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.GuideGroupFinishType")]
public enum EGuideGroupFinishType : byte
{
	Confirm,
	CountDown,
	ChecklistCompleted
}

using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.GuideGroupTriggerType")]
public enum EGuideGroupTriggerType : byte
{
	ObtainItem,
	CountDown,
	ChecklistCompleted
}

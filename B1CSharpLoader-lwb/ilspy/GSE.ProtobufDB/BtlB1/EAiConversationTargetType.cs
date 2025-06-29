using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.AiConversationTargetType")]
public enum EAiConversationTargetType : byte
{
	None,
	Self,
	CurTarget,
	ByGuid,
	LocalPlayer,
	ByTag,
	EventCaster,
	Narrator
}

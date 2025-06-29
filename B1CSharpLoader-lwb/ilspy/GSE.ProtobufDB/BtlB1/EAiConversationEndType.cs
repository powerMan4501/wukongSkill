using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.AiConversationEndType")]
public enum EAiConversationEndType : byte
{
	None,
	Manual,
	AkEnded,
	AmEnded
}

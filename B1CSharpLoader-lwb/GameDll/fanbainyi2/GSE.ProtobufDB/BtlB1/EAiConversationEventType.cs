using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.AiConversationEventType")]
public enum EAiConversationEventType : byte
{
	None,
	OnWakeUp,
	OnDead,
	OnKillPlayer,
	OnPlayerApproached,
	OnPerceptionFindTarget,
	OnTriggerFightSkill
}

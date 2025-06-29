using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.AiConversationConditionType")]
public enum EAiConversationConditionType : byte
{
	None,
	LifeState,
	SimpleState,
	Hp,
	PartnerAround,
	SceneObjStateMachine,
	ActorWithTagAround,
	DistanceToSpeaker2D,
	CheckResId,
	BlackboardData,
	BagItemExist,
	IsInFsmState
}

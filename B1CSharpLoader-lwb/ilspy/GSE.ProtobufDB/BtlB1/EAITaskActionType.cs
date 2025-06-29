using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.EAITaskActionType")]
public enum EAITaskActionType : byte
{
	CastSkill,
	TriggerSkillEffect,
	TriggerSequence
}

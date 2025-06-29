using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.SequenceType")]
public enum ESequenceType : byte
{
	None,
	StorySequence,
	InteractorSequence
}

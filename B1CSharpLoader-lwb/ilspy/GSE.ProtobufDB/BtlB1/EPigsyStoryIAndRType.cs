using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.PigsyStoryIAndRType")]
public enum EPigsyStoryIAndRType : byte
{
	None,
	ResumeDefault,
	InterruptIntoBattle,
	InterruptInteractWithNpc,
	InterruptPlayerMoveOverDist,
	InterruptBajieInteractWait
}

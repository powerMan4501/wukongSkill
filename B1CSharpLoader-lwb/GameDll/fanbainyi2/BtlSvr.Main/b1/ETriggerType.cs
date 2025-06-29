using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.TriggerType")]
public enum ETriggerType : byte
{
	None,
	Interact,
	Overlap,
	CharacterState,
	CharacterAttr,
	CircleRangeCharacterDie
}

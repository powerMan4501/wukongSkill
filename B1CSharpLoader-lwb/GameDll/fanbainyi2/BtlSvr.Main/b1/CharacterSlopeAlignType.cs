using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.CharacterSlopeAlignType")]
internal enum CharacterSlopeAlignType : byte
{
	None,
	AOPlan,
	RotWholeBodyPlan
}
